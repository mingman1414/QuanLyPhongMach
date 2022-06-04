namespace GUI
{
    partial class frm_DoanhThu
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
            this.ThongKeHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLPMDataSet3 = new GUI.QLPMDataSet3();
            this.dtDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtTuNgay = new System.Windows.Forms.DateTimePicker();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ThongKeHoaDonTableAdapter = new GUI.QLPMDataSet3TableAdapters.ThongKeHoaDonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ThongKeHoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLPMDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // ThongKeHoaDonBindingSource
            // 
            this.ThongKeHoaDonBindingSource.DataMember = "ThongKeHoaDon";
            this.ThongKeHoaDonBindingSource.DataSource = this.QLPMDataSet3;
            // 
            // QLPMDataSet3
            // 
            this.QLPMDataSet3.DataSetName = "QLPMDataSet3";
            this.QLPMDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtDenNgay
            // 
            this.dtDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDenNgay.Location = new System.Drawing.Point(574, 45);
            this.dtDenNgay.Name = "dtDenNgay";
            this.dtDenNgay.Size = new System.Drawing.Size(200, 22);
            this.dtDenNgay.TabIndex = 6;
            // 
            // dtTuNgay
            // 
            this.dtTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTuNgay.Location = new System.Drawing.Point(65, 45);
            this.dtTuNgay.Name = "dtTuNgay";
            this.dtTuNgay.Size = new System.Drawing.Size(200, 22);
            this.dtTuNgay.TabIndex = 5;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThongKe.Location = new System.Drawing.Point(331, 32);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(155, 52);
            this.btnThongKe.TabIndex = 4;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.DocumentMapWidth = 85;
            reportDataSource1.Name = "DoanhThu";
            reportDataSource1.Value = this.ThongKeHoaDonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.Report.rp_DoanhThu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 97);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(814, 408);
            this.reportViewer1.TabIndex = 7;
            // 
            // ThongKeHoaDonTableAdapter
            // 
            this.ThongKeHoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // frm_DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(838, 517);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.dtDenNgay);
            this.Controls.Add(this.dtTuNgay);
            this.Controls.Add(this.btnThongKe);
            this.Name = "frm_DoanhThu";
            this.Text = "Doanh thu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_DoanhThu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ThongKeHoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLPMDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtDenNgay;
        private System.Windows.Forms.DateTimePicker dtTuNgay;
        private System.Windows.Forms.Button btnThongKe;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ThongKeHoaDonBindingSource;
        private QLPMDataSet3 QLPMDataSet3;
        private QLPMDataSet3TableAdapters.ThongKeHoaDonTableAdapter ThongKeHoaDonTableAdapter;
    }
}