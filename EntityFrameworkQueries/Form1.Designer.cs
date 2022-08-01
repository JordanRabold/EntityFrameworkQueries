namespace EntityFrameworkQueries
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelectQuery = new System.Windows.Forms.Button();
            this.btnWhereQuery = new System.Windows.Forms.Button();
            this.btnSelectSpecificColumns = new System.Windows.Forms.Button();
            this.btnMiscQueries = new System.Windows.Forms.Button();
            this.btnVendorsAndInvoices = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelectQuery
            // 
            this.btnSelectQuery.Location = new System.Drawing.Point(27, 53);
            this.btnSelectQuery.Name = "btnSelectQuery";
            this.btnSelectQuery.Size = new System.Drawing.Size(184, 29);
            this.btnSelectQuery.TabIndex = 0;
            this.btnSelectQuery.Text = "SELECT * FROM Vendors";
            this.btnSelectQuery.UseVisualStyleBackColor = true;
            this.btnSelectQuery.Click += new System.EventHandler(this.btnSelectAllVendors_Click);
            // 
            // btnWhereQuery
            // 
            this.btnWhereQuery.Location = new System.Drawing.Point(27, 121);
            this.btnWhereQuery.Name = "btnWhereQuery";
            this.btnWhereQuery.Size = new System.Drawing.Size(556, 29);
            this.btnWhereQuery.TabIndex = 1;
            this.btnWhereQuery.Text = "SELECT * FROM Vendors WHERE VendorState=\"CA\" ORDER BY VendorName ASC";
            this.btnWhereQuery.UseVisualStyleBackColor = true;
            this.btnWhereQuery.Click += new System.EventHandler(this.btnWhereQuery_Click);
            // 
            // btnSelectSpecificColumns
            // 
            this.btnSelectSpecificColumns.Location = new System.Drawing.Point(27, 191);
            this.btnSelectSpecificColumns.Name = "btnSelectSpecificColumns";
            this.btnSelectSpecificColumns.Size = new System.Drawing.Size(431, 29);
            this.btnSelectSpecificColumns.TabIndex = 2;
            this.btnSelectSpecificColumns.Text = "SELECT VendorName, VendorCity, VendorState FROM Vendors";
            this.btnSelectSpecificColumns.UseVisualStyleBackColor = true;
            this.btnSelectSpecificColumns.Click += new System.EventHandler(this.btnSelectSpecificColumns_Click);
            // 
            // btnMiscQueries
            // 
            this.btnMiscQueries.Location = new System.Drawing.Point(27, 257);
            this.btnMiscQueries.Name = "btnMiscQueries";
            this.btnMiscQueries.Size = new System.Drawing.Size(106, 29);
            this.btnMiscQueries.TabIndex = 3;
            this.btnMiscQueries.Text = "Misc.Queries";
            this.btnMiscQueries.UseVisualStyleBackColor = true;
            this.btnMiscQueries.Click += new System.EventHandler(this.btnMiscQueries_Click);
            // 
            // btnVendorsAndInvoices
            // 
            this.btnVendorsAndInvoices.Location = new System.Drawing.Point(29, 325);
            this.btnVendorsAndInvoices.Name = "btnVendorsAndInvoices";
            this.btnVendorsAndInvoices.Size = new System.Drawing.Size(276, 29);
            this.btnVendorsAndInvoices.TabIndex = 4;
            this.btnVendorsAndInvoices.Text = "SELECT All Vendors with their invoices";
            this.btnVendorsAndInvoices.UseVisualStyleBackColor = true;
            this.btnVendorsAndInvoices.Click += new System.EventHandler(this.btnVendorsAndInvoices_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVendorsAndInvoices);
            this.Controls.Add(this.btnMiscQueries);
            this.Controls.Add(this.btnSelectSpecificColumns);
            this.Controls.Add(this.btnWhereQuery);
            this.Controls.Add(this.btnSelectQuery);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSelectQuery;
        private Button btnWhereQuery;
        private Button btnSelectSpecificColumns;
        private Button btnMiscQueries;
        private Button btnVendorsAndInvoices;
    }
}