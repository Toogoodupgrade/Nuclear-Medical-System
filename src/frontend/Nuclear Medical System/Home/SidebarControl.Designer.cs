namespace Home
{
    partial class SidebarControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_Logout = new System.Windows.Forms.Button();
            this.button_Result = new System.Windows.Forms.Button();
            this.button_Pending = new System.Windows.Forms.Button();
            this.button_Request = new System.Windows.Forms.Button();
            this.button_Patient = new System.Windows.Forms.Button();
            this.button_Home = new System.Windows.Forms.Button();
            this.panel_Profile = new System.Windows.Forms.Panel();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Department = new System.Windows.Forms.Label();
            this.panel_Menu.SuspendLayout();
            this.panel_Profile.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Menu
            // 
            this.panel_Menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Menu.Controls.Add(this.button_Exit);
            this.panel_Menu.Controls.Add(this.button_Logout);
            this.panel_Menu.Controls.Add(this.button_Result);
            this.panel_Menu.Controls.Add(this.button_Pending);
            this.panel_Menu.Controls.Add(this.button_Request);
            this.panel_Menu.Controls.Add(this.button_Patient);
            this.panel_Menu.Controls.Add(this.button_Home);
            this.panel_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_Menu.Location = new System.Drawing.Point(0, 99);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(200, 923);
            this.panel_Menu.TabIndex = 1;
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.Color.White;
            this.button_Exit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Exit.Image = global::Home.Properties.Resources.exit;
            this.button_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Exit.Location = new System.Drawing.Point(0, 845);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_Exit.Size = new System.Drawing.Size(200, 77);
            this.button_Exit.TabIndex = 1;
            this.button_Exit.Text = "Exit App";
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            this.button_Exit.MouseEnter += new System.EventHandler(this.button_Exit_MouseEnter);
            this.button_Exit.MouseLeave += new System.EventHandler(this.button_Exit_MouseLeave);
            // 
            // button_Logout
            // 
            this.button_Logout.BackColor = System.Drawing.Color.White;
            this.button_Logout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Logout.Image = global::Home.Properties.Resources.user_logout1;
            this.button_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Logout.Location = new System.Drawing.Point(0, 770);
            this.button_Logout.Name = "button_Logout";
            this.button_Logout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_Logout.Size = new System.Drawing.Size(200, 77);
            this.button_Logout.TabIndex = 1;
            this.button_Logout.Text = "Logout";
            this.button_Logout.UseVisualStyleBackColor = false;
            this.button_Logout.Click += new System.EventHandler(this.button_Logout_Click);
            this.button_Logout.MouseEnter += new System.EventHandler(this.button_Logout_MouseEnter);
            this.button_Logout.MouseLeave += new System.EventHandler(this.button_Logout_MouseLeave);
            // 
            // button_Result
            // 
            this.button_Result.BackColor = System.Drawing.Color.White;
            this.button_Result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Result.Image = global::Home.Properties.Resources.document;
            this.button_Result.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Result.Location = new System.Drawing.Point(0, 299);
            this.button_Result.Name = "button_Result";
            this.button_Result.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_Result.Size = new System.Drawing.Size(200, 77);
            this.button_Result.TabIndex = 1;
            this.button_Result.Text = "Result";
            this.button_Result.UseVisualStyleBackColor = false;
            this.button_Result.Click += new System.EventHandler(this.button_Result_Click);
            // 
            // button_Pending
            // 
            this.button_Pending.BackColor = System.Drawing.Color.White;
            this.button_Pending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Pending.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Pending.Image = global::Home.Properties.Resources.clock_three;
            this.button_Pending.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Pending.Location = new System.Drawing.Point(0, 224);
            this.button_Pending.Name = "button_Pending";
            this.button_Pending.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_Pending.Size = new System.Drawing.Size(200, 77);
            this.button_Pending.TabIndex = 1;
            this.button_Pending.Text = "Pending";
            this.button_Pending.UseVisualStyleBackColor = false;
            this.button_Pending.Click += new System.EventHandler(this.button_Pending_Click);
            // 
            // button_Request
            // 
            this.button_Request.BackColor = System.Drawing.Color.White;
            this.button_Request.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Request.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Request.Image = global::Home.Properties.Resources.file_edit;
            this.button_Request.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Request.Location = new System.Drawing.Point(0, 149);
            this.button_Request.Name = "button_Request";
            this.button_Request.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_Request.Size = new System.Drawing.Size(200, 77);
            this.button_Request.TabIndex = 1;
            this.button_Request.Text = "Request";
            this.button_Request.UseVisualStyleBackColor = false;
            this.button_Request.Click += new System.EventHandler(this.button_Request_Click);
            // 
            // button_Patient
            // 
            this.button_Patient.BackColor = System.Drawing.Color.White;
            this.button_Patient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Patient.Image = global::Home.Properties.Resources.patient;
            this.button_Patient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Patient.Location = new System.Drawing.Point(0, 74);
            this.button_Patient.Name = "button_Patient";
            this.button_Patient.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_Patient.Size = new System.Drawing.Size(200, 77);
            this.button_Patient.TabIndex = 1;
            this.button_Patient.Text = "Patient";
            this.button_Patient.UseVisualStyleBackColor = false;
            this.button_Patient.Click += new System.EventHandler(this.button_Patient_Click);
            // 
            // button_Home
            // 
            this.button_Home.BackColor = System.Drawing.Color.White;
            this.button_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Home.Image = global::Home.Properties.Resources.home;
            this.button_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Home.Location = new System.Drawing.Point(0, -1);
            this.button_Home.Name = "button_Home";
            this.button_Home.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_Home.Size = new System.Drawing.Size(200, 77);
            this.button_Home.TabIndex = 1;
            this.button_Home.Text = "Home";
            this.button_Home.UseVisualStyleBackColor = false;
            this.button_Home.Click += new System.EventHandler(this.button_Home_Click);
            // 
            // panel_Profile
            // 
            this.panel_Profile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Profile.Controls.Add(this.label_Name);
            this.panel_Profile.Controls.Add(this.label_Department);
            this.panel_Profile.Location = new System.Drawing.Point(0, 0);
            this.panel_Profile.Name = "panel_Profile";
            this.panel_Profile.Size = new System.Drawing.Size(200, 100);
            this.panel_Profile.TabIndex = 6;
            // 
            // label_Name
            // 
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(-1, 6);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(202, 52);
            this.label_Name.TabIndex = 3;
            this.label_Name.Text = "น.พ.สมชาย สมเกิด";
            this.label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Department
            // 
            this.label_Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Department.ForeColor = System.Drawing.Color.DimGray;
            this.label_Department.Location = new System.Drawing.Point(-1, 58);
            this.label_Department.Name = "label_Department";
            this.label_Department.Size = new System.Drawing.Size(200, 27);
            this.label_Department.TabIndex = 3;
            this.label_Department.Text = "เวชศาตร์นิวเคลียร์";
            this.label_Department.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SidebarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_Profile);
            this.Controls.Add(this.panel_Menu);
            this.Name = "SidebarControl";
            this.Size = new System.Drawing.Size(202, 1023);
            this.panel_Menu.ResumeLayout(false);
            this.panel_Profile.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Button button_Logout;
        private System.Windows.Forms.Button button_Result;
        private System.Windows.Forms.Button button_Pending;
        private System.Windows.Forms.Button button_Request;
        private System.Windows.Forms.Button button_Patient;
        private System.Windows.Forms.Button button_Home;
        private System.Windows.Forms.Panel panel_Profile;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Department;
        private System.Windows.Forms.Button button_Exit;
    }
}
