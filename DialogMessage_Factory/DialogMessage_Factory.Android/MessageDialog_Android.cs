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
         static Context myContext;
        public static void Init(Context context)
        {
            myContext = context;
        }
        public void ShowMessage(string title, string message, string buttonText)
        {
            // TODO: Implementar ShowMessage en Droid.
            AlertDialog Dialog = (new AlertDialog.Builder(myContext)).Create();

            Dialog.SetMessage($"{message}...Android");
            Dialog.SetTitle(title);
            Dialog.SetButton(buttonText, okButton_Handle);
            Dialog.Show();

        }
        private void okButton_Handle(object sender, DialogClickEventArgs e)
        {
            AlertDialog objAlertDialog = sender as AlertDialog;
            Button btnClicked = objAlertDialog.GetButton(e.Which);
        }
    }
}