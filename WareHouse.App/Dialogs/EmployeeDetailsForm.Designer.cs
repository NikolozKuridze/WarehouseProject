namespace WareHouse.App.Dialogs
{
    partial class EmployeeDetailsForm
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.lbllastname = new System.Windows.Forms.Label();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.lblphone = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(130, 144);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(60, 25);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(211, 144);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(62, 25);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtfirstname
            // 
            this.txtfirstname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtfirstname.Location = new System.Drawing.Point(92, 17);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(181, 20);
            this.txtfirstname.TabIndex = 2;
            // 
            // lblfirstname
            // 
            this.lblfirstname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Location = new System.Drawing.Point(10, 20);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(54, 13);
            this.lblfirstname.TabIndex = 3;
            this.lblfirstname.Text = "FirstName";
            // 
            // lbllastname
            // 
            this.lbllastname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbllastname.AutoSize = true;
            this.lbllastname.Location = new System.Drawing.Point(10, 57);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(55, 13);
            this.lbllastname.TabIndex = 5;
            this.lbllastname.Text = "LastName";
            // 
            // txtlastname
            // 
            this.txtlastname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtlastname.Location = new System.Drawing.Point(92, 54);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(181, 20);
            this.txtlastname.TabIndex = 4;
            // 
            // lblphone
            // 
            this.lblphone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblphone.AutoSize = true;
            this.lblphone.Location = new System.Drawing.Point(10, 100);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(38, 13);
            this.lblphone.TabIndex = 7;
            this.lblphone.Text = "Phone";
            // 
            // txtphone
            // 
            this.txtphone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtphone.Location = new System.Drawing.Point(92, 97);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(181, 20);
            this.txtphone.TabIndex = 6;
            // 
            // EmployeeDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 191);
            this.Controls.Add(this.lblphone);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.lbllastname);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.lblfirstname);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "EmployeeDetailsForm";
            this.Text = "EmployeeDetailsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.TextBox txtphone;
    }
}