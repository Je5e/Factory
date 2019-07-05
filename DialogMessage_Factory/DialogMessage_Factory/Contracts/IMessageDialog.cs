using System;
using System.Collections.Generic;
using System.Text;

namespace DialogMessage_Factory.Contracts
{
   public interface IMessageDialog
    {
        // Quién sería el actor?
        void ShowMessage
            (string title, string message, string buttonText);

        
    }
}
