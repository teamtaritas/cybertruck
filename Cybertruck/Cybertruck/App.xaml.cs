using Cybertruck.Views;
using Syncfusion.Licensing;
using Xamarin.Forms;

namespace Cybertruck
{
    public partial class App : Application
    {
        public App()
        { 
            InitializeComponent();
            MainPage = new NavigationPage(new Page1());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
