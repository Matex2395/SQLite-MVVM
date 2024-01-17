using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductoMVVMSQLite.Models;
using ProductoMVVMSQLite.Utils;
using ProductoMVVMSQLite.Views;
using PropertyChanged;
using System.Windows.Input;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProductoMVVMSQLite.ViewModels
{
    public class NuevoProductoViewModel
    {

        public string Nombre { get; set; }
        public string Cantidad { get; set; }
        public string Descripcion { get; set; }


        public NuevoProductoViewModel()
        {

        }

        public ICommand GuardarProducto =>
        new Command(async () =>
        {
                if (!string.IsNullOrEmpty(Nombre) && !string.IsNullOrEmpty(Descripcion) && !string.IsNullOrEmpty(Cantidad))
                {
                Producto producto = new()
                    {
                        Nombre = Nombre,
                        Descripcion = Descripcion,
                        Cantidad = Int32.Parse(Cantidad)
                    };
                    App.productoRepository.Add(producto);
                    Util.ListaProductos = App.productoRepository.GetAll();
                    await App.Current.MainPage.Navigation.PopAsync();
                }
            });

    }
}
