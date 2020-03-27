using Cybertruck.Abstraction;
using Cybertruck.Controls;
using System;
using Xamarin.Forms.Xaml;

namespace Cybertruck.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : BaseContentPage
    {
        private string _value;
        public string CoolingValue
        {
            get { return _value; }
            set { _value = value; OnPropertyChanged(nameof(CoolingValue)); }
        }

        public Page3()
        {
            InitializeComponent();
            BindingContext = this;
            CoolingValue = "24";
        }

        private void GoBack(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            var control = sender as LabelButtonButton;
            if (control.HeaderText == "Auto")
            {
                if (control.ON)
                {
                    control.ButtonIcon = "letterAWhite.png";
                }
                else
                {
                    control.ButtonIcon = "letterADarkGray.png";
                }
            }


            if (control.HeaderText == "Dry")
            {
                if (control.ON)
                {
                    control.ButtonIcon = "dryWhite.png";
                }
                else
                {
                    control.ButtonIcon = "dryDarkGray.png";
                }
            }
            if (control.HeaderText == "Cool")
            {
                if (control.ON)
                {
                    control.ButtonIcon = "coolWhite.png";
                }
                else
                {
                    control.ButtonIcon = "coolDarkGray.png";
                }
            }
            if (control.HeaderText == "Program")
            {
                if (control.ON)
                {
                    control.ButtonIcon = "timerWhite.png";
                }
                else
                {
                    control.ButtonIcon = "timerDarkGray.png";
                }
            }
        }

        private void SfCircularGauge_PointerPositionChanged(object sender, Syncfusion.SfGauge.XForms.PointerPositionChangedArgs args)
        {
            try
            {
                var value = args.pointerValue;
                var result = ((double)value / 45);
                CoolingValue = $"{Convert.ToInt32(result * 5)}";
            }
            catch (Exception ex)
            {

            }
        }
    }
}