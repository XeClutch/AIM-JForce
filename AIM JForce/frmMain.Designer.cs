namespace AIM_JForce
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.banner = new System.Windows.Forms.PictureBox();
            this.tabctrl = new System.Windows.Forms.TabControl();
            this.tabctrl_bruteforce = new System.Windows.Forms.TabPage();
            this.bruteforce_settings = new System.Windows.Forms.GroupBox();
            this.bruteforce_settings_browse = new System.Windows.Forms.Button();
            this.bruteforce_settings_usenums = new System.Windows.Forms.CheckBox();
            this.bruteforce_settings_usespecialchars2 = new System.Windows.Forms.CheckBox();
            this.bruteforce_settings_usespecialchars1 = new System.Windows.Forms.CheckBox();
            this.bruteforce_toggle = new System.Windows.Forms.Button();
            this.bruteforce_resume = new System.Windows.Forms.Button();
            this.bruteforce_pause = new System.Windows.Forms.Button();
            this.bruteforce_islist = new System.Windows.Forms.RadioButton();
            this.bruteforce_ispure = new System.Windows.Forms.RadioButton();
            this.bruteforce_username_lbl = new System.Windows.Forms.Label();
            this.bruteforce_username = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.banner)).BeginInit();
            this.tabctrl.SuspendLayout();
            this.tabctrl_bruteforce.SuspendLayout();
            this.bruteforce_settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // banner
            // 
            this.banner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("banner.BackgroundImage")));
            this.banner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.banner.Location = new System.Drawing.Point(17, 12);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(250, 165);
            this.banner.TabIndex = 0;
            this.banner.TabStop = false;
            // 
            // tabctrl
            // 
            this.tabctrl.Controls.Add(this.tabctrl_bruteforce);
            this.tabctrl.Location = new System.Drawing.Point(12, 183);
            this.tabctrl.Name = "tabctrl";
            this.tabctrl.SelectedIndex = 0;
            this.tabctrl.Size = new System.Drawing.Size(260, 257);
            this.tabctrl.TabIndex = 1;
            // 
            // tabctrl_bruteforce
            // 
            this.tabctrl_bruteforce.Controls.Add(this.bruteforce_settings);
            this.tabctrl_bruteforce.Controls.Add(this.bruteforce_toggle);
            this.tabctrl_bruteforce.Controls.Add(this.bruteforce_resume);
            this.tabctrl_bruteforce.Controls.Add(this.bruteforce_pause);
            this.tabctrl_bruteforce.Controls.Add(this.bruteforce_islist);
            this.tabctrl_bruteforce.Controls.Add(this.bruteforce_ispure);
            this.tabctrl_bruteforce.Controls.Add(this.bruteforce_username_lbl);
            this.tabctrl_bruteforce.Controls.Add(this.bruteforce_username);
            this.tabctrl_bruteforce.Location = new System.Drawing.Point(4, 22);
            this.tabctrl_bruteforce.Name = "tabctrl_bruteforce";
            this.tabctrl_bruteforce.Padding = new System.Windows.Forms.Padding(3);
            this.tabctrl_bruteforce.Size = new System.Drawing.Size(252, 231);
            this.tabctrl_bruteforce.TabIndex = 1;
            this.tabctrl_bruteforce.Text = "Bruteforce";
            this.tabctrl_bruteforce.UseVisualStyleBackColor = true;
            // 
            // bruteforce_settings
            // 
            this.bruteforce_settings.Controls.Add(this.bruteforce_settings_browse);
            this.bruteforce_settings.Controls.Add(this.bruteforce_settings_usenums);
            this.bruteforce_settings.Controls.Add(this.bruteforce_settings_usespecialchars2);
            this.bruteforce_settings.Controls.Add(this.bruteforce_settings_usespecialchars1);
            this.bruteforce_settings.Location = new System.Drawing.Point(6, 90);
            this.bruteforce_settings.Name = "bruteforce_settings";
            this.bruteforce_settings.Size = new System.Drawing.Size(240, 67);
            this.bruteforce_settings.TabIndex = 9;
            this.bruteforce_settings.TabStop = false;
            this.bruteforce_settings.Text = "Settings (each option will take longer)";
            // 
            // bruteforce_settings_browse
            // 
            this.bruteforce_settings_browse.Location = new System.Drawing.Point(76, 27);
            this.bruteforce_settings_browse.Name = "bruteforce_settings_browse";
            this.bruteforce_settings_browse.Size = new System.Drawing.Size(75, 23);
            this.bruteforce_settings_browse.TabIndex = 10;
            this.bruteforce_settings_browse.Text = "Browse";
            this.bruteforce_settings_browse.UseVisualStyleBackColor = true;
            this.bruteforce_settings_browse.Visible = false;
            this.bruteforce_settings_browse.Click += new System.EventHandler(this.bruteforce_settings_browse_Click);
            // 
            // bruteforce_settings_usenums
            // 
            this.bruteforce_settings_usenums.AutoSize = true;
            this.bruteforce_settings_usenums.Checked = true;
            this.bruteforce_settings_usenums.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bruteforce_settings_usenums.Location = new System.Drawing.Point(6, 44);
            this.bruteforce_settings_usenums.Name = "bruteforce_settings_usenums";
            this.bruteforce_settings_usenums.Size = new System.Drawing.Size(162, 17);
            this.bruteforce_settings_usenums.TabIndex = 2;
            this.bruteforce_settings_usenums.Text = "Use numbers (1234567890)";
            this.bruteforce_settings_usenums.UseVisualStyleBackColor = true;
            // 
            // bruteforce_settings_usespecialchars2
            // 
            this.bruteforce_settings_usespecialchars2.AutoSize = true;
            this.bruteforce_settings_usespecialchars2.Location = new System.Drawing.Point(6, 30);
            this.bruteforce_settings_usespecialchars2.Name = "bruteforce_settings_usespecialchars2";
            this.bruteforce_settings_usespecialchars2.Size = new System.Drawing.Size(212, 17);
            this.bruteforce_settings_usespecialchars2.TabIndex = 1;
            this.bruteforce_settings_usespecialchars2.Text = "Use special characters (<^>?/;:\'\"[]{}|\\)";
            this.bruteforce_settings_usespecialchars2.UseVisualStyleBackColor = true;
            // 
            // bruteforce_settings_usespecialchars1
            // 
            this.bruteforce_settings_usespecialchars1.AutoSize = true;
            this.bruteforce_settings_usespecialchars1.Checked = true;
            this.bruteforce_settings_usespecialchars1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bruteforce_settings_usespecialchars1.Location = new System.Drawing.Point(6, 16);
            this.bruteforce_settings_usespecialchars1.Name = "bruteforce_settings_usespecialchars1";
            this.bruteforce_settings_usespecialchars1.Size = new System.Drawing.Size(228, 17);
            this.bruteforce_settings_usespecialchars1.TabIndex = 0;
            this.bruteforce_settings_usespecialchars1.Text = "Use special characters (!@#$%&&*_-+=,.)";
            this.bruteforce_settings_usespecialchars1.UseVisualStyleBackColor = true;
            // 
            // bruteforce_toggle
            // 
            this.bruteforce_toggle.Location = new System.Drawing.Point(12, 192);
            this.bruteforce_toggle.Name = "bruteforce_toggle";
            this.bruteforce_toggle.Size = new System.Drawing.Size(226, 23);
            this.bruteforce_toggle.TabIndex = 8;
            this.bruteforce_toggle.Text = "Start";
            this.bruteforce_toggle.UseVisualStyleBackColor = true;
            this.bruteforce_toggle.Click += new System.EventHandler(this.bruteforce_toggle_Click);
            // 
            // bruteforce_resume
            // 
            this.bruteforce_resume.Enabled = false;
            this.bruteforce_resume.Location = new System.Drawing.Point(128, 163);
            this.bruteforce_resume.Name = "bruteforce_resume";
            this.bruteforce_resume.Size = new System.Drawing.Size(110, 23);
            this.bruteforce_resume.TabIndex = 7;
            this.bruteforce_resume.Text = "Resume";
            this.bruteforce_resume.UseVisualStyleBackColor = true;
            this.bruteforce_resume.Click += new System.EventHandler(this.bruteforce_resume_Click);
            // 
            // bruteforce_pause
            // 
            this.bruteforce_pause.Enabled = false;
            this.bruteforce_pause.Location = new System.Drawing.Point(12, 163);
            this.bruteforce_pause.Name = "bruteforce_pause";
            this.bruteforce_pause.Size = new System.Drawing.Size(110, 23);
            this.bruteforce_pause.TabIndex = 6;
            this.bruteforce_pause.Text = "Pause";
            this.bruteforce_pause.UseVisualStyleBackColor = true;
            this.bruteforce_pause.Click += new System.EventHandler(this.bruteforce_pause_Click);
            // 
            // bruteforce_islist
            // 
            this.bruteforce_islist.AutoSize = true;
            this.bruteforce_islist.Location = new System.Drawing.Point(104, 67);
            this.bruteforce_islist.Name = "bruteforce_islist";
            this.bruteforce_islist.Size = new System.Drawing.Size(99, 17);
            this.bruteforce_islist.TabIndex = 5;
            this.bruteforce_islist.Text = "List Bruteforce";
            this.bruteforce_islist.UseVisualStyleBackColor = true;
            this.bruteforce_islist.CheckedChanged += new System.EventHandler(this.bruteforce_islist_CheckedChanged);
            // 
            // bruteforce_ispure
            // 
            this.bruteforce_ispure.AutoSize = true;
            this.bruteforce_ispure.Checked = true;
            this.bruteforce_ispure.Location = new System.Drawing.Point(104, 44);
            this.bruteforce_ispure.Name = "bruteforce_ispure";
            this.bruteforce_ispure.Size = new System.Drawing.Size(130, 17);
            this.bruteforce_ispure.TabIndex = 4;
            this.bruteforce_ispure.TabStop = true;
            this.bruteforce_ispure.Text = "Recursive Bruteforce";
            this.bruteforce_ispure.UseVisualStyleBackColor = true;
            this.bruteforce_ispure.CheckedChanged += new System.EventHandler(this.bruteforce_ispure_CheckedChanged);
            // 
            // bruteforce_username_lbl
            // 
            this.bruteforce_username_lbl.AutoSize = true;
            this.bruteforce_username_lbl.Location = new System.Drawing.Point(9, 19);
            this.bruteforce_username_lbl.Name = "bruteforce_username_lbl";
            this.bruteforce_username_lbl.Size = new System.Drawing.Size(81, 13);
            this.bruteforce_username_lbl.TabIndex = 3;
            this.bruteforce_username_lbl.Text = "AIM Username";
            // 
            // bruteforce_username
            // 
            this.bruteforce_username.Location = new System.Drawing.Point(104, 16);
            this.bruteforce_username.Name = "bruteforce_username";
            this.bruteforce_username.Size = new System.Drawing.Size(134, 22);
            this.bruteforce_username.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 452);
            this.Controls.Add(this.tabctrl);
            this.Controls.Add(this.banner);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JForce 1.0";
            ((System.ComponentModel.ISupportInitialize)(this.banner)).EndInit();
            this.tabctrl.ResumeLayout(false);
            this.tabctrl_bruteforce.ResumeLayout(false);
            this.tabctrl_bruteforce.PerformLayout();
            this.bruteforce_settings.ResumeLayout(false);
            this.bruteforce_settings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox banner;
        private System.Windows.Forms.TabControl tabctrl;
        private System.Windows.Forms.TabPage tabctrl_bruteforce;
        private System.Windows.Forms.GroupBox bruteforce_settings;
        private System.Windows.Forms.Button bruteforce_settings_browse;
        private System.Windows.Forms.CheckBox bruteforce_settings_usenums;
        private System.Windows.Forms.CheckBox bruteforce_settings_usespecialchars2;
        private System.Windows.Forms.CheckBox bruteforce_settings_usespecialchars1;
        private System.Windows.Forms.Button bruteforce_toggle;
        private System.Windows.Forms.Button bruteforce_resume;
        private System.Windows.Forms.Button bruteforce_pause;
        private System.Windows.Forms.RadioButton bruteforce_islist;
        private System.Windows.Forms.RadioButton bruteforce_ispure;
        private System.Windows.Forms.Label bruteforce_username_lbl;
        private System.Windows.Forms.TextBox bruteforce_username;
    }
}

