// ***************************************************************************
//		CChatIC
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
  public class CChatIC : Racon.RtiLayer.HlaInteractionClass
  {
    #region Declarations
    public Racon.RtiLayer.HlaParameter TimeStamp;
    public Racon.RtiLayer.HlaParameter Message;
    public Racon.RtiLayer.HlaParameter Sender;
    #endregion //Declarations
    
    #region Constructor
    public CChatIC() : base()
    {
      // Initialize Class Properties
      this.Name = "InteractionRoot.Chat";
      this.ClassPS = Racon.PSKind.PublishSubscribe;
      
      // Create Parameters
      // TimeStamp
      TimeStamp= new Racon.RtiLayer.HlaParameter("TimeStamp");
      this.Parameters.Add(TimeStamp);
      // Message
      Message= new Racon.RtiLayer.HlaParameter("Message");
      this.Parameters.Add(Message);
      // Sender
      Sender= new Racon.RtiLayer.HlaParameter("Sender");
      this.Parameters.Add(Sender);
    }
    #endregion //Constructor
  }
}
