using System;
using System.Threading;
using System.Windows.Forms;

namespace Ilaks_Assignment_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // Tooltips to display the functions of clear button and Exit button
        private void Form1_Load(object sender, EventArgs e)
        {
            startbtn.Focus();
            toolTip1.SetToolTip(Clearbtn, "Press to clear form for next user");
            toolTip1.SetToolTip(Exitbtn, "Press to Exit Application");
        }


        // Error message for entering only alphabets in Server Name
        private void Name_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Please enter only alphabets", "Error!");
            }
        }


        // Error message for entering only numeric value in Table Number
        private void Table_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Please enter only numeric", "Error!");
            }
        }


        // Error message for entering "0" in Table number
        private void Table_txtbox_TextChanged(object sender, EventArgs e)
        {
            //local variable declaration
            int TableNum;
            int.TryParse(this.Table_txtbox.Text, out TableNum);
            if (TableNum == 0)
            {
                MessageBox.Show("Enter Table Number between 1-9", "Error");
                Table_txtbox.Clear();
            }
        }


        // Actions performed when start button is clicked
        private void startbtn_Click(object sender, EventArgs e)
        {
            // local variable declaration
            string a1;
            string a2;


            // Assigning vales of the text box to local variables
            a1 = Name_txtbox.Text;
            a2 = Table_txtbox.Text;

            
            // Error message when server name and table number is left blank 
            if (a1 == "" | a2 == "")
            {
                Welcome_panel.Visible = true;
                MessageBox.Show("Enter Server Name and Table Number", "Error");
                this.Text = "Welcome to Sult";
                this.Server_txtbox.Focus();
            }


            // Spliting the first and last name of the server and displaying the first name in the form
            else
            {
                Welcome_panel.Visible = false;
                string[] fullName = a1.Split(new Char[] { ' ' });
                string firstName = fullName[0];
                this.Text = firstName + " " + "@ Table Number" + " " + a2;
                pizzamenu_panel.Visible = true;
                pictureBox1.Visible = true;
                Order_panel.Visible = false;
                Button_panel.Visible = true;
            }
        }


        // Global variable declaration
        string t1,t;
        int clicks;


        // Actions performed when order button is clicked
        public void Orderbtn_Click(object sender, EventArgs e)
        {
            // Total number of transactions made
            ++clicks;

            Server_txtbox.Text = Name_txtbox.Text;
            pizzamenu_panel.Enabled = false;
            Order_panel.Visible = true;
            Summary_panel.Visible = false;


            // Assigning vales of each pizza order to local variables
            string x = Margherita_pizza_txtbox.Text;
            string y = Pepparoni_pizza_txtbox.Text;
            string z = Ham_pineapple_txtbox.Text;

            double x1 = Convert.ToDouble(x);
            double x2 = x1 * 9;
            double y1 = Convert.ToDouble(y);
            double y2 = y1 * 11.50;
            double z1 = Convert.ToDouble(z);
            double z2 = z1 * 12.79;


            // Error message when the pizza values are not entered
            if (x1 == 0 && y1 == 0 && z1 == 0)
            {
                Order_panel.Visible = false;
                pizzamenu_panel.Enabled = true;
                MessageBox.Show("Please enter the quantity of pizzas");
            }


            // Calculating the total number of pizzas and total table receipts and displaying them
            else
            {
                double total_Number_pizza = x1 + y1 + z1;
                t = total_Number_pizza.ToString();
                double total_table_receipts = (x2 + y2 + z2) + 2.49;
                total_pizza_txtbox.Text = t;
                t1 = total_table_receipts.ToString();
                total_receipt_txtbox.Text = "€" + t1;
            }
        }


        // Actions performed when clear button is clicked
        // Clearing all the values entered and returning to the welcome page
        private void Clearbtn_Click(object sender, EventArgs e)
        {
            this.Margherita_pizza_txtbox.Clear();
            this.Pepparoni_pizza_txtbox.Clear();
            this.Ham_pineapple_txtbox.Clear();
            this.Server_txtbox.Clear();
            this.total_pizza_txtbox.Clear();
            this.total_receipt_txtbox.Clear();
            this.Margherita_pizza_txtbox.Text = "0";
            this.Pepparoni_pizza_txtbox.Text = "0";
            this.Ham_pineapple_txtbox.Text = "0";
            this.Company_transaction_txtBox.Clear();
            this.Total_company_pizza_txtBox.Clear();
            this.Total_company_pizza_txtBox.Clear();
            this.Avg_transaction_txtBox.Clear();
            this.Table_txtbox.Text = "1";
            this.Name_txtbox.Clear();
            pizzamenu_panel.Visible = false;
            pizzamenu_panel.Enabled = true;
            Order_panel.Visible = false;
            Summary_panel.Visible = false;
            Welcome_panel.Visible = true;
            Summarybtn.Enabled = true;
            Orderbtn.Enabled = true;
            pictureBox1.Visible = false;
            Button_panel.Visible = false;
            this.Text = "Welcome to Sult";
        }

        
        // Global variable declaration
        int totalnumberofpizzas;
        double totalcompanyreceipts;
        double avgtransactions;


        // Actions performed when summary button is clicked
        public void Summarybtn_Click(object sender, EventArgs e)
        {
            Order_panel.Visible = false;
            Summary_panel.Visible = true;
            pizzamenu_panel.Visible = false;
            this.Text = "Sult Company Summary Data";


            // Calling the global variable to display the total company transactions
            Company_transaction_txtBox.Text = clicks.ToString();


            // Exception handling when the summary button is clicked but the order is not placed
            // Calculating the total Sult receipts 
            try
            {
                double totalreceipt;
                totalreceipt = Convert.ToDouble(t1);
                totalcompanyreceipts += totalreceipt;
                Total_company_receipt_txtBox.Text = "€" + totalcompanyreceipts.ToString();
            }
            catch
            {
                MessageBox.Show("Sorry no transactions were made", "Error");
            }


            // Calculating the total number of pizzas sold by the Sult
            try
            {
                int totalpizza;
                totalpizza = Convert.ToInt32(t);
                totalnumberofpizzas += totalpizza;
                Total_company_pizza_txtBox.Text = totalnumberofpizzas.ToString();
            }
            catch
            {
                MessageBox.Show("Sorry no transactions were made", "Error");
            }


            // Calculating the average transaction values of the Sult
            avgtransactions = totalcompanyreceipts / clicks;
            Math.Round(avgtransactions, 2);
            Avg_transaction_txtBox.Text = "€" + avgtransactions.ToString();
        }


        // Action performed when exit button is clicked
        private void Exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
