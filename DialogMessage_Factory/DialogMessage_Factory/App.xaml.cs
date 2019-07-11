using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DialogMessage_Factory.Contracts;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace DialogMessage_Factory
{
    public partial class App : Application
    {
        public static IMessageDialogFactory Factory { get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new AboutPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
