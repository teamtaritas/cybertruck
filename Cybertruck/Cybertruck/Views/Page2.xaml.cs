using Cybertruck.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cybertruck.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
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

        private void NavigateToPage3(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Page3());
        }
    }
}