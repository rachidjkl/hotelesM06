using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoHotelesM06.Models
{
    public static class CadenasOrm{
        public static string SelectCadenas(string cif)
        {
            cadenas _cadenas = Orm.bd.cadenas.FirstOrDefault(t => t.cif == cif);
            return _cadenas.nombre;
        }

        public static List<cadenas> Select()
        {
            return Orm.bd.cadenas.ToList();
        }
    }
}
