namespace WindowsFormsApp1.Forms
{
    partial class ClientPage
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
            this.client_page_textbox_host_name = new System.Windows.Forms.TextBox();
            this.client_page_textbox_user_name = new System.Windows.Forms.TextBox();
            this.client_page_text_box_password = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.client_page_textbox_port = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.client_page_button_exit = new System.Windows.Forms.Button();
            this.client_page_button_confirm = new System.Windows.Forms.Button();
            this.client_page_label_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // client_page_textbox_host_name
            // 
            this.client_page_textbox_host_name.Location = new System.Drawing.Point(210, 35);
            this.client_page_textbox_host_name.Name = "client_page_textbox_host_name";
            this.client_page_textbox_host_name.Size = new System.Drawing.Size(100, 20);
            this.client_page_textbox_host_name.TabIndex = 0;
            // 
            // client_page_textbox_user_name
            // 
            this.client_page_textbox_user_name.Location = new System.Drawing.Point(210, 85);
            this.client_page_textbox_user_name.Name = "client_page_textbox_user_name";
            this.client_page_textbox_user_name.Size = new System.Drawing.Size(100, 20);
            this.client_page_textbox_user_name.TabIndex = 1;
            // 
            // client_page_text_box_password
            // 
            this.client_page_text_box_password.Location = new System.Drawing.Point(210, 137);
            this.client_page_text_box_password.Name = "client_page_text_box_password";
            this.client_page_text_box_password.PasswordChar = '*';
            this.client_page_text_box_password.Size = new System.Drawing.Size(100, 20);
            this.client_page_text_box_password.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // client_page_textbox_port
            // 
            this.client_page_textbox_port.Location = new System.Drawing.Point(210, 184);
            this.client_page_textbox_port.Name = "client_page_textbox_port";
            this.client_page_textbox_port.Size = new System.Drawing.Size(100, 20);
            this.client_page_textbox_port.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 169);
            this.label1.TabIndex = 5;
            this.label1.Text = "Host Name          :\r\n\r\n\r\n\r\nUser Name          :\r\n\r\n\r\n\r\nUser Password    :\r\n\r\n\r\n\r" +
    "\nPort                      :";
            // 
            // client_page_button_exit
            // 
            this.client_page_button_exit.Location = new System.Drawing.Point(518, 12);
            this.client_page_button_exit.Name = "client_page_button_exit";
            this.client_page_button_exit.Size = new System.Drawing.Size(75, 23);
            this.client_page_button_exit.TabIndex = 6;
            this.client_page_button_exit.Text = "Exit";
            this.client_page_button_exit.UseVisualStyleBackColor = true;
            this.client_page_button_exit.Click += new System.EventHandler(this.client_page_button_exit_Click);
            // 
            // client_page_button_confirm
            // 
            this.client_page_button_confirm.Location = new System.Drawing.Point(518, 330);
            this.client_page_button_confirm.Name = "client_page_button_confirm";
            this.client_page_button_confirm.Size = new System.Drawing.Size(75, 23);
            this.client_page_button_confirm.TabIndex = 7;
            this.client_page_button_confirm.Text = "OK";
            this.client_page_button_confirm.UseVisualStyleBackColor = true;
            this.client_page_button_confirm.Click += new System.EventHandler(this.client_page_button_confirm_Click);
            // 
            // client_page_label_error
            // 
            this.client_page_label_error.AutoSize = true;
            this.client_page_label_error.Location = new System.Drawing.Point(12, 245);
            this.client_page_label_error.Name = "client_page_label_error";
            this.client_page_label_error.Size = new System.Drawing.Size(0, 13);
            this.client_page_label_error.TabIndex = 8;
            // 
            // ClientPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 369);
            this.Controls.Add(this.client_page_label_error);
            this.Controls.Add(this.client_page_button_confirm);
            this.Controls.Add(this.client_page_button_exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.client_page_textbox_port);
            this.Controls.Add(this.client_page_text_box_password);
            this.Controls.Add(this.client_page_textbox_user_name);
            this.Controls.Add(this.client_page_textbox_host_name);
            this.Name = "ClientPage";
            this.Text = "FTPClientPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox client_page_textbox_host_name;
        private System.Windows.Forms.TextBox client_page_textbox_user_name;
        private System.Windows.Forms.TextBox client_page_text_box_password;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox client_page_textbox_port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button client_page_button_exit;
        private System.Windows.Forms.Button client_page_button_confirm;
        private System.Windows.Forms.Label client_page_label_error;
    }
}