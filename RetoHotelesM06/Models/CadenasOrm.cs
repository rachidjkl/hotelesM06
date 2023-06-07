using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoHotelesM06.Models
{
    public static class CadenasOrm{

        public static List<cadenas> Select()
        {
            return Orm.bd.cadenas.ToList();
        }

        public static string AddCadena(cadenas cadena)
        {
            Orm.bd.cadenas.Add(cadena);

            return Orm.MySaveChanges();
        }

        public static string UpdateCadena(cadenas cadena, cadenas update)
        {
            var cadenaToUpdate = Orm.bd.cadenas.FirstOrDefault(h => h.cif == cadena.cif);

            if (cadenaToUpdate != null)
            {
                cadenaToUpdate.cif = update.cif;
                cadenaToUpdate.dir_fis = update.dir_fis;
                cadenaToUpdate.nombre = update.nombre;
            }
            return Orm.MySaveChanges();
        }

        public static string DeleteCadena(cadenas cadena)
        {
            var cadenaToDelete = Orm.bd.cadenas.FirstOrDefault(h => h.cif == cadena.cif);

            if (cadenaToDelete != null)
            {
                Orm.bd.cadenas.Remove(cadenaToDelete);
            }
            return Orm.MySaveChanges();
        }
    }
}
