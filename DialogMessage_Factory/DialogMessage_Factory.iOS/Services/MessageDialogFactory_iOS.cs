using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DialogMessage_Factory.Contracts;
using Foundation;
using UIKit;

namespace DialogMessage_Factory.iOS.Services
{
    public class MessageDialogFactory_iOS : IMessageDialogFactory
    {
        public Func<IMessageDialog> Create { get; set; } = () => new MessageDialog_iOS();
    }
}