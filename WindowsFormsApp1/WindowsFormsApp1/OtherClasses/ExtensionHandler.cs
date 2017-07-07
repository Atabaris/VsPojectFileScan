using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.OtherClasses
{
    class ExtensionHandler
    {
        FileSystemEventArgs event_arg_change = null;
        RenamedEventArgs event_arg_rename = null;
        private string[] extensions = { ".docx", ".txt" };

        //Consturctor
        public ExtensionHandler()
        {

        }

        //Getter and setters
        public void setRenameEvent(RenamedEventArgs event_arg_rename)
        {
            this.event_arg_rename = event_arg_rename;
        }

        public void setChangeEvent(FileSystemEventArgs event_arg_change)
        {
            this.event_arg_change = event_arg_change;
        }

        //Sub methods
        private string isSupported()
        {
            string supported_extension = null;
            string file_extension = null;
            if (event_arg_change != null)//change event extension
            {
                file_extension = Path.GetExtension(event_arg_change.FullPath);
            }
            else//rename event extension
            {
                file_extension = Path.GetExtension(event_arg_rename.FullPath);
            }

            if (extensions.Contains(file_extension))//extension supported
            {
                supported_extension = file_extension;
            }
            return supported_extension;
        }

        public string handle()
        {
            string text = null;
            string change_type;

            if (event_arg_change != null)//change event change type
            {
                change_type = event_arg_change.ChangeType.ToString();
            }
            else//rename event change type
            {
                change_type = event_arg_rename.ChangeType.ToString();
            }

            if (isSupported() != null)//handle extension args
            {
                switch (isSupported())
                {
                    case ".docx":
                        if (change_type.Equals("Created"))//Change event type
                        {
                            text = "File :" + change_type + ":" + event_arg_change.Name + "\n";
                        }
                        else if (change_type.Equals("Renamed"))
                        {
                            text = "File :" + event_arg_rename.OldName + " " + change_type + ":" + event_arg_rename.Name + "\n";
                        }
                        break;
                    case ".txt":
                        if (change_type.Equals("Changed"))
                        {
                            text = "File :" + change_type + ":" + event_arg_change.Name + "\n";
                        }
                        else if (change_type.Equals("Renamed"))
                        {
                            text = "File :" + event_arg_rename.OldName + ":" + change_type + ":" + event_arg_rename.Name + "\n";
                        }
                        break;
                }
            }
            return text;
        }
    }
}
