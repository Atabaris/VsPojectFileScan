using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Commands;

namespace WindowsFormsApp1
{
    class MainPageController
    {

        MainPage main_page;
        ICommand command;

        //Constructor
        public MainPageController(MainPage main_page)
        {
            this.main_page = main_page;
        }

        //Sub methods
        private void StartButtonOptions()  // User have to choose one of 3 methods for exit settings page
        {
            if (main_page.getSettingPage() != null)
            {
                if (main_page.getSettingPage().getSetting_page_checkbox_full_scan().Checked == true)//FullScan choosed
                {
                    command = new FullScanCommand(main_page);
                    command.Execute();
                }
                else if (main_page.getSettingPage().getSetting_page_checkbox_multiple_directory().Checked == false)//Single directroy choosed  ,subdirectroies may be included
                {
                    command = new SingleDirectoryCommand(main_page);
                    command.Execute();
                }
                else//multi directory choosed , subdirectories may be included
                {
                    command = new MultiDirectoryCommand(main_page);
                    command.Execute();
                }
                main_page.getMain_page_btn_start().Text = "Started";
                main_page.getMain_page_btn_stop().Text = "Stop";
                main_page.getMain_page_btn_settings().Enabled = false;
            }
        }

        //CheckboxLog Method
        public void CheckBoxLogChange()
        {
            if (main_page.getMain_page_checkbox_log().Checked == true)
            {
                main_page.getMain_page_checkbox_log().Text = "Show Log";
                main_page.getMain_page_text_box().Text = "Log Closed";
            }
            else
            {
                main_page.getMain_page_checkbox_log().Text = "Close Log";
                main_page.getMain_page_text_box().Text = "Log Opened";
            }
        }

        //Stop Button Method
        public void StopButton()
        {
            main_page.getMain_page_btn_start().Text = "Start";
            main_page.getMain_page_btn_stop().Text = "Stopped";
            if (command != null)
            {
                command.Stop();
            }
            command = null;
            main_page.getMain_page_btn_settings().Enabled = true;

        }

        //Start Button Method
        public void StartButton()
        {
            StartButtonOptions();
        }

        //Setting Page Button Method
        public void OpenSettingPage()
        {
            if (main_page.getSettingPage() == null)
            {
                SettingsPage new_settings_page = new SettingsPage();
                main_page.setSetting_Page(new_settings_page);

            }
            main_page.getSettingPage().Visible = true;
        }

    }
}
