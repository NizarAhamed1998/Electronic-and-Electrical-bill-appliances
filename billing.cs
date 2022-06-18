using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace billing_application
{
   public class billing
    {
        public string path = "E:\\Database\\billing\\product.txt";
       // public string brandpath = "E:\\Database\\billing\\brands\\";
        public Dictionary<string, string[]> mydict = new Dictionary<string, string[]>();
        public List<string> mylist = new List<string>();

        #region datamembers

        public string customername;
        public string contactnumber;
         string _product_item;
         string _brand_name;
         string _product_price;
         decimal _quantity;
         double _cgst;
         double _sgst;
         int _total;
         decimal _discount;
         int gst_percent;
        #endregion
        #region product list in item view in cmb
        public void productlist()
        {
            string[] data = File.ReadAllLines(path);
            for (int i = 0; i < data.Length; i++)
            {
                mylist.Add(data[i]);
            }
        }
        #endregion
        #region brands view in cmb
        public void brandlist()
        {
            mylist.Clear();
            //string name="";
            //DirectoryInfo dir = new DirectoryInfo(brandpath);
            //FileInfo[] files = dir.GetFiles();
            //foreach (FileInfo file in files)
            //{
               // name = file.Name;
                if ("Fridge"==_product_item)
                {
                    string filepath = "E:\\Database\\billing\\brands\\Fridge.txt";
                    string[] data = File.ReadAllLines(filepath);
                    foreach (string item in data)
                    {
                        string[] val = item.Split(',');
                        mylist.Add(val[0]);
                        mydict.Add(val[0],val);
                    }
                }
                else if ("TV" == _product_item)
                {
                    string filepath = "E:\\Database\\billing\\brands\\TV.txt";
                    string[] data = File.ReadAllLines(filepath);
                    foreach (string item in data)
                    {
                        string[] val = item.Split(',');
                        mylist.Add(val[0]);
                        mydict.Add(val[0], val);

                    }
                }
                else if ("Washing machine" == _product_item)
                {
                    string filepath = "E:\\Database\\billing\\brands\\Washing machine.txt";
                    string[] data = File.ReadAllLines(filepath);
                    foreach (string item in data)
                    {
                        string[] val = item.Split(',');
                        mylist.Add(val[0]);
                        mydict.Add(val[0], val);

                    }
                }
                else if ("Grinder" == _product_item)
                {
                    string filepath = "E:\\Database\\billing\\brands\\Grinder.txt";
                    string[] data = File.ReadAllLines(filepath);
                    foreach (string item in data)
                    {
                        string[] val = item.Split(',');
                        mylist.Add(val[0]);
                        mydict.Add(val[0], val);

                    }
                }
                else if ("Ironbox" == _product_item)
                {
                    string filepath = "E:\\Database\\billing\\brands\\Ironbox.txt";
                    string[] data = File.ReadAllLines(filepath);
                    foreach (string item in data)
                    {
                        string[] val = item.Split(',');
                        mylist.Add(val[0]);
                        mydict.Add(val[0], val);

                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("please select product brand",_brand_name,System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Information);
                }
            //}
        }
        #endregion
        #region product price view
        public void productprice()
        {
           
                foreach (string[] item in mydict.Values)
                {
                    if(item[0]==_brand_name)
                    {
                    product_price =item[1];
                     gst_percent = Convert.ToInt32(item[2]);
                    _cgst =(Convert.ToInt32( _product_price) * gst_percent / 100)/2;
                    _sgst = _cgst;
                    }
                }
            
        }
        #endregion
        #region total
        public void totalcalc()
        {
            total =Convert.ToInt32( _product_price) *Convert.ToInt32 (_quantity);
            total = _total +Convert.ToInt32( _cgst) +Convert.ToInt32( _sgst);
        }
        #endregion
        #region discount amount
        public decimal discountcalc()
        {
            int tot = _total * Convert.ToInt32(_discount) / 100;
             _total = _total - tot;
             return _total;
        }
        #endregion

        #region add btn
        public void addindict()
        {
            string details="";
            details =  _product_item + "," + _brand_name + "," + _product_price + ","+_quantity+","+ _cgst + "," + _sgst + "," + (gst_percent/2) + "," + _discount + "," + total;
            string[] det = details.Split(',');
            mylist.Clear();
            foreach (string item in det)
            {
                mylist.Add(item);
            }
        }
        #endregion

        #region bill btn
        public void billview()
        {
            
        }
        #endregion


        #region getset
        public string product_item
        {
            //get
            //{
            //    return _product_item;
            //}
            set
            {
                _product_item = value;
            }
        }
        public string brand_name
        {
            //get
            //{
            //    return _brand_name;
            //}
            set
            {
                _brand_name=value;
            }
        }
        public string product_price
        {
            get
            {
                return _product_price;
            }
            set
            {
                _product_price = value;
            }
        }
        public decimal quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }
        public double cgst
        {
            get
            {
                return _cgst;
            }
            set
            {
                _cgst = value;
            }
        }
        public double sgst
        {
            get
            {
                return _sgst;
            }
            set
            {
                _sgst = value;
            }
        }
        public int total
        {
            get
            {
                return _total;
            }
            set
            {
                _total = value;
            }
        }
        public decimal discount
        {
            get
            {
                return _discount;
            }
            set
            {
                _discount = value;
            }
        }
        #endregion

    }
}
