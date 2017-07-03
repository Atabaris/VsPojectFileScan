using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class MainPage : Form
    {
        MainPageController main_page_controller;
        SettingsPage setting_page;
        //Constructor
        public MainPage()
        {
            InitializeComponent();
            main_page_controller = new MainPageController(this);
        }


        //Getter and setters
        public Button getMain_page_btn_start()
        {
            return main_page_btn_start;
        }

        public void setMain_page_btn_start(Button main_page_btn_start)
        {
            this.main_page_btn_start = main_page_btn_start;
        }

        public Button getMain_page_btn_stop()
        {
            return main_page_btn_stop;
        }

        public void setMain_page_btn_stop(Button main_page_btn_stop)
        {
            this.main_page_btn_stop = main_page_btn_stop;
        }

        public Button getMain_page_btn_settings()
        {
            return main_page_btn_settings;
        }

        public RichTextBox getMain_page_text_box()
        {
            return main_page_text_box;
        }

        public void setMain_page_text_box(RichTextBox main_page_text_box)
        {
            this.main_page_text_box = main_page_text_box;
        }

        public CheckBox getMain_page_checkbox_log()
        {
            return main_page_checkbox_log;
        }

        public void setMain_page_checkbox_log(CheckBox main_page_checkbox_log)
        {
            this.main_page_checkbox_log = main_page_checkbox_log;
        }

        public SettingsPage getSettingPage()
        {
            return setting_page;
        }

        public void setSetting_Page(SettingsPage setting_page)
        {
            this.setting_page = setting_page;
        }


        //Methods

        private void main_page_btn_start_Click(object sender, EventArgs e)
        {
            main_page_controller.StartButton();
        }

        private void main_page_btn_stop_Click(object sender, EventArgs e)
        {
            main_page_controller.StopButton();
        }

        private void main_page_btn_settings_Click(object sender, EventArgs e)
        {
            main_page_controller.OpenSettingPage();
        }

        private void main_page_checkbox_log_CheckedChanged(object sender, EventArgs e)
        {
            main_page_controller.CheckBoxLogChange();
        }
    }
}
