using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorTextos
{
    public partial class FrmDoc : Form
    {
        public ToolStripComboBox? ComboFont { get; set; }
        public ToolStripComboBox? ComboSize { get; set; }
        public FrmDoc()
        {
            InitializeComponent();
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
            return Clipboard.ContainsText() || Clipboard.ContainsImage();
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
            if (SaveDlg.ShowDialog() == DialogResult.OK)
            {
                DocContent.SaveFile(SaveDlg.FileName);
                DocContent.Modified = false;
                this.Text = SaveDlg.FileName;
            }
        }

        public bool OpenDoc()
        {
            if (OpenDlg.ShowDialog() == DialogResult.OK)
            {
                DocContent.LoadFile(OpenDlg.FileName);
                this.Text = OpenDlg.FileName;
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
    }
}
