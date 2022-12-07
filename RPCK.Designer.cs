namespace RandomPicker
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addValue_TxtBx = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.addValue_Btn = new MaterialSkin.Controls.MaterialButton();
            this.result_RichTxtBx = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.seeResult_Btn = new MaterialSkin.Controls.MaterialButton();
            this.nameList_MltlnTxtBx = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.languages_MenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.switchToEN_subBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.switchToFR_subBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.themes_MenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.lightMode_subBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.darkMode_subBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.setValues_RichTxtBx = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.enteredValues_RichTxtBx = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.eraseBox_Btn = new MaterialSkin.Controls.MaterialButton();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // addValue_TxtBx
            // 
            this.addValue_TxtBx.AllowPromptAsInput = true;
            this.addValue_TxtBx.AnimateReadOnly = false;
            this.addValue_TxtBx.AsciiOnly = false;
            this.addValue_TxtBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addValue_TxtBx.BeepOnError = false;
            this.addValue_TxtBx.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.addValue_TxtBx.Depth = 0;
            this.addValue_TxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.addValue_TxtBx.HidePromptOnLeave = false;
            this.addValue_TxtBx.HideSelection = true;
            this.addValue_TxtBx.Hint = "ADD VALUE HERE";
            this.addValue_TxtBx.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.addValue_TxtBx.LeadingIcon = null;
            this.addValue_TxtBx.Location = new System.Drawing.Point(7, 174);
            this.addValue_TxtBx.Mask = "";
            this.addValue_TxtBx.MaxLength = 32767;
            this.addValue_TxtBx.MouseState = MaterialSkin.MouseState.OUT;
            this.addValue_TxtBx.Name = "addValue_TxtBx";
            this.addValue_TxtBx.PasswordChar = '\0';
            this.addValue_TxtBx.PrefixSuffixText = null;
            this.addValue_TxtBx.PromptChar = '_';
            this.addValue_TxtBx.ReadOnly = false;
            this.addValue_TxtBx.RejectInputOnFirstFailure = false;
            this.addValue_TxtBx.ResetOnPrompt = true;
            this.addValue_TxtBx.ResetOnSpace = true;
            this.addValue_TxtBx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addValue_TxtBx.SelectedText = "";
            this.addValue_TxtBx.SelectionLength = 0;
            this.addValue_TxtBx.SelectionStart = 0;
            this.addValue_TxtBx.ShortcutsEnabled = true;
            this.addValue_TxtBx.Size = new System.Drawing.Size(244, 48);
            this.addValue_TxtBx.SkipLiterals = true;
            this.addValue_TxtBx.TabIndex = 1;
            this.addValue_TxtBx.TabStop = false;
            this.addValue_TxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.addValue_TxtBx.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.addValue_TxtBx.TrailingIcon = null;
            this.addValue_TxtBx.UseSystemPasswordChar = false;
            this.addValue_TxtBx.ValidatingType = null;
            // 
            // addValue_Btn
            // 
            this.addValue_Btn.AutoSize = false;
            this.addValue_Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addValue_Btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addValue_Btn.Depth = 0;
            this.addValue_Btn.HighEmphasis = true;
            this.addValue_Btn.Icon = null;
            this.addValue_Btn.Location = new System.Drawing.Point(7, 231);
            this.addValue_Btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addValue_Btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.addValue_Btn.Name = "addValue_Btn";
            this.addValue_Btn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addValue_Btn.Size = new System.Drawing.Size(244, 58);
            this.addValue_Btn.TabIndex = 2;
            this.addValue_Btn.Text = "ADD VALUE TO LIST";
            this.addValue_Btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addValue_Btn.UseAccentColor = false;
            this.addValue_Btn.UseVisualStyleBackColor = true;
            this.addValue_Btn.Click += new System.EventHandler(this.AddToList_Click);
            // 
            // result_RichTxtBx
            // 
            this.result_RichTxtBx.AllowPromptAsInput = true;
            this.result_RichTxtBx.AnimateReadOnly = false;
            this.result_RichTxtBx.AsciiOnly = false;
            this.result_RichTxtBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.result_RichTxtBx.BeepOnError = false;
            this.result_RichTxtBx.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.result_RichTxtBx.Depth = 0;
            this.result_RichTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.result_RichTxtBx.HidePromptOnLeave = false;
            this.result_RichTxtBx.HideSelection = true;
            this.result_RichTxtBx.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.result_RichTxtBx.LeadingIcon = null;
            this.result_RichTxtBx.Location = new System.Drawing.Point(507, 120);
            this.result_RichTxtBx.Mask = "";
            this.result_RichTxtBx.MaxLength = 32767;
            this.result_RichTxtBx.MouseState = MaterialSkin.MouseState.OUT;
            this.result_RichTxtBx.Name = "result_RichTxtBx";
            this.result_RichTxtBx.PasswordChar = '\0';
            this.result_RichTxtBx.PrefixSuffixText = null;
            this.result_RichTxtBx.PromptChar = '_';
            this.result_RichTxtBx.ReadOnly = false;
            this.result_RichTxtBx.RejectInputOnFirstFailure = false;
            this.result_RichTxtBx.ResetOnPrompt = true;
            this.result_RichTxtBx.ResetOnSpace = true;
            this.result_RichTxtBx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.result_RichTxtBx.SelectedText = "";
            this.result_RichTxtBx.SelectionLength = 0;
            this.result_RichTxtBx.SelectionStart = 0;
            this.result_RichTxtBx.ShortcutsEnabled = true;
            this.result_RichTxtBx.Size = new System.Drawing.Size(244, 48);
            this.result_RichTxtBx.SkipLiterals = true;
            this.result_RichTxtBx.TabIndex = 49;
            this.result_RichTxtBx.TabStop = false;
            this.result_RichTxtBx.Text = "RANDOM PICKER\'S RESULT";
            this.result_RichTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.result_RichTxtBx.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.result_RichTxtBx.TrailingIcon = null;
            this.result_RichTxtBx.UseSystemPasswordChar = false;
            this.result_RichTxtBx.ValidatingType = null;
            // 
            // seeResult_Btn
            // 
            this.seeResult_Btn.AutoSize = false;
            this.seeResult_Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.seeResult_Btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.seeResult_Btn.Depth = 0;
            this.seeResult_Btn.HighEmphasis = true;
            this.seeResult_Btn.Icon = null;
            this.seeResult_Btn.Location = new System.Drawing.Point(507, 177);
            this.seeResult_Btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.seeResult_Btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.seeResult_Btn.Name = "seeResult_Btn";
            this.seeResult_Btn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.seeResult_Btn.Size = new System.Drawing.Size(244, 58);
            this.seeResult_Btn.TabIndex = 4;
            this.seeResult_Btn.Text = "SEE RESULT";
            this.seeResult_Btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.seeResult_Btn.UseAccentColor = false;
            this.seeResult_Btn.UseVisualStyleBackColor = true;
            this.seeResult_Btn.Click += new System.EventHandler(this.ShowResults_Click);
            // 
            // nameList_MltlnTxtBx
            // 
            this.nameList_MltlnTxtBx.AnimateReadOnly = false;
            this.nameList_MltlnTxtBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.nameList_MltlnTxtBx.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.nameList_MltlnTxtBx.Depth = 0;
            this.nameList_MltlnTxtBx.HideSelection = true;
            this.nameList_MltlnTxtBx.Location = new System.Drawing.Point(257, 174);
            this.nameList_MltlnTxtBx.MaxLength = 32767;
            this.nameList_MltlnTxtBx.MouseState = MaterialSkin.MouseState.OUT;
            this.nameList_MltlnTxtBx.Name = "nameList_MltlnTxtBx";
            this.nameList_MltlnTxtBx.PasswordChar = '\0';
            this.nameList_MltlnTxtBx.ReadOnly = false;
            this.nameList_MltlnTxtBx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameList_MltlnTxtBx.SelectedText = "";
            this.nameList_MltlnTxtBx.SelectionLength = 0;
            this.nameList_MltlnTxtBx.SelectionStart = 0;
            this.nameList_MltlnTxtBx.ShortcutsEnabled = true;
            this.nameList_MltlnTxtBx.Size = new System.Drawing.Size(244, 200);
            this.nameList_MltlnTxtBx.TabIndex = 18;
            this.nameList_MltlnTxtBx.TabStop = false;
            this.nameList_MltlnTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nameList_MltlnTxtBx.UseSystemPasswordChar = false;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languages_MenuBtn,
            this.themes_MenuBtn});
            this.mainMenuStrip.Location = new System.Drawing.Point(3, 64);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(754, 28);
            this.mainMenuStrip.TabIndex = 8;
            this.mainMenuStrip.Text = "menuStrip";
            // 
            // languages_MenuBtn
            // 
            this.languages_MenuBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.switchToEN_subBtn,
            this.switchToFR_subBtn});
            this.languages_MenuBtn.Name = "languages_MenuBtn";
            this.languages_MenuBtn.Size = new System.Drawing.Size(94, 24);
            this.languages_MenuBtn.Text = "Languages";
            // 
            // switchToEN_subBtn
            // 
            this.switchToEN_subBtn.Name = "switchToEN_subBtn";
            this.switchToEN_subBtn.Size = new System.Drawing.Size(204, 26);
            this.switchToEN_subBtn.Text = "Switch to English";
            this.switchToEN_subBtn.Click += new System.EventHandler(this.SwitchToEN_Click);
            // 
            // switchToFR_subBtn
            // 
            this.switchToFR_subBtn.Name = "switchToFR_subBtn";
            this.switchToFR_subBtn.Size = new System.Drawing.Size(204, 26);
            this.switchToFR_subBtn.Text = "Switch to French";
            this.switchToFR_subBtn.Click += new System.EventHandler(this.SwitchToFR_Click);
            // 
            // themes_MenuBtn
            // 
            this.themes_MenuBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lightMode_subBtn,
            this.darkMode_subBtn});
            this.themes_MenuBtn.Name = "themes_MenuBtn";
            this.themes_MenuBtn.Size = new System.Drawing.Size(74, 24);
            this.themes_MenuBtn.Text = "Themes";
            // 
            // lightMode_subBtn
            // 
            this.lightMode_subBtn.Name = "lightMode_subBtn";
            this.lightMode_subBtn.Size = new System.Drawing.Size(206, 26);
            this.lightMode_subBtn.Text = "Set in light mode";
            this.lightMode_subBtn.Click += new System.EventHandler(this.SetLightMode_Click);
            // 
            // darkMode_subBtn
            // 
            this.darkMode_subBtn.Name = "darkMode_subBtn";
            this.darkMode_subBtn.Size = new System.Drawing.Size(206, 26);
            this.darkMode_subBtn.Text = "Set in dark mode";
            this.darkMode_subBtn.Click += new System.EventHandler(this.SetDarkMode_Click);
            // 
            // setValues_RichTxtBx
            // 
            this.setValues_RichTxtBx.AllowPromptAsInput = true;
            this.setValues_RichTxtBx.AnimateReadOnly = false;
            this.setValues_RichTxtBx.AsciiOnly = false;
            this.setValues_RichTxtBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.setValues_RichTxtBx.BeepOnError = false;
            this.setValues_RichTxtBx.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.setValues_RichTxtBx.Depth = 0;
            this.setValues_RichTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.setValues_RichTxtBx.HidePromptOnLeave = false;
            this.setValues_RichTxtBx.HideSelection = true;
            this.setValues_RichTxtBx.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.setValues_RichTxtBx.LeadingIcon = null;
            this.setValues_RichTxtBx.Location = new System.Drawing.Point(7, 120);
            this.setValues_RichTxtBx.Mask = "";
            this.setValues_RichTxtBx.MaxLength = 32767;
            this.setValues_RichTxtBx.MouseState = MaterialSkin.MouseState.OUT;
            this.setValues_RichTxtBx.Name = "setValues_RichTxtBx";
            this.setValues_RichTxtBx.PasswordChar = '\0';
            this.setValues_RichTxtBx.PrefixSuffixText = null;
            this.setValues_RichTxtBx.PromptChar = '_';
            this.setValues_RichTxtBx.ReadOnly = false;
            this.setValues_RichTxtBx.RejectInputOnFirstFailure = false;
            this.setValues_RichTxtBx.ResetOnPrompt = true;
            this.setValues_RichTxtBx.ResetOnSpace = true;
            this.setValues_RichTxtBx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.setValues_RichTxtBx.SelectedText = "";
            this.setValues_RichTxtBx.SelectionLength = 0;
            this.setValues_RichTxtBx.SelectionStart = 0;
            this.setValues_RichTxtBx.ShortcutsEnabled = true;
            this.setValues_RichTxtBx.Size = new System.Drawing.Size(244, 48);
            this.setValues_RichTxtBx.SkipLiterals = true;
            this.setValues_RichTxtBx.TabIndex = 45;
            this.setValues_RichTxtBx.TabStop = false;
            this.setValues_RichTxtBx.Text = "SET YOUR VALUES";
            this.setValues_RichTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.setValues_RichTxtBx.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.setValues_RichTxtBx.TrailingIcon = null;
            this.setValues_RichTxtBx.UseSystemPasswordChar = false;
            this.setValues_RichTxtBx.ValidatingType = null;
            // 
            // enteredValues_RichTxtBx
            // 
            this.enteredValues_RichTxtBx.AllowPromptAsInput = true;
            this.enteredValues_RichTxtBx.AnimateReadOnly = false;
            this.enteredValues_RichTxtBx.AsciiOnly = false;
            this.enteredValues_RichTxtBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.enteredValues_RichTxtBx.BeepOnError = false;
            this.enteredValues_RichTxtBx.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.enteredValues_RichTxtBx.Depth = 0;
            this.enteredValues_RichTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.enteredValues_RichTxtBx.HidePromptOnLeave = false;
            this.enteredValues_RichTxtBx.HideSelection = true;
            this.enteredValues_RichTxtBx.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.enteredValues_RichTxtBx.LeadingIcon = null;
            this.enteredValues_RichTxtBx.Location = new System.Drawing.Point(257, 120);
            this.enteredValues_RichTxtBx.Mask = "";
            this.enteredValues_RichTxtBx.MaxLength = 32767;
            this.enteredValues_RichTxtBx.MouseState = MaterialSkin.MouseState.OUT;
            this.enteredValues_RichTxtBx.Name = "enteredValues_RichTxtBx";
            this.enteredValues_RichTxtBx.PasswordChar = '\0';
            this.enteredValues_RichTxtBx.PrefixSuffixText = null;
            this.enteredValues_RichTxtBx.PromptChar = '_';
            this.enteredValues_RichTxtBx.ReadOnly = false;
            this.enteredValues_RichTxtBx.RejectInputOnFirstFailure = false;
            this.enteredValues_RichTxtBx.ResetOnPrompt = true;
            this.enteredValues_RichTxtBx.ResetOnSpace = true;
            this.enteredValues_RichTxtBx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.enteredValues_RichTxtBx.SelectedText = "";
            this.enteredValues_RichTxtBx.SelectionLength = 0;
            this.enteredValues_RichTxtBx.SelectionStart = 0;
            this.enteredValues_RichTxtBx.ShortcutsEnabled = true;
            this.enteredValues_RichTxtBx.Size = new System.Drawing.Size(244, 48);
            this.enteredValues_RichTxtBx.SkipLiterals = true;
            this.enteredValues_RichTxtBx.TabIndex = 47;
            this.enteredValues_RichTxtBx.TabStop = false;
            this.enteredValues_RichTxtBx.Text = "YOUR ENTERED VALUES:";
            this.enteredValues_RichTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.enteredValues_RichTxtBx.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.enteredValues_RichTxtBx.TrailingIcon = null;
            this.enteredValues_RichTxtBx.UseSystemPasswordChar = false;
            this.enteredValues_RichTxtBx.ValidatingType = null;
            // 
            // eraseBox_Btn
            // 
            this.eraseBox_Btn.AutoSize = false;
            this.eraseBox_Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.eraseBox_Btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.eraseBox_Btn.Depth = 0;
            this.eraseBox_Btn.HighEmphasis = true;
            this.eraseBox_Btn.Icon = null;
            this.eraseBox_Btn.Location = new System.Drawing.Point(257, 383);
            this.eraseBox_Btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.eraseBox_Btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.eraseBox_Btn.Name = "eraseBox_Btn";
            this.eraseBox_Btn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.eraseBox_Btn.Size = new System.Drawing.Size(244, 58);
            this.eraseBox_Btn.TabIndex = 50;
            this.eraseBox_Btn.Text = "ERASE LIST";
            this.eraseBox_Btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.eraseBox_Btn.UseAccentColor = false;
            this.eraseBox_Btn.UseVisualStyleBackColor = true;
            this.eraseBox_Btn.Click += new System.EventHandler(this.EraseList_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 450);
            this.Controls.Add(this.eraseBox_Btn);
            this.Controls.Add(this.enteredValues_RichTxtBx);
            this.Controls.Add(this.setValues_RichTxtBx);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.nameList_MltlnTxtBx);
            this.Controls.Add(this.seeResult_Btn);
            this.Controls.Add(this.addValue_Btn);
            this.Controls.Add(this.addValue_TxtBx);
            this.Controls.Add(this.result_RichTxtBx);
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximumSize = new System.Drawing.Size(760, 450);
            this.MinimumSize = new System.Drawing.Size(760, 450);
            this.Name = "MainForm";
            this.Text = "RPCK - Random Picker";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialMaskedTextBox addValue_TxtBx;
        private MaterialSkin.Controls.MaterialButton addValue_Btn;
        private MaterialSkin.Controls.MaterialMaskedTextBox result_RichTxtBx;
        private MaterialSkin.Controls.MaterialButton seeResult_Btn;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 nameList_MltlnTxtBx;
        private MenuStrip mainMenuStrip;
        private ToolStripMenuItem languages_MenuBtn;
        private ToolStripMenuItem themes_MenuBtn;
        private MaterialSkin.Controls.MaterialMaskedTextBox setValues_RichTxtBx;
        private MaterialSkin.Controls.MaterialMaskedTextBox enteredValues_RichTxtBx;
        private MaterialSkin.Controls.MaterialButton eraseBox_Btn;
        private ToolStripMenuItem switchToEN_subBtn;
        private ToolStripMenuItem switchToFR_subBtn;
        private ToolStripMenuItem lightMode_subBtn;
        private ToolStripMenuItem darkMode_subBtn;
    }
}