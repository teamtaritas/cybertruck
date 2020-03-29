using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using Android.Content.Res;
using Android.Util;
using Android.Content;

namespace Cybertruck.Droid
{
    [Activity(Label = "Cybertruck", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ScreenOrientation = ScreenOrientation.Portrait)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            ImageCircle.Forms.Plugin.Droid.ImageCircleRenderer.Init();
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        private void initFontScale()
        {
            Configuration configuration = Resources.Configuration;
            configuration.FontScale = (float)1;
            //0.85 small, 1 standard, 1.15 big，1.3 more bigger ，1.45 supper big 
            DisplayMetrics metrics = new DisplayMetrics();
            WindowManager.DefaultDisplay.GetMetrics(metrics);
            metrics.ScaledDensity = configuration.FontScale * metrics.Density;
            BaseContext.Resources.UpdateConfiguration(configuration, metrics);
        }

        #region Prevent system fontSize
        protected override void AttachBaseContext(Context @base)
        {
            var configuration = new Configuration(@base.Resources.Configuration);
            //0.85 small, 1 standard, 1.15 big，1.3 more bigger ，1.45 supper big 
            //configuration.FontScale = 1f;
            var config = Application.Context.CreateConfigurationContext(configuration);

            base.AttachBaseContext(config);
        }
        #endregion
    }
}