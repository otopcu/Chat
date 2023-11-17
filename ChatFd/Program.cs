// ***************************************************************************
//		
//		copyright	: 	(C) Okan Topcu
//		email			: 	okantopcu@gmail.com
// ***************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Chat
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      // Create the main UI and run it
      Form1 frm = new Form1();
      frm.Show();
      while (frm.Created)
      {
        frm.DoSimulation(); // The Main Simulation Loop
        Application.DoEvents();
      }
    }
  }
}
