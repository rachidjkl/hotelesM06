using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoHotelesM06.Models
{
    public static class ActividadesOrm
    {
        public static List<actividades> SelectActividades()
        {
            List<actividades> _act_hotel = Orm.bd.actividades
                .ToList();

            return _act_hotel;
        }

        public static int SelectGrado(actividades actividades)
        {
            int grado = Orm.bd.act_hotel
                .Where(c => c.id_act == actividades.id_act)
                .Select(c => c.grado)
                .FirstOrDefault();

            return grado;
        }
    }
}
