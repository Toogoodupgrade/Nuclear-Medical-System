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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.leftsidebarControl = new Home.SidebarControl();
            this.headerControl = new Home.HeaderControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(301, 290);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1535, 651);
            this.dataGridView1.TabIndex = 0;
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
            // Rad_Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1021);
            this.Controls.Add(this.leftsidebarControl);
            this.Controls.Add(this.headerControl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Rad_Result";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rad_Result";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Rad_Result_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private SidebarControl leftsidebarControl;
        private HeaderControl headerControl;
    }
}