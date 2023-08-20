namespace EditorTextos
{
    partial class dlgReplace
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
            components = new System.ComponentModel.Container();
            textFrom = new TextBox();
            textTo = new TextBox();
            btnSubstituir = new Button();
            btnSubstituirTudo = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // textFrom
            // 
            textFrom.Location = new Point(12, 12);
            textFrom.Name = "textFrom";
            textFrom.PlaceholderText = "Localizar...";
            textFrom.Size = new Size(393, 27);
            textFrom.TabIndex = 1;
            toolTip1.SetToolTip(textFrom, "Texto a localizar");
            // 
            // textTo
            // 
            textTo.Location = new Point(12, 45);
            textTo.Name = "textTo";
            textTo.PlaceholderText = "Substituir...";
            textTo.Size = new Size(393, 27);
            textTo.TabIndex = 2;
            toolTip1.SetToolTip(textTo, "Texto que será usado para substituir");
            // 
            // btnSubstituir
            // 
            btnSubstituir.Location = new Point(411, 10);
            btnSubstituir.Name = "btnSubstituir";
            btnSubstituir.Size = new Size(129, 29);
            btnSubstituir.TabIndex = 3;
            btnSubstituir.Text = "Substituir";
            btnSubstituir.UseVisualStyleBackColor = true;
            // 
            // btnSubstituirTudo
            // 
            btnSubstituirTudo.Location = new Point(411, 45);
            btnSubstituirTudo.Name = "btnSubstituirTudo";
            btnSubstituirTudo.Size = new Size(129, 29);
            btnSubstituirTudo.TabIndex = 4;
            btnSubstituirTudo.Text = "Substituir Tudo";
            btnSubstituirTudo.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            toolTip1.IsBalloon = true;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Dica";
            // 
            // dlgReplace
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 83);
            Controls.Add(btnSubstituirTudo);
            Controls.Add(btnSubstituir);
            Controls.Add(textTo);
            Controls.Add(textFrom);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MinimizeBox = false;
            Name = "dlgReplace";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Substituir";
            TopMost = true;
            TransparencyKey = Color.Silver;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public TextBox textFrom;
        public TextBox textTo;
        public Button btnSubstituir;
        public Button btnSubstituirTudo;
        private ToolTip toolTip1;
        private Button button2;
    }
}