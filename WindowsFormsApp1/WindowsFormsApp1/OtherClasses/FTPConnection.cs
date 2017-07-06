using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.OtherClasses
{
    class FTPConnection
    {
        FtpWebRequest request;
        Stream responseStream;
        StreamReader reader;
        private string host_name;
        private string user_name;
        private string user_password;
        private string port;
        private bool connected = false;
        //Constructor
        public FTPConnection(string host_name, string user_name, string user_password, string port)
        {
            this.host_name = host_name;
            this.user_name = user_name;
            this.user_password = user_password;
            this.port = port;
        }

        public string OpenConnection()
        {
            string result;
            try
            {
                request = (FtpWebRequest)WebRequest.Create("ftp://" + host_name + ":" + port + "/");
                request.Method = WebRequestMethods.Ftp.ListDirectory;
                request.Credentials = new NetworkCredential(user_name, user_password);
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();

                responseStream = response.GetResponseStream();
                reader = new StreamReader(responseStream);
                result = reader.ReadToEnd()+"\n";
                result = result + "Connected";
                connected = true;
            }
            catch (Exception e)

            {
                result = e.Message.ToString();
            }

            return result;
        }

        public void CloseConnection()
        {
            if (IsConnected())
            {                
                reader.Close();
                responseStream.Close();
                request = null;
            }          
        }

        public bool IsConnected()
        {
            return connected;
        }

    }
}
