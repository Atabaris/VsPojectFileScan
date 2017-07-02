using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controller;

namespace WindowsFormsApp1
{
    public partial class SettingsPage : Form
    {
        SettingPageController setting_page_controller;
        //Constructor
        public SettingsPage()
        {
            InitializeComponent();
            this.ControlBox = false;
            setting_page_controller = new SettingPageController(this);
        }

        //Getter and setters

        public Button getSetting_page_btn_exit()
        {
            return setting_page_btn_exit;
        }

        public Button getSetting_page_btn_clear_textbox()
        {
            return setting_page_btn_clear_textbox;
        }

        public void setSetting_page_btn_clear_textbox(Button setting_page_btn_clear_textbox)
        {
            this.setting_page_btn_clear_textbox = setting_page_btn_clear_textbox;
        }

        public Button getSetting_page_btn_browse_directory()
        {
            return setting_page_btn_browse_directory;
        }

        public void setSetting_page_btn_browse_directory(Button setting_page_btn_browse_directory)
        {
            this.setting_page_btn_browse_directory = setting_page_btn_browse_directory;
        }

        public CheckBox getSetting_page_checkbox_full_scan()
        {
            return setting_page_checkbox_full_scan;
        }

        public void setSetting_page_checkbox_full_scan(CheckBox setting_page_checkbox_full_scan)
        {
            this.setting_page_checkbox_full_scan = setting_page_checkbox_full_scan;
            
        }

        public CheckBox getSetting_page_checkbox_subdirectory()
        {
            return setting_page_checkbox_subdirectory;
        }

        public void setSetting_page_checkbox_subdirectory(CheckBox setting_page_checkbox_subdirectory)
        {
            this.setting_page_checkbox_subdirectory = setting_page_checkbox_subdirectory;
        }

        public CheckBox getSetting_page_checkbox_multiple_directory()
        {
            return setting_page_checkbox_multiple_directory;
        }

        public void setSetting_page_checkbox_multiple_directory(CheckBox setting_page_checkbox_multiple_directory)
        {
            this.setting_page_checkbox_multiple_directory = setting_page_checkbox_multiple_directory;
        }


        //Methods
        private void setting_page_checkbox_full_scan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void setting_page_checkbox_subdirectory_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void setting_page_checkbox_multiple_directory_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void setting_page_btn_browse_directory_Click(object sender, EventArgs e)
        {

        }

        private void setting_page_btn_clear_textbox_Click(object sender, EventArgs e)
        {

        }

        private void setting_page_btn_exit_Click(object sender, EventArgs e)
        {
            setting_page_controller.ClosePage();
        }
    }
}
