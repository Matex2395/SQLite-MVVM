using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductoMVVMSQLite.Models;

namespace ProductoMVVMSQLite.Utils
{
    public static class Util
    {

        static public List<Producto> ListaProductos = new List<Producto>()
        {
            new Producto{
                IdProducto=1,
                Nombre="Producto 1",
                Descripcion="Descripcion 1",
                Cantidad=1
            },

            new Producto{
                IdProducto=2,
                Nombre = "Producto 2",
                Descripcion="Descripcion 2",
                Cantidad=2
            }

        };

        private const string DBFileName = "producto.db3";
        public const SQLiteOpenFlags Flags =
            SQLiteOpenFlags.ReadWrite |
            SQLiteOpenFlags.Create |
            SQLiteOpenFlags.SharedCache;

        public static string DataBasePath
        {
            get
            {
                return Path.Combine(FileSystem.AppDataDirectory, DBFileName);
            }
        }
    }
}
