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
using DialogMessage_Factory.Contracts;

namespace DialogMessage_Factory.Droid
{
    class MessageDialog_Android : IMessageDialog
    {
        public void ShowMessage(string title, string message, string buttonText)
        {
            // TODO: Implementar ShowMessage en Droid.
            throw new NotImplementedException();
        }
    }
}