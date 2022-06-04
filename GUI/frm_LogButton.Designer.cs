
namespace GUI
{
    partial class frm_LogButton
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
            this.txtLogButton = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtLogButton
            // 
            this.txtLogButton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtLogButton.Location = new System.Drawing.Point(12, 12);
            this.txtLogButton.Multiline = true;
            this.txtLogButton.Name = "txtLogButton";
            this.txtLogButton.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLogButton.Size = new System.Drawing.Size(1051, 578);
            this.txtLogButton.TabIndex = 1;
            // 
            // frm_LogButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1075, 602);
            this.Controls.Add(this.txtLogButton);
            this.Name = "frm_LogButton";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_LogButton";
            this.Load += new System.EventHandler(this.frm_LogButton_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogButton;
    }
}