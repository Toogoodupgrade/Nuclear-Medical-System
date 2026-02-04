namespace Home
{
    partial class Rad_Result
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
            this.dataGrid_Result = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.leftsidebarControl = new Home.SidebarControl();
            this.headerControl = new Home.HeaderControl();
            this.panel_Detail = new System.Windows.Forms.Panel();
            this.pictureBox_Result = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Result_Findings = new System.Windows.Forms.Label();
            this.label_Result_Impression = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Result)).BeginInit();
            this.panel_Detail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Result)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_Result
            // 
            this.dataGrid_Result.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Result.Location = new System.Drawing.Point(282, 262);
            this.dataGrid_Result.Name = "dataGrid_Result";
            this.dataGrid_Result.Size = new System.Drawing.Size(1110, 724);
            this.dataGrid_Result.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(226, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(391, 30);
            this.label9.TabIndex = 16;
            this.label9.Text = "Pending / Request จากโรงพยาบาลอื่น";
            // 
            // leftsidebarControl
            // 
            this.leftsidebarControl.Location = new System.Drawing.Point(0, 0);
            this.leftsidebarControl.Name = "leftsidebarControl";
            this.leftsidebarControl.Size = new System.Drawing.Size(202, 1023);
            this.leftsidebarControl.TabIndex = 17;
            // 
            // headerControl
            // 
            this.headerControl.HN = "\"";
            this.headerControl.Location = new System.Drawing.Point(199, 0);
            this.headerControl.Name = "headerControl";
            this.headerControl.pt_FName = "\"\"";
            this.headerControl.pt_Gender = "\"\"";
            this.headerControl.pt_Level = "\"\"";
            this.headerControl.pt_LName = "\"\"";
            this.headerControl.pt_Medical_Condition = "\"\"";
            this.headerControl.pt_Right = "\"\"";
            this.headerControl.pt_Tel = "\"\"";
            this.headerControl.Size = new System.Drawing.Size(1710, 198);
            this.headerControl.TabIndex = 18;
            // 
            // panel_Detail
            // 
            this.panel_Detail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Detail.Controls.Add(this.pictureBox_Result);
            this.panel_Detail.Controls.Add(this.label3);
            this.panel_Detail.Controls.Add(this.label1);
            this.panel_Detail.Controls.Add(this.label_Result_Findings);
            this.panel_Detail.Controls.Add(this.label_Result_Impression);
            this.panel_Detail.Location = new System.Drawing.Point(1412, 262);
            this.panel_Detail.Name = "panel_Detail";
            this.panel_Detail.Size = new System.Drawing.Size(431, 724);
            this.panel_Detail.TabIndex = 19;
            this.panel_Detail.Visible = false;
            // 
            // pictureBox_Result
            // 
            this.pictureBox_Result.Location = new System.Drawing.Point(13, 13);
            this.pictureBox_Result.Name = "pictureBox_Result";
            this.pictureBox_Result.Size = new System.Drawing.Size(402, 318);
            this.pictureBox_Result.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Result.TabIndex = 8;
            this.pictureBox_Result.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 528);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Impression";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Found";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Result_Findings
            // 
            this.label_Result_Findings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Result_Findings.Location = new System.Drawing.Point(34, 394);
            this.label_Result_Findings.Name = "label_Result_Findings";
            this.label_Result_Findings.Size = new System.Drawing.Size(361, 129);
            this.label_Result_Findings.TabIndex = 7;
            this.label_Result_Findings.Text = "-";
            // 
            // label_Result_Impression
            // 
            this.label_Result_Impression.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Result_Impression.Location = new System.Drawing.Point(30, 578);
            this.label_Result_Impression.Name = "label_Result_Impression";
            this.label_Result_Impression.Size = new System.Drawing.Size(361, 129);
            this.label_Result_Impression.TabIndex = 7;
            this.label_Result_Impression.Text = "-";
            // 
            // Rad_Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1021);
            this.Controls.Add(this.panel_Detail);
            this.Controls.Add(this.leftsidebarControl);
            this.Controls.Add(this.headerControl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGrid_Result);
            this.Name = "Rad_Result";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rad_Result";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Rad_Result_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Result)).EndInit();
            this.panel_Detail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Result)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_Result;
        private System.Windows.Forms.Label label9;
        private SidebarControl leftsidebarControl;
        private HeaderControl headerControl;
        private System.Windows.Forms.Panel panel_Detail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Result_Findings;
        private System.Windows.Forms.Label label_Result_Impression;
        private System.Windows.Forms.PictureBox pictureBox_Result;
    }
}