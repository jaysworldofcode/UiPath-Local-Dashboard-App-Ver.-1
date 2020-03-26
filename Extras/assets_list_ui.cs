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

namespace WindowsFormsApp1
{
    public partial class assets_list_ui : Form
    {
        asset_list_ui_controller controller;
        data_holder memory = data_holder.Instance;
        Assets_Panel assets_main_panel;
        public int asset_id;
        public String asset_name;
        public String asset_description;
        public String asset_first_value;
        public String asset_second_value;
        public Boolean asset_isGlobal;
        public String asset_type;
        public assets_list_ui()
        {
            InitializeComponent();
            Self_Init();
        }
        void Self_Init()
        {
            controller = new asset_list_ui_controller(this);
            BT_View.Click += new EventHandler(controller.ViewPress);

            main_panel.MouseHover += new EventHandler(controller.MouseEnterMenu);
            main_panel.MouseLeave += new EventHandler(controller.MouseLeaveMenu);
            for (int count = 0; count < main_panel.Controls.Count; count++)
            {
                main_panel.Controls[count].MouseHover += new EventHandler(controller.MouseEnterMenu);
                main_panel.Controls[count].MouseLeave += new EventHandler(controller.MouseLeaveMenu);
            }
        }
        public void set_data(
            int asset_id,
            String asset_name,
            String asset_description,
            String asset_first_value,
            String asset_second_value,
            String image_path,
            Assets_Panel assets_main_panel,
            String asset_type)
        {
            this.asset_id = asset_id;
            this.asset_name = asset_name;
            this.asset_description = asset_description;
            this.asset_first_value = asset_first_value;
            this.asset_second_value = "....";
            this.asset_type = asset_type;

            label_asset_name.Text = asset_name;
            label_asset_value.Text = asset_first_value;

            image_type.Image = System.Drawing.Bitmap.FromFile(image_path);
            image_type.Width = 100;
            image_type.Width = 30;
            this.assets_main_panel = assets_main_panel;
        }
        public void set_data_to_view() { assets_main_panel.set_data_to_view(); }
    }
}
