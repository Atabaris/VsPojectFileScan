using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controllers;

namespace WindowsFormsApp1.Forms
{
    public partial class ClientPage : Form
    {
        private bool client_page_connection_to_sever=false;
        ClientPageController client_page_controller;
        public ClientPage()
        {
            InitializeComponent();
            this.ControlBox = false;
            client_page_controller = new ClientPageController(this);
        }


        //Getter and Setters
        public TextBox getClient_page_textbox_host()
        {
            return client_page_textbox_host_name;
        }

        public TextBox getClient_page_textbox_user_name()
        {
            return client_page_textbox_user_name;
        }

        public TextBox getClient_page_textbox_password()
        {
            return client_page_text_box_password;
        }

        public TextBox getClient_page_textbox_port()
        {
            return client_page_textbox_port;
        }

        public Label getClient_page_label_error()
        {
            return client_page_label_error;
        }
        public bool getClient_page_connection_to_server()
        {
            return client_page_connection_to_sever;
        }

        //Methods
        private void client_page_button_exit_Click(object sender, EventArgs e)
        {
            client_page_controller.ExitPage();
        }

        private void client_page_button_confirm_Click(object sender, EventArgs e)
        {
            client_page_controller.Confirm();
        }
    }
}
