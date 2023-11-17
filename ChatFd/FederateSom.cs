// ***************************************************************************
//		FederateSom
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
  public class FederateSom : Racon.ObjectModel.CObjectModel
  {
    #region Declarations
    #region SOM Declaration
    public Chat.Som.CUserOC UserOC;
    public Chat.Som.CChatIC ChatIC;
    #endregion
    #endregion //Declarations
    
    #region Constructor
    public FederateSom() : base()
    {
      // Construct SOM
      UserOC = new Chat.Som.CUserOC();
      this.AddToObjectModel(UserOC);
      ChatIC = new Chat.Som.CChatIC();
      this.AddToObjectModel(ChatIC);
      // Create regions manually
    }
    #endregion //Constructor
  }
}
