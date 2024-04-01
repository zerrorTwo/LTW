namespace DoAnLTW
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panelLg = new Guna.UI.WinForms.GunaElipsePanel();
            this.btnLogin = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnRegister = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.tBUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.tBPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.tBComfirmPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnComfimRegis = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lbRegister = new System.Windows.Forms.Label();
            this.panelLg.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLg
            // 
            this.panelLg.BackColor = System.Drawing.Color.Transparent;
            this.panelLg.BaseColor = System.Drawing.Color.GhostWhite;
            this.panelLg.Controls.Add(this.tBComfirmPass);
            this.panelLg.Controls.Add(this.tBPassword);
            this.panelLg.Controls.Add(this.tBUserName);
            this.panelLg.Location = new System.Drawing.Point(251, 133);
            this.panelLg.Name = "panelLg";
            this.panelLg.Radius = 50;
            this.panelLg.Size = new System.Drawing.Size(441, 223);
            this.panelLg.TabIndex = 0;
            this.panelLg.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLg_Paint);
            // 
            // btnLogin
            // 
            this.btnLogin.AllowAnimations = true;
            this.btnLogin.AllowMouseEffects = true;
            this.btnLogin.AllowToggling = false;
            this.btnLogin.AnimationSpeed = 200;
            this.btnLogin.AutoGenerateColors = false;
            this.btnLogin.AutoRoundBorders = false;
            this.btnLogin.AutoSizeLeftIcon = true;
            this.btnLogin.AutoSizeRightIcon = true;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackColor1 = System.Drawing.Color.LimeGreen;
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.btnLogin.ButtonText = "Đăng nhập";
            this.btnLogin.ButtonTextMarginLeft = 0;
            this.btnLogin.ColorContrastOnClick = 45;
            this.btnLogin.ColorContrastOnHover = 45;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnLogin.CustomizableEdges = borderEdges1;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogin.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.btnLogin.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLogin.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLogin.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnLogin.IconMarginLeft = 11;
            this.btnLogin.IconPadding = 10;
            this.btnLogin.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnLogin.IconSize = 25;
            this.btnLogin.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnLogin.IdleBorderRadius = 20;
            this.btnLogin.IdleBorderThickness = 1;
            this.btnLogin.IdleFillColor = System.Drawing.Color.LimeGreen;
            this.btnLogin.IdleIconLeftImage = null;
            this.btnLogin.IdleIconRightImage = null;
            this.btnLogin.IndicateFocus = false;
            this.btnLogin.Location = new System.Drawing.Point(251, 442);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogin.OnDisabledState.BorderRadius = 20;
            this.btnLogin.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogin.OnDisabledState.BorderThickness = 0;
            this.btnLogin.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLogin.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLogin.OnDisabledState.IconLeftImage = null;
            this.btnLogin.OnDisabledState.IconRightImage = null;
            this.btnLogin.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogin.onHoverState.BorderRadius = 20;
            this.btnLogin.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogin.onHoverState.BorderThickness = 0;
            this.btnLogin.onHoverState.FillColor = System.Drawing.Color.Green;
            this.btnLogin.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnLogin.onHoverState.IconLeftImage = null;
            this.btnLogin.onHoverState.IconRightImage = null;
            this.btnLogin.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogin.OnIdleState.BorderRadius = 20;
            this.btnLogin.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.btnLogin.OnIdleState.BorderThickness = 0;
            this.btnLogin.OnIdleState.FillColor = System.Drawing.Color.LimeGreen;
            this.btnLogin.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnLogin.OnIdleState.IconLeftImage = null;
            this.btnLogin.OnIdleState.IconRightImage = null;
            this.btnLogin.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLogin.OnPressedState.BorderRadius = 20;
            this.btnLogin.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogin.OnPressedState.BorderThickness = 0;
            this.btnLogin.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLogin.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnLogin.OnPressedState.IconLeftImage = null;
            this.btnLogin.OnPressedState.IconRightImage = null;
            this.btnLogin.Size = new System.Drawing.Size(187, 60);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogin.TextMarginLeft = 0;
            this.btnLogin.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnLogin.UseDefaultRadiusAndThickness = true;
            // 
            // btnRegister
            // 
            this.btnRegister.AllowAnimations = true;
            this.btnRegister.AllowMouseEffects = true;
            this.btnRegister.AllowToggling = false;
            this.btnRegister.AnimationSpeed = 200;
            this.btnRegister.AutoGenerateColors = false;
            this.btnRegister.AutoRoundBorders = false;
            this.btnRegister.AutoSizeLeftIcon = true;
            this.btnRegister.AutoSizeRightIcon = true;
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.BackColor1 = System.Drawing.Color.WhiteSmoke;
            this.btnRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegister.BackgroundImage")));
            this.btnRegister.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.btnRegister.ButtonText = "Đăng kí";
            this.btnRegister.ButtonTextMarginLeft = 0;
            this.btnRegister.ColorContrastOnClick = 45;
            this.btnRegister.ColorContrastOnHover = 45;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnRegister.CustomizableEdges = borderEdges2;
            this.btnRegister.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRegister.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.btnRegister.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRegister.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnRegister.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.Gray;
            this.btnRegister.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnRegister.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnRegister.IconMarginLeft = 11;
            this.btnRegister.IconPadding = 10;
            this.btnRegister.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegister.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnRegister.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnRegister.IconSize = 25;
            this.btnRegister.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnRegister.IdleBorderRadius = 20;
            this.btnRegister.IdleBorderThickness = 1;
            this.btnRegister.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegister.IdleIconLeftImage = null;
            this.btnRegister.IdleIconRightImage = null;
            this.btnRegister.IndicateFocus = false;
            this.btnRegister.Location = new System.Drawing.Point(505, 442);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnRegister.OnDisabledState.BorderRadius = 20;
            this.btnRegister.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRegister.OnDisabledState.BorderThickness = 0;
            this.btnRegister.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRegister.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnRegister.OnDisabledState.IconLeftImage = null;
            this.btnRegister.OnDisabledState.IconRightImage = null;
            this.btnRegister.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnRegister.onHoverState.BorderRadius = 20;
            this.btnRegister.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRegister.onHoverState.BorderThickness = 0;
            this.btnRegister.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnRegister.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnRegister.onHoverState.IconLeftImage = null;
            this.btnRegister.onHoverState.IconRightImage = null;
            this.btnRegister.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnRegister.OnIdleState.BorderRadius = 20;
            this.btnRegister.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.btnRegister.OnIdleState.BorderThickness = 0;
            this.btnRegister.OnIdleState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegister.OnIdleState.ForeColor = System.Drawing.Color.Gray;
            this.btnRegister.OnIdleState.IconLeftImage = null;
            this.btnRegister.OnIdleState.IconRightImage = null;
            this.btnRegister.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnRegister.OnPressedState.BorderRadius = 20;
            this.btnRegister.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRegister.OnPressedState.BorderThickness = 0;
            this.btnRegister.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnRegister.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnRegister.OnPressedState.IconLeftImage = null;
            this.btnRegister.OnPressedState.IconRightImage = null;
            this.btnRegister.Size = new System.Drawing.Size(187, 60);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegister.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRegister.TextMarginLeft = 0;
            this.btnRegister.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnRegister.UseDefaultRadiusAndThickness = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // tBUserName
            // 
            this.tBUserName.BorderColor = System.Drawing.Color.Transparent;
            this.tBUserName.BorderRadius = 20;
            this.tBUserName.BorderThickness = 0;
            this.tBUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tBUserName.DefaultText = "";
            this.tBUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tBUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tBUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tBUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tBUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tBUserName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tBUserName.Location = new System.Drawing.Point(36, 48);
            this.tBUserName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tBUserName.Name = "tBUserName";
            this.tBUserName.PasswordChar = '\0';
            this.tBUserName.PlaceholderText = "UserName";
            this.tBUserName.SelectedText = "";
            this.tBUserName.Size = new System.Drawing.Size(366, 45);
            this.tBUserName.TabIndex = 2;
            this.tBUserName.TextChanged += new System.EventHandler(this.tBUserName_TextChanged);
            // 
            // tBPassword
            // 
            this.tBPassword.BorderColor = System.Drawing.Color.Transparent;
            this.tBPassword.BorderRadius = 20;
            this.tBPassword.BorderThickness = 0;
            this.tBPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tBPassword.DefaultText = "";
            this.tBPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tBPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tBPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tBPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tBPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tBPassword.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tBPassword.Location = new System.Drawing.Point(36, 123);
            this.tBPassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tBPassword.Name = "tBPassword";
            this.tBPassword.PasswordChar = '*';
            this.tBPassword.PlaceholderText = "Password";
            this.tBPassword.SelectedText = "";
            this.tBPassword.Size = new System.Drawing.Size(366, 45);
            this.tBPassword.TabIndex = 3;
            // 
            // tBComfirmPass
            // 
            this.tBComfirmPass.BorderColor = System.Drawing.Color.Transparent;
            this.tBComfirmPass.BorderRadius = 20;
            this.tBComfirmPass.BorderThickness = 0;
            this.tBComfirmPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tBComfirmPass.DefaultText = "";
            this.tBComfirmPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tBComfirmPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tBComfirmPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tBComfirmPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tBComfirmPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tBComfirmPass.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBComfirmPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tBComfirmPass.Location = new System.Drawing.Point(36, 199);
            this.tBComfirmPass.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tBComfirmPass.Name = "tBComfirmPass";
            this.tBComfirmPass.PasswordChar = '*';
            this.tBComfirmPass.PlaceholderText = "Comfirm Password";
            this.tBComfirmPass.SelectedText = "";
            this.tBComfirmPass.Size = new System.Drawing.Size(366, 45);
            this.tBComfirmPass.TabIndex = 4;
            this.tBComfirmPass.Visible = false;
            this.tBComfirmPass.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // btnComfimRegis
            // 
            this.btnComfimRegis.AllowAnimations = true;
            this.btnComfimRegis.AllowMouseEffects = true;
            this.btnComfimRegis.AllowToggling = false;
            this.btnComfimRegis.AnimationSpeed = 200;
            this.btnComfimRegis.AutoGenerateColors = false;
            this.btnComfimRegis.AutoRoundBorders = false;
            this.btnComfimRegis.AutoSizeLeftIcon = true;
            this.btnComfimRegis.AutoSizeRightIcon = true;
            this.btnComfimRegis.BackColor = System.Drawing.Color.Transparent;
            this.btnComfimRegis.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnComfimRegis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnComfimRegis.BackgroundImage")));
            this.btnComfimRegis.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.btnComfimRegis.ButtonText = "Đăng kí";
            this.btnComfimRegis.ButtonTextMarginLeft = 0;
            this.btnComfimRegis.ColorContrastOnClick = 45;
            this.btnComfimRegis.ColorContrastOnHover = 45;
            this.btnComfimRegis.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnComfimRegis.CustomizableEdges = borderEdges3;
            this.btnComfimRegis.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnComfimRegis.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.btnComfimRegis.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnComfimRegis.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnComfimRegis.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnComfimRegis.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComfimRegis.ForeColor = System.Drawing.Color.White;
            this.btnComfimRegis.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComfimRegis.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnComfimRegis.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnComfimRegis.IconMarginLeft = 11;
            this.btnComfimRegis.IconPadding = 10;
            this.btnComfimRegis.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComfimRegis.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnComfimRegis.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnComfimRegis.IconSize = 25;
            this.btnComfimRegis.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnComfimRegis.IdleBorderRadius = 20;
            this.btnComfimRegis.IdleBorderThickness = 1;
            this.btnComfimRegis.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnComfimRegis.IdleIconLeftImage = null;
            this.btnComfimRegis.IdleIconRightImage = null;
            this.btnComfimRegis.IndicateFocus = false;
            this.btnComfimRegis.Location = new System.Drawing.Point(363, 442);
            this.btnComfimRegis.Name = "btnComfimRegis";
            this.btnComfimRegis.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnComfimRegis.OnDisabledState.BorderRadius = 20;
            this.btnComfimRegis.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnComfimRegis.OnDisabledState.BorderThickness = 0;
            this.btnComfimRegis.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnComfimRegis.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnComfimRegis.OnDisabledState.IconLeftImage = null;
            this.btnComfimRegis.OnDisabledState.IconRightImage = null;
            this.btnComfimRegis.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnComfimRegis.onHoverState.BorderRadius = 20;
            this.btnComfimRegis.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnComfimRegis.onHoverState.BorderThickness = 0;
            this.btnComfimRegis.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnComfimRegis.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnComfimRegis.onHoverState.IconLeftImage = null;
            this.btnComfimRegis.onHoverState.IconRightImage = null;
            this.btnComfimRegis.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnComfimRegis.OnIdleState.BorderRadius = 20;
            this.btnComfimRegis.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.btnComfimRegis.OnIdleState.BorderThickness = 0;
            this.btnComfimRegis.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnComfimRegis.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnComfimRegis.OnIdleState.IconLeftImage = null;
            this.btnComfimRegis.OnIdleState.IconRightImage = null;
            this.btnComfimRegis.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnComfimRegis.OnPressedState.BorderRadius = 20;
            this.btnComfimRegis.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnComfimRegis.OnPressedState.BorderThickness = 0;
            this.btnComfimRegis.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnComfimRegis.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnComfimRegis.OnPressedState.IconLeftImage = null;
            this.btnComfimRegis.OnPressedState.IconRightImage = null;
            this.btnComfimRegis.Size = new System.Drawing.Size(187, 60);
            this.btnComfimRegis.TabIndex = 3;
            this.btnComfimRegis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnComfimRegis.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnComfimRegis.TextMarginLeft = 0;
            this.btnComfimRegis.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnComfimRegis.UseDefaultRadiusAndThickness = true;
            this.btnComfimRegis.Visible = false;
            // 
            // lbRegister
            // 
            this.lbRegister.AutoSize = true;
            this.lbRegister.BackColor = System.Drawing.Color.Transparent;
            this.lbRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegister.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbRegister.Location = new System.Drawing.Point(557, 522);
            this.lbRegister.Name = "lbRegister";
            this.lbRegister.Size = new System.Drawing.Size(253, 25);
            this.lbRegister.TabIndex = 4;
            this.lbRegister.Text = "Đã có tài khoản. Click Here!";
            this.lbRegister.Visible = false;
            this.lbRegister.Click += new System.EventHandler(this.lbRegister_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DoAnLTW.Properties.Resources.AnyConv_com__loginBackgr;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(917, 570);
            this.Controls.Add(this.lbRegister);
            this.Controls.Add(this.btnComfimRegis);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.panelLg);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panelLg.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel panelLg;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnLogin;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnRegister;
        private Guna.UI2.WinForms.Guna2TextBox tBUserName;
        private Guna.UI2.WinForms.Guna2TextBox tBPassword;
        private Guna.UI2.WinForms.Guna2TextBox tBComfirmPass;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnComfimRegis;
        private System.Windows.Forms.Label lbRegister;
    }
}

