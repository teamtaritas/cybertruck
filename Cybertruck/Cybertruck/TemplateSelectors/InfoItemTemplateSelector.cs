using Cybertruck.Models;
using Xamarin.Forms;

namespace Cybertruck.TemplateSelectors
{
    public class InfoItemTemplateSelector : DataTemplateSelector
    {
        public DataTemplate EngineInfoTemplate { get; set; }
        public DataTemplate ClimateInfoTemplate { get; set; }
        public DataTemplate TireInfoTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (((HelperModel)item).Header == "Engine")
            {
                return EngineInfoTemplate;
            }
            else if (((HelperModel)item).Header == "Climate")
            {
                return ClimateInfoTemplate;
            }
            else if (((HelperModel)item).Header == "Tires")
            {
                return TireInfoTemplate;
            }
            return null;
        }
    }
}
