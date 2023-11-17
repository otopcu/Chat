using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;// For Marshalling
using System.Threading;

namespace Chat
{
  public partial class Form1 : Form
  {
    public CSimulationManager simulation;
    //delegate void SetTextCallback();

    // Constructor
    public Form1()
    {
      InitializeComponent();
      simulation = new CSimulationManager(this);
      dataGridView1.DataSource = simulation.Users;

      // Getting the information/debugging messages
      simulation.federate.StatusMessageChanged += new EventHandler(CChatFd_StatusMessageChanged);
      simulation.federate.LogLevel = Racon.LogLevel.ALL;
      simulation.federate.FederateStateChanged += Federate_FederateStateChanged;
    }

    private void Federate_FederateStateChanged(object sender, Racon.CFederateStateEventArgs e)
    {
      switch (e.FdState)
      {
        case Racon.FederateStates.NOTCONNECTED:
          // GUI Setup for enter
          button_exit.Enabled = false;
          button_send.Enabled = false;
          textBox_send.Enabled = false;
          Button_enter.Enabled = true;
          AcceptButton = Button_enter;
          break;
        case Racon.FederateStates.CONNECTED | Racon.FederateStates.JOINED | Racon.FederateStates.FREERUN:
          // GUI Setup for chat
          button_exit.Enabled = true;
          button_send.Enabled = true;
          textBox_send.Enabled = true;
          Button_enter.Enabled = false;
          AcceptButton = button_send;
          textBox_send.Focus();
          //// For Portico
          //simulation.federate.RegisterHlaObject(simulation.Users[0]);
          break;
        default:
          break;
      }
    }

    // Racon Information recevied
    void CChatFd_StatusMessageChanged(object sender, EventArgs e)
    {
      TB_RaconMsg.AppendText(simulation.federate.StatusMessage + Environment.NewLine);
    }
    // Initialize Federation
    private void Button_enter_Click(object sender, EventArgs e)
    {
      NickNameDialog _nDlg = new NickNameDialog();
      _nDlg.ShowDialog();
      if (_nDlg.DialogResult == DialogResult.OK)
      {
        //simulation.federate.NickName = "Test" + DateTime.Now.Second;
        simulation.federate.NickName = _nDlg.NickName;
        simulation.federate.FederationExecution.FederateName = simulation.federate.NickName;
        // Local user
        // Create Local Object - User
        CUser user = new CUser(simulation.federate.Som.UserOC)
        {
          NickName = simulation.federate.NickName,
          Status = StatusTypes.INCHAT
        };
        simulation.Users.Add(user);
        //simulation.Users[0].ObjectInstanceName = _nDlg.UserOC.NickName; // RTI performance penalty due to the name reservation

        // Initialize Federation
        _ = simulation.federate.InitializeFederation(simulation.federate.FederationExecution);
        // test
        _ = simulation.federate.GetFederateName(simulation.federate.FederateHandle);
      }
    }

    // Exit Federation
    private void button_exit_Click(object sender, EventArgs e)
    {
      // Delete Local object
      simulation.federate.DeleteObjectInstance(simulation.Users[0], Tags.DeleteRemoveTag); 
      // When not registered, it raises an exception ObjectNotKnown
      // Leave federation
      bool result = simulation.federate.FinalizeFederation(simulation.federate.FederationExecution, Racon.ResignAction.NO_ACTION);
      // Reset Local data
      simulation.Users[0].Status = StatusTypes.READY;
      simulation.Users.Clear();
    }

    // Send message
    private void button_send_Click(object sender, EventArgs e)
    {
      //// To UTF-8
      //byte[] bytes = Encoding.Default.GetBytes(textBox_send.Text);
      //string message = Encoding.UTF8.GetString(bytes);
      string message = textBox_send.Text;
      // Send Chat Interaction
      if (simulation.federate.SendMessage(message))
        //Racon.RtiLayer.EventRetractionHandle handle = simulation.federate.SendMessage(message, 0.1);
        RTB_Chat.ForeColor = Color.Blue;
      RTB_Chat.AppendText(simulation.federate.NickName + "> " + message + Environment.NewLine);
      RTB_Chat.ForeColor = Color.Black;
      textBox_send.Clear();

      //// Memory test
      //bool flag = true;
      //string message = "0123456789";//char = 2 bytes, so 20 bytes in total
      //while (flag)
      //{
      //  if (simulation.federate.SendMessage(message))
      //  {
      //    RTB_Chat.ForeColor = Color.Blue;
      //    RTB_Chat.AppendText(simulation.federate.NickName + "> " + message + Environment.NewLine);
      //    //RTB_Chat.ForeColor = Color.Black;
      //    textBox_send.Clear();
      //  }
      //}
      //Thread.Sleep(10);
      //Application.DoEvents();
    }

  // DoSimulation
  public void DoSimulation()
  {
    if (simulation.federate.FederateState.HasFlag(Racon.FederateStates.JOINED))
    {
      simulation.federate.Run(); // Tick callbacks
    }
  }

  private void BT_Copy_Click(object sender, EventArgs e)
  {
    TB_RaconMsg.SelectAll();
    TB_RaconMsg.Copy();
  }

  private void BT_Clear_Click(object sender, EventArgs e)
  {
    TB_RaconMsg.Clear();
  }

  private void pictureBox1_Click(object sender, EventArgs e)
  {
    simulation.federate.UpdateName(simulation.Users[0]);
    simulation.federate.UpdateStatus(simulation.Users[0]);
    //simulation.federate.PullOwnershipUnOwnedAttributes(simulation.Users[1]);
  }

  private void cUserBindingSource_CurrentChanged(object sender, EventArgs e)
  {

  }

  private void Form1_FormClosing(object sender, FormClosingEventArgs e)
  {
    bool result = simulation.federate.FinalizeFederation(simulation.federate.FederationExecution);
  }
}
}
