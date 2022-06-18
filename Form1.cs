using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace billing_application
{
    public partial class Form1 : Form
    {
       
       public billing bill = new billing();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bill.customername = cust_name_tb.Text;
            bill.contactnumber = cont_num_tb.Text;
            bill.addindict();
        }

        private void prod_item_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            bill.product_item = prod_item_cmb.Text;
            bill.brandlist();
            brand_cmb.Items.Clear();
            foreach (string item in bill.mylist)
            {
                brand_cmb.Items.Add(item);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bill.productlist();
            foreach (string item in bill.mylist)
            {
                prod_item_cmb.Items.Add(item);
            }
           // bill.brandlist();
        }

        private void brand_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            bill.brand_name = brand_cmb.Text;
            prod_price_tb.Clear();
            bill.productprice();
            prod_price_tb.Text = bill.product_price;
            cgst_tb.Text =Convert.ToString( bill.cgst);
            sgst_tb.Text =Convert.ToString( bill.sgst);
        }

        private void Quantity_nud_ValueChanged(object sender, EventArgs e)
        {
            
            bill.quantity = Quantity_nud.Value;
                bill.totalcalc();      
           total_tb.Text = Convert.ToString(bill.total);
        }

        private void discount_nud_ValueChanged(object sender, EventArgs e)
        {
            total_tb.Clear();
            bill.discount = discount_nud.Value;
            bill.discountcalc();
            total_tb.Text = Convert.ToString(bill.total);

        }

        private void bill_btn_Click(object sender, EventArgs e)
        {
            
            bill_lb.Items.Add(" ");
            bill_lb.Items.Add(" ");
            bill_lb.Items.Add("\t\t\t\t\t\t\t"+topicnamelbl.Text);
            bill_lb.Items.Add(" ");
            bill_lb.Items.Add("Customer Name :"+cust_name_tb.Text);
            bill_lb.Items.Add(" ");
            bill_lb.Items.Add("--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            bill_lb.Items.Add("\tProduct Item" + "\t" + "Brand Name" + "\t" + "Product Price" + "\t" +"Quantity"+"\t                "+ "CGST" + "\t                 " + "SGST" + "\t            " + "Discount" + "\t                " + "TOTAL");
            bill_lb.Items.Add("--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            
            foreach (string item in bill.mylist)
            {
                bill_lb.Items.Add("\t" + bill.mylist[0] + "\t\t" + bill.mylist[1] + "\t\t" + bill.mylist[2] + "\t\t" + bill.mylist[3] + "\t\t" + bill.mylist[4] + " " + bill.mylist[6] + "%" + "\t\t" + bill.mylist[5] + " " + bill.mylist[6] + "%" + "\t\t" + bill.mylist[7] + "%" + "\t\t" + bill.mylist[8]+"\n");
            }
        }

        private void clr_btn_Click(object sender, EventArgs e)
        {
            prod_item_cmb.Text = "";
            brand_cmb.Text = "";
            prod_price_tb.Text = "";
            cgst_tb.Text = "";
            sgst_tb.Text = "";
            Quantity_nud.Value =0 ;
            discount_nud .Value=0 ;
            total_tb.Text = "";
        }
    }
}
