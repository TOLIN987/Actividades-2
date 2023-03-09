using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Actividades_2
{
    internal class Product
   {
        protected string name;
        protected decimal? price;
        protected int? quantity;
        protected string category;
        protected string description;
            public string Name 
            { get { return name; }    
              set { name = value; } 
            }public decimal? Price 
            { get { return price; }    
              set { price = value; } 
            }public int? Quantity 
            { get { return quantity; }    
              set { quantity = value; } 
            }public string Category 
            { get { return category; }    
              set { category = value; } 
            }public string Description 
            { get { return description; }    
              set { description = value; } 
            }
            
            public Product()
            {
                name = string.Empty;
                price = null;
                quantity = null;
                category = string.Empty;
                description = string.Empty;
            }
            public Product(string name, decimal price, int quentity, string category, string description)
            {
                this.name = name;
                this.price = price;
                this.quantity = quentity;
                this.category = category;
                this.description = description;
            }
        public override string ToString()
        {

            return name + "," + "$"+price + "," + quantity + "," + category + "," + description;
        }       
    }
}
