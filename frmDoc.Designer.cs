﻿namespace EditorTextos
{
    partial class FrmDoc
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
            DocContent = new RichTextBox();
            OpenDlg = new OpenFileDialog();
            SaveDlg = new SaveFileDialog();
            SuspendLayout();
            // 
            // DocContent
            // 
            DocContent.Dock = DockStyle.Fill;
            DocContent.Location = new Point(0, 0);
            DocContent.Margin = new Padding(3, 4, 3, 4);
            DocContent.Name = "DocContent";
            DocContent.Size = new Size(914, 600);
            DocContent.TabIndex = 0;
            DocContent.Text = "";
            DocContent.SelectionChanged += DocContent_SelectionChanged;
            // 
            // OpenDlg
            // 
            OpenDlg.DefaultExt = "rtf";
            OpenDlg.FileName = "openFileDialog1";
            OpenDlg.Filter = "Documento de texto|*.rtf";
            OpenDlg.ShowPreview = true;
            OpenDlg.Title = "Abrir documento";
            // 
            // SaveDlg
            // 
            SaveDlg.CreatePrompt = true;
            SaveDlg.DefaultExt = "rtf";
            SaveDlg.Filter = "Documento de Texto|*.rtf";
            SaveDlg.Title = "Salvar Documento";
            // 
            // FrmDoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(DocContent);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmDoc";
            ShowIcon = false;
            Text = "Sem título";
            FormClosing += FrmDoc_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox DocContent;
        private SaveFileDialog SaveDlg;
        private OpenFileDialog OpenDlg;
    }
}