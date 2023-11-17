// **************************************************************************************************
//		CChatFd
//
//		generated
//			by		: 	Simulation Generator (SimGe) v.0.2.6
//			at		: 	Thursday, January 14, 2016 10:08:45 AM
//		compatible with		: 	Racon v.0.0.1.2
//
//		copyright		: 	(C) 
//		email			: 	
// **************************************************************************************************
/// <summary>
/// The application specific federate that is extended from the Generic Federate Class of Racon API
/// </summary>

// System
using System;
// Racon
using Racon;
using Racon.RtiLayer;
// Application
using Chat.Som;

namespace Chat
{
  public partial class CChatFd : Racon.CGenericFederate
  {
    #region Declarations
    public Chat.Som.FederateSom Som;
    #endregion //Declarations

    #region Constructor
    public CChatFd() : base(RTILibraryType.HLA1516e_Portico)
    {
      // Create and Attach Som to federate
      Som = new Chat.Som.FederateSom();
      SetSom(Som);
    }

    #endregion //Constructor

    #region Event Handlers

    #region Federate Callback Event Handlers
    #region Federation Management Callbacks
    // FdAmb_ConnectionLost
    public override void FdAmb_ConnectionLost(object sender, HlaFederationManagementEventArgs data)
    {
      // Call the base class handler
      base.FdAmb_ConnectionLost(sender, data);

      #region User Code
      //throw new NotImplementedException("FdAmb_ConnectionLost");
      #endregion //User Code
    }
    // FdAmb_InitiateFederateSaveHandler
    public override void FdAmb_InitiateFederateSaveHandler(object sender, HlaFederationManagementEventArgs data)
    {
      // Call the base class handler
      base.FdAmb_InitiateFederateSaveHandler(sender, data);

      #region User Code
      throw new NotImplementedException("FdAmb_InitiateFederateSaveHandler");
      #endregion //User Code
    }
    // FdAmb_InitiateFederateRestoreHandler
    public override void FdAmb_InitiateFederateRestoreHandler(object sender, Racon.RtiLayer.HlaFederationManagementEventArgs data)
    {
      // Call the base class handler
      base.FdAmb_InitiateFederateRestoreHandler(sender, data);

      #region User Code
      throw new NotImplementedException("FdAmb_InitiateFederateRestoreHandler");
      #endregion //User Code
    }
    // FdAmb_ConfirmFederationRestorationRequestHandler
    public override void FdAmb_ConfirmFederationRestorationRequestHandler(object sender, Racon.RtiLayer.HlaFederationManagementEventArgs data)
    {
      // Call the base class handler
      base.FdAmb_ConfirmFederationRestorationRequestHandler(sender, data);

      #region User Code
      throw new NotImplementedException("FdAmb_ConfirmFederationRestorationRequestHandler");
      #endregion //User Code
    }
    // FdAmb_FederationSaved
    public override void FdAmb_FederationSaved(object sender, Racon.RtiLayer.HlaFederationManagementEventArgs data)
    {
      // Call the base class handler
      base.FdAmb_FederationSaved(sender, data);

      #region User Code
      throw new NotImplementedException("FdAmb_FederationSaved");
      #endregion //User Code
    }
    // FdAmb_FederationRestored
    public override void FdAmb_FederationRestored(object sender, Racon.RtiLayer.HlaFederationManagementEventArgs data)
    {
      // Call the base class handler
      base.FdAmb_FederationRestored(sender, data);

      #region User Code
      throw new NotImplementedException("FdAmb_FederationRestored");
      #endregion //User Code
    }
    // FdAmb_FederationRestoreBegun
    public override void FdAmb_FederationRestoreBegun(object sender, Racon.RtiLayer.HlaFederationManagementEventArgs data)
    {
      // Call the base class handler
      base.FdAmb_FederationRestoreBegun(sender, data);

      #region User Code
      throw new NotImplementedException("FdAmb_FederationRestoreBegun");
      #endregion //User Code
    }
    #endregion //Federation Management Callbacks
    #region Declaration Management Callbacks
    // Stop Registration
    public override void FdAmb_StopRegistrationForObjectClassAdvisedHandler(object sender, Racon.RtiLayer.HlaDeclarationManagementEventArgs data)
    {
      // Call the base class handler
      base.FdAmb_StopRegistrationForObjectClassAdvisedHandler(sender, data);

      #region User Code
      throw new NotImplementedException("FdAmb_StopRegistrationForObjectClassAdvisedHandler");
      #endregion //User Code
    }
    // Turn Interactions Off
    public override void FdAmb_TurnInteractionsOffAdvisedHandler(object sender, Racon.RtiLayer.HlaDeclarationManagementEventArgs data)
    {
      // Call the base class handler
      base.FdAmb_TurnInteractionsOffAdvisedHandler(sender, data);

      #region User Code
      throw new NotImplementedException("FdAmb_TurnInteractionsOffAdvisedHandler");
      #endregion //User Code
    }
    // Turn Interactions On
    //public override void FdAmb_TurnInteractionsOnAdvisedHandler(object sender, Racon.RtiLayer.HlaDeclarationManagementEventArgs data)
    //{
    //  // Call the base class handler
    //  base.FdAmb_TurnInteractionsOnAdvisedHandler(sender, data);

