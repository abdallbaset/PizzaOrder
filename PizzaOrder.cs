using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrder_Project
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        float GetSelectedSizePrice()
        {
            if (rb_SizeLarg.Checked)
            {
                return Convert.ToSingle(rb_SizeLarg.Tag);
            }
            else if (rb_SizeMeduim.Checked)
            {
                return Convert.ToSingle(rb_SizeMeduim.Tag);

            }
            else
            {
                return Convert.ToSingle(rb_SizeSmail.Tag);
            }
        }
        float GetSelectedCurstPrice()
        {
            if(rb_ThinCrust.Checked)
            {
                return Convert.ToSingle(rb_ThinCrust.Tag);
            }
            else if(rb_ThinkCrust.Checked)
            {
                return Convert.ToSingle(rb_ThinkCrust.Tag);
            }
            return 0;

        }
        float GetToppingPrice()
        {
            float ToppingTotalPrice = 0;
            if (chk_ExtraChees.Checked)
            {
                ToppingTotalPrice += Convert.ToSingle(chk_ExtraChees.Tag);
            }
            if (chk_GreenPeppers.Checked)
            {
                ToppingTotalPrice += Convert.ToSingle(chk_GreenPeppers.Tag);
            }
            if (chk_Mushrooms.Checked)
            {
                ToppingTotalPrice += Convert.ToSingle(chk_Mushrooms.Tag);
            }
            if (chk_Olives.Checked)
            {
                ToppingTotalPrice += Convert.ToSingle(chk_Olives.Tag);
            }
            if (chk_Onion.Checked)
            {
                ToppingTotalPrice += Convert.ToSingle(chk_Onion.Tag);
            }
            if (chk_Tomatoes.Checked)
            {
                ToppingTotalPrice += Convert.ToSingle(chk_Tomatoes.Tag);
            }
           
            return ToppingTotalPrice;
        }

        float CalculateTotalPrice()
        {
            return (GetSelectedSizePrice() + GetSelectedCurstPrice() + GetToppingPrice())* (float)numUDo_CounterOrede.Value; 
        }

        void UpdateTotalPrise()
        {
            lbl_PriceValue.Text = "$" + CalculateTotalPrice().ToString();

        }
        void UpdateCrust()
        {
            UpdateTotalPrise();
            if(rb_ThinCrust.Checked)
            {
                lbl_CrustTypeValue.Text = rb_ThinCrust.Text;
                return;
            }

            if (rb_ThinkCrust.Checked)
            {
                lbl_CrustTypeValue.Text = rb_ThinkCrust.Text;
                return;
            }
        }
        void UpdateSize()
        {
            UpdateTotalPrise();
            if(rb_SizeSmail.Checked)
            {
                lbl_SizeValue.Text = rb_SizeSmail.Text;
            }
            else if(rb_SizeMeduim.Checked)
            {
                lbl_SizeValue.Text = rb_SizeMeduim.Text;

            }
            else
            {
                lbl_SizeValue.Text = rb_SizeLarg.Text;
            }

        }
        void UpdateWhereToEat()
        {
            if(rb_EatIn.Checked)
            {
                lbl_WhrToEatValue.Text = rb_EatIn.Text;
            }
            else
            {
                lbl_WhrToEatValue.Text = rb_TakeOut.Text;
            }

        }
        void UpdateToppings()
        {
            UpdateTotalPrise();
            string sToppings = "";
            if(chk_ExtraChees.Checked)
            {
                sToppings = chk_ExtraChees.Text;
            }

            if (chk_Mushrooms.Checked)
            {
                sToppings += "," + chk_Mushrooms.Text;  
            }
            if (chk_Tomatoes.Checked)
            {
                sToppings += "," + chk_Tomatoes.Text;  
            }
            if (chk_Onion.Checked)
            {
                sToppings += "," + chk_Onion.Text;  
            }
            if (chk_Olives.Checked)
            {
                sToppings += "," + chk_Olives.Text;  
            }
            if (chk_GreenPeppers.Checked)
            {
                sToppings += "," + chk_GreenPeppers.Text;  
            }

            if(sToppings.StartsWith(","))
            {
                sToppings = sToppings.Substring(1, sToppings.Length-1).Trim();
            }

            if(sToppings == "")
            {
                sToppings = "No Toping";
            }
            txt_ToppingsValue.Text = sToppings;
        }

        

       void UpdateOrderSummary()
        {
            UpdateSize();
            UpdateCrust();
            UpdateToppings();
            UpdateWhereToEat();
            UpdateTotalPrise();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }
 
   
        private void rb_SizeSmail_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rb_SizeMeduim_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rb_SizeLarg_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }
        

        private void rb_ThinCrust_CheckedChanged(object sender, EventArgs e)
        {

            UpdateCrust();

        }

        private void rb_ThinkCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }


        private void rb_EatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rb_TakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

    
        private void chk_ExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chk_Mushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void chk_Tomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void chk_Onion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chk_Olives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chk_GreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void btn_OrderPizza_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_OrderPizza.Enabled = false;
                gb_CrustType.Enabled = false;
                gb_Size.Enabled      = false;
                gb_Toppings.Enabled  = false;
                gb_whrToEat.Enabled  = false;
                numUDo_CounterOrede.Enabled = false;
            }
        }

        void ResetForm()
        {
            btn_OrderPizza.Enabled = true;
            gb_CrustType.Enabled = true;
            gb_Size.Enabled = true;
            gb_Toppings.Enabled = true;
            gb_whrToEat.Enabled = true;
            chk_ExtraChees.Checked = false;
            chk_GreenPeppers.Checked = false;
            chk_Mushrooms.Checked = false;
            chk_Olives.Checked = false;
            chk_Onion.Checked = false;
            chk_Tomatoes.Checked = false;
            rb_EatIn.Checked = false;
            rb_TakeOut.Checked = false;
            rb_ThinCrust.Checked = false;
            rb_ThinkCrust.Checked = false;
            rb_SizeLarg.Checked = false;
            rb_SizeMeduim.Checked = false;
            rb_SizeSmail.Checked = true;
            numUDo_CounterOrede.Enabled = true;
            numUDo_CounterOrede.Value = 1;
            lbl_SizeValue.Text = "";
            lbl_WhrToEatValue.Text = "";
            lbl_CrustTypeValue.Text = "";
        }
        private void btn_ResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void lbl_PriceValue_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        
        private void numUDo_CounterOrede_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrise();
        }
    }
    }
