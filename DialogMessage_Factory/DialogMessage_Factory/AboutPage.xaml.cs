using DialogMessage_Factory.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DialogMessage_Factory
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AboutPage : ContentPage
	{
		public AboutPage ()
		{
			InitializeComponent ();
		}

        private void BtnAbout_Clicked(object sender, EventArgs e)
        {
            IMessageDialog message = App.Factory.Create();
            message.ShowMessage("About", "Estás en la plataforma...", "Ok");
        }
    }
}