namespace Home
{
    partial class Patient
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
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView_Pt = new System.Windows.Forms.DataGridView();
            this.leftsidebarControl = new Home.SidebarControl();
            this.headerControl = new Home.HeaderControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Pt)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(226, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 30);
            this.label9.TabIndex = 8;
            this.label9.Text = "รายชื่อคนไข้";
            // 
            // dataGridView_Pt
            // 
            this.dataGridView_Pt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Pt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Pt.Location = new System.Drawing.Point(293, 271);
            this.dataGridView_Pt.Name = "dataGridView_Pt";
            this.dataGridView_Pt.Size = new System.Drawing.Size(1522, 692);
            this.dataGridView_Pt.TabIndex = 9;
            // 
            // leftsidebarControl
            // 
            this.leftsidebarControl.Location = new System.Drawing.Point(0, 0);
            this.leftsidebarControl.Name = "leftsidebarControl";
            this.leftsidebarControl.Size = new System.Drawing.Size(202, 1023);
            this.leftsidebarControl.TabIndex = 10;
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
            this.headerControl.TabIndex = 11;
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1021);
            this.Controls.Add(this.leftsidebarControl);
            this.Controls.Add(this.headerControl);
            this.Controls.Add(this.dataGridView_Pt);
            this.Controls.Add(this.label9);
            this.MaximizeBox = false;
            this.Name = "Patient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Patient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Pt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView_Pt;
        private SidebarControl leftsidebarControl;
        private HeaderControl headerControl;
    }
}