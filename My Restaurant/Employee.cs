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

        //CR: Constructor of Employee class has no arguments
        public Employee(int quantity, string menuItem)
        {
            this.quantity = quantity;
            this.menuItem = menuItem;
        }

        /*
        |   METHOD NEWREQUEST              |
        |__________________________________|
        */
        object MI;

        //CR: Method NewRequest has 2 arguments
        public object NewRequest(string menuItem)
        {
            if (menuItem == "Chicken")
            {
                ChickenOrder chicken = new ChickenOrder();
                MI = chicken.GetQuantity(quantity);
                //CR: Quantity should be gotten from UI 
                return MI;
            }
            else
            //CR: It will be better, if you add one more if-statement to check (menuItem=="Egg"???)
            {

                EggOrder egg = new EggOrder();
                MI = egg.GetQuantity(quantity);
                //CR: Quantity should be gotten from UI 
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
            //CR: You should not create an instance of Employee class here
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
            //CR: Check requirements for this method
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
                //CR: Where is CutUp-method, that should be called for every menuItem in the order?
                //CR: You don't need to create an instance of ChickenOrder here
                ChickenOrder chicken = new ChickenOrder();
                string fdCh = chicken.Cook();
                return fdCh;
            }
            else
            {
                //CR: Where is CutUp-method, that should be called for every menuItem in the order?
                //CR: You don't need to create an instance of EggOrder here
                EggOrder egg = new EggOrder();
                string fdE = egg.Cook();
                return fdE;
            }

        }
    }
}
