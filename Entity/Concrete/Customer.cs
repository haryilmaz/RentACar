using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Customer : IEntity 
    {
        public int CustomerId { get; set; }
        public String Name { get; set; }
        public String Address { get; set; } 
        public String City { get; set; }    
        public String Region { get; set; }  
        public String PostalCode { get; set; }  
        public String Country { get; set; } 
        public String Phone { get; set; }   
        public String Fax { get; set; } 
        
    }
}
