using JewelryShopMAUI.Views;

namespace JewelryShopMAUI;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AcasaView();
	}
}
