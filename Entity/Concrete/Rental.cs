﻿using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Rental : IEntity
    {
        public int RentalId { get; set; }    
        public DateTime RentDate { get; set; }
        public DateTime DeliveryDate { get; set; }
           
    }
}
