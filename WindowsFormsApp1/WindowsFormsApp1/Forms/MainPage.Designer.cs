namespace WindowsFormsApp1
{
    partial class MainPage
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
            this.main_page_btn_start = new System.Windows.Forms.Button();
            this.main_page_btn_stop = new System.Windows.Forms.Button();
            this.main_page_btn_settings = new System.Windows.Forms.Button();
            this.main_page_text_box = new System.Windows.Forms.RichTextBox();
            this.main_page_checkbox_log = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // main_page_btn_start
            // 
            this.main_page_btn_start.AccessibleName = "";
            this.main_page_btn_start.Enabled = false;
            this.main_page_btn_start.Location = new System.Drawing.Point(12, 12);
            this.main_page_btn_start.Name = "main_page_btn_start";
            this.main_page_btn_start.Size = new System.Drawing.Size(138, 92);
            this.main_page_btn_start.TabIndex = 0;
            this.main_page_btn_start.Text = "Start";
            this.main_page_btn_start.UseVisualStyleBackColor = true;
            this.main_page_btn_start.Click += new System.EventHandler(this.main_page_btn_start_Click);
            // 
            // main_page_btn_stop
            // 
            this.main_page_btn_stop.Enabled = false;
            this.main_page_btn_stop.Location = new System.Drawing.Point(192, 13);
            this.main_page_btn_stop.Name = "main_page_btn_stop";
            this.main_page_btn_stop.Size = new System.Drawing.Size(138, 91);
            this.main_page_btn_stop.TabIndex = 1;
            this.main_page_btn_stop.Text = "Stop";
            this.main_page_btn_stop.UseVisualStyleBackColor = true;
            this.main_page_btn_stop.Click += new System.EventHandler(this.main_page_btn_stop_Click);
            // 
            // main_page_btn_settings
            // 
            this.main_page_btn_settings.Location = new System.Drawing.Point(377, 13);
            this.main_page_btn_settings.Name = "main_page_btn_settings";
            this.main_page_btn_settings.Size = new System.Drawing.Size(138, 91);
            this.main_page_btn_settings.TabIndex = 2;
            this.main_page_btn_settings.Text = "Settings";
            this.main_page_btn_settings.UseVisualStyleBackColor = true;
            this.main_page_btn_settings.Click += new System.EventHandler(this.main_page_btn_settings_Click);
            // 
            // main_page_text_box
            // 
            this.main_page_text_box.Enabled = false;
            this.main_page_text_box.Location = new System.Drawing.Point(13, 127);
            this.main_page_text_box.Name = "main_page_text_box";
            this.main_page_text_box.Size = new System.Drawing.Size(851, 387);
            this.main_page_text_box.TabIndex = 3;
            this.main_page_text_box.Text = "";
            // 
            // main_page_checkbox_log
            // 
            this.main_page_checkbox_log.AutoSize = true;
            this.main_page_checkbox_log.Location = new System.Drawing.Point(788, 91);
            this.main_page_checkbox_log.Name = "main_page_checkbox_log";
            this.main_page_checkbox_log.Size = new System.Drawing.Size(74, 17);
            this.main_page_checkbox_log.TabIndex = 5;
            this.main_page_checkbox_log.Text = "Show Log";
            this.main_page_checkbox_log.UseVisualStyleBackColor = true;
            this.main_page_checkbox_log.CheckedChanged += new System.EventHandler(this.main_page_checkbox_log_CheckedChanged);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 526);
            this.Controls.Add(this.main_page_checkbox_log);
            this.Controls.Add(this.main_page_text_box);
            this.Controls.Add(this.main_page_btn_settings);
            this.Controls.Add(this.main_page_btn_stop);
            this.Controls.Add(this.main_page_btn_start);
            this.Name = "MainPage";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button main_page_btn_start;
        private System.Windows.Forms.Button main_page_btn_stop;
        private System.Windows.Forms.Button main_page_btn_settings;
        private System.Windows.Forms.RichTextBox main_page_text_box;
        private System.Windows.Forms.CheckBox main_page_checkbox_log;
    }
}

