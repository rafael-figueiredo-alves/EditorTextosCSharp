using System.Windows.Forms;

namespace EditorTextos
{
    public partial class FrmDoc : Form
    {
        public ToolStripComboBox? ComboFont { get; set; }
        public ToolStripComboBox? ComboSize { get; set; }
        private string DocFilename { get; set; } = string.Empty;

        private int _checkPrint;

        private StringReader? leitor;
        public FrmDoc(int DocNo = 0)
        {
            InitializeComponent();

            if (DocNo > 0)
            {
                Text = "Sem título " + DocNo;
            }

            //printDoc.BeginPrint += prin
        }
        //-------------------------------------------------------------------------------
        // Métodos para ler propriedades do RichTextBox
        public bool Modified()
        {
            return DocContent.Modified;
        }
        public bool IsBold()
        {
            if (DocContent.SelectionFont != null)
            {
                return DocContent.SelectionFont.Bold;
            }
            else { return false; }
        }
        public bool IsItalic()
        {
            if (DocContent.SelectionFont != null)
            {
                return DocContent.SelectionFont.Italic;
            }
            else { return false; }
        }
        public bool IsUnderline()
        {
            if (DocContent.SelectionFont != null)
            {
                return DocContent.SelectionFont.Underline;
            }
            else
            { return false; }
        }
        public string FontName()
        {
            if (DocContent.SelectionFont != null)
            {
                return DocContent.SelectionFont.Name.ToString();
            }
            else
            { return string.Empty; }
        }
        public string FontSize()
        {
            if (DocContent.SelectionFont != null)
            {
                return DocContent.SelectionFont.Size.ToString();
            }
            else
            {
                return string.Empty;
            }
        }
        public HorizontalAlignment DocAlignment()
        {
            return DocContent.SelectionAlignment;
        }
        public bool AbleUNDO()
        {
            return DocContent.CanUndo;
        }
        public bool AbleREDO()
        {
            return DocContent.CanRedo;
        }
        public bool AblePASTE()
        {
            DataFormats.Format fm = DataFormats.GetFormat(DataFormats.Rtf);
            return DocContent.CanPaste(fm);
        }

        public bool CanIncreaseZoom()
        {
            return DocContent.ZoomFactor >= 1 && DocContent.ZoomFactor < 64;
        }

        public bool CanDecreaseZoom()
        {
            return DocContent.ZoomFactor <= 64 && DocContent.ZoomFactor > 1;
        }

        public int ZoomFactor()
        {
            return Convert.ToInt32(DocContent.ZoomFactor);
        }

        public int GetLinha()
        {
            // Get the line.
            int index = DocContent.SelectionStart;
            return DocContent.GetLineFromCharIndex(index);
        }

        public int GetColuna()
        {
            // Get the line.
            int index = DocContent.SelectionStart;
            int line = DocContent.GetLineFromCharIndex(index);

            // Get the column.
            int firstChar = DocContent.GetFirstCharIndexFromLine(line);
            return index - firstChar;
        }

