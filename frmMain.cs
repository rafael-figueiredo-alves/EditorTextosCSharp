using System.Runtime.CompilerServices;

namespace EditorTextos
{
    public partial class frmMain : Form
    {
        private int Docs = 1;
        public frmMain()
        {
            InitializeComponent();

            FillFontCombobox();
            cbFont.SelectedIndex = 0;
            cbFontSize.SelectedIndex = 0;
        }

        private RichTextBox? DocWindow()
        {
            if (ActiveMdiChild is FrmDoc Docs)
            {
                return Docs.DocContent;
            }
            else
            {
                return null;
            }
        }

        private void FillFontSizeCombobox()
        {
            IList<string> fontNames = FontFamily.Families.Select(f => f.Name).ToList();

        }

        private void FillFontCombobox()
        {
            IList<string> fontNames = FontFamily.Families.Select(f => f.Name).ToList();
            foreach (string fontName in fontNames)
            {
                cbFont.Items.Add(fontName);
            }
        }


        private void CxPesquisa_Enter(object sender, EventArgs e)
        {
            if (cxPesquisa.Text == "Pesquisar...")
            {
                cxPesquisa.Clear();
            }
        }

        private void CxPesquisa_Leave(object sender, EventArgs e)
        {
            if (cxPesquisa.Text == string.Empty || cxPesquisa.Text == null)
            {
                cxPesquisa.Text = "Pesquisar...";
            }
        }

        private void MenuSobre_Click(object sender, EventArgs e)
        {
            FrmAbout formAbout = new();
            _ = formAbout.ShowDialog();
        }

        private void EncerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AlignmentChanged(HorizontalAlignment align)
        {
            DocWindow()!.SelectionAlignment = align;

            BtnEsquerda.Checked = align == HorizontalAlignment.Left;
            BtnCentro.Checked = align == HorizontalAlignment.Center;
            BtnDireita.Checked = align == HorizontalAlignment.Right;
        }

        private void NovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDoc Documento = new()
            {
                MdiParent = this,
                Text = "Sem Título " + Docs.ToString()
            };
            Documento.Show();
            Docs++;

            cbFont.Text = Documento.DocContent.Font.Name.ToString();
            cbFontSize.Text = Documento.DocContent.Font.Size.ToString();
        }

        private void TimerControles_Tick(object sender, EventArgs e)
        {
            if (DocWindow() != null)
            {
                BtnSalvar.Enabled = DocWindow()!.Modified;
                BtnImprimir.Enabled = true;
                BtnCopiar.Enabled = true;
                BtnCortar.Enabled = true;
                BtnColar.Enabled = true;
                BtnDesfazer.Enabled = DocWindow()!.CanUndo;
                BtnRefazer.Enabled = DocWindow()!.CanRedo;
                cbFont.Enabled = true;
                cbFontSize.Enabled = true;
                BtnNegrito.Enabled = true;
                BtnItalico.Enabled = true;
                BtnSublinhar.Enabled = true;
                BtnEsquerda.Enabled = true;
                BtnCentro.Enabled = true;
                BtnDireita.Enabled = true;
                cxPesquisa.Enabled = true;
                salvarComoToolStripMenuItem.Enabled = true;
                salvarToolStripMenuItem.Enabled = true;
                desfazerToolStripMenuItem.Enabled = true;
                refazerToolStripMenuItem.Enabled = true;
                copiarToolStripMenuItem.Enabled = true;
                colarToolStripMenuItem.Enabled = true;
                recortarToolStripMenuItem.Enabled = true;
                selecionarTudoToolStripMenuItem.Enabled = true;
                fecharTodosOsDocumentosToolStripMenuItem.Enabled = true;
                imprimirToolStripMenuItem.Enabled = true;
                BtnEsquerda.Checked = (DocWindow()!.SelectionAlignment == HorizontalAlignment.Left);
                BtnCentro.Checked = (DocWindow()!.SelectionAlignment == HorizontalAlignment.Center);
                BtnDireita.Checked = (DocWindow()!.SelectionAlignment == HorizontalAlignment.Right);
            }
            else
            {
                BtnSalvar.Enabled = false;
                BtnImprimir.Enabled = false;
                BtnCopiar.Enabled = false;
                BtnCortar.Enabled = false;
                BtnColar.Enabled = false;
                BtnDesfazer.Enabled = false;
                BtnRefazer.Enabled = false;
                cbFont.Enabled = false;
                cbFontSize.Enabled = false;
                BtnNegrito.Enabled = false;
                BtnItalico.Enabled = false;
                BtnSublinhar.Enabled = false;
                BtnEsquerda.Enabled = false;
                BtnCentro.Enabled = false;
                BtnDireita.Enabled = false;
                cxPesquisa.Enabled = false;
                salvarComoToolStripMenuItem.Enabled = false;
                salvarToolStripMenuItem.Enabled = false;
                desfazerToolStripMenuItem.Enabled = false;
                refazerToolStripMenuItem.Enabled = false;
                copiarToolStripMenuItem.Enabled = false;
                colarToolStripMenuItem.Enabled = false;
                recortarToolStripMenuItem.Enabled = false;
                selecionarTudoToolStripMenuItem.Enabled = false;
                fecharTodosOsDocumentosToolStripMenuItem.Enabled = false;
                imprimirToolStripMenuItem.Enabled = false;
            }
        }

        private void fecharTodosOsDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in MdiChildren)
            {
                form.Close();
            }
        }

        private void cxPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                if (DocWindow()!.Find(cxPesquisa.Text) == -1)
                {
                    MessageBox.Show("Não foi possível encontrar nenhum resultado para a busca.");
                }
                cxPesquisa.Clear();
                DocWindow()!.Focus();
            }
        }

        private void BtnEsquerda_Click(object sender, EventArgs e)
        {
            AlignmentChanged(HorizontalAlignment.Left);
            DocWindow()!.Focus();
        }

        private void BtnCentro_Click(object sender, EventArgs e)
        {
            AlignmentChanged(HorizontalAlignment.Center);
            DocWindow()!.Focus();
        }

        private void BtnDireita_Click(object sender, EventArgs e)
        {
            AlignmentChanged(HorizontalAlignment.Right);
            DocWindow()!.Focus();
        }

        private void BtnNegrito_Click(object sender, EventArgs e)
        {
            if (BtnNegrito.Checked)
            {
                DocWindow()!.SelectionFont = new Font(DocWindow()!.SelectionFont, DocWindow()!.SelectionFont.Style | FontStyle.Bold);
            }
            else
            {
                DocWindow().SelectionFont = new Font(DocWindow()!.SelectionFont, DocWindow()!.SelectionFont.Style & FontStyle.Bold);
            }
        }

        private void BtnItalico_Click(object sender, EventArgs e)
        {
            if (BtnItalico.Checked)
            {
                DocWindow()!.SelectionFont = new Font(DocWindow()!.SelectionFont, DocWindow()!.SelectionFont.Style | FontStyle.Italic);
            }
            else
            {
                DocWindow().SelectionFont = new Font(DocWindow()!.SelectionFont, DocWindow()!.SelectionFont.Style & FontStyle.Italic);
            }
        }
    }
}