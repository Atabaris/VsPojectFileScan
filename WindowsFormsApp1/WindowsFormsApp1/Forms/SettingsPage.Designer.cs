namespace WindowsFormsApp1
{
    partial class SettingsPage
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
            this.setting_page_checkbox_subdirectory = new System.Windows.Forms.CheckBox();
            this.setting_page_checkbox_full_scan = new System.Windows.Forms.CheckBox();
            this.setting_page_btn_browse_directory = new System.Windows.Forms.Button();
            this.setting_page_textbox_single_directory = new System.Windows.Forms.TextBox();
            this.setting_page_checkbox_multiple_directory = new System.Windows.Forms.CheckBox();
            this.setting_page_textbox_multiple_directory = new System.Windows.Forms.RichTextBox();
            this.setting_page_btn_clear_textbox = new System.Windows.Forms.Button();
            this.setting_page_btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // setting_page_checkbox_subdirectory
            // 
            this.setting_page_checkbox_subdirectory.AutoSize = true;
            this.setting_page_checkbox_subdirectory.Location = new System.Drawing.Point(12, 60);
            this.setting_page_checkbox_subdirectory.Name = "setting_page_checkbox_subdirectory";
            this.setting_page_checkbox_subdirectory.Size = new System.Drawing.Size(131, 17);
            this.setting_page_checkbox_subdirectory.TabIndex = 0;
            this.setting_page_checkbox_subdirectory.Text = "Include Subdirectories";
            this.setting_page_checkbox_subdirectory.UseVisualStyleBackColor = true;
            // 
            // setting_page_checkbox_full_scan
            // 
            this.setting_page_checkbox_full_scan.AutoSize = true;
            this.setting_page_checkbox_full_scan.Location = new System.Drawing.Point(12, 12);
            this.setting_page_checkbox_full_scan.Name = "setting_page_checkbox_full_scan";
            this.setting_page_checkbox_full_scan.Size = new System.Drawing.Size(118, 17);
            this.setting_page_checkbox_full_scan.TabIndex = 1;
            this.setting_page_checkbox_full_scan.Text = "Full Computer Scan";
            this.setting_page_checkbox_full_scan.UseVisualStyleBackColor = true;
            this.setting_page_checkbox_full_scan.CheckedChanged += new System.EventHandler(this.setting_page_checkbox_full_scan_CheckedChanged);
            // 
            // setting_page_btn_browse_directory
            // 
            this.setting_page_btn_browse_directory.Location = new System.Drawing.Point(12, 159);
            this.setting_page_btn_browse_directory.Name = "setting_page_btn_browse_directory";
            this.setting_page_btn_browse_directory.Size = new System.Drawing.Size(118, 56);
            this.setting_page_btn_browse_directory.TabIndex = 2;
            this.setting_page_btn_browse_directory.Text = "Choose Directory";
            this.setting_page_btn_browse_directory.UseVisualStyleBackColor = true;
            this.setting_page_btn_browse_directory.Click += new System.EventHandler(this.setting_page_btn_browse_directory_Click);
            // 
            // setting_page_textbox_single_directory
            // 
            this.setting_page_textbox_single_directory.Enabled = false;
            this.setting_page_textbox_single_directory.Location = new System.Drawing.Point(164, 178);
            this.setting_page_textbox_single_directory.Name = "setting_page_textbox_single_directory";
            this.setting_page_textbox_single_directory.Size = new System.Drawing.Size(496, 20);
            this.setting_page_textbox_single_directory.TabIndex = 3;
            // 
            // setting_page_checkbox_multiple_directory
            // 
            this.setting_page_checkbox_multiple_directory.AutoSize = true;
            this.setting_page_checkbox_multiple_directory.Location = new System.Drawing.Point(12, 110);
            this.setting_page_checkbox_multiple_directory.Name = "setting_page_checkbox_multiple_directory";
            this.setting_page_checkbox_multiple_directory.Size = new System.Drawing.Size(146, 17);
            this.setting_page_checkbox_multiple_directory.TabIndex = 4;
            this.setting_page_checkbox_multiple_directory.Text = "Choose Multiple Directroy";
            this.setting_page_checkbox_multiple_directory.UseVisualStyleBackColor = true;
            this.setting_page_checkbox_multiple_directory.CheckedChanged += new System.EventHandler(this.setting_page_checkbox_multiple_directory_CheckedChanged);
            // 
            // setting_page_textbox_multiple_directory
            // 
            this.setting_page_textbox_multiple_directory.Enabled = false;
            this.setting_page_textbox_multiple_directory.Location = new System.Drawing.Point(164, 229);
            this.setting_page_textbox_multiple_directory.Name = "setting_page_textbox_multiple_directory";
            this.setting_page_textbox_multiple_directory.Size = new System.Drawing.Size(496, 337);
            this.setting_page_textbox_multiple_directory.TabIndex = 5;
            this.setting_page_textbox_multiple_directory.Text = "";
            // 
            // setting_page_btn_clear_textbox
            // 
            this.setting_page_btn_clear_textbox.Enabled = false;
            this.setting_page_btn_clear_textbox.Location = new System.Drawing.Point(12, 505);
            this.setting_page_btn_clear_textbox.Name = "setting_page_btn_clear_textbox";
            this.setting_page_btn_clear_textbox.Size = new System.Drawing.Size(118, 60);
            this.setting_page_btn_clear_textbox.TabIndex = 6;
            this.setting_page_btn_clear_textbox.Text = "Clear List";
            this.setting_page_btn_clear_textbox.UseVisualStyleBackColor = true;
            this.setting_page_btn_clear_textbox.Click += new System.EventHandler(this.setting_page_btn_clear_textbox_Click);
            // 
            // setting_page_btn_exit
            // 
            this.setting_page_btn_exit.Location = new System.Drawing.Point(573, 12);
            this.setting_page_btn_exit.Name = "setting_page_btn_exit";
            this.setting_page_btn_exit.Size = new System.Drawing.Size(75, 23);
            this.setting_page_btn_exit.TabIndex = 7;
            this.setting_page_btn_exit.Text = "Exit";
            this.setting_page_btn_exit.UseVisualStyleBackColor = true;
            this.setting_page_btn_exit.Click += new System.EventHandler(this.setting_page_btn_exit_Click);
            // 
            // SettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 578);
            this.Controls.Add(this.setting_page_btn_exit);
            this.Controls.Add(this.setting_page_btn_clear_textbox);
            this.Controls.Add(this.setting_page_textbox_multiple_directory);
            this.Controls.Add(this.setting_page_checkbox_multiple_directory);
            this.Controls.Add(this.setting_page_textbox_single_directory);
            this.Controls.Add(this.setting_page_btn_browse_directory);
            this.Controls.Add(this.setting_page_checkbox_full_scan);
            this.Controls.Add(this.setting_page_checkbox_subdirectory);
            this.Name = "SettingsPage";
            this.Text = "SettingsPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox setting_page_checkbox_subdirectory;
        private System.Windows.Forms.CheckBox setting_page_checkbox_full_scan;
        private System.Windows.Forms.Button setting_page_btn_browse_directory;
        private System.Windows.Forms.TextBox setting_page_textbox_single_directory;
        private System.Windows.Forms.CheckBox setting_page_checkbox_multiple_directory;
        private System.Windows.Forms.RichTextBox setting_page_textbox_multiple_directory;
        private System.Windows.Forms.Button setting_page_btn_clear_textbox;
        private System.Windows.Forms.Button setting_page_btn_exit;
    }
}