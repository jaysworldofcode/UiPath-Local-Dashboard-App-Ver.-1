using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controller;
using WindowsFormsApp1.db;
using WindowsFormsApp1.Extras;

namespace WindowsFormsApp1
{
    class data_holder
    {
        //Variable instance
        #region
        String username = "John Doe";
        //---------------------Please don't change this----------------------------
        readonly String package_path = "C:\\Users\\" + Environment.UserName + "\\.nuget\\packages";
        readonly String package_install_path = "C:\\ProgramData\\UiPath\\Packages";
        //-------------------------------------------------------------------------
        readonly String assets_path = "D:\\C#\\Main\\WindowsFormsApp1\\Asset";
        readonly String main_path = "D:\\C#\\Main\\WindowsFormsApp1";
        static schedule_model schedule_model;
        queue_data_info data_info_queue;
        public String current_robot_run = null;
        Panel panel_change_taskbar;
        private static readonly object padlock = new object();
        private static data_holder instance = null;
        List<String> asset_choosen_details = new List<String>();
        Form TaskBar_Form = null;
        public String menuChoosen = "";
        Dashboard_Panel dashboard_panel;
        public String JobID;
        #endregion

        //Class Instance
        #region
        public static data_holder Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new data_holder();
                        schedule_model = new schedule_model();
                    }
                    return instance;
                }
            }
        }
        #endregion

        //Sub Class instance
        #region
        public List<String> GetAsset_choosen_details() { return asset_choosen_details; }
        public void SetDashboardPanel(Dashboard_Panel dashboard_panel) { this.dashboard_panel = dashboard_panel; }
        public Dashboard_Panel GetDashboardPanel() { return dashboard_panel; }
        public void SetPanelChanger(Panel panel_change_taskbar){ this.panel_change_taskbar = panel_change_taskbar; }
        public Panel GetPanelChanger() { return panel_change_taskbar; }
        public String GetAssetsPath() { return assets_path; }
        public String GetPackage_Path() { return package_path; }
        public String GetMainPath() { return main_path; }
        public String GetPackageInstallPath() { return package_install_path; }
        public schedule_model GetScheduleModel() { return schedule_model; }
        public void SetTaskbarForm(Form form) { TaskBar_Form = form; }
        public Form GetTaskbarForm() { return TaskBar_Form; }
        public String GetUsername() { return username; }
        public String GetJobID() { return JobID; }
        public void RetrieveScheduleModel() { schedule_model = new schedule_model(); }
        public queue_data_info GetDataQueueInfo() {

            if (data_info_queue == null)
            {
                data_info_queue = new queue_data_info();
                data_info_queue.Location = new Point(Cursor.Position.X + 40, Cursor.Position.Y);
            }

            return data_info_queue; 
        }
        #endregion
    }
}
