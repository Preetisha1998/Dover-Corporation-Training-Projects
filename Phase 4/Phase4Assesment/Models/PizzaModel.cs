using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phase4Assesment.Models
{
    public class PizzaModel
    {
        public int PizzaId { get; set; }
        public string PName { get; set; }
        public string Crust { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
    }
}
