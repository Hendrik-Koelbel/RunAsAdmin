namespace RunAs
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonRestartWithAdminRights = new System.Windows.Forms.Button();
            this.labelCurrentUser = new System.Windows.Forms.Label();
            this.textBoxDomain = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelDomain = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonStart.AutoSize = true;
            this.buttonStart.Location = new System.Drawing.Point(8, 108);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(99, 38);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Get Admin Rights";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonRestartWithAdminRights
            // 
            this.buttonRestartWithAdminRights.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRestartWithAdminRights.AutoSize = true;
            this.buttonRestartWithAdminRights.Location = new System.Drawing.Point(125, 108);
            this.buttonRestartWithAdminRights.Name = "buttonRestartWithAdminRights";
            this.buttonRestartWithAdminRights.Size = new System.Drawing.Size(165, 38);
            this.buttonRestartWithAdminRights.TabIndex = 5;
            this.buttonRestartWithAdminRights.Text = "Start with Admin Rights";
            this.buttonRestartWithAdminRights.UseVisualStyleBackColor = true;
            this.buttonRestartWithAdminRights.Click += new System.EventHandler(this.buttonRestartWithAdminRights_Click);
            // 
            // labelCurrentUser
            // 
            this.labelCurrentUser.AutoSize = true;
            this.tableLayoutPanel.SetColumnSpan(this.labelCurrentUser, 2);
            this.labelCurrentUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCurrentUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentUser.Location = new System.Drawing.Point(3, 0);
            this.labelCurrentUser.MaximumSize = new System.Drawing.Size(428, 237);
            this.labelCurrentUser.Name = "labelCurrentUser";
            this.labelCurrentUser.Size = new System.Drawing.Size(293, 16);
            this.labelCurrentUser.TabIndex = 0;
            this.labelCurrentUser.Text = "labelUser";
            this.labelCurrentUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxDomain
            // 
            this.textBoxDomain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDomain.Location = new System.Drawing.Point(119, 19);
            this.textBoxDomain.Name = "textBoxDomain";
            this.textBoxDomain.Size = new System.Drawing.Size(177, 20);
            this.textBoxDomain.TabIndex = 1;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUsername.Location = new System.Drawing.Point(119, 45);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(177, 20);
            this.textBoxUsername.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassword.Location = new System.Drawing.Point(119, 71);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(177, 20);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelDomain
            // 
            this.labelDomain.AutoSize = true;
            this.labelDomain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDomain.Location = new System.Drawing.Point(3, 16);
            this.labelDomain.Name = "labelDomain";
            this.labelDomain.Size = new System.Drawing.Size(110, 26);
            this.labelDomain.TabIndex = 0;
            this.labelDomain.Text = "Domain local is only \'.\'";
            this.labelDomain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUsername.Location = new System.Drawing.Point(3, 42);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(110, 26);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username";
            this.labelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPassword.Location = new System.Drawing.Point(3, 68);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(110, 26);
            this.labelPassword.TabIndex = 0;
            this.labelPassword.Text = "Password";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoSize = true;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.labelCurrentUser, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.labelDomain, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.labelUsername, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.labelPassword, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.textBoxDomain, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.textBoxUsername, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.textBoxPassword, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.buttonStart, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.buttonRestartWithAdminRights, 1, 4);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(299, 161);
            this.tableLayoutPanel.TabIndex = 9;
            // 
            // frmMain
            // 
            this.AcceptButton = this.buttonStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(299, 161);
            this.Controls.Add(this.tableLayoutPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(315, 200);
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RunAsAdmin";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonRestartWithAdminRights;
        private System.Windows.Forms.Label labelCurrentUser;
        private System.Windows.Forms.TextBox textBoxDomain;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelDomain;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
    }
}

