using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetoHotelesM06.Models
{
    public static class HotelesOrm
    {
        public static List<hoteles> Select()
        {
            return Orm.bd.hoteles.ToList();
        }
        public static string UpdateHotel(hoteles hotel, hoteles update)
        {
            var hotelToUpdate = Orm.bd.hoteles.FirstOrDefault(h => h.id_ciudad == hotel.id_ciudad && h.nombre == hotel.nombre);

            if (hotelToUpdate != null)
            {
                hotelToUpdate.tipo = update.tipo;
                hotelToUpdate.telefono = update.telefono;
                hotelToUpdate.categoria = update.categoria;
                hotelToUpdate.direccion = update.direccion;
                hotelToUpdate.act_hotel = update.act_hotel;


            }
            return Orm.MySaveChanges();
        }

    }
}
