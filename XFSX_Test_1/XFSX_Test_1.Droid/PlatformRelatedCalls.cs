using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace XFSX_Test_1
{
    class PlatformRelatedCalls
    {
        public void showToast(string msg)
        {
            Toast.MakeText(Application.Context, msg, ToastLength.Long).Show();
        }
    }
}