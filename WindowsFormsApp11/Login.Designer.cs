namespace Interfaces
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.PictureBox();
            this.AcceptButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CancelButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcceptButton)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginBox
            // 
            this.LoginBox.Location = new System.Drawing.Point(75, 40);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(170, 20);
            this.LoginBox.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Пароль";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(75, 97);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(170, 20);
            this.PasswordBox.TabIndex = 23;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Transparent;
            this.CancelButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelButton.Image")));
            this.CancelButton.Location = new System.Drawing.Point(175, 136);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(40, 40);
            this.CancelButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CancelButton.TabIndex = 18;
            this.CancelButton.TabStop = false;
            // 
            // AcceptButton
            // 
            this.AcceptButton.BackColor = System.Drawing.Color.Transparent;
            this.AcceptButton.Image = ((System.Drawing.Image)(resources.GetObject("AcceptButton.Image")));
            this.AcceptButton.Location = new System.Drawing.Point(95, 136);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(40, 40);
            this.AcceptButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AcceptButton.TabIndex = 17;
            this.AcceptButton.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 188);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AcceptButton);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.CancelButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcceptButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox AcceptButton;
        private System.Windows.Forms.PictureBox CancelButton;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordBox;
    }
}