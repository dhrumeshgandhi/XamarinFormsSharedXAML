using System;
using MessageBar;

namespace XFSX_Test_1
{
    class PlatformRelatedCalls
    {
        public void showToast(string msg)
        {
            MessageBarManager.SharedInstance.ShowMessage("Info", msg, MessageType.Info);
        }
    }
}