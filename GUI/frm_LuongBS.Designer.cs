
namespace GUI
{
    partial class frm_LuongBS
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.LuongBSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLPMDataSet5 = new GUI.QLPMDataSet5();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LuongBSTableAdapter = new GUI.QLPMDataSet5TableAdapters.LuongBSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LuongBSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLPMDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // LuongBSBindingSource
            // 
            this.LuongBSBindingSource.DataMember = "LuongBS";
            this.LuongBSBindingSource.DataSource = this.QLPMDataSet5;
            // 
            // QLPMDataSet5
            // 
            this.QLPMDataSet5.DataSetName = "QLPMDataSet5";
            this.QLPMDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.LuongBSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.Report.rp_LuongBS.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1055, 552);
            this.reportViewer1.TabIndex = 0;
            // 
            // LuongBSTableAdapter
            // 
            this.LuongBSTableAdapter.ClearBeforeFill = true;
            // 
            // frm_LuongBS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1079, 576);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_LuongBS";
            this.Text = "Lương bác sĩ";
            this.Load += new System.EventHandler(this.frm_LuongBS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LuongBSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLPMDataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource LuongBSBindingSource;
        private QLPMDataSet5 QLPMDataSet5;
        private QLPMDataSet5TableAdapters.LuongBSTableAdapter LuongBSTableAdapter;
    }
}