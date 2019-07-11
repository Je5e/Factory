using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DialogMessage_Factory.Contracts;

namespace DialogMessage_Factory.UWP
{
    public class MessageDialogFactory_UWP : IMessageDialogFactory
    {
        public Func<IMessageDialog> Create { get; set; } = () => new MessageDialog_UWP();
    }
}
