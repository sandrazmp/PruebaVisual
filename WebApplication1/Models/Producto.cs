﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
   public class Producto
    {
        public int codigoproducto { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int cantidad { get; set; }
        public double precio { get; set; }
    }
}
