namespace LicencePlate
{
    partial class LicenceForm
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
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtLicencePlate = new System.Windows.Forms.TextBox();
            this.lblLicencePlateIsValid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(50, 53);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // txtLicencePlate
            // 
            this.txtLicencePlate.Location = new System.Drawing.Point(50, 27);
            this.txtLicencePlate.Name = "txtLicencePlate";
            this.txtLicencePlate.Size = new System.Drawing.Size(100, 20);
            this.txtLicencePlate.TabIndex = 1;
            // 
            // lblLicencePlateIsValid
            // 
            this.lblLicencePlateIsValid.AutoSize = true;
            this.lblLicencePlateIsValid.ForeColor = System.Drawing.Color.Red;
            this.lblLicencePlateIsValid.Location = new System.Drawing.Point(50, 102);
            this.lblLicencePlateIsValid.Name = "lblLicencePlateIsValid";
            this.lblLicencePlateIsValid.Size = new System.Drawing.Size(37, 13);
            this.lblLicencePlateIsValid.TabIndex = 2;
            this.lblLicencePlateIsValid.Text = "invalid";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 143);
            this.Controls.Add(this.lblLicencePlateIsValid);
            this.Controls.Add(this.txtLicencePlate);
            this.Controls.Add(this.btnCheck);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtLicencePlate;
        private System.Windows.Forms.Label lblLicencePlateIsValid;
    }
}

