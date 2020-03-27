using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cybertruck.Abstraction
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BaseContentPage : ContentPage
    {
        public BaseContentPage()
        {
            InitializeComponent();
        }

        public async Task PushModelNextPage(Page page)
        {
            if (page != null)
            {
                if (App.Current.MainPage.Navigation.ModalStack.Count > 0)
                {
                    var latestPage = App.Current.MainPage.Navigation.ModalStack.LastOrDefault();
                    if (latestPage?.GetType() != page.GetType())
                    {
                        await App.Current.MainPage.Navigation.PushModalAsync(page);
                    }
                }
                else
                {
                    await App.Current.MainPage.Navigation.PushModalAsync(page);
                }

            }
        }
    }
}