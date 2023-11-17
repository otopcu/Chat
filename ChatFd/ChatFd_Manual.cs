// ***************************************************************************
//		CChatFd
//		copyright	: 	(C) Okan Topcu
//		email			: 	okantopcu@gmail.com
// ***************************************************************************
/// <summary>
/// The application specific federate that is extended from the Generic Federate Class of Racon API
/// </summary>

#region Using Directives
using System;
using System.Text;
using System.Linq;
using Racon.RtiLayer;
#endregion //Using Directives
namespace Chat
{
  public partial class CChatFd : Racon.CGenericFederate
  {
    #region Manually Added Code
    private object thisLock = new object();
    // Local Data
    private CSimulationManager simManager;
    private string _systemMessage;
    public string NickName;
    #region Properties
    public String ViewText
    {
      get { return _systemMessage; }
      set
      {
        _systemMessage = value;
        this.simManager.view.RTB_Chat.AppendText(_systemMessage); // Bad Coding
      }
    }
    #endregion // Properties
    public CChatFd(CSimulationManager parent)
      : this()
    {
      // Set simulation manager
      simManager = parent;
    }
    // Send Chat ChatIC.Message
    public bool SendMessage(string txt)
    {
      Racon.RtiLayer.HlaInteraction interaction = new Racon.RtiLayer.HlaInteraction(Som.ChatIC, "Chat");

      // Add Values
      interaction.AddParameterValue(Som.ChatIC.Sender, NickName); // String
      interaction.AddParameterValue(Som.ChatIC.Message, txt); // String
      // Other Types
      interaction.AddParameterValue(Som.ChatIC.TimeStamp, DateTime.Now); // DateTime
      //interaction.AddParameterValue(Som.ChatIC.TimeStamp, 1); // int, long
      //interaction.AddParameterValue<double>(Som.ChatIC.TimeStamp, 5.5); // double
      //interaction.AddParameterValue(Som.ChatIC.TimeStamp, 1.6f); // float
      //interaction.AddParameterValue<uint>(Som.ChatIC.TimeStamp, 1); // uint
      // Enums
      //interaction.AddParameterValue(this.ChatIC.TimeStamp, (uint)StatusTypes.READY);

      // Alternative use
      // update parameter values
      //Som.ChatIC.Sender.AddValue(NickName);
      // Add parameters
      //interaction.AddParameter(Som.ChatIC.Sender);

      // Send interaction
      return (SendInteraction(interaction, Tags.SendReceive));
    }
    // Send Chat ChatIC.Message with Timestamp
    public Racon.RtiLayer.MessageRetraction SendMessage(string txt, double ts)
    {
      Racon.RtiLayer.HlaInteraction interaction = new Racon.RtiLayer.HlaInteraction(Som.ChatIC, "Chat");
      // Add Values
      interaction.AddParameterValue(Som.ChatIC.Sender, NickName);
      interaction.AddParameterValue(Som.ChatIC.Message, txt);
      interaction.AddParameterValue(Som.ChatIC.TimeStamp, DateTime.Now);
      // Enums
      //interaction.AddParameterValue(this.ChatIC.TimeStamp, (uint)StatusTypes.READY);
      // Send interaction
      return (SendInteraction(interaction, ts));
    }
    // UpdateName
    public bool UpdateName(CUser user)
    {
      // Add Values
      user.AddAttributeValue(Som.UserOC.NickName, user.NickName);
      return (UpdateAttributeValues(user, Tags.UpdateReflectTag));
    }
    // UpdateStatus
    public bool UpdateStatus(CUser user)
    {
      user.AddAttributeValue(Som.UserOC.Status, (uint)user.Status);
      return (UpdateAttributeValues(user, Tags.UpdateReflectTag));
      //// Update attribute using a logical timestamp
      //MessageRetraction handle = UpdateAttributeValues(user, 3.14);
      //return true;
    }
    // Pull Ownership
    public void PullOwnershipUnOwnedAttributes(CUser user)
    {
      // Create attribute set that we want to take ownership
      RaconAttributeSet set = new Racon.RtiLayer.RaconAttributeSet();
      set.AddAttribute(Som.UserOC.NickName);
      set.AddAttribute(Som.UserOC.PrivilegeToDelete);
      //this.AttributeOwnershipAcquisitionIfAvailable(user, set);
      // Pull All
      AttributeOwnershipAcquisition(user, "");
      // Pull
      //this.AttributeOwnershipAcquisition(user, set);
      // Cancel
      //this.CancelAttributeOwnershipAcquisition(user, set);
    }

    // RtiAmb Events
    public override void RtiAmb_FederationExecutionCreated(object sender, Racon.RtiLayer.RaconEventArgs e)
    {
      // Always call the base class handler first
      base.RtiAmb_FederationExecutionCreated(sender, e);
      // Specialize the event handler, if needed.
    }

    // Cut and paste the callbacks that you want to modify from the Generated ChatFd file (ChatFd_Generated.cs)

