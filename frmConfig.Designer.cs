namespace EditorTextos
{
    partial class frmConfig
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
            chDetectURLS = new CheckBox();
            chUseMargins = new CheckBox();
            cbFont = new ComboBox();
            cbFontSize = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // chDetectURLS
            // 
            chDetectURLS.AutoSize = true;
            chDetectURLS.Location = new Point(12, 22);
            chDetectURLS.Name = "chDetectURLS";
            chDetectURLS.Size = new Size(464, 24);
            chDetectURLS.TabIndex = 0;
            chDetectURLS.Text = "Detectar URLs no texto e usar devida formatação e permitir clicar";
            chDetectURLS.UseVisualStyleBackColor = true;
            // 
            // chUseMargins
            // 
            chUseMargins.AutoSize = true;
            chUseMargins.Location = new Point(12, 68);
            chUseMargins.Name = "chUseMargins";
            chUseMargins.Size = new Size(245, 24);
            chUseMargins.TabIndex = 1;
            chUseMargins.Text = "Usar Margens no editor de texto";
            chUseMargins.UseVisualStyleBackColor = true;
            // 
            // cbFont
            // 
            cbFont.FormattingEnabled = true;
            cbFont.Location = new Point(114, 123);
            cbFont.Name = "cbFont";
            cbFont.Size = new Size(439, 28);
            cbFont.TabIndex = 2;
            // 
            // cbFontSize
            // 
            cbFontSize.FormattingEnabled = true;
            cbFontSize.Items.AddRange(new object[] { "8", "9", "10", "12", "14", "16", "18", "20", "22", "24", "28", "32", "48", "72" });
            cbFontSize.Location = new Point(199, 176);
            cbFontSize.Name = "cbFontSize";
            cbFontSize.Size = new Size(151, 28);
            cbFontSize.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 126);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 4;
            label1.Text = "Fonte Padrão";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 179);
            label2.Name = "label2";
            label2.Size = new Size(181, 20);
            label2.TabIndex = 5;
            label2.Text = "Tamanho de fonte padrão";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(459, 175);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "&Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // frmConfig
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 215);
            Controls.Add(btnSalvar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbFontSize);
            Controls.Add(cbFont);
            Controls.Add(chUseMargins);
            Controls.Add(chDetectURLS);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmConfig";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Configurações";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chDetectURLS;
        private CheckBox chUseMargins;
        private ComboBox cbFont;
        private ComboBox cbFontSize;
        private Label label1;
        private Label label2;
        private Button btnSalvar;
    }
}