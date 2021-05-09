using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Restaurant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        int CounterChickBtn = 0;
        int CounterEggBtn = 0;
        private void btnNewRequest_Click(object sender, EventArgs e)
        {
             
       
            bool chicken = radioButtonChicken.Checked;
            bool egg = radioButtonEgg.Checked;

            string menuItem;

            if (chicken == true)
            {
                // COUNTERS
                CounterChickBtn++;
                
                // string txt = (CounterChickBtn % 3 == 0 ? "Egg" : "Chicken");
               
                
                if (CounterChickBtn % 3 == 0)
                {
                   // AGAR RADIOBUTTONI CHICKEN VAQTI 3 BOR ZER KARDAGI BUTTON NEWREQUESTANDA  TRUE BOSHAD OBJECTI eggOrdero BAR MEGARDONAD.
                
                    
                    menuItem = "Egg";
                    try 
                    {
                        int quantity = Convert.ToInt32(txtBoxQuantity.Text);
                        // PROVERKA quantity
                        if (quantity > 0)
                        {
                            Employee employee = new Employee(quantity, menuItem);
                            object questFood = employee.NewRequest(menuItem);
                            txtBoxResults.Text = $"{CounterChickBtn} You request is {questFood.ToString()}, {menuItem}";
                          
                            //Employee emp = new Employee(quantity, menuItem);
                            string empInsE = employee.Inspect(menuItem);
                            
                            // INSPECT 
                            resultlblQuality.Text = empInsE;
                        }
                        else
                        {
                            MessageBox.Show("Write quantity number big is 0");
                        }
                    }
                    catch (FormatException fex)
                    {
                        MessageBox.Show(fex.Message);
                    }
                } 
                
                // ELSE
                // VAGARNA OBJECTI chickenOrdera BARMEGARDONAD
                
                
                else
                {
                    menuItem = "Chicken";
                    try
                    {
                        int quantity = Convert.ToInt32(txtBoxQuantity.Text);
                        // PROVERKA quantity
                        if (quantity > 0)
                        {
                            Employee employee = new Employee(quantity, menuItem);
                            object questFood = employee.NewRequest(menuItem);
                            txtBoxResults.Text = $"{CounterChickBtn}You request is {questFood.ToString()}, {menuItem}";

                            string empInsCh = employee.Inspect(menuItem);
                            resultlblQuality.Text = empInsCh;
                        }
                        else
                        {
                            MessageBox.Show("Write quantity number big is 0");
                        }
                    }
                    catch (FormatException fex)
                    {
                        MessageBox.Show(fex.Message);
                    }
                }


                // RESULT 
                //txtBoxResults.Text = CounterChickBtn.ToString() + " " + txt;
            }

            // VAGARNA RADIOBUTTONI EGG VAQTI 3 BOR ZER KARDAGI BUTTON NEWREQUESTANDA  TRUE BOSHAD OBJECTI chickenOrder BAR MEGARDONAD.
            else if (egg == true)
            {
                // COUNTERS
                CounterEggBtn++;
               // string tx = (CounterEggBtn % 3 == 0 ? "Chicken" : "Egg");
             
                if(CounterEggBtn % 3 == 0)
                {
                    menuItem = "Chicken";
                   
                    try
                    {
                        int quantity = Convert.ToInt32(txtBoxQuantity.Text);
                        // PROVERKA quantity
                        if (quantity > 0)
                        {
                            Employee employee = new Employee(quantity, menuItem);
                            object questFood = employee.NewRequest(menuItem);
                            txtBoxResults.Text = $"{CounterChickBtn} You request is {questFood.ToString()}, {menuItem}";

                            string empInsCh = employee.Inspect(menuItem);
                            resultlblQuality.Text = empInsCh;
                        }
                        else
                        {
                            MessageBox.Show("Write quantity number big is 0");
                        }
                    }
                    catch (FormatException fex)
                    {
                        MessageBox.Show(fex.Message);
                    }
                }
                // ELSE
                // VAGARNA OBJECTI eggOrdera BARMEGARDONAD

                else
                {
                    menuItem = "Egg";
                   
                    try
                    {
                        int quantity = Convert.ToInt32(txtBoxQuantity.Text);
                        // PROVERKA quantity
                        if (quantity > 0)
                        {
                            Employee employee = new Employee(quantity, menuItem);
                            object questFood = employee.NewRequest(menuItem);
                            txtBoxResults.Text = $"{CounterChickBtn} You request is {questFood.ToString()}, {menuItem}";

                            string empInsE = employee.Inspect(menuItem);
                            resultlblQuality.Text = empInsE;
                        }
                        else
                        {
                            MessageBox.Show("Write quantity number big is 0");
                        }
                    }
                    catch (FormatException fex)
                    {
                        MessageBox.Show(fex.Message);
                    }
                
                }

               // RESULT
               //txtBoxResults.Text = CounterEggBtn.ToString() + " " + tx;
            }
            else
            {
                // THIS ELSE NO WORKED!
                txtBoxResults.Text = "OK";
            }
        
        }

        int counterPreBtn = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if (CounterChickBtn > 0 || CounterEggBtn > 0) {
                
                int quantity = Convert.ToInt32(txtBoxQuantity.Text);
                string menuItem;
                counterPreBtn++;

                if (radioButtonChicken.Checked) {
                    if (counterPreBtn % 2 != 0)
                    {
                        menuItem = "Chicken";
                        Employee employee = new Employee(quantity, menuItem);
                        string empPreFd = employee.PrepareFood(menuItem);

                        txtBoxResults.Text = $"You {empPreFd}";
                    }
                    else
                    {
                        txtBoxResults.Text = "You not PrepareFood";
                    }
                return;
                
                }else
                {
                    if (counterPreBtn % 2 != 0)
                    {
                        menuItem = "Egg";
                        Employee employee = new Employee(quantity, menuItem);
                        string empPreFd = employee.PrepareFood(menuItem);

                        txtBoxResults.Text = $"You {empPreFd}";
                    }
                    else
                    {
                        txtBoxResults.Text = "You not PrepareFood";
                    }
                }
                return;
            }
            else
            {
                MessageBox.Show("You not requested MenuItem");
            }

        }

        
        int CountChickenBtn = 0;
        int CountEggBtn = 0;
        private void btnCopy_Click(object sender, EventArgs e)
        {
            
            bool chicken = radioButtonChicken.Checked;
            bool egg = radioButtonEgg.Checked;
            string menuItem;
            
            
            if (CounterChickBtn > 0 || CounterEggBtn > 0) {

                if (chicken == true)
                {
                    CountChickenBtn++;

                    // string tx = (CountChickenBtn % 3 == 0 ? "Egg" : "Chicken");

                    menuItem = "Chicken";
                    
                    try
                    {
                        int quantity = Convert.ToInt32(txtBoxQuantity.Text);
                        if (quantity > 0 || txtBoxQuantity.Text == "")
                        {
                            Employee employee = new Employee(quantity, menuItem);
                            object emp = employee.CopyRequest();
                            MessageBox.Show($"You {emp.ToString()}, {menuItem} copyed");
                        }
                        else
                        {
                            MessageBox.Show("Write quantity for coped!");
                        }
                    }
                    catch(FormatException fex)
                    {
                        MessageBox.Show(fex.Message);
                    }

                    // RESULT
                    // txtBoxResults.Text = CountChickenBtn.ToString() + " " + tx;
                }

                else if (egg == true)
                {
                    CountEggBtn++;

                    menuItem = "Egg";
                    try
                    {
                        int quantity = Convert.ToInt32(txtBoxQuantity.Text);

                        if (quantity > 0 || txtBoxQuantity.Text == "")
                        {
                            Employee employee = new Employee(quantity, menuItem);
                            object emp = employee.CopyRequest();
                            MessageBox.Show($"You {emp.ToString()}, {menuItem} copyed");
                        }
                        else
                        {
                            MessageBox.Show("Write quantity for coped!");
                        }
                    }
                    catch (FormatException fex)
                    {
                        MessageBox.Show(fex.Message);
                    }


                    // string tx = (CountEggBtn % 3 == 0 ? "Chicken" : "Egg");
                    // RESULT
                    // txtBoxResults.Text = CountEggBtn.ToString() + " " + tx;
                }

                else
                {
                    // THIS ELSE NO WORKED!
                    MessageBox.Show("OK");
                }
            }
            else
            {
                MessageBox.Show("You Not Coped!");
            }
            
        }
    }
}
 