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
using WindowsFormsApp1.Forms;

namespace WindowsFormsApp1
{
    public partial class SettingsPage : Form
    {
        ClientPage client_page;
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


        public Button getSetting_page_btn_browse_directory()
        {
            return setting_page_btn_browse_directory;
        }

        public CheckBox getSetting_page_checkbox_full_scan()
        {
            return setting_page_checkbox_full_scan;
        }

        public CheckBox getSetting_page_checkbox_subdirectory()
        {
            return setting_page_checkbox_subdirectory;
        }

        public CheckBox getSetting_page_checkbox_multiple_directory()
        {
            return setting_page_checkbox_multiple_directory;
        }
        
        public CheckBox getSetting_page_chekcbox_copy_files()
        {
            return setting_page_checkbox_copy_files;
        }

        public TextBox getSetting_page_textbox_single_directory()
        {
            return setting_page_textbox_single_directory;
        }

        public RichTextBox getSetting_page_textbox_multiple_directory()
        {
            return setting_page_textbox_multiple_directory;
        }

        public ClientPage getClientPage()
        {
            return client_page;
        }

        public void setClientPage(ClientPage client_page)
        {
            this.client_page = client_page;
        }


        //Methods
        private void setting_page_checkbox_full_scan_CheckedChanged(object sender, EventArgs e)
        {
            setting_page_controller.FullScanCheckBoxChange();
        }

        private void setting_page_btn_browse_directory_Click(object sender, EventArgs e)
        {
            setting_page_controller.BrowseDirectroyChange();
        }

        private void setting_page_btn_clear_textbox_Click(object sender, EventArgs e)
        {
            setting_page_controller.ClearList();
        }

        private void setting_page_btn_exit_Click(object sender, EventArgs e)
        {
            setting_page_controller.ClosePage();
        }

        private void setting_page_checkbox_multiple_directory_CheckedChanged(object sender, EventArgs e)
        {
            setting_page_controller.MultiDirectoryCheckBoxChange();
        }

        private void setting_page_checkbox_copy_files_CheckedChanged(object sender, EventArgs e)
        {
            setting_page_controller.OpenClientPage();
        }
    }
}
