
namespace temperature_message
{
    partial class Frmtemperaturemessage
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
            this.txttemperature = new System.Windows.Forms.TextBox();
            this.btnCalcuate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnFormOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txttemperature
            // 
            this.txttemperature.Location = new System.Drawing.Point(111, 44);
            this.txttemperature.Name = "txttemperature";
            this.txttemperature.Size = new System.Drawing.Size(163, 23);
            this.txttemperature.TabIndex = 0;
            // 
            // btnCalcuate
            // 
            this.btnCalcuate.Location = new System.Drawing.Point(111, 89);
            this.btnCalcuate.Name = "btnCalcuate";
            this.btnCalcuate.Size = new System.Drawing.Size(162, 24);
            this.btnCalcuate.TabIndex = 1;
            this.btnCalcuate.Text = "Display Temperature";
            this.btnCalcuate.UseVisualStyleBackColor = true;
            this.btnCalcuate.Click += new System.EventHandler(this.btnCalcuate_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(111, 138);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 15);
            this.lblResult.TabIndex = 2;
            this.lblResult.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(238, 253);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 41);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(63, 253);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(99, 41);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnFormOpen
            // 
            this.btnFormOpen.Location = new System.Drawing.Point(111, 191);
            this.btnFormOpen.Name = "btnFormOpen";
            this.btnFormOpen.Size = new System.Drawing.Size(157, 28);
            this.btnFormOpen.TabIndex = 5;
            this.btnFormOpen.Text = "Open Form";
            this.btnFormOpen.UseVisualStyleBackColor = true;
            this.btnFormOpen.Click += new System.EventHandler(this.btnFormOpen_Click);
            // 
            // Frmtemperaturemessage
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(456, 439);
            this.Controls.Add(this.btnFormOpen);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalcuate);
            this.Controls.Add(this.txttemperature);
            this.KeyPreview = true;
            this.Name = "Frmtemperaturemessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temerature Message";
            this.Load += new System.EventHandler(this.Frmtemperaturemessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttemperature;
        private System.Windows.Forms.Button btnCalcuate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnFormOpen;
    }
}

