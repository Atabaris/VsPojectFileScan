using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Forms;

namespace WindowsFormsApp1.Controller
{
    class SettingPageController
    {
        SettingsPage setting_page;

        //Constructor
        public SettingPageController(SettingsPage setting_page)
        {
            this.setting_page = setting_page;
        }

        //Sub Methods
        private void FullScanSettingsActive() //Change interface of form when Full Scan checkbox checked
        {
            setting_page.getSetting_page_checkbox_subdirectory().Enabled = false;
            setting_page.getSetting_page_checkbox_subdirectory().Checked = false;
            setting_page.getSetting_page_checkbox_multiple_directory().Enabled = false;
            setting_page.getSetting_page_checkbox_multiple_directory().Checked = false;
            setting_page.getSetting_page_btn_browse_directory().Enabled = false;
            setting_page.getSetting_page_btn_clear_textbox().Enabled = false;
            setting_page.getSetting_page_textbox_single_directory().Text = "";
            setting_page.getSetting_page_textbox_multiple_directory().Text = "";
        }

        private void FullScanSettingsClose()
        {
            setting_page.getSetting_page_checkbox_subdirectory().Enabled = true;
            setting_page.getSetting_page_checkbox_multiple_directory().Enabled = true;
            setting_page.getSetting_page_btn_browse_directory().Enabled = true;
        }

        private void openPathMenuSingleDirectory()
        {
            System.Windows.Forms.FolderBrowserDialog folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                setting_page.getSetting_page_textbox_single_directory().Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void openPathMenuMultiDirectory()
        {
            System.Windows.Forms.FolderBrowserDialog folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                setting_page.getSetting_page_textbox_multiple_directory().AppendText(folderBrowserDialog.SelectedPath + "\n");
            }
        }

        private bool ExitButtonOptions()
        {
            bool ready;
            if (setting_page.getSetting_page_checkbox_multiple_directory().Checked == true)//if multi directory choosed 
            {
                if (setting_page.getSetting_page_textbox_multiple_directory().TextLength == 0)// there is no path added
                {
                    ready = false;
                }
                else
                {
                    ready = true;
                }
            }
            else//single path or fullscan choosed
            {
                if (setting_page.getSetting_page_checkbox_full_scan().Checked == true)//full scan choosed
                {
                    ready = true;
                }
                else//single directory choosed
                {
                    if (setting_page.getSetting_page_textbox_single_directory().TextLength == 0)//no path for single directory
                    {
                        ready = false;
                    }
                    else
                    {
                        ready = true;
                    }
                }
            }

            return ready;
        }

        //MultiDirectory checkbox Method
        public void MultiDirectoryCheckBoxChange()
        {
            if (setting_page.getSetting_page_checkbox_multiple_directory().Checked == true)
            {
                setting_page.getSetting_page_textbox_single_directory().Text = "";
                setting_page.getSetting_page_btn_clear_textbox().Enabled = true;
            }
            else
            {
                setting_page.getSetting_page_textbox_multiple_directory().Text = "";
                setting_page.getSetting_page_btn_clear_textbox().Enabled = false;
            }
        }

        //FullScan checkbox Method
        public void FullScanCheckBoxChange()
        {
            if (setting_page.getSetting_page_checkbox_full_scan().Checked == true)
            {
                FullScanSettingsActive();
            }
            else
            {
                FullScanSettingsClose();
            }
        }

        //Browse button Method
        public void BrowseDirectroyChange()
        {
            if (setting_page.getSetting_page_checkbox_multiple_directory().Checked == true)
            {
                openPathMenuMultiDirectory();
            }
            else
            {
                openPathMenuSingleDirectory();
            }
        }

        //Clear List button Method
        public void ClearList()
        {
            setting_page.getSetting_page_textbox_multiple_directory().Text = "";
        }

        //Exit Button method
        public void ClosePage()
        {
            if (ExitButtonOptions())
            {
                setting_page.Visible = false;
            }
        }

        //Copy Files checkbox method
        public void OpenClientPage()
        {
            if (setting_page.getClientPage() == null)
            {
                ClientPage new_client_page = new ClientPage();
                setting_page.setClientPage(new_client_page);

            }
            setting_page.getClientPage().Visible = true;
        }
    }
}
