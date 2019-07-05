using System;
using System.Collections.Generic;
using System.Text;

namespace DialogMessage_Factory.Contracts
{
   public interface IMessageDialogFactory
    {
       Func<IMessageDialog> Create { get; set; }

        //IMessageDialog Create()
        //{
        //    return IMessageDialog;
        //}
    }
}