    #region Event Handlers
    #region Federate Callback Event Handlers
    #region Declaration Management Callbacks
    // Start Registration
    public override void FdAmb_StartRegistrationForObjectClassAdvisedHandler(object sender, HlaDeclarationManagementEventArgs data)
    {
      // Call the base class handler
      base.FdAmb_StartRegistrationForObjectClassAdvisedHandler(sender, data);

      // User code
      // Check that this is for the USerOC
      if (data.ObjectClassHandle == Som.UserOC.Handle)
        RegisterHlaObject(simManager.Users[0]);
    }
    // Turn Interactions On
    public override void FdAmb_TurnInteractionsOnAdvisedHandler(object sender, Racon.RtiLayer.HlaDeclarationManagementEventArgs data)
    {
      // Call the base class handler
      base.FdAmb_TurnInteractionsOnAdvisedHandler(sender, data);

      // User code
    }
    #endregion //Declaration Management Callbacks
    #region Object Management Callbacks
    // An Object is Discovered
    public override void FdAmb_ObjectDiscoveredHandler(object sender, Racon.RtiLayer.HlaObjectEventArgs data)
    {
      // Call the base class handler
      base.FdAmb_ObjectDiscoveredHandler(sender, data);

      // User code
      // Check the class type of the discovered object
      if (data.ClassHandle == Som.UserOC.Handle)
      {
        // Create and add a new user to the list
        CUser nUser = new CUser(data.ObjectInstance);
        nUser.Type = Som.UserOC;
        simManager.Users.Add(nUser);

        // Request Update Values
        RequestAttributeValueUpdate(nUser, string.Empty);// Request update values of all attributes for this specific object

        //RequestAttributeValueUpdate(Som.UserOC);// Request update for all attribute values of all objects related to this object class

        // Request Update Values for specific attributes only
        //List<HlaAttribute> attributes = new List<HlaAttribute>();
        //attributes.Add(Som.UserOC.NickName);
        //attributes.Add(Som.UserOC.Status);
        //RequestAttributeValueUpdate(nUser, attributes);
      }
    }
    // An Object is Removed
    public override void FdAmb_ObjectRemovedHandler(object sender, Racon.RtiLayer.HlaObjectEventArgs data)
    {
      // Call the base class handler
      base.FdAmb_ObjectRemovedHandler(sender, data);

      // User code
      // Lock while taking a snapshot - to avoid foreach loop enumeration exception
      object[] snap;
      lock (thisLock)
      {
        snap = simManager.Users.ToArray();
      }
      foreach (CUser user in snap)
      {
        if (data.ObjectInstance.Handle == user.Handle)// Find the Object
        {
          simManager.Users.Remove(user);
          // for DateTime
          ViewText = "Object removed. Reason: " + data.Tag.GetData<string>() + ". ";
          ViewText += "User: " + user.NickName + " left. Number of Users Left: " + simManager.Users.Count + Environment.NewLine;
        }
      }
    }
    // Attribute Value Update is Requested
    public override void FdAmb_AttributeValueUpdateRequestedHandler(object sender, Racon.RtiLayer.HlaObjectEventArgs data)
    {
      // Call the base class handler
      base.FdAmb_AttributeValueUpdateRequestedHandler(sender, data);

      // User code
      // !!! If it is created only one object, then it is sufficient to check the handle of that object, otherwise we need to check all the collection
      // Find the object class for which the request is made
      //ViewText = "received handle: " + data.ObjectInstance.Handle + ", local handle: " + simManager.Users[0].Handle + Environment.NewLine;
      if (data.ObjectInstance.Handle == simManager.Users[0].Handle)
      {
        // We can further try to figure out the attributes for which update is requested.
        // First check the  update is requested for the attribute, if true provide an update for that specific attribute
        //foreach (var item in data.ObjectInstance.Attributes)
        //{
        //  if (item.Handle == Som.UserOC.NickName.Handle) UpdateName(simManager.Users[0]);
        //  else if (item.Handle == Som.UserOC.Status.Handle) UpdateStatus(simManager.Users[0]);
        //}

        // We can update all attributes if we dont want to check every attribute.
        // Add Values
        // Nickname
        simManager.Users[0].AddAttributeValue(Som.UserOC.NickName, simManager.Users[0].NickName);
        //UpdateAttributeValues(simManager.Users[0], Tags.UpdateReflectTag);
        // Status
        simManager.Users[0].AddAttributeValue(Som.UserOC.Status, (uint)simManager.Users[0].Status);
        UpdateAttributeValues(simManager.Users[0], Tags.UpdateReflectTag);

        //UpdateName(simManager.Users[0]);
        //UpdateStatus(simManager.Users[0]);
      }
    }
    // Reflect Object Attributes
    public override void FdAmb_ObjectAttributesReflectedHandler(object sender, Racon.RtiLayer.HlaObjectEventArgs data)
    {
      // Call the base class handler
      base.FdAmb_ObjectAttributesReflectedHandler(sender, data);

      // User code
      foreach (CUser user in simManager.Users)
      {
        // Find the Object
        if (data.ObjectInstance.Handle == user.Handle)
        {
          // Get Attribute values
          // 1st method
          // First check wheather the attr is updated or not. Result returns 0/null if the updated attribute set does not contain the attr and its value 
          if (data.IsValueUpdated(Som.UserOC.NickName))
            user.NickName = data.GetAttributeValue<string>(Som.UserOC.NickName);
          if (data.IsValueUpdated(Som.UserOC.Status))
            user.Status = (StatusTypes)data.GetAttributeValue<uint>(Som.UserOC.Status);

          // 2nd method
          //foreach (var item in data.ObjectInstance.Attributes)
          //{
          //  if (item.Handle == Som.UserOC.NickName.Handle) user.NickName = item.GetValue<string>();
          //  else if (item.Handle == Som.UserOC.Status.Handle) user.Status = (StatusTypes)item.GetValue<uint>();
          //}
          ViewText = "NickName: " + user.NickName + ". Status: " + user.Status + ". Update reason: " + data.Tag.GetData<string>() + Environment.NewLine;
        }
      }
    }

