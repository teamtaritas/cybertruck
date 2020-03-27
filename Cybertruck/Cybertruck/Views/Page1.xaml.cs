using Cybertruck.Abstraction;
using System;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cybertruck.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : BaseContentPage
    {
        public Page1()
        {
            InitializeComponent();         
        }

        protected override void OnAppearing()
        {
            var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;
            if (mainDisplayInfo.Width>720)
            {
                Grid2.IsVisible = true;
                Grid1.IsVisible = false;
            }
            else
            {
                Grid2.IsVisible = false;
                Grid1.IsVisible = true;
            }
        }

        private async void ButtonTapped(object sender, EventArgs e)
        {
            if (Grid2.IsVisible)
            {
                image.Source = "lockDarkGray.png";
                ButtonControl.BorderColor = Color.FromHex("#FF1B2024");
                SfGradientStop1.Color = Color.FromHex("#FF2B3034");
                SfGradientStop2.Color = Color.FromHex("#FF212528");
                await Task.Delay(50);
                image.Source = "lock.png";
                ButtonControl.BorderColor = Color.FromHex("#FF0E9BED");
                SfGradientStop1.Color = Color.FromHex("#FF0361A7");
                SfGradientStop2.Color = Color.FromHex("#FF0E9BED");
            }
            else{
                image.Source = "lockDarkGray.png";
                ButtonControl2.BorderColor = Color.FromHex("#FF1B2024");
                SfGradientStop21.Color = Color.FromHex("#FF2B3034");
                SfGradientStop22.Color = Color.FromHex("#FF212528");
                await Task.Delay(50);
                image.Source = "lock.png";
                ButtonControl2.BorderColor = Color.FromHex("#FF0E9BED");
                SfGradientStop21.Color = Color.FromHex("#FF0361A7");
                SfGradientStop22.Color = Color.FromHex("#FF0E9BED");
            }

            await PushModelNextPage(new Page2());
        }
    }
}