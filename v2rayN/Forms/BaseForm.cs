using MaterialSkin;
using System;
using System.Drawing;
using System.Windows.Forms;
using v2rayN.Mode;

namespace v2rayN.Forms
{
    public partial class BaseForm : MaterialSkin.Controls.MaterialForm
    {
        protected static Config config;
        protected static System.Drawing.Icon icon;

        public BaseForm()
        {
            InitializeComponent();
            var matskin = MaterialSkinManager.Instance;
            InitializeComponent();
            matskin.AddFormToManage(this);
            Load += BaseForm_Load;
            LoadCustomIcon();
        }

        private void LoadCustomIcon()
        {
            try
            {
                if (icon == null)
                {
                    string file = Utils.GetPath(Global.CustomIconName);
                    if (!System.IO.File.Exists(file))
                    {
                        return;
                    }
                    icon = new System.Drawing.Icon(file);
                }
                this.Icon = icon;
            }
            catch (Exception e)
            {
                Utils.SaveLog($"Loading custom icon failed: {e.Message}");
            }
        }

        public static int counttheme=0;
        private void BaseForm_Load(object sender, EventArgs e)
        {
           
            if (counttheme<=0)
            {
                SkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                MaterialSkinManager.Instance.ColorScheme = new ColorScheme(Color.Tomato, Color.Tomato,
                    Color.GreenYellow, Color.Chocolate, TextShade.WHITE);
            }
         counttheme++;

        }
    }
}
