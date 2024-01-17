using ProductoMVVMSQLite.Models;
using ProductoMVVMSQLite.ViewModels;

namespace ProductoMVVMSQLite.Views;

public partial class ProductoPage : ContentPage
{
    public ProductoPage()
	{
		InitializeComponent();
		BindingContext = new ProductoViewModel();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        (BindingContext as ProductoViewModel).LoadProducts();
    }

    private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
    {

        if (e.SelectedItem is Producto producto)
        {
            (BindingContext as ProductoViewModel)?.OnClickShowDetails.Execute(producto);
        }
    }
}