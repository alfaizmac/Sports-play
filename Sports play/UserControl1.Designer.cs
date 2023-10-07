namespace Sports_play
{
    partial class UserControl1
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
            this.components = new System.ComponentModel.Container();
            this.screeningpanel = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.screen2ndpanel = new System.Windows.Forms.Panel();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.sidebartimer = new System.Windows.Forms.Timer(this.components);
            this.panelhome = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.LightMenuB = new System.Windows.Forms.Button();
            this.LightHomeB = new System.Windows.Forms.Button();
            this.LightSettingB = new System.Windows.Forms.Button();
            this.LightHelpB = new System.Windows.Forms.Button();
            this.LightAboutB = new System.Windows.Forms.Button();
            this.screeningpanel.SuspendLayout();
            this.screen2ndpanel.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelhome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // screeningpanel
            // 
            this.screeningpanel.BackColor = System.Drawing.Color.White;
            this.screeningpanel.Controls.Add(this.linkLabel1);
            this.screeningpanel.Location = new System.Drawing.Point(679, 164);
            this.screeningpanel.Name = "screeningpanel";
            this.screeningpanel.Size = new System.Drawing.Size(416, 275);
            this.screeningpanel.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(925, 993);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(202, 50);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Press enter";
            // 
            // screen2ndpanel
            // 
            this.screen2ndpanel.BackColor = System.Drawing.Color.Yellow;
            this.screen2ndpanel.Controls.Add(this.sidebar);
            this.screen2ndpanel.Controls.Add(this.panelhome);
            this.screen2ndpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screen2ndpanel.Location = new System.Drawing.Point(0, 0);
            this.screen2ndpanel.Name = "screen2ndpanel";
            this.screen2ndpanel.Size = new System.Drawing.Size(1920, 1080);
            this.screen2ndpanel.TabIndex = 1;
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.ForeColor = System.Drawing.Color.Coral;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(253, 1080);
            this.sidebar.MinimumSize = new System.Drawing.Size(83, 1080);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(253, 1080);
            this.sidebar.TabIndex = 0;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LightMenuB);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 92);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LightHomeB);
            this.panel2.Location = new System.Drawing.Point(3, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 67);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LightSettingB);
            this.panel3.Location = new System.Drawing.Point(3, 174);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 67);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.LightHelpB);
            this.panel4.Location = new System.Drawing.Point(3, 247);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 67);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.LightAboutB);
            this.panel5.Location = new System.Drawing.Point(3, 320);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 67);
            this.panel5.TabIndex = 4;
            // 
            // sidebartimer
            // 
            this.sidebartimer.Interval = 10;
            this.sidebartimer.Tick += new System.EventHandler(this.sidebartimer_Tick);
            // 
            // panelhome
            // 
            this.panelhome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panelhome.Controls.Add(this.pictureBox1);
            this.panelhome.Controls.Add(this.pictureBox3);
            this.panelhome.Controls.Add(this.panel6);
            this.panelhome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelhome.Location = new System.Drawing.Point(0, 0);
            this.panelhome.Name = "panelhome";
            this.panelhome.Size = new System.Drawing.Size(1920, 1080);
            this.panelhome.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Location = new System.Drawing.Point(578, 552);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(844, 398);
            this.panel6.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sports_play.Properties.Resources.arrow_left_circle__2_;
            this.pictureBox1.Location = new System.Drawing.Point(418, 702);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 98);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Sports_play.Properties.Resources.arrow_right_circle__2_;
            this.pictureBox3.Location = new System.Drawing.Point(1484, 702);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(98, 98);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // LightMenuB
            // 
            this.LightMenuB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.LightMenuB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LightMenuB.ForeColor = System.Drawing.Color.White;
            this.LightMenuB.Image = global::Sports_play.Properties.Resources.menu__1_;
            this.LightMenuB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LightMenuB.Location = new System.Drawing.Point(-8, -14);
            this.LightMenuB.Name = "LightMenuB";
            this.LightMenuB.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.LightMenuB.Size = new System.Drawing.Size(270, 122);
            this.LightMenuB.TabIndex = 2;
            this.LightMenuB.Text = "                Menu";
            this.LightMenuB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LightMenuB.UseVisualStyleBackColor = false;
            this.LightMenuB.Click += new System.EventHandler(this.LightMenuB_Click);
            // 
            // LightHomeB
            // 
            this.LightHomeB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.LightHomeB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LightHomeB.ForeColor = System.Drawing.Color.White;
            this.LightHomeB.Image = global::Sports_play.Properties.Resources.home__1_;
            this.LightHomeB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LightHomeB.Location = new System.Drawing.Point(-9, -11);
            this.LightHomeB.Name = "LightHomeB";
            this.LightHomeB.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.LightHomeB.Size = new System.Drawing.Size(270, 90);
            this.LightHomeB.TabIndex = 1;
            this.LightHomeB.Text = "               Home";
            this.LightHomeB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LightHomeB.UseVisualStyleBackColor = false;
            // 
            // LightSettingB
            // 
            this.LightSettingB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.LightSettingB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LightSettingB.ForeColor = System.Drawing.Color.White;
            this.LightSettingB.Image = global::Sports_play.Properties.Resources.settings__1_;
            this.LightSettingB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LightSettingB.Location = new System.Drawing.Point(-9, -11);
            this.LightSettingB.Name = "LightSettingB";
            this.LightSettingB.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.LightSettingB.Size = new System.Drawing.Size(270, 90);
            this.LightSettingB.TabIndex = 1;
            this.LightSettingB.Text = "              Setting";
            this.LightSettingB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LightSettingB.UseVisualStyleBackColor = false;
            // 
            // LightHelpB
            // 
            this.LightHelpB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.LightHelpB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LightHelpB.ForeColor = System.Drawing.Color.White;
            this.LightHelpB.Image = global::Sports_play.Properties.Resources.help__1_;
            this.LightHelpB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LightHelpB.Location = new System.Drawing.Point(-9, -11);
            this.LightHelpB.Name = "LightHelpB";
            this.LightHelpB.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.LightHelpB.Size = new System.Drawing.Size(270, 90);
            this.LightHelpB.TabIndex = 1;
            this.LightHelpB.Text = "                Help";
            this.LightHelpB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LightHelpB.UseVisualStyleBackColor = false;
            // 
            // LightAboutB
            // 
            this.LightAboutB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.LightAboutB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LightAboutB.ForeColor = System.Drawing.Color.White;
            this.LightAboutB.Image = global::Sports_play.Properties.Resources.info__1_;
            this.LightAboutB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LightAboutB.Location = new System.Drawing.Point(-9, -11);
            this.LightAboutB.Name = "LightAboutB";
            this.LightAboutB.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.LightAboutB.Size = new System.Drawing.Size(270, 90);
            this.LightAboutB.TabIndex = 1;
            this.LightAboutB.Text = "               About";
            this.LightAboutB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LightAboutB.UseVisualStyleBackColor = false;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.screen2ndpanel);
            this.Controls.Add(this.screeningpanel);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.screeningpanel.ResumeLayout(false);
            this.screeningpanel.PerformLayout();
            this.screen2ndpanel.ResumeLayout(false);
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panelhome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel screeningpanel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel screen2ndpanel;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Button LightHomeB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button LightSettingB;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button LightHelpB;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button LightAboutB;
        private System.Windows.Forms.Button LightMenuB;
        private System.Windows.Forms.Timer sidebartimer;
        private System.Windows.Forms.Panel panelhome;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