    //  #region User Code
    //  throw new NotImplementedException("FdAmb_TurnInteractionsOnAdvisedHandler");
    //  #endregion //User Code
    //}
    #endregion //Declaration Management Callbacks
    #region Object Management Callbacks
    // An Object is Discovered
    //public override void FdAmb_ObjectDiscoveredHandler(object sender, Racon.RtiLayer.HlaObjectEventArgs data)
    //{
    //  // Call the base class handler
    //  base.FdAmb_ObjectDiscoveredHandler(sender, data);

    //  #region User Code
    //  throw new NotImplementedException("FdAmb_ObjectDiscoveredHandler");
    //  #endregion //User Code
    //}
    // Attribute Value Update is Requested
    //public override void FdAmb_AttributeValueUpdateRequestedHandler(object sender, Racon.RtiLayer.HlaObjectEventArgs data)
    //{
    //  // Call the base class handler
    //  base.FdAmb_AttributeValueUpdateRequestedHandler(sender, data);

    //  #region User Code
    //  throw new NotImplementedException("FdAmb_AttributeValueUpdateRequestedHandler");
    //  #endregion //User Code
    //}
    // Reflect Object Attributes
    //public override void FdAmb_ObjectAttributesReflectedHandler(object sender, Racon.RtiLayer.HlaObjectEventArgs data)
    //{
    //  // Call the base class handler
    //  base.FdAmb_ObjectAttributesReflectedHandler(sender, data);

    //  #region User Code
    //  throw new NotImplementedException("FdAmb_ObjectAttributesReflectedHandler");
    //  #endregion //User Code
    //}
    //// Interaction Received
    //public override void FdAmb_InteractionReceivedHandler(object sender, Racon.RtiLayer.CHlaInteractionEventArgs data)
    //{
    //  // Call the base class handler
    //  base.FdAmb_InteractionReceivedHandler(sender, data);

    //  #region User Code
    //  throw new NotImplementedException("FdAmb_InteractionReceivedHandler");
    //  #endregion //User Code
    //}
    #endregion //Object Management Callbacks
    #region Ownership Management Callbacks
    // FdAmb_AttributeOwnershipAssumptionRequested
    public override void FdAmb_AttributeOwnershipAssumptionRequested(object sender, Racon.RtiLayer.HlaOwnershipManagementEventArgs data)
    {
      // Call the base class handler
      base.FdAmb_AttributeOwnershipAssumptionRequested(sender, data);

      #region User Code
      throw new NotImplementedException("FdAmb_AttributeOwnershipAssumptionRequested");
      #endregion //User Code
    }
    // FdAmb_AttributeOwnershipAcquisitionCancellationConfirmed
    public override void FdAmb_AttributeOwnershipAcquisitionCancellationConfirmed(object sender, Racon.RtiLayer.HlaOwnershipManagementEventArgs data)
    {
      // Call the base class handler
      base.FdAmb_AttributeOwnershipAcquisitionCancellationConfirmed(sender, data);

      #region User Code
      throw new NotImplementedException("FdAmb_AttributeOwnershipAcquisitionCancellationConfirmed");
      #endregion //User Code
    }
    // FdAmb_AttributeOwnershipUnavailable
    public override void FdAmb_AttributeOwnershipUnavailable(object sender, Racon.RtiLayer.HlaOwnershipManagementEventArgs data)
    {
      // Call the base class handler
      base.FdAmb_AttributeOwnershipUnavailable(sender, data);

      #region User Code
      throw new NotImplementedException("FdAmb_AttributeOwnershipUnavailable");
      #endregion //User Code
    }
    // FdAmb_AttributeOwnershipDivestitureNotified
    public override void FdAmb_AttributeOwnershipDivestitureNotified(object sender, Racon.RtiLayer.HlaOwnershipManagementEventArgs data)
    {
      // Call the base class handler
      base.FdAmb_AttributeOwnershipDivestitureNotified(sender, data);

      #region User Code
      throw new NotImplementedException("FdAmb_AttributeOwnershipDivestitureNotified");
      #endregion //User Code
    }
    // FdAmb_AttributeOwnershipAcquisitionNotified
    public override void FdAmb_AttributeOwnershipAcquisitionNotified(object sender, Racon.RtiLayer.HlaOwnershipManagementEventArgs data)
    {
      // Call the base class handler
      base.FdAmb_AttributeOwnershipAcquisitionNotified(sender, data);

      #region User Code
      throw new NotImplementedException("FdAmb_AttributeOwnershipAcquisitionNotified");
      #endregion //User Code
    }
    // FdAmb_AttributeOwnershipInformed
    public override void FdAmb_AttributeOwnershipInformed(object sender, Racon.RtiLayer.HlaOwnershipManagementEventArgs data)
    {
      // Call the base class handler
      base.FdAmb_AttributeOwnershipInformed(sender, data);

      #region User Code
      throw new NotImplementedException("FdAmb_AttributeOwnershipInformed");
      #endregion //User Code
    }
    // FdAmb_AttributeOwnershipReleaseRequestedHandler
    public override void FdAmb_AttributeOwnershipReleaseRequestedHandler(object sender, Racon.RtiLayer.HlaOwnershipManagementEventArgs data)
    {
      // Call the base class handler
      base.FdAmb_AttributeOwnershipReleaseRequestedHandler(sender, data);

      #region User Code
      throw new NotImplementedException("FdAmb_AttributeOwnershipReleaseRequestedHandler");
      #endregion //User Code
    }
    #endregion //Ownership Management Callbacks
    #endregion //Federate Callback Event Handlers
    #endregion //Event Handlers
  }
}
