using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chat
{
  public partial class NickNameDialog : Form
  {
    private string _nickName;

    public string NickName
    {
      get { return _nickName; }
      set
      {
        _nickName = value;
        textBox1.Text = _nickName;
      }
    }

    public NickNameDialog()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      NickName = textBox1.Text;
    }

    private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
    {
      //if (e.KeyChar == (char)(Keys.Enter)) { this.button1_Click(sender, e); e.Handled = true; }
    }
  }
}
