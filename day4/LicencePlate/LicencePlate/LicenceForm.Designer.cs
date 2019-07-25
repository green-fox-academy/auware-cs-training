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
            this.components = new System.ComponentModel.Container();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtLicencePlate = new System.Windows.Forms.TextBox();
            this.lblLicencePlateIsValid = new System.Windows.Forms.Label();
            this.lbLicences = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.licencesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.licencesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(25, 48);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // txtLicencePlate
            // 
            this.txtLicencePlate.Location = new System.Drawing.Point(12, 22);
            this.txtLicencePlate.Name = "txtLicencePlate";
            this.txtLicencePlate.Size = new System.Drawing.Size(100, 20);
            this.txtLicencePlate.TabIndex = 1;
            // 
            // lblLicencePlateIsValid
            // 
            this.lblLicencePlateIsValid.AutoSize = true;
            this.lblLicencePlateIsValid.ForeColor = System.Drawing.Color.Red;
            this.lblLicencePlateIsValid.Location = new System.Drawing.Point(41, 85);
            this.lblLicencePlateIsValid.Name = "lblLicencePlateIsValid";
            this.lblLicencePlateIsValid.Size = new System.Drawing.Size(37, 13);
            this.lblLicencePlateIsValid.TabIndex = 2;
            this.lblLicencePlateIsValid.Text = "invalid";
            // 
            // lbLicences
            // 
            this.lbLicences.DataSource = this.licencesBindingSource;
            this.lbLicences.FormattingEnabled = true;
            this.lbLicences.Location = new System.Drawing.Point(382, 48);
            this.lbLicences.Name = "lbLicences";
            this.lbLicences.Size = new System.Drawing.Size(120, 95);
            this.lbLicences.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 149);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(402, 160);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // LicenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 259);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbLicences);
            this.Controls.Add(this.lblLicencePlateIsValid);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtLicencePlate);
            this.Name = "LicenceForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.licencesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtLicencePlate;
        private System.Windows.Forms.Label lblLicencePlateIsValid;
        private System.Windows.Forms.ListBox lbLicences;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.BindingSource licencesBindingSource;
    }
}

