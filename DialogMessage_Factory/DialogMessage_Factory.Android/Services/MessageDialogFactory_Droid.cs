using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DialogMessage_Factory.Contracts;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace DialogMessage_Factory.Droid.Services
{
    public class MessageDialogFactory_Droid : IMessageDialogFactory
    {
        public  Func<IMessageDialog> Create { get; set; } = ()=> new MessageDialog_Android();
    }
}