namespace sshServer.Forms
{
    partial class listServersForm
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
            button1 = new Button();
            dataServerTable = new DataGridView();
            btnUpdateTable = new Button();
            ((System.ComponentModel.ISupportInitialize)dataServerTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(354, 19);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Servers";
            // 
            // button1
            // 
            button1.Location = new Point(605, 388);
            button1.Name = "button1";
            button1.Size = new Size(183, 50);
            button1.TabIndex = 1;
            button1.Text = "Agregar Servidor";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataServerTable
            // 
            dataServerTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataServerTable.Location = new Point(23, 81);
            dataServerTable.Name = "dataServerTable";
            dataServerTable.Size = new Size(755, 272);
            dataServerTable.TabIndex = 2;
            // 
            // btnUpdateTable
            // 
            btnUpdateTable.Location = new Point(392, 389);
            btnUpdateTable.Name = "btnUpdateTable";
            btnUpdateTable.Size = new Size(183, 49);
            btnUpdateTable.TabIndex = 3;
            btnUpdateTable.Text = "Actualizar Tabla";
            btnUpdateTable.UseVisualStyleBackColor = true;
            btnUpdateTable.Click += btnUpdateTable_Click;
            // 
            // listServersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdateTable);
            Controls.Add(dataServerTable);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "listServersForm";
            Text = "listServersForm";
            ((System.ComponentModel.ISupportInitialize)dataServerTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private DataGridView dataServerTable;
        private Button btnUpdateTable;
    }
}