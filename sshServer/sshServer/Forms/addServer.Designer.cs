namespace sshServer.Forms
{
    partial class addServer
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
            label1 = new Label();
            lblServerName = new Label();
            lblPassword1 = new Label();
            lblPassword2 = new Label();
            txtServerName = new TextBox();
            txtIpServer = new TextBox();
            txtPassword1 = new TextBox();
            txtPassword2 = new TextBox();
            btnAddServer = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(166, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre del servidor (Usuario)";
            // 
            // lblServerName
            // 
            lblServerName.AutoSize = true;
            lblServerName.Location = new Point(12, 83);
            lblServerName.Name = "lblServerName";
            lblServerName.Size = new Size(81, 15);
            lblServerName.TabIndex = 1;
            lblServerName.Text = "IP del servidor";
            // 
            // lblPassword1
            // 
            lblPassword1.AutoSize = true;
            lblPassword1.Location = new Point(12, 124);
            lblPassword1.Name = "lblPassword1";
            lblPassword1.Size = new Size(67, 15);
            lblPassword1.TabIndex = 2;
            lblPassword1.Text = "Contraseña";
            // 
            // lblPassword2
            // 
            lblPassword2.AutoSize = true;
            lblPassword2.Location = new Point(12, 168);
            lblPassword2.Name = "lblPassword2";
            lblPassword2.Size = new Size(76, 15);
            lblPassword2.TabIndex = 3;
            lblPassword2.Text = "Contraseña 2";
            // 
            // txtServerName
            // 
            txtServerName.Location = new Point(199, 37);
            txtServerName.Name = "txtServerName";
            txtServerName.Size = new Size(146, 23);
            txtServerName.TabIndex = 4;
            // 
            // txtIpServer
            // 
            txtIpServer.Location = new Point(199, 80);
            txtIpServer.Name = "txtIpServer";
            txtIpServer.Size = new Size(146, 23);
            txtIpServer.TabIndex = 5;
            // 
            // txtPassword1
            // 
            txtPassword1.Location = new Point(199, 121);
            txtPassword1.Name = "txtPassword1";
            txtPassword1.Size = new Size(146, 23);
            txtPassword1.TabIndex = 6;
            // 
            // txtPassword2
            // 
            txtPassword2.Location = new Point(199, 165);
            txtPassword2.Name = "txtPassword2";
            txtPassword2.Size = new Size(146, 23);
            txtPassword2.TabIndex = 7;
            // 
            // btnAddServer
            // 
            btnAddServer.Location = new Point(162, 238);
            btnAddServer.Name = "btnAddServer";
            btnAddServer.Size = new Size(132, 30);
            btnAddServer.TabIndex = 8;
            btnAddServer.Text = "Agregar";
            btnAddServer.UseVisualStyleBackColor = true;
            btnAddServer.Click += btnAddServer_Click;
            // 
            // addServer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 305);
            Controls.Add(btnAddServer);
            Controls.Add(txtPassword2);
            Controls.Add(txtPassword1);
            Controls.Add(txtIpServer);
            Controls.Add(txtServerName);
            Controls.Add(lblPassword2);
            Controls.Add(lblPassword1);
            Controls.Add(lblServerName);
            Controls.Add(label1);
            Name = "addServer";
            Text = "addServer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblServerName;
        private Label lblPassword1;
        private Label lblPassword2;
        private TextBox txtServerName;
        private TextBox txtIpServer;
        private TextBox txtPassword1;
        private TextBox txtPassword2;
        private Button btnAddServer;
    }
}