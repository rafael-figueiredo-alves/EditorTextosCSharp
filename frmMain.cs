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

        private FrmDoc? DocWindow()
        {
            if (ActiveMdiChild is FrmDoc Docs)
            {
                return Docs;
            }
            else
            {
                return null;
            }
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
            if (DocWindow() != null)
                DocWindow()!.SelectionAlignment(align);

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

            cbFont.Text = Documento.FontName();
            cbFontSize.Text = Documento.FontSize();
            Documento.ComboFont = cbFont;
            Documento.ComboSize = cbFontSize;
        }

        private void TimerControles_Tick(object sender, EventArgs e)
        {
            if (DocWindow() != null)
            {
                BtnSalvar.Enabled = DocWindow()!.Modified();
                BtnImprimir.Enabled = true;
                BtnCopiar.Enabled = true;
                BtnCortar.Enabled = true;
                BtnColar.Enabled = true;
                BtnDesfazer.Enabled = DocWindow()!.AbleUNDO();
                BtnRefazer.Enabled = DocWindow()!.AbleREDO();
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
                colarToolStripMenuItem.Enabled = DocWindow()!.AblePASTE();
                recortarToolStripMenuItem.Enabled = true;
                selecionarTudoToolStripMenuItem.Enabled = true;
                fecharTodosOsDocumentosToolStripMenuItem.Enabled = true;
                imprimirToolStripMenuItem.Enabled = true;

                BtnEsquerda.Checked = (DocWindow()!.DocAlignment() == HorizontalAlignment.Left);
                BtnCentro.Checked = (DocWindow()!.DocAlignment() == HorizontalAlignment.Center);
                BtnDireita.Checked = (DocWindow()!.DocAlignment() == HorizontalAlignment.Right);

                BtnNegrito.Checked = (DocWindow()!.IsBold());
                BtnItalico.Checked = (DocWindow()!.IsItalic());
                BtnSublinhar.Checked = (DocWindow()!.IsUnderline());
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

        private void FecharTodosOsDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in MdiChildren)
            {
                form.Close();
            }
        }

        private void CxPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                if (DocWindow()!.DocFind(cxPesquisa.Text) == -1)
                {
                    MessageBox.Show("Não foi possível encontrar nenhum resultado para a busca.");
                }
                cxPesquisa.Clear();
                DocWindow()!.DocFocus();
            }
        }

        private void BtnEsquerda_Click(object sender, EventArgs e)
        {
            AlignmentChanged(HorizontalAlignment.Left);
            DocWindow()!.DocFocus();
        }

        private void BtnCentro_Click(object sender, EventArgs e)
        {
            AlignmentChanged(HorizontalAlignment.Center);
            DocWindow()!.DocFocus();
        }

        private void BtnDireita_Click(object sender, EventArgs e)
        {
            AlignmentChanged(HorizontalAlignment.Right);
            DocWindow()!.DocFocus();
        }

        private void BtnNegrito_Click(object sender, EventArgs e)
        {
            DocWindow()!.SetBold();
        }

        private void BtnItalico_Click(object sender, EventArgs e)
        {
            DocWindow()!.SetItalic();
        }

        private void BtnSublinhar_Click(object sender, EventArgs e)
        {
            DocWindow()!.SetUnderline();
        }

        private void CbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DocWindow() != null)
            {
                DocWindow()!.SetFontName(cbFont.Text);
                DocWindow()!.DocFocus();
            }

        }

        private void CbFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DocWindow() != null)
            {
                DocWindow()!.SetFontSize(float.Parse(cbFontSize.Text));
                DocWindow()!.DocFocus();
            }
        }

        private void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDoc Documento = new()
            {
                MdiParent = this,
            };
            if (Documento.OpenDoc())
            {
                cbFont.Text = Documento.FontName();
                cbFontSize.Text = Documento.FontSize();
                Documento.ComboFont = cbFont;
                Documento.ComboSize = cbFontSize;
            }
        }

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocWindow()!.SaveDocAs();
        }
    }
}