﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RetoHotelesM06.Models
{
    public static class HotelesOrm
    {
        public static List<hoteles> Select()
        {
            return Orm.bd.hoteles.ToList();
        }
    }
}
