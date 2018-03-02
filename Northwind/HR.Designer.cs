namespace Northwind
{
    partial class HR
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
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_Orders = new System.Windows.Forms.Button();
            this.bt_OCount = new System.Windows.Forms.Button();
            this.bt_cCount = new System.Windows.Forms.Button();
            this.bt_Customers = new System.Windows.Forms.Button();
            this.bt_ECount = new System.Windows.Forms.Button();
            this.bt_Employees = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView6
            // 
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(2022, 89);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.RowTemplate.Height = 40;
            this.dataGridView6.Size = new System.Drawing.Size(325, 244);
            this.dataGridView6.TabIndex = 23;
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(1576, 89);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowTemplate.Height = 40;
            this.dataGridView5.Size = new System.Drawing.Size(381, 647);
            this.dataGridView5.TabIndex = 22;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(1219, 89);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 40;
            this.dataGridView4.Size = new System.Drawing.Size(325, 244);
            this.dataGridView4.TabIndex = 21;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(812, 89);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 40;
            this.dataGridView3.Size = new System.Drawing.Size(383, 647);
            this.dataGridView3.TabIndex = 20;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(450, 89);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 40;
            this.dataGridView2.Size = new System.Drawing.Size(325, 244);
            this.dataGridView2.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(387, 647);
            this.dataGridView1.TabIndex = 18;
            // 
            // bt_Orders
            // 
            this.bt_Orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Orders.Location = new System.Drawing.Point(1576, 764);
            this.bt_Orders.Name = "bt_Orders";
            this.bt_Orders.Size = new System.Drawing.Size(381, 62);
            this.bt_Orders.TabIndex = 17;
            this.bt_Orders.Text = "Orders";
            this.bt_Orders.UseVisualStyleBackColor = true;
            this.bt_Orders.Click += new System.EventHandler(this.bt_Orders_Click_1);
            // 
            // bt_OCount
            // 
            this.bt_OCount.Location = new System.Drawing.Point(2022, 339);
            this.bt_OCount.Name = "bt_OCount";
            this.bt_OCount.Size = new System.Drawing.Size(325, 91);
            this.bt_OCount.TabIndex = 16;
            this.bt_OCount.Text = "Number of Orders";
            this.bt_OCount.UseVisualStyleBackColor = true;
            this.bt_OCount.Click += new System.EventHandler(this.bt_OCount_Click_1);
            // 
            // bt_cCount
            // 
            this.bt_cCount.Location = new System.Drawing.Point(1219, 339);
            this.bt_cCount.Name = "bt_cCount";
            this.bt_cCount.Size = new System.Drawing.Size(325, 91);
            this.bt_cCount.TabIndex = 15;
            this.bt_cCount.Text = "Number of Customers";
            this.bt_cCount.UseVisualStyleBackColor = true;
            this.bt_cCount.Click += new System.EventHandler(this.bt_cCount_Click_1);
            // 
            // bt_Customers
            // 
            this.bt_Customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Customers.Location = new System.Drawing.Point(812, 764);
            this.bt_Customers.Name = "bt_Customers";
            this.bt_Customers.Size = new System.Drawing.Size(383, 61);
            this.bt_Customers.TabIndex = 14;
            this.bt_Customers.Text = "Customers";
            this.bt_Customers.UseVisualStyleBackColor = true;
            this.bt_Customers.Click += new System.EventHandler(this.bt_Sales_Click);
            // 
            // bt_ECount
            // 
            this.bt_ECount.Location = new System.Drawing.Point(450, 339);
            this.bt_ECount.Name = "bt_ECount";
            this.bt_ECount.Size = new System.Drawing.Size(325, 91);
            this.bt_ECount.TabIndex = 13;
            this.bt_ECount.Text = "Number of Employees";
            this.bt_ECount.UseVisualStyleBackColor = true;
            this.bt_ECount.Click += new System.EventHandler(this.bt_ECount_Click_1);
            // 
            // bt_Employees
            // 
            this.bt_Employees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Employees.Location = new System.Drawing.Point(40, 763);
            this.bt_Employees.Name = "bt_Employees";
            this.bt_Employees.Size = new System.Drawing.Size(387, 62);
            this.bt_Employees.TabIndex = 12;
            this.bt_Employees.Text = "Employees";
            this.bt_Employees.UseVisualStyleBackColor = true;
            this.bt_Employees.Click += new System.EventHandler(this.bt_Employees_Click_1);
            // 
            // HR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2507, 1024);
            this.Controls.Add(this.dataGridView6);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_Orders);
            this.Controls.Add(this.bt_OCount);
            this.Controls.Add(this.bt_cCount);
            this.Controls.Add(this.bt_Customers);
            this.Controls.Add(this.bt_ECount);
            this.Controls.Add(this.bt_Employees);
            this.Name = "HR";
            this.Text = "HR";
            this.Load += new System.EventHandler(this.HR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_Orders;
        private System.Windows.Forms.Button bt_OCount;
        private System.Windows.Forms.Button bt_cCount;
        private System.Windows.Forms.Button bt_Customers;
        private System.Windows.Forms.Button bt_ECount;
        private System.Windows.Forms.Button bt_Employees;
    }
}