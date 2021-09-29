
namespace temperature_message
{
    partial class FrmUser
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
            this.btnOKFormUser = new System.Windows.Forms.Button();
            this.btnCancelFormUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOKFormUser
            // 
            this.btnOKFormUser.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOKFormUser.Location = new System.Drawing.Point(59, 140);
            this.btnOKFormUser.Name = "btnOKFormUser";
            this.btnOKFormUser.Size = new System.Drawing.Size(128, 49);
            this.btnOKFormUser.TabIndex = 0;
            this.btnOKFormUser.Text = "&OK Form User";
            this.btnOKFormUser.UseVisualStyleBackColor = true;
            // 
            // btnCancelFormUser
            // 
            this.btnCancelFormUser.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelFormUser.Location = new System.Drawing.Point(248, 136);
            this.btnCancelFormUser.Name = "btnCancelFormUser";
            this.btnCancelFormUser.Size = new System.Drawing.Size(142, 52);
            this.btnCancelFormUser.TabIndex = 1;
            this.btnCancelFormUser.Text = "&Cancel From User";
            this.btnCancelFormUser.UseVisualStyleBackColor = true;
            // 
            // FrmUser
            // 
            this.AcceptButton = this.btnOKFormUser;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelFormUser;
            this.ClientSize = new System.Drawing.Size(431, 261);
            this.Controls.Add(this.btnCancelFormUser);
            this.Controls.Add(this.btnOKFormUser);
            this.Name = "FrmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extra Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOKFormUser;
        private System.Windows.Forms.Button btnCancelFormUser;
    }
}