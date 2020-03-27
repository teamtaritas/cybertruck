using Cybertruck.Abstraction;
using Cybertruck.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cybertruck.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : BaseContentPage
    {
        private ObservableCollection<HelperModel> _informations;
        public ObservableCollection<HelperModel> Informations
        {
            get { return _informations; }
            set { _informations = value; OnPropertyChanged(nameof(Informations)); }
        }

        public Page2()
        {
            InitializeComponent();
            BindingContext = this;

            Informations = new ObservableCollection<HelperModel>(new List<HelperModel> 
            {
                new HelperModel{  Header="Engine", Detail= "Sleeping mode"},
                new HelperModel{  Header="Climate", Detail= "A/C is ON"},
                new HelperModel{  Header="Tires", Detail= "Low presure"}
            });
        }

        private void GoBack(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        private async void NavigateToPage3(object sender, EventArgs e)
        {
            image.Source = "powerDarkGray.png";
            ButtonControl.BorderColor = Color.FromHex("#FF1B2024");
            SfGradientStop1.Color = Color.FromHex("#FF2B3034");
            SfGradientStop2.Color = Color.FromHex("#FF212528");
            await Task.Delay(50);
            image.Source = "power.png";
            ButtonControl.BorderColor = Color.FromHex("#FF0E9BED");
            SfGradientStop1.Color = Color.FromHex("#FF0361A7");
            SfGradientStop2.Color = Color.FromHex("#FF0E9BED");
            
            await PushModelNextPage(new Page3());
        }
    }
}