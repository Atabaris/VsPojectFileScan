using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    class FileWatcher
    {
        private MainPage main_page;
        private FileSystemWatcher watcher;
        private string directory_path;
        public FileWatcher(MainPage main_page, string directory_path)
        {
            this.main_page = main_page;
            this.directory_path = directory_path;
        }

        public void createWatcher()
        {
            watcher = new FileSystemWatcher();
            watcher.SynchronizingObject = main_page;
            watcher.Path = directory_path;
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            watcher.Filter = "*.*";
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);
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

        public FileSystemWatcher getWatcher()
        {
            return watcher;
        }
    }
}
