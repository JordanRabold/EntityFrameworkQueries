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
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelectQuery
            // 
            this.btnSelectQuery.Location = new System.Drawing.Point(27, 53);
            this.btnSelectQuery.Name = "btnSelectQuery";
            this.btnSelectQuery.Size = new System.Drawing.Size(155, 29);
            this.btnSelectQuery.TabIndex = 0;
            this.btnSelectQuery.Text = "SELECT Query";
            this.btnSelectQuery.UseVisualStyleBackColor = true;
            this.btnSelectQuery.Click += new System.EventHandler(this.btnSelectAllVendors_Click);
            // 
            // btnWhereQuery
            // 
            this.btnWhereQuery.Location = new System.Drawing.Point(27, 121);
            this.btnWhereQuery.Name = "btnWhereQuery";
            this.btnWhereQuery.Size = new System.Drawing.Size(155, 29);
            this.btnWhereQuery.TabIndex = 1;
            this.btnWhereQuery.Text = "WHERE Query";
            this.btnWhereQuery.UseVisualStyleBackColor = true;
            this.btnWhereQuery.Click += new System.EventHandler(this.btnWhereQuery_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(27, 191);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnWhereQuery);
            this.Controls.Add(this.btnSelectQuery);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSelectQuery;
        private Button btnWhereQuery;
        private Button button3;
    }
}