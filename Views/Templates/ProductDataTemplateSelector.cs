using JewelryShopMAUI.Models;

namespace JewelryShopMAUI.Views.Templates
{
    public class ProductDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate ResultsTemplate { get; set; }
        public DataTemplate ProductTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var product = (Produs)item;

            if (product.IsEmpty())
                return ResultsTemplate;

            return ProductTemplate;
        }
    }
}