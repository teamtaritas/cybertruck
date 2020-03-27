using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cybertruck.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingControl : Grid
    {
        public static readonly BindableProperty ImageHeightProperty = BindableProperty.Create(nameof(ImageHeight), typeof(double), typeof(SettingControl), 20.0);
        public double ImageHeight
        {
            get { return (double)GetValue(ImageHeightProperty); }
            set { SetValue(ImageHeightProperty, value); }
        }

        public static readonly BindableProperty ControlImageProperty = BindableProperty.Create(nameof(ControlImage), typeof(ImageSource), typeof(SettingControl));
        public ImageSource ControlImage
        {
            get { return (ImageSource)GetValue(ControlImageProperty); }
            set { SetValue(ControlImageProperty, value); }
        }

        public SettingControl()
        {
            InitializeComponent();
        }
    }
}