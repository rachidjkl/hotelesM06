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
            List<cadenas> _cadenas = (
                from c in Orm.bd.cadenas
                select c).ToList();

            return _cadenas;
        }
    }
}
