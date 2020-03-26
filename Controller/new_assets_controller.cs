using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.db;
using WindowsFormsApp1.Extras;

namespace WindowsFormsApp1.Controller
{
    class new_assets_controller
    {
        data_holder memory = data_holder.Instance;
        New_Assets_Panel main;
        public new_assets_controller(New_Assets_Panel main)
        {
            this.main = main;
        }
        public void CancelClick(object sender, EventArgs e) 
        {
            new set_panel_changer(memory.GetPanelChanger(), new Assets_Panel().MainPanel);
        }
        public void AddClick(object sender, EventArgs e)
        {
            pop_up_medium pop_up = new pop_up_medium();
            pop_up.SetParentForm(memory.GetTaskbarForm());
            if (pop_up.GetChoosen())
            {
                if (main.CB_type.SelectedIndex == 0)
                {
                    Asset asset = new Asset();
                    asset.Name = main.TF_asset_name.Text;
                    asset.ValueTypeId = 1;
                    asset.StringValue = main.TF_asset_text.Text;
                    asset.Description = main.TF_asset_description.Text;
                    DBQueries.AddNewAsset(asset, AssetType.Text);

                } else
                {
                    Asset asset = new Asset();
                    asset.Name = main.TF_asset_name.Text;
                    asset.ValueTypeId = 4;
                    asset.CredentialUsername = main.TF_asset_text.Text;
                    asset.CredentialPassword = AesCryptography.Pasword.Encrypt(main.TF_asset_password.Text);
                    asset.Description = main.TF_asset_description.Text;
                    DBQueries.AddNewAsset(asset, AssetType.Credential);
                }
                new set_panel_changer(memory.GetPanelChanger(), new Assets_Panel().MainPanel);
            }
        }
        public void change_type(object sender, EventArgs e)
        {
            if(main.CB_type.SelectedIndex == 0)
            {
                main.Label_asset_password.Visible = false;
                main.TF_asset_password.Visible = false;
                main.Label_asset_text.Text = "Asset text";
            } else {
                main.Label_asset_password.Visible = true;
                main.TF_asset_password.Visible = true;
                main.Label_asset_text.Text = "Asset username";
            }
        }
    }
}
