
namespace GUI
{
    partial class frm_LogForm
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
            this.txtLogForm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtLogForm
            // 
            this.txtLogForm.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtLogForm.Location = new System.Drawing.Point(12, 12);
            this.txtLogForm.Multiline = true;
            this.txtLogForm.Name = "txtLogForm";
            this.txtLogForm.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLogForm.Size = new System.Drawing.Size(1006, 572);
            this.txtLogForm.TabIndex = 0;
            // 
            // frm_LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1030, 596);
            this.Controls.Add(this.txtLogForm);
            this.Name = "frm_LogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log form";
            this.Load += new System.EventHandler(this.frm_LogForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogForm;
    }
}