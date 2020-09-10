namespace WareHouse.App.Dialogs
{
  partial class CategoryDetailsForm
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
      this.txtName = new System.Windows.Forms.TextBox();
      this.txtDescription = new System.Windows.Forms.TextBox();
      this.lblName = new System.Windows.Forms.Label();
      this.lblDescription = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnOk
      // 
      this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnOk.Location = new System.Drawing.Point(174, 79);
      this.btnOk.Name = "btnOk";
      this.btnOk.Size = new System.Drawing.Size(75, 23);
      this.btnOk.TabIndex = 0;
      this.btnOk.Text = "Ok";
      this.btnOk.UseVisualStyleBackColor = true;
      this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(255, 79);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 23);
      this.btnCancel.TabIndex = 1;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(103, 12);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(227, 20);
      this.txtName.TabIndex = 5;
      // 
      // txtDescription
      // 
      this.txtDescription.Location = new System.Drawing.Point(103, 44);
      this.txtDescription.Name = "txtDescription";
      this.txtDescription.Size = new System.Drawing.Size(227, 20);
      this.txtDescription.TabIndex = 6;
      // 
      // lblName
      // 
      this.lblName.AutoSize = true;
      this.lblName.Location = new System.Drawing.Point(19, 15);
      this.lblName.Name = "lblName";
      this.lblName.Size = new System.Drawing.Size(35, 13);
      this.lblName.TabIndex = 8;
      this.lblName.Text = "Name";
      // 
      // lblDescription
      // 
      this.lblDescription.AutoSize = true;
      this.lblDescription.Location = new System.Drawing.Point(19, 47);
      this.lblDescription.Name = "lblDescription";
      this.lblDescription.Size = new System.Drawing.Size(60, 13);
      this.lblDescription.TabIndex = 9;
      this.lblDescription.Text = "Description";
      // 
      // CategoryDetailsForm
      // 
      this.AcceptButton = this.btnOk;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(347, 114);
      this.Controls.Add(this.lblDescription);
      this.Controls.Add(this.lblName);
      this.Controls.Add(this.txtDescription);
      this.Controls.Add(this.txtName);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnOk);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "CategoryDetailsForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "CategoryDetailsForm";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnOk;
    private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
    }
}