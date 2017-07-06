using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Forms;
using WindowsFormsApp1.OtherClasses;

namespace WindowsFormsApp1.Controllers
{
    class ClientPageController
    {
        ClientPage client_page;

        //Constructor
        public ClientPageController(ClientPage client_page)
        {
            this.client_page = client_page;
        }

        //Exit button 
        public void ExitPage()
        {
            client_page.Visible = false;
        }
        //OK button
        public void Confirm()
        {
            string host_name = client_page.getClient_page_textbox_host().Text;
            string user_name = client_page.getClient_page_textbox_user_name().Text;
            string user_password = client_page.getClient_page_textbox_password().Text;
            string port = client_page.getClient_page_textbox_port().Text;

            FTPConnection connection = new FTPConnection(host_name,user_name,user_password,port);
            string result=connection.OpenConnection();
            client_page.getClient_page_label_error().Text = result;
            connection.CloseConnection();
        }
    }
}
