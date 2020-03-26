using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cybertruck.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PowerbuttonControl : Grid
    {
        private bool _isClicked;

        public PowerbuttonControl()
        {
            InitializeComponent();
        }

        private void ButtonTapped(object sender, System.EventArgs e)
        {
            if (!_isClicked)
            {
                image.Source = "power.png";
                ButtonControl.BorderColor = Color.FromHex("#FF0E9BED");
                SfGradientStop1.Color = Color.FromHex("#FF0361A7");
                SfGradientStop2.Color = Color.FromHex("#FF0E9BED");
            }
            else
            {
                image.Source = "powerDarkGray.png";
                ButtonControl.BorderColor = Color.FromHex("#FF1B2024");
                SfGradientStop1.Color = Color.FromHex("#FF2B3034");
                SfGradientStop2.Color = Color.FromHex("#FF212528");
            }

            _isClicked = !_isClicked;
        }
    }
}