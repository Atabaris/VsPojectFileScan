using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1.Commands
{
    class SingleDirectoryCommand : ICommand
    {
        MainPage main_page;
        private FileWatcher watcher;

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
            watcher.getWatcher().EnableRaisingEvents = true;
        }

        public void Stop()
        {
            watcher.getWatcher().EnableRaisingEvents = false;
            watcher.getWatcher().Dispose();
        }

        //Sub Methods
        private void CreateWatcher()
        {
            string directory_path = main_page.getSettingPage().getSetting_page_textbox_single_directory().Text;
            watcher= new FileWatcher(main_page, directory_path);                        
            if (main_page.getSettingPage().getSetting_page_checkbox_subdirectory().Checked == true)
            {
                watcher.getWatcher().IncludeSubdirectories = true;
            }
        }
    }
}
