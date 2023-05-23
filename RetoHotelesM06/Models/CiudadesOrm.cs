using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoHotelesM06.Models
{
    public static class CiudadesOrm
    {
        public static List<ciudades> SelectCiudades()
        {
            return Orm.bd.ciudades.ToList();
        }
    }
}
