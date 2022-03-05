using MaterialSkin.Controls;

namespace Game_Catalogue
{

    public partial class Form1 : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public Form1()
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