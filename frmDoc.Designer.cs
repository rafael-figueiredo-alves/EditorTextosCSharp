namespace EditorTextos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoc));
            DocContent = new RichTextBox();
            OpenDlg = new OpenFileDialog();
            SaveDlg = new SaveFileDialog();
            SelectImage = new OpenFileDialog();
            fontDlg = new FontDialog();
            printDlg = new PrintDialog();
            printDoc = new System.Drawing.Printing.PrintDocument();
            printPreviewDlg = new PrintPreviewDialog();
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
            DocContent.LinkClicked += DocContent_LinkClicked;
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
            SaveDlg.DefaultExt = "rtf";
            SaveDlg.Filter = "Documento de Texto|*.rtf";
            SaveDlg.Title = "Salvar Documento";
            // 
            // SelectImage
            // 
            SelectImage.DefaultExt = "png";
            SelectImage.FileName = "openFileDialog1";
            SelectImage.Filter = "Imagem PNG|*png|Imagem JPG|*.jpg|Imagem JPEG|*.jpg|Imagem Gif|*.gif";
            SelectImage.ShowPreview = true;
            SelectImage.Title = "Selecione a imagem que deseja inserir";
            // 
            // printDlg
            // 
            printDlg.UseEXDialog = true;
            // 
            // printDoc
            // 
            printDoc.PrintPage += PrintDoc_PrintPage;
            // 
            // printPreviewDlg
            // 
            printPreviewDlg.AutoScrollMargin = new Size(0, 0);
            printPreviewDlg.AutoScrollMinSize = new Size(0, 0);
            printPreviewDlg.ClientSize = new Size(400, 300);
            printPreviewDlg.Enabled = true;
            printPreviewDlg.Icon = (Icon)resources.GetObject("printPreviewDlg.Icon");
            printPreviewDlg.Name = "printPreviewDlg";
            printPreviewDlg.Visible = false;
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
            WindowState = FormWindowState.Maximized;
            FormClosing += FrmDoc_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox DocContent;
        private SaveFileDialog SaveDlg;
        private OpenFileDialog OpenDlg;
        private OpenFileDialog SelectImage;
        private FontDialog fontDlg;
        private PrintDialog printDlg;
        private System.Drawing.Printing.PrintDocument printDoc;
        private PrintPreviewDialog printPreviewDlg;
    }
}