namespace Home
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label_Date = new System.Windows.Forms.Label();
            this.leftsidebarControl = new Home.SidebarControl();
            this.headerControl = new Home.HeaderControl();
            this.SuspendLayout();
            // 
            // label_Date
            // 
            this.label_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Date.Location = new System.Drawing.Point(226, 219);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(439, 30);
            this.label_Date.TabIndex = 7;
            this.label_Date.Text = "แผนกเวชศาสตร์นิวเคลียร์ - วันพฤหัสบดีที่ 1 มกราคม 2569";
            // 
            // leftsidebarControl
            // 
            this.leftsidebarControl.Location = new System.Drawing.Point(0, 0);
            this.leftsidebarControl.Name = "leftsidebarControl";
            this.leftsidebarControl.Size = new System.Drawing.Size(202, 1023);
            this.leftsidebarControl.TabIndex = 24;
            // 
            // headerControl
            // 
            this.headerControl.HN = "\"";
            this.headerControl.Location = new System.Drawing.Point(198, 0);
            this.headerControl.Name = "headerControl";
            this.headerControl.pt_FName = "\"\"";
            this.headerControl.pt_Gender = "\"\"";
            this.headerControl.pt_Level = "\"\"";
            this.headerControl.pt_LName = "\"\"";
            this.headerControl.pt_Medical_Condition = "\"\"";
            this.headerControl.pt_Right = "\"\"";
            this.headerControl.pt_Tel = "\"\"";
            this.headerControl.Size = new System.Drawing.Size(1710, 198);
            this.headerControl.TabIndex = 25;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1021);
            this.Controls.Add(this.leftsidebarControl);
            this.Controls.Add(this.headerControl);
            this.Controls.Add(this.label_Date);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "โรงพยาบาลมหาราชนครราชสีมา";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_Date;
        private SidebarControl leftsidebarControl;
        private HeaderControl headerControl;
    }
}

