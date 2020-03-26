using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controller;
using WindowsFormsApp1.db;
using WindowsFormsApp1.Extras;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class Assets_Panel : Form
    {
        assets_panel_controller controller;
        data_holder memory = data_holder.Instance;
        int getY;

        public Assets_Panel()
        {
            InitializeComponent();
            Self_Init();
        }
        void Self_Init()
        {
            attach_model_data();
            controller = new assets_panel_controller(this);
            new set_button_invisible(BT_AddAssets, System.Drawing.Bitmap.FromFile(memory.GetAssetsPath() + "\\Image\\plus-circle.png"));
            BT_AddAssets.Click += new EventHandler(controller.AddAssetsClick);
            BT_delete.Click += new EventHandler(controller.DeleteAssetsClick);
            BT_AddAssets.Text = null;
            new create_rounded_button(BT_AddAssets);
            getY = BT_update.Location.Y;
        }
        void attach_model_data()
        {
            int count = 0;
            foreach (var item in DBQueries.getAllAssets())
            {
                String image_path;
                if (item.ValueTypeId.Equals(1))
                {
                    image_path = memory.GetAssetsPath() + "\\Image\\folder.png";
                }
                else
                {
                    image_path = memory.GetAssetsPath() + "\\Image\\lock.png";
                }
                assets_list_ui asset_ui = new assets_list_ui();
                asset_ui.set_data(
                    item.ID, 
                    item.Name, 
                    item.Description, 
                    item.StringValue, 
                    "",
                    image_path,
                    this,
                    item.ValueTypeId.ToString()
                );
                Panel panel = asset_ui.main_panel;
                panel.Location = new Point(0, panel.Height * count);
                list_panel.Controls.Add(panel);
                new size_listener(list_panel, panel, panel.Height, 0);
                list_panel.Height = list_panel.Height + panel.Height;
                count++;
            }
        }
        public void set_data_to_view()
        {
            TF_asset_name.Text = memory.GetAsset_choosen_details()[0];
            TF_asset_description.Text = memory.GetAsset_choosen_details()[1];
            TF_asset_text.Text = memory.GetAsset_choosen_details()[2];
            TF_asset_password.Text = memory.GetAsset_choosen_details()[3];

            if (memory.GetAsset_choosen_details()[6].Equals("2"))
            {
                Label_asset_text.Text = "Asset username";
                TF_asset_password.Visible = true;
                Label_asset_password.Visible = true;
            } else {
                Label_asset_text.Text = "Asset text";
                TF_asset_password.Visible = false;
                Label_asset_password.Visible = false;
            }
        }
    }
}
