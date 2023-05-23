using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoHotelesM06.Models
{
    public static class ActividadesOrm
    {
        public static List<act_hotel> SelectActividades(hoteles hotel)
        {
            List<act_hotel> _act_hotel = Orm.bd.act_hotel
                .Where(c => c.id_ciudad == hotel.id_ciudad && c.nombre == hotel.nombre)
                .ToList();

            return _act_hotel;
        }

        public static List<actividades> Select()
        {
            List<actividades> _act_hotel = Orm.bd.actividades
                .ToList();

            return _act_hotel;
        }
    }
}
