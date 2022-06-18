namespace billing_application
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.topicnamelbl = new System.Windows.Forms.Label();
            this.cust_name_lbl = new System.Windows.Forms.Label();
            this.cont_num_lbl = new System.Windows.Forms.Label();
            this.prod_item_lbl = new System.Windows.Forms.Label();
            this.prod_price_lbl = new System.Windows.Forms.Label();
            this.quantity_lbl = new System.Windows.Forms.Label();
            this.total_lbl = new System.Windows.Forms.Label();
            this.cust_name_tb = new System.Windows.Forms.TextBox();
            this.cont_num_tb = new System.Windows.Forms.TextBox();
            this.prod_item_cmb = new System.Windows.Forms.ComboBox();
            this.Quantity_nud = new System.Windows.Forms.NumericUpDown();
            this.total_tb = new System.Windows.Forms.TextBox();
            this.brand_name_lbl = new System.Windows.Forms.Label();
            this.brand_cmb = new System.Windows.Forms.ComboBox();
            this.cgst_lbl = new System.Windows.Forms.Label();
            this.cgst_tb = new System.Windows.Forms.TextBox();
            this.sgst_lbl = new System.Windows.Forms.Label();
            this.sgst_tb = new System.Windows.Forms.TextBox();
            this.discount_lbl = new System.Windows.Forms.Label();
            this.discount_nud = new System.Windows.Forms.NumericUpDown();
            this.add_btn = new System.Windows.Forms.Button();
            this.bill_btn = new System.Windows.Forms.Button();
            this.clr_btn = new System.Windows.Forms.Button();
            this.bill_lb = new System.Windows.Forms.ListBox();
            this.prod_price_tb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discount_nud)).BeginInit();
            this.SuspendLayout();
            // 
            // topicnamelbl
            // 
            this.topicnamelbl.AutoSize = true;
            this.topicnamelbl.BackColor = System.Drawing.SystemColors.Control;
            this.topicnamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topicnamelbl.Location = new System.Drawing.Point(486, 66);
            this.topicnamelbl.Name = "topicnamelbl";
            this.topicnamelbl.Size = new System.Drawing.Size(362, 26);
            this.topicnamelbl.TabIndex = 0;
            this.topicnamelbl.Text = "Razin Electricals and Electronics";
            // 
            // cust_name_lbl
            // 
            this.cust_name_lbl.AutoSize = true;
            this.cust_name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_name_lbl.Location = new System.Drawing.Point(255, 119);
            this.cust_name_lbl.Name = "cust_name_lbl";
            this.cust_name_lbl.Size = new System.Drawing.Size(124, 20);
            this.cust_name_lbl.TabIndex = 1;
            this.cust_name_lbl.Text = "Customer Name";
            // 
            // cont_num_lbl
            // 
            this.cont_num_lbl.AutoSize = true;
            this.cont_num_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cont_num_lbl.Location = new System.Drawing.Point(255, 148);
            this.cont_num_lbl.Name = "cont_num_lbl";
            this.cont_num_lbl.Size = new System.Drawing.Size(125, 20);
            this.cont_num_lbl.TabIndex = 2;
            this.cont_num_lbl.Text = "Contact Number";
            // 
            // prod_item_lbl
            // 
            this.prod_item_lbl.AutoSize = true;
            this.prod_item_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prod_item_lbl.Location = new System.Drawing.Point(255, 177);
            this.prod_item_lbl.Name = "prod_item_lbl";
            this.prod_item_lbl.Size = new System.Drawing.Size(108, 20);
            this.prod_item_lbl.TabIndex = 3;
            this.prod_item_lbl.Text = "Product Items";
            // 
            // prod_price_lbl
            // 
            this.prod_price_lbl.AutoSize = true;
            this.prod_price_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prod_price_lbl.Location = new System.Drawing.Point(255, 206);
            this.prod_price_lbl.Name = "prod_price_lbl";
            this.prod_price_lbl.Size = new System.Drawing.Size(102, 20);
            this.prod_price_lbl.TabIndex = 4;
            this.prod_price_lbl.Text = "Product price";
            // 
            // quantity_lbl
            // 
            this.quantity_lbl.AutoSize = true;
            this.quantity_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_lbl.Location = new System.Drawing.Point(255, 235);
            this.quantity_lbl.Name = "quantity_lbl";
            this.quantity_lbl.Size = new System.Drawing.Size(68, 20);
            this.quantity_lbl.TabIndex = 5;
            this.quantity_lbl.Text = "Quantity";
            // 
            // total_lbl
            // 
            this.total_lbl.AutoSize = true;
            this.total_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_lbl.Location = new System.Drawing.Point(255, 264);
            this.total_lbl.Name = "total_lbl";
            this.total_lbl.Size = new System.Drawing.Size(44, 20);
            this.total_lbl.TabIndex = 6;
            this.total_lbl.Text = "Total";
            // 
            // cust_name_tb
            // 
            this.cust_name_tb.Location = new System.Drawing.Point(406, 119);
            this.cust_name_tb.Name = "cust_name_tb";
            this.cust_name_tb.Size = new System.Drawing.Size(121, 20);
            this.cust_name_tb.TabIndex = 7;
            // 
            // cont_num_tb
            // 
            this.cont_num_tb.Location = new System.Drawing.Point(406, 147);
            this.cont_num_tb.Name = "cont_num_tb";
            this.cont_num_tb.Size = new System.Drawing.Size(121, 20);
            this.cont_num_tb.TabIndex = 8;
            // 
            // prod_item_cmb
            // 
            this.prod_item_cmb.FormattingEnabled = true;
            this.prod_item_cmb.Location = new System.Drawing.Point(406, 175);
            this.prod_item_cmb.Name = "prod_item_cmb";
            this.prod_item_cmb.Size = new System.Drawing.Size(121, 21);
            this.prod_item_cmb.TabIndex = 9;
            this.prod_item_cmb.SelectedIndexChanged += new System.EventHandler(this.prod_item_cmb_SelectedIndexChanged);
            // 
            // Quantity_nud
            // 
            this.Quantity_nud.Location = new System.Drawing.Point(406, 233);
            this.Quantity_nud.Name = "Quantity_nud";
            this.Quantity_nud.Size = new System.Drawing.Size(121, 20);
            this.Quantity_nud.TabIndex = 11;
            this.Quantity_nud.ValueChanged += new System.EventHandler(this.Quantity_nud_ValueChanged);
            // 
            // total_tb
            // 
            this.total_tb.Location = new System.Drawing.Point(406, 261);
            this.total_tb.Name = "total_tb";
            this.total_tb.Size = new System.Drawing.Size(121, 20);
            this.total_tb.TabIndex = 12;
            // 
            // brand_name_lbl
            // 
            this.brand_name_lbl.AutoSize = true;
            this.brand_name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brand_name_lbl.Location = new System.Drawing.Point(546, 177);
            this.brand_name_lbl.Name = "brand_name_lbl";
            this.brand_name_lbl.Size = new System.Drawing.Size(52, 20);
            this.brand_name_lbl.TabIndex = 13;
            this.brand_name_lbl.Text = "Brand";
            // 
            // brand_cmb
            // 
            this.brand_cmb.FormattingEnabled = true;
            this.brand_cmb.Location = new System.Drawing.Point(602, 175);
            this.brand_cmb.Name = "brand_cmb";
            this.brand_cmb.Size = new System.Drawing.Size(121, 21);
            this.brand_cmb.TabIndex = 14;
            this.brand_cmb.SelectedIndexChanged += new System.EventHandler(this.brand_cmb_SelectedIndexChanged);
            // 
            // cgst_lbl
            // 
            this.cgst_lbl.AutoSize = true;
            this.cgst_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cgst_lbl.Location = new System.Drawing.Point(550, 205);
            this.cgst_lbl.Name = "cgst_lbl";
            this.cgst_lbl.Size = new System.Drawing.Size(39, 15);
            this.cgst_lbl.TabIndex = 15;
            this.cgst_lbl.Text = "CGST";
            // 
            // cgst_tb
            // 
            this.cgst_tb.Location = new System.Drawing.Point(602, 205);
            this.cgst_tb.Name = "cgst_tb";
            this.cgst_tb.Size = new System.Drawing.Size(57, 20);
            this.cgst_tb.TabIndex = 16;
            // 
            // sgst_lbl
            // 
            this.sgst_lbl.AutoSize = true;
            this.sgst_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sgst_lbl.Location = new System.Drawing.Point(552, 234);
            this.sgst_lbl.Name = "sgst_lbl";
            this.sgst_lbl.Size = new System.Drawing.Size(39, 15);
            this.sgst_lbl.TabIndex = 17;
            this.sgst_lbl.Text = "SGST";
            // 
            // sgst_tb
            // 
            this.sgst_tb.Location = new System.Drawing.Point(601, 234);
            this.sgst_tb.Name = "sgst_tb";
            this.sgst_tb.Size = new System.Drawing.Size(57, 20);
            this.sgst_tb.TabIndex = 18;
            // 
            // discount_lbl
            // 
            this.discount_lbl.AutoSize = true;
            this.discount_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount_lbl.Location = new System.Drawing.Point(544, 261);
            this.discount_lbl.Name = "discount_lbl";
            this.discount_lbl.Size = new System.Drawing.Size(72, 20);
            this.discount_lbl.TabIndex = 19;
            this.discount_lbl.Text = "Discount";
            // 
            // discount_nud
            // 
            this.discount_nud.Location = new System.Drawing.Point(622, 261);
            this.discount_nud.Name = "discount_nud";
            this.discount_nud.Size = new System.Drawing.Size(101, 20);
            this.discount_nud.TabIndex = 20;
            this.discount_nud.ValueChanged += new System.EventHandler(this.discount_nud_ValueChanged);
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(875, 144);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 21;
            this.add_btn.Text = "ADD";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // bill_btn
            // 
            this.bill_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_btn.Location = new System.Drawing.Point(875, 188);
            this.bill_btn.Name = "bill_btn";
            this.bill_btn.Size = new System.Drawing.Size(75, 23);
            this.bill_btn.TabIndex = 22;
            this.bill_btn.Text = "BILL";
            this.bill_btn.UseVisualStyleBackColor = true;
            this.bill_btn.Click += new System.EventHandler(this.bill_btn_Click);
            // 
            // clr_btn
            // 
            this.clr_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clr_btn.Location = new System.Drawing.Point(875, 232);
            this.clr_btn.Name = "clr_btn";
            this.clr_btn.Size = new System.Drawing.Size(75, 23);
            this.clr_btn.TabIndex = 23;
            this.clr_btn.Text = "Clear";
            this.clr_btn.UseVisualStyleBackColor = true;
            this.clr_btn.Click += new System.EventHandler(this.clr_btn_Click);
            // 
            // bill_lb
            // 
            this.bill_lb.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bill_lb.FormattingEnabled = true;
            this.bill_lb.Location = new System.Drawing.Point(215, 301);
            this.bill_lb.Name = "bill_lb";
            this.bill_lb.Size = new System.Drawing.Size(847, 394);
            this.bill_lb.TabIndex = 24;
            // 
            // prod_price_tb
            // 
            this.prod_price_tb.Location = new System.Drawing.Point(406, 205);
            this.prod_price_tb.Name = "prod_price_tb";
            this.prod_price_tb.Size = new System.Drawing.Size(121, 20);
            this.prod_price_tb.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1251, 516);
            this.Controls.Add(this.prod_price_tb);
            this.Controls.Add(this.bill_lb);
            this.Controls.Add(this.clr_btn);
            this.Controls.Add(this.bill_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.discount_nud);
            this.Controls.Add(this.discount_lbl);
            this.Controls.Add(this.sgst_tb);
            this.Controls.Add(this.sgst_lbl);
            this.Controls.Add(this.cgst_tb);
            this.Controls.Add(this.cgst_lbl);
            this.Controls.Add(this.brand_cmb);
            this.Controls.Add(this.brand_name_lbl);
            this.Controls.Add(this.total_tb);
            this.Controls.Add(this.Quantity_nud);
            this.Controls.Add(this.prod_item_cmb);
            this.Controls.Add(this.cont_num_tb);
            this.Controls.Add(this.cust_name_tb);
            this.Controls.Add(this.total_lbl);
            this.Controls.Add(this.quantity_lbl);
            this.Controls.Add(this.prod_price_lbl);
            this.Controls.Add(this.prod_item_lbl);
            this.Controls.Add(this.cont_num_lbl);
            this.Controls.Add(this.cust_name_lbl);
            this.Controls.Add(this.topicnamelbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Quantity_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discount_nud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topicnamelbl;
        private System.Windows.Forms.Label cust_name_lbl;
        private System.Windows.Forms.Label cont_num_lbl;
        private System.Windows.Forms.Label prod_item_lbl;
        private System.Windows.Forms.Label prod_price_lbl;
        private System.Windows.Forms.Label quantity_lbl;
        private System.Windows.Forms.Label total_lbl;
        private System.Windows.Forms.TextBox cust_name_tb;
        private System.Windows.Forms.TextBox cont_num_tb;
        private System.Windows.Forms.ComboBox prod_item_cmb;
        private System.Windows.Forms.NumericUpDown Quantity_nud;
        private System.Windows.Forms.TextBox total_tb;
        private System.Windows.Forms.Label brand_name_lbl;
        private System.Windows.Forms.ComboBox brand_cmb;
        private System.Windows.Forms.Label cgst_lbl;
        private System.Windows.Forms.TextBox cgst_tb;
        private System.Windows.Forms.Label sgst_lbl;
        private System.Windows.Forms.TextBox sgst_tb;
        private System.Windows.Forms.Label discount_lbl;
        private System.Windows.Forms.NumericUpDown discount_nud;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button bill_btn;
        private System.Windows.Forms.Button clr_btn;
        private System.Windows.Forms.ListBox bill_lb;
        private System.Windows.Forms.TextBox prod_price_tb;
    }
}

