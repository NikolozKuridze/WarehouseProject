namespace WareHouse.App
{
  partial class MainForm
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
            this.btncategories = new System.Windows.Forms.Button();
            this.btnproducts = new System.Windows.Forms.Button();
            this.btnemployees = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncategories
            // 
            this.btncategories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncategories.Location = new System.Drawing.Point(35, 68);
            this.btncategories.Name = "btncategories";
            this.btncategories.Size = new System.Drawing.Size(101, 26);
            this.btncategories.TabIndex = 0;
            this.btncategories.Text = "Categories";
            this.btncategories.UseVisualStyleBackColor = true;
            this.btncategories.Click += new System.EventHandler(this.btnInsertcategory_Click);
            // 
            // btnproducts
            // 
            this.btnproducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnproducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproducts.Location = new System.Drawing.Point(35, 107);
            this.btnproducts.Name = "btnproducts";
            this.btnproducts.Size = new System.Drawing.Size(101, 26);
            this.btnproducts.TabIndex = 3;
            this.btnproducts.Text = "Products";
            this.btnproducts.UseVisualStyleBackColor = true;
            this.btnproducts.Click += new System.EventHandler(this.btnInsertproduct_Click);
            // 
            // btnemployees
            // 
            this.btnemployees.Location = new System.Drawing.Point(35, 27);
            this.btnemployees.Name = "btnemployees";
            this.btnemployees.Size = new System.Drawing.Size(101, 23);
            this.btnemployees.TabIndex = 4;
            this.btnemployees.Text = "Employees";
            this.btnemployees.UseVisualStyleBackColor = true;
            this.btnemployees.Click += new System.EventHandler(this.btnInsertEmployees_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(172, 163);
            this.Controls.Add(this.btnemployees);
            this.Controls.Add(this.btnproducts);
            this.Controls.Add(this.btncategories);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Button btncategories;
        private System.Windows.Forms.Button btnproducts;
        private System.Windows.Forms.Button btnemployees;
    }
}

