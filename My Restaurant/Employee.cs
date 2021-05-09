using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Restaurant
{
    class Employee
    {
        private int quantity;
        private string menuItem;
         public Employee(int quantity, string menuItem) 
         {
         this.quantity = quantity;
         this.menuItem = menuItem;
         }

        /*
        ___________________________________
        |   METHOD NEWREQUEST              |
        |__________________________________|
        */
        object MI;
        public object NewRequest(string menuItem)
        {
            
            if (menuItem == "Chicken")
            {
                ChickenOrder chicken = new ChickenOrder();
                MI = chicken.GetQuantity(quantity);
                return MI; 
            } 
            else  
            {
               
                EggOrder egg = new EggOrder();
                MI = egg.GetQuantity(quantity);
                return MI;
            } 
              
        }

        /*
        ___________________________________
        |   METHOD COPYREQUEST             |
        |__________________________________|
        */
        public object CopyRequest()
        {
            Employee employee = new Employee(quantity, menuItem);
            object mi = employee.NewRequest(menuItem);
            return mi;
        }

        /*
        ___________________________________
        |   METHOD INSPECT                 |
        |__________________________________|
        */
        public string Inspect(string menuItem)
         {
            if (menuItem == "Chicken")
            {
                ChickenOrder chicken = new ChickenOrder();
                return chicken.CutUp();
            }
             else
            {
                EggOrder egg = new EggOrder();
        
                if (egg.Crack() > 25)
                {
                    return $"{egg.GetQuality()} , {egg.DiscardShell()}";
                }
                else
                {
                    return egg.GetQuality();
                }
                
            }
            
        }

        /*
        ___________________________________
        |   METHOD PREPAREFOOD             |
        |__________________________________|
        */
        public string PrepareFood(string menuItem)
        {
            //Employee employee = new Employee(quantity, menuItem);
           // object fd = employee.NewRequest(menuItem);
            if (menuItem == "Chicken")
            {
                ChickenOrder chicken = new ChickenOrder();
                string fdCh = chicken.Cook();
                return fdCh;
            }
            else
            {
                EggOrder egg = new EggOrder();
                string fdE = egg.Cook();
                return fdE;
            }
           
        }
    }
}
