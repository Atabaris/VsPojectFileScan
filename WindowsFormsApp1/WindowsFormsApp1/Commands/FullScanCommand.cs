using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp1.Commands
{
    class FullScanCommand : ICommand
    {
        List<FileSystemWatcher> watchers = new List<FileSystemWatcher>();
        MainPage main_page;

        public FullScanCommand(MainPage main_page)
        {
            this.main_page = main_page;
        }

        
        //Override Methods
        public void Execute()
        {
            CreateWatchers();
            foreach (FileSystemWatcher watcher in watchers)
            {
                watcher.EnableRaisingEvents = true;
            }
        }

        public void Stop()
        {
            foreach (FileSystemWatcher watcher in watchers)
            {
                watcher.EnableRaisingEvents = false;
                watcher.Dispose();
            }
            watchers.Clear();

        }

        public string CommandName()
        {
            return "FullScanCommand";
        }

        //Sub Methods
        private void CreateWatchers()
        {
            foreach (string directory_path in Environment.GetLogicalDrives())
            {
                FileSystemWatcher watcher = new FileSystemWatcher();
                watcher.SynchronizingObject = main_page;
                watcher.Path = directory_path;
                watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;
                watcher.Filter = "*.*";
                watcher.Changed += new FileSystemEventHandler(OnChanged);
                watcher.Created += new FileSystemEventHandler(OnChanged);
                watcher.Deleted += new FileSystemEventHandler(OnChanged);
                watcher.Renamed += new RenamedEventHandler(OnRenamed);
                watcher.IncludeSubdirectories = true;
                watchers.Add(watcher);
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
