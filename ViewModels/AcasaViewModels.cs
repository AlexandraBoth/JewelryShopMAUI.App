
using JewelryShopMAUI.Models;
using JewelryShopMAUI.Services;
using System.Collections.ObjectModel;



namespace JewelryShopMAUI.ViewModels
{
    public class AcasaViewModel : ViewModelBase
    {
        ObservableCollection<Produs> _produse;

        public AcasaViewModel()
        {
            LoadData();
        }

        public ObservableCollection<Produs> Produse
        {
            get { return _produse; }
            set
            {
                _produse = value;
                OnPropertyChanged();
            }
        }

        private void LoadData()
        {
            Produse = new ObservableCollection<Produs>();

            // Add first fake item
            Produse.Add(new Produs());

            foreach (var produs in ProdusS.Instance.GetProdus())
                Produse.Add(produs);
        }
    }
}
