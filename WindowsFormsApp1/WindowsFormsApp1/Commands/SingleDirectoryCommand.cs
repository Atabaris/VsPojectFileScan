using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Commands
{
    class SingleDirectoryCommand : ICommand
    {
        MainPage main_page;
        FileSystemWatcher watcher;

        public SingleDirectoryCommand(MainPage main_page)
        {
            this.main_page = main_page;
        }

        //Override Methods
        public string CommandName()
        {
            return "SingleDirectoryCommand";
        }

        public void Execute()
        {
            CreateWatcher();
            watcher.EnableRaisingEvents = true;
        }

        public void Stop()
        {
            watcher.EnableRaisingEvents = false;
            watcher.Dispose();
        }

        //Sub Methods
        private void CreateWatcher()
        {
            watcher = new FileSystemWatcher();
            watcher.SynchronizingObject = main_page;
            watcher.Path = main_page.getSettingPage().getSetting_page_textbox_single_directory().Text;
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            watcher.Filter = "*.*";
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);
            if (main_page.getSettingPage().getSetting_page_checkbox_subdirectory().Checked == true)
            {
                watcher.IncludeSubdirectories = true;
            }
        }

        private void OnChanged(object source, FileSystemEventArgs e)
        {

            string name = e.Name;
            string type = e.ChangeType.ToString();
            if (main_page.getMain_page_text_box().Text != "Log Closed")
            {
                main_page.getMain_page_text_box().AppendText("[[File " + type + "]] " + name + "\n");
            }
        }

        private void OnRenamed(object source, RenamedEventArgs e)
        {
            string _old = e.OldName;
            string _new = e.Name;
            if (main_page.getMain_page_text_box().Text != "Log Closed")
            {
                main_page.getMain_page_text_box().AppendText("[[File renamed ]] " + _old + " --->>> " + _new + "\n");
            }
        }
    }
}
