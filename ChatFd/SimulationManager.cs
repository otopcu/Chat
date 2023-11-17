// ***************************************************************************
//		
//		copyright	: 	(C) Okan Topcu
//		email			: 	okantopcu@gmail.com
// ***************************************************************************
using System.ComponentModel;
using Racon;

namespace Chat
{
  public class CSimulationManager
  {
    public Form1 view;
    // The local data structures
    public BindingList<CUser> Users;
    // The HLA part (communication model)
    // Application-specific federate
    public CChatFd federate;
    // The Simulation part (computational model)
    // None for chat federation

    // Constructor
    public CSimulationManager(Form1 _form)
    {
      // Back reference to view
      view = _form;
      // Initialize the application-specific federate
      federate = new CChatFd(this);
      // Initialize the federation execution
      federate.FederationExecution.Name = "CHAT";
      federate.FederationExecution.FederateType = "TestFederate";
      //federate.FederationExecution.ConnectionSettings = "rti://10.144.180.3";
      federate.FederationExecution.ConnectionSettings = "rti://127.0.0.1";

      // RTI Variation Handling
      switch (federate.RTILibrary)
      {
        case RTILibraryType.HLA13_DMSO:
        case RTILibraryType.HLA13_Portico:
        case RTILibraryType.HLA13_OpenRti: // OpenRTI uses IEEE1516e format for FED
          federate.Som.UserOC.Name = "ObjectRoot.User";
          federate.Som.ChatIC.Name = "InteractionRoot.Chat";
          federate.Som.UserOC.PrivilegeToDelete.Name = "privilegeToDelete";
          federate.FederationExecution.FDD = @".\SimGe_Chat.fed";
          break;
        case RTILibraryType.HLA1516e_Portico:
        case RTILibraryType.HLA1516e_OpenRti:
          federate.Som.UserOC.Name = "HLAobjectRoot.User";
          federate.Som.ChatIC.Name = "HLAinteractionRoot.Chat";
          federate.FederationExecution.FDD = @".\SimGe_Chat.xml";
          break;
        default:
          break;
      }

      // Populate the local user list for GUI
      Users = new BindingList<CUser>();
    }

  }
}
