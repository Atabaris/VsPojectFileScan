using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1.Commands
{
    class MultiDirectoryCommand : ICommand
    {
        List<FileWatcher> watchers = new List<FileWatcher>();
        List<string> watcher_paths = new List<string>();
        MainPage main_page;

        public MultiDirectoryCommand(MainPage main_page)
        {
            this.main_page = main_page;
        }


        //Override Methods
        public void Execute()
        {
            CreatePaths();
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
            watcher_paths.Clear();
        }

        public string CommandName()
        {
            return "MultiDirectoryCommand";
        }

        //Sub Methods
        private void CreateWatchers()
        {
            foreach (string directory_path in watcher_paths)
            {
                FileWatcher watcher = new FileWatcher(main_page, directory_path);
                if (main_page.getSettingPage().getSetting_page_checkbox_subdirectory().Checked == true)
                {
                    watcher.getWatcher().IncludeSubdirectories = true;
                }
                watchers.Add(watcher);
            }
        }

        private void CreatePaths()
        {
            for (int i = 0; i < main_page.getSettingPage().getSetting_page_textbox_multiple_directory().Lines.Count() - 1; i++)// Paths in the textbox of main_page
            {
                string line = main_page.getSettingPage().getSetting_page_textbox_multiple_directory().Lines[i];
                watcher_paths.Add(line);
            }
        }
    }
}
