using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.db;
using WindowsFormsApp1.Extras;

namespace WindowsFormsApp1.Controller
{
    class assets_panel_controller
    {
        data_holder memory = data_holder.Instance;
        Assets_Panel main;
        public assets_panel_controller(Assets_Panel main)
        {
            this.main = main;
        }
        public void AddAssetsClick(object sender, EventArgs e)
        {
            new set_panel_changer(
                memory.GetPanelChanger(), 
                new New_Assets_Panel().MainPanel
             );
        }
        public void DeleteAssetsClick(object sender, EventArgs e)
        {
            /*if (!(memory.GetAsset_choosen_details().Count == 0))
            {
                pop_up_medium pop_up = new pop_up_medium();
                pop_up.SetParentForm(memory.GetTaskbarForm());
                if (pop_up.GetChoosen())
                {
                    new assets_db().DeleteAssets( memory.GetDB_conn(),
                        Convert.ToInt32(memory.GetAsset_choosen_details()[5])
                    );
                    new set_panel_changer(memory.GetPanelChanger(), new Assets_Panel().MainPanel);
                }
            }*/
        }
    }
}
