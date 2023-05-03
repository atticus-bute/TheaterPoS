namespace POSForm1
{
    partial class frmPurchase
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
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lboOrder = new System.Windows.Forms.ListBox();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnCard = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.btnFinalize = new System.Windows.Forms.Button();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.grpPaymentMethod = new System.Windows.Forms.GroupBox();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.grpPaymentMethod.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotal.Location = new System.Drawing.Point(543, 538);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(255, 64);
            this.lblTotal.TabIndex = 26;
            this.lblTotal.Text = "Total:";
            // 
            // lblTax
            // 
            this.lblTax.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTax.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTax.Location = new System.Drawing.Point(543, 513);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(255, 25);
            this.lblTax.TabIndex = 25;
            this.lblTax.Text = "Tax:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSubtotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSubtotal.Location = new System.Drawing.Point(543, 488);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(255, 25);
            this.lblSubtotal.TabIndex = 23;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lboOrder
            // 
            this.lboOrder.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lboOrder.FormattingEnabled = true;
            this.lboOrder.ItemHeight = 24;
            this.lboOrder.Location = new System.Drawing.Point(543, 49);
            this.lboOrder.Name = "lboOrder";
            this.lboOrder.Size = new System.Drawing.Size(255, 436);
            this.lboOrder.TabIndex = 24;
            // 
            // btnCash
            // 
            this.btnCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCash.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCash.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCash.Location = new System.Drawing.Point(173, 49);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(345, 161);
            this.btnCash.TabIndex = 27;
            this.btnCash.Text = "Cash";
            this.btnCash.UseVisualStyleBackColor = false;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnCard
            // 
            this.btnCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnCard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCard.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCard.Location = new System.Drawing.Point(173, 232);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(345, 161);
            this.btnCard.TabIndex = 28;
            this.btnCard.Text = "Card";
            this.btnCard.UseVisualStyleBackColor = false;
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(173, 632);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(345, 124);
            this.btnBack.TabIndex = 30;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPaymentMethod.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPaymentMethod.Location = new System.Drawing.Point(8, 23);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(0, 24);
            this.lblPaymentMethod.TabIndex = 34;
            // 
            // btnFinalize
            // 
            this.btnFinalize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnFinalize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFinalize.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFinalize.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFinalize.Location = new System.Drawing.Point(8, 115);
            this.btnFinalize.Name = "btnFinalize";
            this.btnFinalize.Size = new System.Drawing.Size(345, 72);
            this.btnFinalize.TabIndex = 33;
            this.btnFinalize.Text = "Complete Transaction";
            this.btnFinalize.UseVisualStyleBackColor = false;
            this.btnFinalize.Click += new System.EventHandler(this.btnFinalize_Click);
            // 
            // txtPayment
            // 
            this.txtPayment.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPayment.Location = new System.Drawing.Point(8, 53);
            this.txtPayment.MaxLength = 12;
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(345, 56);
            this.txtPayment.TabIndex = 31;
            // 
            // grpPaymentMethod
            // 
            this.grpPaymentMethod.Controls.Add(this.txtPayment);
            this.grpPaymentMethod.Controls.Add(this.lblPaymentMethod);
            this.grpPaymentMethod.Controls.Add(this.btnFinalize);
            this.grpPaymentMethod.Enabled = false;
            this.grpPaymentMethod.Location = new System.Drawing.Point(165, 415);
            this.grpPaymentMethod.Name = "grpPaymentMethod";
            this.grpPaymentMethod.Size = new System.Drawing.Size(362, 195);
            this.grpPaymentMethod.TabIndex = 35;
            this.grpPaymentMethod.TabStop = false;
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCurrentUser.Location = new System.Drawing.Point(173, 9);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(146, 24);
            this.lblCurrentUser.TabIndex = 36;
            this.lblCurrentUser.Text = "Current User:";
            // 
            // frmPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(982, 797);
            this.Controls.Add(this.lblCurrentUser);
            this.Controls.Add(this.grpPaymentMethod);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCard);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lboOrder);
            this.Name = "frmPurchase";
            this.Text = "Complete Transaction";
            this.grpPaymentMethod.ResumeLayout(false);
            this.grpPaymentMethod.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTotal;
        private Label lblTax;
        private Label lblSubtotal;
        private ListBox lboOrder;
        private Button btnCash;
        private Button btnCard;
        private Button btnBack;
        private Label lblPaymentMethod;
        private Button btnFinalize;
        private TextBox txtPayment;
        private GroupBox grpPaymentMethod;
        private Label lblCurrentUser;
    }
}