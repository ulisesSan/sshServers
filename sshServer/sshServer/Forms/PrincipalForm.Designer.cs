namespace sshServer
{
    partial class PrincipalForm
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
            MenuPanel = new Panel();
            btnServers = new Button();
            PrincipalPanel = new Panel();
            MenuPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MenuPanel
            // 
            MenuPanel.Controls.Add(btnServers);
            MenuPanel.Location = new Point(0, 0);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(258, 625);
            MenuPanel.TabIndex = 0;
            // 
            // btnServers
            // 
            btnServers.Location = new Point(40, 47);
            btnServers.Name = "btnServers";
            btnServers.Size = new Size(170, 32);
            btnServers.TabIndex = 0;
            btnServers.Text = "Servidores";
            btnServers.UseVisualStyleBackColor = true;
            btnServers.Click += btnServers_Click;
            // 
            // PrincipalPanel
            // 
            PrincipalPanel.Location = new Point(262, 2);
            PrincipalPanel.Name = "PrincipalPanel";
            PrincipalPanel.Size = new Size(942, 623);
            PrincipalPanel.TabIndex = 1;
            // 
            // PrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 625);
            Controls.Add(PrincipalPanel);
            Controls.Add(MenuPanel);
            Name = "PrincipalForm";
            Text = "Form1";
            MenuPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel MenuPanel;
        private Button btnServers;
        private Panel PrincipalPanel;
    }
}
