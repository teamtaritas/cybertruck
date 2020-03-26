using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cybertruck.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsControl : Grid
    {
        public static readonly BindableProperty ImageHeightProperty = BindableProperty.Create(nameof(ImageHeight), typeof(double), typeof(SettingsControl), 13.0);
        public double ImageHeight
        {
            get { return (double)GetValue(ImageHeightProperty); }
            set { SetValue(ImageHeightProperty, value); }
        }

        public static readonly BindableProperty ControlImageProperty = BindableProperty.Create(nameof(ControlImage), typeof(ImageSource), typeof(SettingsControl));
        public ImageSource ControlImage
        {
            get { return (ImageSource)GetValue(ControlImageProperty); }
            set { SetValue(ControlImageProperty, value); }
        }

        public SettingsControl()
        {
            InitializeComponent();
        }
    }
}