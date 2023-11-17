// ***************************************************************************
//		CUserOC
//
//		generated
//			by		: 	Simulation Generator (SimGe) v.0.2.0
//			at		: 	Sunday, November 10, 2013 1:53:19 AM
//		compatible with		: 	Racon v.0.0.1.2
//
//		copyright		: 	(C) User Name
//		email			: 	Mail Adress
// ***************************************************************************
/// <summary>
/// This class is extended from the object model of Racon API
/// </summary>

#region Using Directives
using System;
using Racon;
#endregion //Using Directives

namespace Chat.Som
{
  public class CUserOC : Racon.RtiLayer.HlaObjectClass
  {
    #region Declarations
    public Racon.RtiLayer.HlaAttribute Status;
    public Racon.RtiLayer.HlaAttribute NickName;
    #endregion //Declarations
    
    #region Constructor
    public CUserOC() : base()
    {
      // Initialize Class Properties
      Name = "ObjectRoot.User";
      ClassPS = Racon.PSKind.PublishSubscribe;
      
      // Create Attributes
      // Status
      Status= new Racon.RtiLayer.HlaAttribute("Status", Racon.PSKind.PublishSubscribe);
      Attributes.Add(Status);
      // NickName
      NickName= new Racon.RtiLayer.HlaAttribute("NickName", Racon.PSKind.PublishSubscribe);
      Attributes.Add(NickName);
    }
    #endregion //Constructor
  }
}
