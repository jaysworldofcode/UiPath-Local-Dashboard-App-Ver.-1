using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Controller
{
    class asset_list_ui_controller
    {
        data_holder memory = data_holder.Instance;
        assets_list_ui main;
        public asset_list_ui_controller(assets_list_ui main)
        {
            this.main = main;
        }
        public void ViewPress(object sender, EventArgs e)
        {
            memory.GetAsset_choosen_details().Clear();
            memory.GetAsset_choosen_details().Add(main.asset_name);
            memory.GetAsset_choosen_details().Add(main.asset_description);
            memory.GetAsset_choosen_details().Add(main.asset_first_value);
            memory.GetAsset_choosen_details().Add(main.asset_second_value);
            memory.GetAsset_choosen_details().Add(main.asset_isGlobal.ToString());
            memory.GetAsset_choosen_details().Add(main.asset_id.ToString());
            memory.GetAsset_choosen_details().Add(main.asset_type);
            main.set_data_to_view();
        }
        public void MouseEnterMenu(object sender, EventArgs e)
        {
            main.main_panel.BackColor = Color.WhiteSmoke;
        }
        public void MouseLeaveMenu(object sender, EventArgs e)
        {
            main.main_panel.BackColor = Color.White;
            memory.GetDataQueueInfo().Hide();
        }
    }
}
