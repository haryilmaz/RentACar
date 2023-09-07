
using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Car : IEntity
    {
        public int CarId { get; set; }
        public DateTime ManufactureDate { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; } 
        public int Price { get; set; }
    }
}