        public bool usingBullets()
        {
            return DocContent.SelectionBullet;
        }
        //---------------------------------------------------------------------------------------------------------------
        // Métodos que permitem acesso aos métodos do RichTextBox
        public void SelectionAlignment(HorizontalAlignment align)
        {
            DocContent.SelectionAlignment = align;
        }
        public int DocFind(string Ftext)
        {
            return DocContent.Find(Ftext);
        }
        public void DocFocus()
        {
            DocContent.Focus();
        }
        public void SetBold()
        {
            if (DocContent.SelectionFont != null)
            {
                if (DocContent.SelectionFont.Bold)
                {
                    DocContent.SelectionFont = new Font(DocContent.SelectionFont, DocContent.SelectionFont.Style & ~FontStyle.Bold);
                }
                else
                {
                    DocContent.SelectionFont = new Font(DocContent.SelectionFont, DocContent.SelectionFont.Style | FontStyle.Bold);
                }
            }
            else
            {
                DocContent.SelectionFont = new Font(DocContent.Font, DocContent.Font.Style | FontStyle.Bold);
            }
        }
        public void SetItalic()
        {
            if (DocContent.SelectionFont != null)
            {
                if (DocContent.SelectionFont.Italic)
                {
                    DocContent.SelectionFont = new Font(DocContent.SelectionFont, DocContent.SelectionFont.Style & ~FontStyle.Italic);
                }
                else
                {
                    DocContent.SelectionFont = new Font(DocContent.SelectionFont, DocContent.SelectionFont.Style | FontStyle.Italic);
                }
            }
            else
            {
                DocContent.SelectionFont = new Font(DocContent.Font, DocContent.Font.Style | FontStyle.Italic);
            }
        }
        public void SetUnderline()
        {
            if (DocContent.SelectionFont != null)
            {
                if (DocContent.SelectionFont.Underline)
                {
                    DocContent.SelectionFont = new Font(DocContent.SelectionFont, DocContent.SelectionFont.Style & ~FontStyle.Underline);
                }
                else
                {
                    DocContent.SelectionFont = new Font(DocContent.SelectionFont, DocContent.SelectionFont.Style | FontStyle.Underline);
                }
            }
            else
            {
                DocContent.SelectionFont = new Font(DocContent.Font, DocContent.Font.Style | FontStyle.Underline);
            }
        }
        public void SetBullets()
        {
            DocContent.SelectionBullet = !DocContent.SelectionBullet;
        }
        public void SetFontName(string FFontName)
        {
            if (DocContent.SelectionFont != null)
            {
                DocContent.SelectionFont = new Font(FFontName, DocContent.SelectionFont.Size);
            }
            else
            {
                DocContent.SelectionFont = new Font(FFontName, DocContent.Font.Size);
            }
        }
        public void SetFontSize(float FFontSize)
        {
            if (DocContent.SelectionFont != null)
            {
                DocContent.SelectionFont = new Font(DocContent.SelectionFont.Name.ToString(), FFontSize);
            }
            else
            {
                DocContent.SelectionFont = new Font(DocContent.Font.Name.ToString(), FFontSize);
            }
        }
        private void DocContent_SelectionChanged(object sender, EventArgs e)
        {
            if (ComboFont != null)
            {
                if (DocContent.SelectionFont != null)
                {
                    ComboFont.Text = DocContent.SelectionFont.Name.ToString();
                }
                else
                {
                    ComboFont.Text = DocContent.Font.Name.ToString();
                }
            }

            if (ComboSize != null)
            {
                if (DocContent.SelectionFont != null)
                {
                    ComboSize.Text = DocContent.SelectionFont.Size.ToString();
                }
                else
                {
                    ComboSize.Text = DocContent.Font.Size.ToString();
                }

            }
        }
        private void FrmDoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DocContent.Modified)
            {
                if (MessageBox.Show("O documento tem modificações não salvas. Tem certeza que deseja fechar sem salvar?",
                                    "Fechar sem salvar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }

            }
        }
        public void SaveDocAs()
        {
            if (DocFilename != string.Empty)
            {
                SaveDlg.FileName = DocFilename;
            }
            else
            {
                SaveDlg.FileName = this.Text.Replace(' ', '-');
            }

            if (SaveDlg.ShowDialog() == DialogResult.OK)
            {
                DocContent.SaveFile(SaveDlg.FileName);
                DocFilename = SaveDlg.FileName;
                DocContent.Modified = false;
                this.Text = Path.GetFileNameWithoutExtension(SaveDlg.FileName);
            }
        }
        public bool OpenDoc()
        {
            if (OpenDlg.ShowDialog() == DialogResult.OK)
            {
                DocContent.LoadFile(OpenDlg.FileName);
                this.Text = Path.GetFileNameWithoutExtension(OpenDlg.FileName);
                this.Show();
                DocContent.Modified = false;
                return true;
            }
            else
            {
                this.Close();
                return false;
            }
        }
        public void SaveDoc()
        {
            if (DocFilename == string.Empty)
            {
                SaveDocAs();
            }
            else
            {
                DocContent.SaveFile(DocFilename);
                DocContent.Modified = false;
            }
        }
        public void InsertImage()
        {
            if (SelectImage.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(SelectImage.FileName);
                Clipboard.SetImage(img);
                DocContent.Paste();
                Clipboard.Clear();
                DocContent.Focus();
            }
            else
            {
                DocContent.Focus();
            }

        }
        public void InsertDateTime()
        {
            DocContent.SelectedText += DateTime.Now.ToString();
        }
        public void InsertSimpleDate()
        {
            DocContent.SelectedText += DateTime.Now.ToString("dd/MM/yyyy");
        }
        public void InsertTime()
        {
            DocContent.SelectedText += DateTime.Now.ToString("hh:mm:ss");
        }
        public void FormatFont()
        {
            fontDlg.Font = DocContent.SelectionFont;

            if (fontDlg.ShowDialog() == DialogResult.OK)
            {
                DocContent.SelectionFont = fontDlg.Font;
            }
        }
        public void DocUndo()
        {
            DocContent.Undo();
        }
        public void DocRedo()
        {
            DocContent.Redo();
        }
        public void DocSelectAll()
        {
            DocContent.SelectAll();
        }
        public void DocCopy()
        {
            DocContent.Copy();
        }
        public void DocCut()
        {
            DocContent.Cut();
        }
        public void DocPaste()
        {
            DocContent.Paste();
        }
        public void SetPrinter()
        {
            printDlg.Document = printDoc;
            printDlg.ShowDialog();
        }
        public void PreviewPrint()
        {
            printPreviewDlg.Document = printDoc;
            printPreviewDlg.ShowDialog();
        }
        public void PrintDoc()
        {
            if (printDlg.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
        }
        private void PrintDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Print the content of RichTextBox. Store the last character printed.
            _checkPrint = DocContent.Print(_checkPrint, DocContent.TextLength, e);

            // Check for more pages
            e.HasMorePages = _checkPrint < DocContent.TextLength;
        }
        private void DocContent_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            if ((e.LinkLength > 0) && (e.LinkText != null))
            {
                System.Diagnostics.Process.Start(e.LinkText);
            }
        }

        public void IncreaseZoom()
        {
            if (DocContent.ZoomFactor < 64)
            {
                DocContent.ZoomFactor += 1;
            }
        }

        public void DecreaseZoom()
        {
            if (DocContent.ZoomFactor > 1)
            {
                DocContent.ZoomFactor -= 1;
            }
        }

        public void ReplaceText(string textFrom, string textTo, bool Tudo = false)
        {
            if(Tudo)
            {
                int Initial_position = 0;
                do
                {
                    Initial_position = DocContent.Find(textFrom);
                    if (Initial_position >= 0)
                    {
                        DocContent.SelectionStart = Initial_position;
                        DocContent.SelectionLength = textFrom.Length;
                        DocContent.SelectedText = textTo;
                    }
                } while (Initial_position >= 0);
            }
            else
            {
                int Initial_position = DocContent.Find(textFrom);
                if (Initial_position >= 0)
                {
                    DocContent.SelectionStart = Initial_position;
                    DocContent.SelectionLength = textFrom.Length;
                    DocContent.SelectedText = textTo;
                }
            }
        }

        private void printDoc_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _checkPrint = 0;
        }
    }
}
