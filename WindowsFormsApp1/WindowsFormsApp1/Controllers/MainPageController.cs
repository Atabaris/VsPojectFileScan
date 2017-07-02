using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class MainPageController
    {
        MainPage main_page;

        public MainPageController(MainPage main_page)
        {
            this.main_page = main_page;
        }

        public void Open_settings_page()
        {
            if (main_page.getSettingPage()==null)
            {
                SettingsPage new_settings_page = new SettingsPage();
                main_page.setSetting_Page(new_settings_page);
                
            }
            main_page.getSettingPage().Visible=true;


        }
    }
}
