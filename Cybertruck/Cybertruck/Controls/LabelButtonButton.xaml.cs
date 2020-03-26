using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cybertruck.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LabelButtonButton : StackLayout
    {
        public static readonly BindableProperty ONProperty = BindableProperty.Create(nameof(ON), typeof(bool), typeof(LabelButtonButton), false);
        public bool ON
        {
            get { return (bool)GetValue(ONProperty); }
            set { SetValue(ONProperty, value); }
        }

        public static readonly BindableProperty ImageHeightProperty = BindableProperty.Create(nameof(ImageHeight), typeof(double), typeof(LabelButtonButton), 14.0);
        public double ImageHeight
        {
            get { return (double)GetValue(ImageHeightProperty); }
            set { SetValue(ImageHeightProperty, value); }
        }

        public static readonly BindableProperty HeaderTextProperty = BindableProperty.Create(nameof(HeaderText), typeof(string), typeof(LabelButtonButton), string.Empty);
        public string HeaderText
        {
            get { return (string)GetValue(HeaderTextProperty); }
            set { SetValue(HeaderTextProperty, value); }
        }

        public static readonly BindableProperty ButtonIconProperty = BindableProperty.Create(nameof(ButtonIcon), typeof(ImageSource), typeof(LabelButtonButton));

        public ImageSource ButtonIcon
        {
            get { return (ImageSource)GetValue(ButtonIconProperty); }
            set { SetValue(ButtonIconProperty, value); }
        }

        public LabelButtonButton()
        {
            InitializeComponent();
        }

        private void ButtonTapped(object sender, System.EventArgs e)
        {
            if (!ON)
            {
                ButtonControl.BorderColor = Color.FromHex("#FF0E9BED");
                SfGradientStop1.Color = Color.FromHex("#FF0361A7");
                SfGradientStop2.Color = Color.FromHex("#FF0E9BED");
            }
            else
            {
                ButtonControl.BorderColor = Color.FromHex("#FF1B2024");
                SfGradientStop1.Color = Color.FromHex("#FF2B3034");
                SfGradientStop2.Color = Color.FromHex("#FF212528");
            }

            ON = !ON;
        }
    }
}