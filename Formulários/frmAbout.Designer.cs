namespace EditorTextos
{
    partial class FrmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            imageLogo = new PictureBox();
            lblTitulo = new Label();
            lblVersion = new Label();
            lblCopyright = new Label();
            btnFechar = new Button();
            grHistorico = new GroupBox();
            TxtHistorico = new TextBox();
            ((System.ComponentModel.ISupportInitialize)imageLogo).BeginInit();
            grHistorico.SuspendLayout();
            SuspendLayout();
            // 
            // imageLogo
            // 
            imageLogo.Image = (Image)resources.GetObject("imageLogo.Image");
            imageLogo.Location = new Point(12, 12);
            imageLogo.Name = "imageLogo";
            imageLogo.Size = new Size(100, 100);
            imageLogo.TabIndex = 0;
            imageLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(118, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(435, 46);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Editor de Texto em C#";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Location = new Point(125, 49);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(75, 20);
            lblVersion.TabIndex = 2;
            lblVersion.Text = "versão 1.4";
            // 
            // lblCopyright
            // 
            lblCopyright.AutoSize = true;
            lblCopyright.Font = new Font("Arial", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblCopyright.Location = new Point(123, 72);
            lblCopyright.Name = "lblCopyright";
            lblCopyright.Size = new Size(380, 20);
            lblCopyright.TabIndex = 3;
            lblCopyright.Text = "©2023 - Produzido por Rafael de Figueiredo Alves";
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(567, 380);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(89, 33);
            btnFechar.TabIndex = 4;
            btnFechar.Text = "&Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // grHistorico
            // 
            grHistorico.Controls.Add(TxtHistorico);
            grHistorico.Location = new Point(12, 127);
            grHistorico.Name = "grHistorico";
            grHistorico.Size = new Size(647, 248);
            grHistorico.TabIndex = 5;
            grHistorico.TabStop = false;
            grHistorico.Text = " Histórico de versões ";
            // 
            // TxtHistorico
            // 
            TxtHistorico.BackColor = Color.White;
            TxtHistorico.Dock = DockStyle.Fill;
            TxtHistorico.Location = new Point(3, 23);
            TxtHistorico.Margin = new Padding(5);
            TxtHistorico.Multiline = true;
            TxtHistorico.Name = "TxtHistorico";
            TxtHistorico.ReadOnly = true;
            TxtHistorico.ScrollBars = ScrollBars.Vertical;
            TxtHistorico.Size = new Size(641, 222);
            TxtHistorico.TabIndex = 0;
            TxtHistorico.Text = resources.GetString("TxtHistorico.Text");
            // 
            // FrmAbout
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            ClientSize = new Size(671, 419);
            ControlBox = false;
            Controls.Add(grHistorico);
            Controls.Add(btnFechar);
            Controls.Add(lblCopyright);
            Controls.Add(lblVersion);
            Controls.Add(lblTitulo);
            Controls.Add(imageLogo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FrmAbout";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sobre o EditorTexto";
            ((System.ComponentModel.ISupportInitialize)imageLogo).EndInit();
            grHistorico.ResumeLayout(false);
            grHistorico.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox imageLogo;
        private Label lblTitulo;
        private Label lblVersion;
        private Label lblCopyright;
        private Button btnFechar;
        private GroupBox grHistorico;
        private TextBox TxtHistorico;
    }
}