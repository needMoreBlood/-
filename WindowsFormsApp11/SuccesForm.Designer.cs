namespace Interfaces
{
    partial class SuccesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuccesForm));
            this.AcceptButton = new System.Windows.Forms.PictureBox();
            this.Massage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AcceptButton)).BeginInit();
            this.SuspendLayout();
            // 
            // AcceptButton
            // 
            this.AcceptButton.BackColor = System.Drawing.Color.Transparent;
            this.AcceptButton.Image = ((System.Drawing.Image)(resources.GetObject("AcceptButton.Image")));
            this.AcceptButton.Location = new System.Drawing.Point(152, 150);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(40, 40);
            this.AcceptButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AcceptButton.TabIndex = 18;
            this.AcceptButton.TabStop = false;
            // 
            // Massage
            // 
            this.Massage.AutoSize = true;
            this.Massage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Massage.Location = new System.Drawing.Point(51, 80);
            this.Massage.Name = "Massage";
            this.Massage.Size = new System.Drawing.Size(0, 24);
            this.Massage.TabIndex = 19;
            // 
            // SuccesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(343, 202);
            this.Controls.Add(this.Massage);
            this.Controls.Add(this.AcceptButton);
            this.Name = "SuccesForm";
            this.Text = "SuccesForm";
            ((System.ComponentModel.ISupportInitialize)(this.AcceptButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox AcceptButton;
        private System.Windows.Forms.Label Massage;
    }
}