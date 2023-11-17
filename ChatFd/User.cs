// ***************************************************************************
//		
//		copyright	: 	(C) Okan Topcu
//		email			: 	okantopcu@gmail.com
// ***************************************************************************
using System;
using System.ComponentModel; // INotifyProoertyChanged
using System.Linq;
using System.Text;
using Racon.RtiLayer;
using System.Runtime.InteropServices; // StructLayout

namespace Chat
{
  [Serializable]
  public enum StatusTypes { READY, INCHAT };

  public class CUser : HlaObject, INotifyPropertyChanged
  {
    // Local data
    private string _nickName;
    private StatusTypes _status;

    // NickName_User
    public string NickName
    {
      get { return _nickName; }
      set
      {
        _nickName = value;
        OnPropertyChanged("NickName");
      }
    }
    // Status_User
    public StatusTypes Status
    {
      get { return _status; }
      set
      {
        _status = value;
        OnPropertyChanged("Status");
      }
    }

    public CUser(HlaObjectClass _type) : base(_type)
    {
      // Local Data
      NickName = "Guest";
      Status = StatusTypes.READY;
    }
    public CUser(HlaObject _obj)
      : base(_obj)
    {
      // Local Data
      NickName = "Guest";
      Status = StatusTypes.READY;
      Type = _obj.Type;
    }

    // To refresh display elements
    #region INotifyPropertyChanged Members

    /// <summary>
    /// Raised when data property on this object has data new value.
    /// </summary>
    [field: NonSerialized]
    public event PropertyChangedEventHandler PropertyChanged;

    /// <summary>
    /// Raises this object's PropertyChanged event.
    /// </summary>
    /// <param projectName="propertyName">The property that has data new value.</param>
    protected virtual void OnPropertyChanged(string propertyName)
    {
      PropertyChangedEventHandler handler = this.PropertyChanged;
      if (handler != null)
      {
        var e = new PropertyChangedEventArgs(propertyName);
        handler(this, e);
      }
    }

    #endregion // INotifyPropertyChanged Members

  }
}
