
namespace GUI
{
    partial class frm_DsBenhNhan
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QLPMDataSet6 = new GUI.QLPMDataSet6();
            this.DSBenhNhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSBenhNhanTableAdapter = new GUI.QLPMDataSet6TableAdapters.DSBenhNhanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QLPMDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSBenhNhanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.DocumentMapWidth = 49;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.DSBenhNhanBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.Report.rp_DSBenhNhan.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 426);
            this.reportViewer1.TabIndex = 0;
            // 
            // QLPMDataSet6
            // 
            this.QLPMDataSet6.DataSetName = "QLPMDataSet6";
            this.QLPMDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DSBenhNhanBindingSource
            // 
            this.DSBenhNhanBindingSource.DataMember = "DSBenhNhan";
            this.DSBenhNhanBindingSource.DataSource = this.QLPMDataSet6;
            // 
            // DSBenhNhanTableAdapter
            // 
            this.DSBenhNhanTableAdapter.ClearBeforeFill = true;
            // 
            // frm_DsBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_DsBenhNhan";
            this.Text = "Danh sách bệnh nhân";
            this.Load += new System.EventHandler(this.frm_DsBenhNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QLPMDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSBenhNhanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DSBenhNhanBindingSource;
        private QLPMDataSet6 QLPMDataSet6;
        private QLPMDataSet6TableAdapters.DSBenhNhanTableAdapter DSBenhNhanTableAdapter;
    }
}