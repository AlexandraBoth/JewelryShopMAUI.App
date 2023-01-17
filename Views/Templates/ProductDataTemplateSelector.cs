using JewelryShopMAUI.Models;

namespace JewelryShopMAUI.Views.Templates
{
    public class ProductDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate ResultsTemplate { get; set; }
        public DataTemplate ProdusTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var product = (Produs)item;

            if (product.IsEmpty())
                return ResultsTemplate;

            return ProdusTemplate;
        }
    }
}