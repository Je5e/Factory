using DialogMessage_Factory.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace DialogMessage_Factory.UWP
{
    class MessageDialog_UWP : IMessageDialog
    {
        public async void ShowMessage(string title, string message, string buttonText)
        {
            // TODO: Implementar ShowMessage en UWP
            ContentDialog noWifiDialog = new ContentDialog
            {
                Title = title,
                Content = $"UWP...{message}",
                CloseButtonText = buttonText
            };

            ContentDialogResult result = await noWifiDialog.ShowAsync();
        }
    }
}
