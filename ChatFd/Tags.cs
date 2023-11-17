using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
  public struct test
  {
    public int x;
    public int y;
  }
  public static class Tags
  {
    public static string UpdateReflectTag = "update/reflect";
    //public static bool SendReceive = true;
    public static string SendReceive = "send/receive";
    //public static test DeleteRemoveTag = new test{ x=10, y=-10};
    //public static StatusTypes DeleteRemoveTag = StatusTypes.INCHAT;
    //public static DateTime DeleteRemoveTag = DateTime.Now;
    //public static long DeleteRemoveTag = 1001;
    public static string DeleteRemoveTag = "delete/remove";
    public static string DivestitureRequestTag = "divestiture request";
    public static string DivestitureCompletionTag = "divestiture completion";
    public static string AcquisitionRequestTag = "acquisition request";
    public static string RequestUpdateTag = "request/update";
  }
}
