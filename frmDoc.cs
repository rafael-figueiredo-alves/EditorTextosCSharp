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
            return DocContent.SelectionFont.Bold;
        }

        public bool IsItalic()
        {
            return DocContent.SelectionFont.Italic;
        }

        public bool IsUnderline()
        {
            return DocContent.SelectionFont.Underline;
        }

        public string FontName()
        {
            return DocContent.SelectionFont.Name.ToString();
        }

        public string FontSize()
        {
            return DocContent.SelectionFont.Size.ToString();
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
            if (DocContent.SelectionFont.Bold)
            {
                DocContent.SelectionFont = new Font(DocContent.SelectionFont, DocContent.SelectionFont.Style & ~FontStyle.Bold);
            }
            else
            {
                DocContent.SelectionFont = new Font(DocContent.SelectionFont, DocContent.SelectionFont.Style | FontStyle.Bold);
            }
        }

        public void SetItalic()
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

        public void SetUnderline()
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

        public void SetFontName(string FFontName)
        {
            DocContent.SelectionFont = new Font(FFontName, DocContent.SelectionFont.Size);
        }

        public void SetFontSize(float FFontSize)
        {
            DocContent.SelectionFont = new Font(DocContent.SelectionFont.Name.ToString(), FFontSize);
        }
    }
}
