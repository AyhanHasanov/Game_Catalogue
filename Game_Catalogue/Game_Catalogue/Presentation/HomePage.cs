using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Game_Catalogue.Presentation
{
    public partial class HomePage : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public HomePage()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme
                (MaterialSkin.Primary.Purple500, MaterialSkin.Primary.Purple700,
                MaterialSkin.Primary.Red100, MaterialSkin.Accent.Cyan700, MaterialSkin.TextShade.WHITE);

            this.ForeColor = Color.White;
        }
    }
}
