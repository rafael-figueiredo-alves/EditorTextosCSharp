using System.Windows.Forms;

namespace EditorTextos
{
    public partial class FrmMain : Form
    {
        private int Docs = 1;
        public FrmMain()
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
            FrmDoc Documento = new(Docs)
            {
                MdiParent = this
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
                desfazerToolStripMenuItem.Enabled = DocWindow()!.AbleUNDO();
                refazerToolStripMenuItem.Enabled = DocWindow()!.AbleREDO();
                copiarToolStripMenuItem.Enabled = true;
                colarToolStripMenuItem.Enabled = DocWindow()!.AblePASTE();
                InsMarcadores.Enabled = true;
                recortarToolStripMenuItem.Enabled = true;
                selecionarTudoToolStripMenuItem.Enabled = true;
                fecharTodosOsDocumentosToolStripMenuItem.Enabled = true;
                imprimirToolStripMenuItem.Enabled = true;
                salvarToolStripMenuItem.Enabled = DocWindow()!.Modified();
                MnuInserirImagem.Enabled = true;
                MnuFonte.Enabled = true;
                MnuDataHora.Enabled = true;
                MnuMinimizarDocs.Enabled = true;
                organizarDocumentosEmCascataToolStripMenuItem.Enabled = true;
                MnuOrgDocHorizontal.Enabled = true;
                organizarDocumentosVerticalmenteToolStripMenuItem.Enabled = true;
                MnuConfigImpressao.Enabled = true;
                MnuVisualizarImpressao.Enabled = true;
                imprimirToolStripMenuItem.Enabled = true;
                MnuAumentarZoom.Enabled = DocWindow()!.CanIncreaseZoom();
                DiminuirZoomToolStripMenuItem.Enabled = DocWindow()!.CanDecreaseZoom();
                substituirToolStripMenuItem.Visible = true;
                localizarToolStripMenuItem.Visible = true;
                Documentos.Visible = true;
                statusBar.Visible = true;

                stLinha.Text = "Linha: " + DocWindow()!.GetLinha().ToString();
                stColuna.Text = "Coluna: " + DocWindow()!.GetColuna().ToString();
                stZoomFactor.Text = "Fator de Zoom: " + DocWindow()!.ZoomFactor().ToString() + "x";

                BtnEsquerda.Checked = (DocWindow()!.DocAlignment() == HorizontalAlignment.Left);
                BtnCentro.Checked = (DocWindow()!.DocAlignment() == HorizontalAlignment.Center);
                BtnDireita.Checked = (DocWindow()!.DocAlignment() == HorizontalAlignment.Right);

                BtnNegrito.Checked = (DocWindow()!.IsBold());
                BtnItalico.Checked = (DocWindow()!.IsItalic());
                BtnSublinhar.Checked = (DocWindow()!.IsUnderline());
                InsMarcadores.Checked = (DocWindow()!.usingBullets());
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
                InsMarcadores.Enabled = false;
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
                MnuInserirImagem.Enabled = false;
                MnuFonte.Enabled = false;
                MnuDataHora.Enabled = false;
                MnuMinimizarDocs.Enabled = false;
                organizarDocumentosEmCascataToolStripMenuItem.Enabled = false;
                organizarDocumentosVerticalmenteToolStripMenuItem.Enabled = false;
                MnuOrgDocHorizontal.Enabled = false;
                MnuConfigImpressao.Enabled = false;
                MnuVisualizarImpressao.Enabled = false;
                imprimirToolStripMenuItem.Enabled = false;
                MnuAumentarZoom.Enabled = false;
                DiminuirZoomToolStripMenuItem.Enabled = false;
                Documentos.Visible = false;
                statusBar.Visible = false;
                substituirToolStripMenuItem.Visible = false;
                localizarToolStripMenuItem.Visible = false;
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
            DocWindow()!.DocFocus();
        }

        private void BtnItalico_Click(object sender, EventArgs e)
        {
            DocWindow()!.SetItalic();
            DocWindow()!.DocFocus();
        }

        private void BtnSublinhar_Click(object sender, EventArgs e)
        {
            DocWindow()!.SetUnderline();
            DocWindow()!.DocFocus();
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

        private void SalvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocWindow()!.SaveDocAs();
        }

        private void MnuMinimizarDocs_Click(object sender, EventArgs e)
        {
            foreach (Form form in MdiChildren)
            {
                form.WindowState = FormWindowState.Minimized;
            }
        }

        private void OrganizarDocumentosEmCascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void MnuOrgDocHorizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void OrganizarDocumentosVerticalmenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            DocWindow()!.SaveDoc();
        }

        private void MnuInserirImagem_Click(object sender, EventArgs e)
        {
            DocWindow()!.InsertImage();
        }

        private void MnuDataHora_Click(object sender, EventArgs e)
        {
            DocWindow()!.InsertDateTime();
        }

        private void MnuFonte_Click(object sender, EventArgs e)
        {
            DocWindow()!.FormatFont();
        }

        private void BtnDesfazer_Click(object sender, EventArgs e)
        {
            DocWindow()!.DocUndo();
        }

        private void BtnRefazer_Click(object sender, EventArgs e)
        {
            DocWindow()!.DocRedo();
        }

        private void BtnCopiar_Click(object sender, EventArgs e)
        {
            DocWindow()!.DocCopy();
        }

        private void BtnCortar_Click(object sender, EventArgs e)
        {
            DocWindow()!.DocCut();
        }

        private void BtnColar_Click(object sender, EventArgs e)
        {
            DocWindow()!.DocPaste();
        }

        private void SelecionarTudoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocWindow()!.DocSelectAll();
        }

        private void MnuConfigImpressao_Click(object sender, EventArgs e)
        {
            DocWindow()!.SetPrinter();
        }

        private void MnuVisualizarImpressao_Click(object sender, EventArgs e)
        {
            DocWindow()!.PreviewPrint();
        }

        private void ImprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocWindow()!.PrintDoc();
        }

        private void ApenasADataNoFormatoDDMMAAAAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocWindow()!.InsertSimpleDate();
        }

        private void ApenasAHoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocWindow()!.InsertTime();
        }

        private void MnuAumentarZoom_Click(object sender, EventArgs e)
        {
            DocWindow()!.IncreaseZoom();
        }

        private void DiminuirZoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocWindow()!.DecreaseZoom();
        }

        private void InsMarcadores_Click(object sender, EventArgs e)
        {
            DocWindow()!.SetBullets();
            DocWindow()!.DocFocus();
        }

        private void localizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cxPesquisa.Focus();
        }

        private void substituirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlgReplace frmReplace = new dlgReplace();
            frmReplace.Left = this.Left + (this.Width - frmReplace.Width) - 10;
            frmReplace.Top = this.Top + (this.Height - frmReplace.Height) - 10;
            frmReplace.btnSubstituir.Click += (s, e) =>
            {
                DocWindow()!.ReplaceText(frmReplace.textFrom.Text, frmReplace.textTo.Text);
                DocWindow()!.DocFocus();
            };
            frmReplace.btnSubstituirTudo.Click += (s, e) =>
            {
                DocWindow()!.ReplaceText(frmReplace.textFrom.Text, frmReplace.textTo.Text, true);
                DocWindow()!.DocFocus();
            };
            frmReplace.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frmConfig formConfig = new frmConfig();
            formConfig.ShowDialog();
        }
    }
}