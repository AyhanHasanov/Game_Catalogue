using MaterialSkin.Controls;

namespace Game_Catalogue
{

    public partial class LogIn_Page : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public LogIn_Page()
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