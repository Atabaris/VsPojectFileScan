using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1.Commands
{
    class FullScanCommand : ICommand
    {
        List<FileWatcher> watchers = new List<FileWatcher>();
        MainPage main_page;

        public FullScanCommand(MainPage main_page)
        {
            this.main_page = main_page;
        }

        
        //Override Methods
        public void Execute()
        {
            CreateWatchers();
            foreach (FileWatcher watcher in watchers)
            {
                watcher.getWatcher().EnableRaisingEvents = true;
            }
        }

        public void Stop()
        {
            foreach (FileWatcher watcher in watchers)
            {
                watcher.getWatcher().EnableRaisingEvents = false;
                watcher.getWatcher().Dispose();
            }
            watchers.Clear();

        }

        public string CommandName()
        {
            return "FullScanCommand";
        }

        //Sub Methods
        private void CreateWatchers()//Add multiple watcher object to list
        {
            foreach (string directory_path in Environment.GetLogicalDrives())//Get Logical Disk of computer Ex: C:\\ D:\\ E:\\  USB and extratable disk are not included 
            {
                FileWatcher watcher = new FileWatcher(main_page, directory_path);
                watcher.getWatcher().IncludeSubdirectories = true;
                watchers.Add(watcher);
            }
        }

    }
}
