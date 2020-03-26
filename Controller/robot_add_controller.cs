using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Extras;

namespace WindowsFormsApp1.Controller
{
    class robot_add_controller
    {
        data_holder memory = data_holder.Instance;
        New_Robot_Panel main;
        public robot_add_controller(New_Robot_Panel main)
        {
            this.main = main;
        }
        public void CancelClick(object sender, EventArgs e)
        {
            new set_panel_changer(memory.GetPanelChanger(), new Packages_Panel().MainPanel);
        }
        public void AddClick(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(main.TF_package_path.Text) || !String.IsNullOrWhiteSpace(main.TF_package_path.Text))
            {
                if (File.Exists(memory.GetPackageInstallPath() + "\\" + Path.GetFileName(main.TF_package_path.Text)))
                    File.Delete(memory.GetPackageInstallPath() + "\\" + Path.GetFileName(main.TF_package_path.Text));
                File.Copy(main.TF_package_path.Text, memory.GetPackageInstallPath()+"\\"+Path.GetFileName(main.TF_package_path.Text));
                new set_panel_changer(memory.GetPanelChanger(), new Packages_Panel().MainPanel);
            }
        }
        public void BrowseClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                Console.WriteLine(file); // <-- Shows file size in debugging mode.
                try
                {
                    main.TF_package_path.Text = file;
                }
                catch (IOException)
                {
                }
            }
            Console.WriteLine(size); // <-- Shows file size in debugging mode.
            Console.WriteLine(result); // <-- For debugging use.
        }
    }
}
