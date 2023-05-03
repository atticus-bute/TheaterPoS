namespace POSForm1
{
    partial class frmLogin
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
            this.txtPin = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefund = new System.Windows.Forms.Button();
            this.btnToMenu = new System.Windows.Forms.Button();
            this.btnEndShift = new System.Windows.Forms.Button();
            this.lblLoginResult = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPin
            // 
            this.txtPin.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPin.Location = new System.Drawing.Point(12, 30);
            this.txtPin.MaxLength = 4;
            this.txtPin.Name = "txtPin";
            this.txtPin.PasswordChar = '#';
            this.txtPin.Size = new System.Drawing.Size(191, 56);
            this.txtPin.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogin.Location = new System.Drawing.Point(12, 92);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(191, 61);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Location = new System.Drawing.Point(209, 159);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(405, 128);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "PIN:";
            // 
            // btnRefund
            // 
            this.btnRefund.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnRefund.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefund.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRefund.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefund.Location = new System.Drawing.Point(209, 293);
            this.btnRefund.Name = "btnRefund";
            this.btnRefund.Size = new System.Drawing.Size(405, 128);
            this.btnRefund.TabIndex = 4;
            this.btnRefund.Text = "Refund";
            this.btnRefund.UseVisualStyleBackColor = false;
            this.btnRefund.Click += new System.EventHandler(this.btnRefund_Click);
            // 
            // btnToMenu
            // 
            this.btnToMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnToMenu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnToMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnToMenu.Location = new System.Drawing.Point(209, 25);
            this.btnToMenu.Name = "btnToMenu";
            this.btnToMenu.Size = new System.Drawing.Size(405, 128);
            this.btnToMenu.TabIndex = 6;
            this.btnToMenu.Text = "Menu";
            this.btnToMenu.UseVisualStyleBackColor = false;
            this.btnToMenu.Click += new System.EventHandler(this.btnToMenu_Click);
            // 
            // btnEndShift
            // 
            this.btnEndShift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnEndShift.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEndShift.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEndShift.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEndShift.Location = new System.Drawing.Point(209, 427);
            this.btnEndShift.Name = "btnEndShift";
            this.btnEndShift.Size = new System.Drawing.Size(405, 128);
            this.btnEndShift.TabIndex = 5;
            this.btnEndShift.Text = "End Shift";
            this.btnEndShift.UseVisualStyleBackColor = false;
            this.btnEndShift.Click += new System.EventHandler(this.btnEndShift_Click);
            // 
            // lblLoginResult
            // 
            this.lblLoginResult.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoginResult.ForeColor = System.Drawing.Color.Gold;
            this.lblLoginResult.Location = new System.Drawing.Point(12, 159);
            this.lblLoginResult.Name = "lblLoginResult";
            this.lblLoginResult.Size = new System.Drawing.Size(191, 396);
            this.lblLoginResult.TabIndex = 7;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHelp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHelp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHelp.Location = new System.Drawing.Point(620, 25);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(29, 37);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(690, 777);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblLoginResult);
            this.Controls.Add(this.btnToMenu);
            this.Controls.Add(this.btnEndShift);
            this.Controls.Add(this.btnRefund);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPin);
            this.Name = "frmLogin";
            this.Text = "Main Menu";
            this.Activated += new System.EventHandler(this.frmLogin_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtPin;
        private Button btnLogin;
        private Button btnLogout;
        private Label label1;
        private Button btnRefund;
        private Button btnToMenu;
        private Button btnEndShift;
        private Label lblLoginResult;
        private Button btnHelp;
    }
}