    // Interaction Received
    public override void FdAmb_InteractionReceivedHandler(object sender, Racon.RtiLayer.HlaInteractionEventArgs data)
    {
      // Call the base class handler
      base.FdAmb_InteractionReceivedHandler(sender, data);

      // User code
      // Which interaction class?
      if (data.Interaction.ClassHandle == Som.ChatIC.Handle)
      {
        string sentBy = "";
        string msg = "";
        var ts = new DateTime();
        //double ts = 0;

        // Get parameter values
        // 1st Method
        // Check which parameter is updated
        if (data.IsValueUpdated(Som.ChatIC.Sender))
          sentBy = data.GetParameterValue<string>(Som.ChatIC.Sender);
        if (data.IsValueUpdated(Som.ChatIC.Message))
          msg = data.GetParameterValue<string>(Som.ChatIC.Message);
        if (data.IsValueUpdated(Som.ChatIC.TimeStamp))
          ts = data.GetParameterValue<DateTime>(Som.ChatIC.TimeStamp);


        // 2nd method
        //foreach (var item in data.Interaction.Parameters)
        //{
        //if (Som.ChatIC.Sender.Handle == item.Handle) sentBy = item.GetValue<string>();
        //else if (Som.ChatIC.Message.Handle == item.Handle) msg = item.GetValue<string>();
        //else if (Som.ChatIC.TimeStamp.Handle == item.Handle) ts = item.GetValue<DateTime>(); // must match with AddValue() type
        //}

        ViewText = sentBy + "> " + msg + " (" + ts + ")" + ". Send Reason: " + data.Tag.GetData<string>() + Environment.NewLine;
      }
    }
    #endregion //Object Management Callbacks
    #endregion //Federate Callback Event Handlers
    #endregion //Event Handlers

    #endregion //Manually Added Code

    // THREAD SAFE
    //// Discover Object - Thread Safe
    //public override void FdAmb_ObjectDiscovered(object sender, object param)
    //{
    //  base.FdAmb_ObjectDiscovered(sender, param);
    //  Racon.RtiLayer.CHlaObjectDiscoveredEventArgs fe = (Racon.RtiLayer.CHlaObjectDiscoveredEventArgs)param;
    //  //this.Tick();
    //  SimpleDelegate del1 = delegate()
    //  {
    //    // Check the class type of the discovered object
    //    if (fe.ClassHandle == this.UserOC.ClassHandle)
    //    {
    //      this.ViewText = "ChatFd>> An object (" + fe.ObjectHandle + ") is discovered. " + Environment.NewLine;
    //      // Create and add a new user to the list
    //      CUser nUser = new CUser();
    //      nUser.ObjectHandle = fe.ObjectHandle;
    //      lock (this.thisLock)
    //      {
    //        this.simManager.Users.Add(nUser);
    //      }
    //      // Request update for this object
    //      this.RequestAttributeUpdate(this.UserOC);
    //    }
    //  };

    //  this.simManager.view.BeginInvoke(del1);


    //}
    //// Object Removed
    //  public override void FdAmb_ObjectRemoved(object sender, object param)
    //  {
    //     base.FdAmb_ObjectRemoved(sender, param);
    //     if (this.simManager.view.InvokeRequired)
    //     {
    //       this.simManager.view.Invoke(new EventHandler<Racon.RtiLayer.CHlaObjectDiscoveredEventArgs>(FdAmb_ObjectRemoved), new object[] { sender, param });
    //     }
    //     else
    //     {
    //       Racon.RtiLayer.CHlaObjectDiscoveredEventArgs fe = (Racon.RtiLayer.CHlaObjectDiscoveredEventArgs) param;
    //       // Lock while taking a snapshot - to avoid foreach loop enumeration exception
    //       object[] snap;
    //       lock (this.thisLock)
    //       {
    //         snap = this.simManager.Users.ToArray();
    //       }
    //       foreach (CUser user in snap)
    //       {
    //         if (fe.ObjectHandle == user.ObjectHandle)// Find the Object
    //         {
    //           this.simManager.Users.Remove(user);
    //           this.ViewText = "User: " + user.UserOC.NickName + " removed. Number of Users Left: " + this.simManager.Users.Count + Environment.NewLine;
    //         }
    //       }
    //     }
    //  }
  }
}
