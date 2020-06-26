using PruebaCorpSafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaCorpSafe.Services
{
    public class ProductoRepositorioEnMemoria
    {
        public List<Producto> ObtenerTodos()
        {
            List<Producto> productos = new List<Producto>()
            {
                new Producto(){Id=1,Nombre="Producto1",Precio=1,Cantidad=1,Descontinuado=false },
                new Producto(){Id=2,Nombre="Producto2",Precio=2,Cantidad=2,Descontinuado=false },
                new Producto(){Id=3,Nombre="Producto3",Precio=3,Cantidad=3,Descontinuado=false },
                new Producto(){Id=4,Nombre="Producto4",Precio=4,Cantidad=4,Descontinuado=false },
                new Producto(){Id=5,Nombre="Producto5",Precio=5,Cantidad=5,Descontinuado=false },
                new Producto(){Id=6,Nombre="Producto6",Precio=6,Cantidad=6,Descontinuado=false },
                new Producto(){Id=7,Nombre="Producto7",Precio=7,Cantidad=7,Descontinuado=false },
                new Producto(){Id=8,Nombre="Producto8",Precio=8,Cantidad=8,Descontinuado=false },
                new Producto(){Id=9,Nombre="Producto9",Precio=9,Cantidad=9,Descontinuado=false },
                new Producto(){Id=10,Nombre="Producto10",Precio=10,Cantidad=10,Descontinuado=false },
                new Producto(){Id=11,Nombre="Producto11",Precio=11,Cantidad=11,Descontinuado=false },
                new Producto(){Id=12,Nombre="Producto12",Precio=12,Cantidad=12,Descontinuado=false },
                new Producto(){Id=13,Nombre="Producto13",Precio=13,Cantidad=13,Descontinuado=true },
                new Producto(){Id=14,Nombre="Producto14",Precio=14,Cantidad=14,Descontinuado=true },
                new Producto(){Id=15,Nombre="Producto15",Precio=15,Cantidad=15,Descontinuado=true },
                new Producto(){Id=16,Nombre="Producto16",Precio=16,Cantidad=16,Descontinuado=true },
                new Producto(){Id=17,Nombre="Producto17",Precio=17,Cantidad=17,Descontinuado=true },
                new Producto(){Id=18,Nombre="Producto18",Precio=18,Cantidad=18,Descontinuado=true },
                new Producto(){Id=19,Nombre="Producto19",Precio=19,Cantidad=19,Descontinuado=true },
                new Producto(){Id=20,Nombre="Producto20",Precio=20,Cantidad=20,Descontinuado=true },
                new Producto(){Id=21,Nombre="Producto21",Precio=21,Cantidad=21,Descontinuado=true },
                new Producto(){Id=22,Nombre="Producto22",Precio=22,Cantidad=22,Descontinuado=true },
                new Producto(){Id=23,Nombre="Producto23",Precio=23,Cantidad=23,Descontinuado=true },
                new Producto(){Id=24,Nombre="Producto24",Precio=24,Cantidad=24,Descontinuado=true },
                new Producto(){Id=25,Nombre="Producto25",Precio=25,Cantidad=25,Descontinuado=true }
            };
            return productos;
        }
    }
}
