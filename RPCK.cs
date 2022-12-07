using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace RandomPicker
{
    public partial class MainForm : MaterialForm
    {
        public List<string> nameList = new List<string>();
        public Random random = new Random();

        public MainForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple800, Primary.Purple900, Primary.Purple500, Accent.Purple200, TextShade.WHITE);
            mainMenuStrip.Renderer = new ToolStripProfessionalRenderer(new LightColorTable());
            switchToEN_subBtn.Enabled = false;
            lightMode_subBtn.Enabled = false;
        }

        #region RandomPicker_Main

        private void AddToList_Click(object sender, EventArgs e)
        {

            nameList.Add(addValue_TxtBx.Text);
            nameList_MltlnTxtBx.Text += addValue_TxtBx.Text + Environment.NewLine;
            addValue_TxtBx.Clear();

        }

        private void ShowResults_Click(object sender, EventArgs e)
        {
            if (switchToEN_subBtn.Enabled == false) { 
                if (nameList.Count >= 2 && nameList_MltlnTxtBx.Text != String.Empty)
                {
                    int index = random.Next(nameList.Count);
                    MessageBox.Show("The following element: " + nameList[index] + " have been choosed", "RPCK - Random Picker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nameList_MltlnTxtBx.Clear();
                }
                else
                {
                    MessageBox.Show("The list is empty. Try to add at least 2 elements !", "RPCK - Random Picker", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (nameList.Count >= 2 && nameList_MltlnTxtBx.Text != String.Empty)
                {
                    int index = random.Next(nameList.Count);
                    MessageBox.Show("L'élément suivant: " + nameList[index] + " a été choisi", "RPCK - Sélecteur aléatoire", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nameList_MltlnTxtBx.Clear();
                }
                else
                {
                    MessageBox.Show("La liste est vide. veuillez ajouter au moins 2 éléments !", "RPCK - Sélecteur aléatoire", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void EraseList_Click(object sender, EventArgs e)
        {
            if (nameList.Any()) //prevent IndexOutOfRangeException for empty list
            {
                nameList.RemoveAt(nameList.Count - 1);
                nameList_MltlnTxtBx.Text = nameList_MltlnTxtBx.Text.Remove(nameList_MltlnTxtBx.Text.LastIndexOf(Environment.NewLine));
            }
            else
            {
                nameList.Clear();
                nameList_MltlnTxtBx.Clear();
            }
        }
        #endregion

        #region StripMenu

        private void SwitchToEN_Click(object sender, EventArgs e)
        {
            this.Text = "RPCK - Random Picker";
            languages_MenuBtn.Text = "Languages";
            switchToEN_subBtn.Text = "Switch to English";
            switchToEN_subBtn.Enabled = false;
            switchToFR_subBtn.Text = "Switch to French";
            switchToFR_subBtn.Enabled = true;
            themes_MenuBtn.Text = "Themes";
            lightMode_subBtn.Text = "Set to light mode";
            darkMode_subBtn.Text = "Set to dark mode";
            setValues_RichTxtBx.Text = "SET YOUR VALUES";
            addValue_TxtBx.Hint = "ADD VALUE HERE";
            addValue_Btn.Text = "ADD VALUE TO LIST";
            enteredValues_RichTxtBx.Text = "YOUR ENTERED VALUES";
            result_RichTxtBx.Text = "RANDOM PICKER'S RESULT";
            seeResult_Btn.Text = "SEE RESULT";
        }

        private void SwitchToFR_Click(object sender, EventArgs e)
        {
            this.Text = "RPCK - Sélecteur aléatoire";
            languages_MenuBtn.Text = "Langues";
            switchToEN_subBtn.Text = "Basculer en Anglais";
            switchToEN_subBtn.Enabled = true;
            switchToFR_subBtn.Text = "Basculer en Français";
            switchToFR_subBtn.Enabled = false;
            themes_MenuBtn.Text = "Thèmes";
            lightMode_subBtn.Text = "Basculer en mode jour";
            darkMode_subBtn.Text = "Basculer en mode nuit";
            setValues_RichTxtBx.Text = "ENTRER LES ÉLÉMENTS";
            addValue_TxtBx.Hint = "ENTRER L'ÉLÉMENT ICI";
            addValue_Btn.Text = "AJOUTER l'ÉLÉMENT A LA LISTE";
            enteredValues_RichTxtBx.Text = "ÉLÉMENTS ENTRÉS";
            result_RichTxtBx.Text = "RÉSULTAT";
            seeResult_Btn.Text = "VOIR LE RÉSULTAT";
        }

        private void SetLightMode_Click(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple800, Primary.Purple900, Primary.Purple500, Accent.Purple200, TextShade.WHITE);
            mainMenuStrip.Renderer = new ToolStripProfessionalRenderer(new LightColorTable());
            darkMode_subBtn.ForeColor = Color.Black;
            darkMode_subBtn.Enabled = true;
            lightMode_subBtn.ForeColor = Color.Black;
            lightMode_subBtn.Enabled = false;
            switchToEN_subBtn.ForeColor = Color.Black;
            switchToFR_subBtn.ForeColor = Color.Black;
        }

        private void SetDarkMode_Click(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple800, Primary.Purple900, Primary.Purple500, Accent.Purple200, TextShade.WHITE);
            mainMenuStrip.Renderer = new ToolStripProfessionalRenderer(new DarkColorTable());
            darkMode_subBtn.ForeColor = Color.White;
            darkMode_subBtn.Enabled = false;
            lightMode_subBtn.ForeColor = Color.White;
            lightMode_subBtn.Enabled = true;
            switchToEN_subBtn.ForeColor = Color.White;
            switchToFR_subBtn.ForeColor = Color.White;
        }

        #endregion

        #region ColorTables

        public class DarkColorTable : ProfessionalColorTable
        {
            public override Color ToolStripDropDownBackground
            {
                get
                {
                    return Color.FromArgb(45, 45, 45);
                }
            }

            public override Color ImageMarginGradientBegin
            {
                get
                {
                    return Color.FromArgb(45, 45, 45);
                }
            }

            public override Color ImageMarginGradientMiddle
            {
                get
                {
                    return Color.FromArgb(45, 45, 45);
                }
            }

            public override Color ImageMarginGradientEnd
            {
                get
                {
                    return Color.FromArgb(45, 45, 45);
                }
            }

            public override Color MenuBorder
            {
                get
                {
                    return Color.Black;
                }
            }

            public override Color MenuItemBorder
            {
                get
                {
                    return Color.Black;
                }
            }

            public override Color MenuItemSelected
            {
                get
                {
                    return Color.FromArgb(45, 45, 45);
                }
            }

            public override Color MenuStripGradientBegin
            {
                get
                {
                    return Color.FromArgb(45, 45, 45);
                }
            }

            public override Color MenuStripGradientEnd
            {
                get
                {
                    return Color.FromArgb(45, 45, 45);
                }
            }

            public override Color MenuItemSelectedGradientBegin
            {
                get
                {
                    return Color.FromArgb(45, 45, 45);
                }
            }

            public override Color MenuItemSelectedGradientEnd
            {
                get
                {
                    return Color.FromArgb(45, 45, 45);
                }
            }

            public override Color MenuItemPressedGradientBegin
            {
                get
                {
                    return Color.FromArgb(45, 45, 45);
                }
            }

            public override Color MenuItemPressedGradientEnd
            {
                get
                {
                    return Color.FromArgb(45, 45, 45);
                }
            }
        }
        public class LightColorTable : ProfessionalColorTable
        {
            public override Color ToolStripDropDownBackground
            {
                get
                {
                    return Color.White;
                }
            }

            public override Color ImageMarginGradientBegin
            {
                get
                {
                    return Color.White;
                }
            }

            public override Color ImageMarginGradientMiddle
            {
                get
                {
                    return Color.White;
                }
            }

            public override Color ImageMarginGradientEnd
            {
                get
                {
                    return Color.White;
                }
            }

            public override Color MenuBorder
            {
                get
                {
                    return Color.Black;
                }
            }

            public override Color MenuItemBorder
            {
                get
                {
                    return Color.Black;
                }
            }

            public override Color MenuItemSelected
            {
                get
                {
                    return Color.White;
                }
            }

            public override Color MenuStripGradientBegin
            {
                get
                {
                    return Color.White;
                }
            }

            public override Color MenuStripGradientEnd
            {
                get
                {
                    return Color.White;
                }
            }

            public override Color MenuItemSelectedGradientBegin
            {
                get
                {
                    return Color.White;
                }
            }

            public override Color MenuItemSelectedGradientEnd
            {
                get
                {
                    return Color.White;
                }
            }

            public override Color MenuItemPressedGradientBegin
            {
                get
                {
                    return Color.White;
                }
            }

            public override Color MenuItemPressedGradientEnd
            {
                get
                {
                    return Color.White;
                }
            }
        } 
        #endregion

    }
}