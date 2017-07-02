using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Controller
{
    class SettingPageController
    {
        SettingsPage setting_page;

        public SettingPageController(SettingsPage setting_page)
        {
            this.setting_page = setting_page;
        }

        public void ClosePage()
        {
            setting_page.Visible = false;
        }

    }
}
