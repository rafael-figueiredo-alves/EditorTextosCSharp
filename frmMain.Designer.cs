namespace EditorTextos
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            salvarToolStripMenuItem = new ToolStripMenuItem();
            salvarComoToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            MnuConfigImpressao = new ToolStripMenuItem();
            MnuVisualizarImpressao = new ToolStripMenuItem();
            imprimirToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            encerrarToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            desfazerToolStripMenuItem = new ToolStripMenuItem();
            refazerToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            copiarToolStripMenuItem = new ToolStripMenuItem();
            recortarToolStripMenuItem = new ToolStripMenuItem();
            colarToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripSeparator();
            selecionarTudoToolStripMenuItem = new ToolStripMenuItem();
            inserirToolStripMenuItem = new ToolStripMenuItem();
            MnuDataHora = new ToolStripMenuItem();
            dataEHoraCompletaToolStripMenuItem = new ToolStripMenuItem();
            apenasADataNoFormatoDDMMAAAAToolStripMenuItem = new ToolStripMenuItem();
            apenasAHoraToolStripMenuItem = new ToolStripMenuItem();
            MnuInserirImagem = new ToolStripMenuItem();
            formatarToolStripMenuItem = new ToolStripMenuItem();
            MnuFonte = new ToolStripMenuItem();
            Documentos = new ToolStripMenuItem();
            MnuMinimizarDocs = new ToolStripMenuItem();
            fecharTodosOsDocumentosToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            organizarDocumentosEmCascataToolStripMenuItem = new ToolStripMenuItem();
            MnuOrgDocHorizontal = new ToolStripMenuItem();
            organizarDocumentosVerticalmenteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            cxPesquisa = new ToolStripTextBox();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            menuSobre = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripSeparator();
            toolStrip1 = new ToolStrip();
            btnNovo = new ToolStripButton();
            BtnAbrir = new ToolStripButton();
            BtnSalvar = new ToolStripButton();
            BtnImprimir = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            BtnDesfazer = new ToolStripButton();
            BtnRefazer = new ToolStripButton();
            BtnCopiar = new ToolStripButton();
            BtnCortar = new ToolStripButton();
            BtnColar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            cbFont = new ToolStripComboBox();
            cbFontSize = new ToolStripComboBox();
            toolStripSeparator3 = new ToolStripSeparator();
            BtnNegrito = new ToolStripButton();
            BtnItalico = new ToolStripButton();
            BtnSublinhar = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            BtnEsquerda = new ToolStripButton();
            BtnCentro = new ToolStripButton();
            BtnDireita = new ToolStripButton();
            Dicas = new ToolTip(components);
            timerControles = new System.Windows.Forms.Timer(components);
            MnuVertical = new ToolStripMenuItem();
            toolStripMenuItem7 = new ToolStripSeparator();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, editarToolStripMenuItem, inserirToolStripMenuItem, formatarToolStripMenuItem, Documentos, cxPesquisa, ajudaToolStripMenuItem });
            menuStrip1.MdiWindowListItem = Documentos;
            menuStrip1.Name = "menuStrip1";
            menuStrip1.ShowItemToolTips = true;
            Dicas.SetToolTip(menuStrip1, resources.GetString("menuStrip1.ToolTip"));
            // 
            // arquivoToolStripMenuItem
            // 
            resources.ApplyResources(arquivoToolStripMenuItem, "arquivoToolStripMenuItem");
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem, abrirToolStripMenuItem, salvarToolStripMenuItem, salvarComoToolStripMenuItem, toolStripMenuItem1, MnuConfigImpressao, MnuVisualizarImpressao, imprimirToolStripMenuItem, toolStripMenuItem2, encerrarToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            // 
            // novoToolStripMenuItem
            // 
            resources.ApplyResources(novoToolStripMenuItem, "novoToolStripMenuItem");
            novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            novoToolStripMenuItem.Click += NovoToolStripMenuItem_Click;
            // 
            // abrirToolStripMenuItem
            // 
            resources.ApplyResources(abrirToolStripMenuItem, "abrirToolStripMenuItem");
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Click += AbrirToolStripMenuItem_Click;
            // 
            // salvarToolStripMenuItem
            // 
            resources.ApplyResources(salvarToolStripMenuItem, "salvarToolStripMenuItem");
            salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            salvarToolStripMenuItem.Click += BtnSalvar_Click;
            // 
            // salvarComoToolStripMenuItem
            // 
            resources.ApplyResources(salvarComoToolStripMenuItem, "salvarComoToolStripMenuItem");
            salvarComoToolStripMenuItem.Name = "salvarComoToolStripMenuItem";
            salvarComoToolStripMenuItem.Click += SalvarComoToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(toolStripMenuItem1, "toolStripMenuItem1");
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            // 
            // MnuConfigImpressao
            // 
            resources.ApplyResources(MnuConfigImpressao, "MnuConfigImpressao");
            MnuConfigImpressao.Name = "MnuConfigImpressao";
            MnuConfigImpressao.Click += MnuConfigImpressao_Click;
            // 
            // MnuVisualizarImpressao
            // 
            resources.ApplyResources(MnuVisualizarImpressao, "MnuVisualizarImpressao");
            MnuVisualizarImpressao.Name = "MnuVisualizarImpressao";
            MnuVisualizarImpressao.Click += MnuVisualizarImpressao_Click;
            // 
            // imprimirToolStripMenuItem
            // 
            resources.ApplyResources(imprimirToolStripMenuItem, "imprimirToolStripMenuItem");
            imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            imprimirToolStripMenuItem.Click += ImprimirToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            resources.ApplyResources(toolStripMenuItem2, "toolStripMenuItem2");
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            // 
            // encerrarToolStripMenuItem
            // 
            resources.ApplyResources(encerrarToolStripMenuItem, "encerrarToolStripMenuItem");
            encerrarToolStripMenuItem.Name = "encerrarToolStripMenuItem";
            encerrarToolStripMenuItem.Click += EncerrarToolStripMenuItem_Click;
            // 
            // editarToolStripMenuItem
            // 
            resources.ApplyResources(editarToolStripMenuItem, "editarToolStripMenuItem");
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { desfazerToolStripMenuItem, refazerToolStripMenuItem, toolStripMenuItem3, copiarToolStripMenuItem, recortarToolStripMenuItem, colarToolStripMenuItem, toolStripMenuItem4, selecionarTudoToolStripMenuItem });
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            // 
            // desfazerToolStripMenuItem
            // 
            resources.ApplyResources(desfazerToolStripMenuItem, "desfazerToolStripMenuItem");
            desfazerToolStripMenuItem.Name = "desfazerToolStripMenuItem";
            desfazerToolStripMenuItem.Click += BtnDesfazer_Click;
            // 
            // refazerToolStripMenuItem
            // 
            resources.ApplyResources(refazerToolStripMenuItem, "refazerToolStripMenuItem");
            refazerToolStripMenuItem.Name = "refazerToolStripMenuItem";
            refazerToolStripMenuItem.Click += BtnRefazer_Click;
            // 
            // toolStripMenuItem3
            // 
            resources.ApplyResources(toolStripMenuItem3, "toolStripMenuItem3");
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            // 
            // copiarToolStripMenuItem
            // 
            resources.ApplyResources(copiarToolStripMenuItem, "copiarToolStripMenuItem");
            copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            copiarToolStripMenuItem.Click += BtnCopiar_Click;
            // 
            // recortarToolStripMenuItem
            // 
            resources.ApplyResources(recortarToolStripMenuItem, "recortarToolStripMenuItem");
            recortarToolStripMenuItem.Name = "recortarToolStripMenuItem";
            recortarToolStripMenuItem.Click += BtnCortar_Click;
            // 
            // colarToolStripMenuItem
            // 
            resources.ApplyResources(colarToolStripMenuItem, "colarToolStripMenuItem");
            colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            colarToolStripMenuItem.Click += BtnColar_Click;
            // 
            // toolStripMenuItem4
            // 
            resources.ApplyResources(toolStripMenuItem4, "toolStripMenuItem4");
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            // 
            // selecionarTudoToolStripMenuItem
            // 
            resources.ApplyResources(selecionarTudoToolStripMenuItem, "selecionarTudoToolStripMenuItem");
            selecionarTudoToolStripMenuItem.Name = "selecionarTudoToolStripMenuItem";
            selecionarTudoToolStripMenuItem.Click += SelecionarTudoToolStripMenuItem_Click;
            // 
            // inserirToolStripMenuItem
            // 
            resources.ApplyResources(inserirToolStripMenuItem, "inserirToolStripMenuItem");
            inserirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MnuDataHora, MnuInserirImagem });
            inserirToolStripMenuItem.Name = "inserirToolStripMenuItem";
            // 
            // MnuDataHora
            // 
            resources.ApplyResources(MnuDataHora, "MnuDataHora");
            MnuDataHora.DropDownItems.AddRange(new ToolStripItem[] { dataEHoraCompletaToolStripMenuItem, apenasADataNoFormatoDDMMAAAAToolStripMenuItem, apenasAHoraToolStripMenuItem });
            MnuDataHora.Name = "MnuDataHora";
            // 
            // dataEHoraCompletaToolStripMenuItem
            // 
            resources.ApplyResources(dataEHoraCompletaToolStripMenuItem, "dataEHoraCompletaToolStripMenuItem");
            dataEHoraCompletaToolStripMenuItem.Name = "dataEHoraCompletaToolStripMenuItem";
            dataEHoraCompletaToolStripMenuItem.Click += MnuDataHora_Click;
            // 
            // apenasADataNoFormatoDDMMAAAAToolStripMenuItem
            // 
            resources.ApplyResources(apenasADataNoFormatoDDMMAAAAToolStripMenuItem, "apenasADataNoFormatoDDMMAAAAToolStripMenuItem");
            apenasADataNoFormatoDDMMAAAAToolStripMenuItem.Name = "apenasADataNoFormatoDDMMAAAAToolStripMenuItem";
            apenasADataNoFormatoDDMMAAAAToolStripMenuItem.Click += apenasADataNoFormatoDDMMAAAAToolStripMenuItem_Click;
            // 
            // apenasAHoraToolStripMenuItem
            // 
            resources.ApplyResources(apenasAHoraToolStripMenuItem, "apenasAHoraToolStripMenuItem");
            apenasAHoraToolStripMenuItem.Name = "apenasAHoraToolStripMenuItem";
            apenasAHoraToolStripMenuItem.Click += apenasAHoraToolStripMenuItem_Click;
            // 
            // MnuInserirImagem
            // 
            resources.ApplyResources(MnuInserirImagem, "MnuInserirImagem");
            MnuInserirImagem.Name = "MnuInserirImagem";
            MnuInserirImagem.Click += MnuInserirImagem_Click;
            // 
            // formatarToolStripMenuItem
            // 
            resources.ApplyResources(formatarToolStripMenuItem, "formatarToolStripMenuItem");
            formatarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MnuFonte });
            formatarToolStripMenuItem.Name = "formatarToolStripMenuItem";
            // 
            // MnuFonte
            // 
            resources.ApplyResources(MnuFonte, "MnuFonte");
            MnuFonte.Name = "MnuFonte";
            MnuFonte.Click += MnuFonte_Click;
            // 
            // Documentos
            // 
            resources.ApplyResources(Documentos, "Documentos");
            Documentos.DropDownItems.AddRange(new ToolStripItem[] { MnuMinimizarDocs, fecharTodosOsDocumentosToolStripMenuItem, toolStripSeparator5, organizarDocumentosEmCascataToolStripMenuItem, MnuOrgDocHorizontal, organizarDocumentosVerticalmenteToolStripMenuItem, toolStripSeparator6 });
            Documentos.Name = "Documentos";
            // 
            // MnuMinimizarDocs
            // 
            resources.ApplyResources(MnuMinimizarDocs, "MnuMinimizarDocs");
            MnuMinimizarDocs.Name = "MnuMinimizarDocs";
            MnuMinimizarDocs.Click += MnuMinimizarDocs_Click;
            // 
            // fecharTodosOsDocumentosToolStripMenuItem
            // 
            resources.ApplyResources(fecharTodosOsDocumentosToolStripMenuItem, "fecharTodosOsDocumentosToolStripMenuItem");
            fecharTodosOsDocumentosToolStripMenuItem.Name = "fecharTodosOsDocumentosToolStripMenuItem";
            fecharTodosOsDocumentosToolStripMenuItem.Click += FecharTodosOsDocumentosToolStripMenuItem_Click;
            // 
            // toolStripSeparator5
            // 
            resources.ApplyResources(toolStripSeparator5, "toolStripSeparator5");
            toolStripSeparator5.Name = "toolStripSeparator5";
            // 
            // organizarDocumentosEmCascataToolStripMenuItem
            // 
            resources.ApplyResources(organizarDocumentosEmCascataToolStripMenuItem, "organizarDocumentosEmCascataToolStripMenuItem");
            organizarDocumentosEmCascataToolStripMenuItem.Name = "organizarDocumentosEmCascataToolStripMenuItem";
            organizarDocumentosEmCascataToolStripMenuItem.Click += OrganizarDocumentosEmCascataToolStripMenuItem_Click;
            // 
            // MnuOrgDocHorizontal
            // 
            resources.ApplyResources(MnuOrgDocHorizontal, "MnuOrgDocHorizontal");
            MnuOrgDocHorizontal.Name = "MnuOrgDocHorizontal";
            MnuOrgDocHorizontal.Click += MnuOrgDocHorizontal_Click;
            // 
            // organizarDocumentosVerticalmenteToolStripMenuItem
            // 
            resources.ApplyResources(organizarDocumentosVerticalmenteToolStripMenuItem, "organizarDocumentosVerticalmenteToolStripMenuItem");
            organizarDocumentosVerticalmenteToolStripMenuItem.Name = "organizarDocumentosVerticalmenteToolStripMenuItem";
            organizarDocumentosVerticalmenteToolStripMenuItem.Click += OrganizarDocumentosVerticalmenteToolStripMenuItem_Click;
            // 
            // toolStripSeparator6
            // 
            resources.ApplyResources(toolStripSeparator6, "toolStripSeparator6");
            toolStripSeparator6.Name = "toolStripSeparator6";
            // 
            // cxPesquisa
            // 
            resources.ApplyResources(cxPesquisa, "cxPesquisa");
            cxPesquisa.Alignment = ToolStripItemAlignment.Right;
            cxPesquisa.AutoToolTip = true;
            cxPesquisa.BorderStyle = BorderStyle.FixedSingle;
            cxPesquisa.Margin = new Padding(5, 1, 10, 1);
            cxPesquisa.Name = "cxPesquisa";
            cxPesquisa.Overflow = ToolStripItemOverflow.Never;
            cxPesquisa.Enter += CxPesquisa_Enter;
            cxPesquisa.Leave += CxPesquisa_Leave;
            cxPesquisa.KeyPress += CxPesquisa_KeyPress;
            // 
            // ajudaToolStripMenuItem
            // 
            resources.ApplyResources(ajudaToolStripMenuItem, "ajudaToolStripMenuItem");
            ajudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuSobre });
            ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            // 
            // menuSobre
            // 
            resources.ApplyResources(menuSobre, "menuSobre");
            menuSobre.Name = "menuSobre";
            menuSobre.Click += MenuSobre_Click;
            // 
            // toolStripMenuItem5
            // 
            resources.ApplyResources(toolStripMenuItem5, "toolStripMenuItem5");
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            // 
            // toolStrip1
            // 
            resources.ApplyResources(toolStrip1, "toolStrip1");
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnNovo, BtnAbrir, BtnSalvar, BtnImprimir, toolStripSeparator1, BtnDesfazer, BtnRefazer, BtnCopiar, BtnCortar, BtnColar, toolStripSeparator2, cbFont, cbFontSize, toolStripSeparator3, BtnNegrito, BtnItalico, BtnSublinhar, toolStripSeparator4, BtnEsquerda, BtnCentro, BtnDireita });
            toolStrip1.Name = "toolStrip1";
            Dicas.SetToolTip(toolStrip1, resources.GetString("toolStrip1.ToolTip"));
            // 
            // btnNovo
            // 
            resources.ApplyResources(btnNovo, "btnNovo");
            btnNovo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnNovo.Image = Properties.Resources.icons8_new_16;
            btnNovo.Name = "btnNovo";
            btnNovo.Click += NovoToolStripMenuItem_Click;
            // 
            // BtnAbrir
            // 
            resources.ApplyResources(BtnAbrir, "BtnAbrir");
            BtnAbrir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BtnAbrir.Image = Properties.Resources.icons8_open_16;
            BtnAbrir.Name = "BtnAbrir";
            BtnAbrir.Click += AbrirToolStripMenuItem_Click;
            // 
            // BtnSalvar
            // 
            resources.ApplyResources(BtnSalvar, "BtnSalvar");
            BtnSalvar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BtnSalvar.Image = Properties.Resources.icons8_save_close_16;
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // BtnImprimir
            // 
            resources.ApplyResources(BtnImprimir, "BtnImprimir");
            BtnImprimir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BtnImprimir.Image = Properties.Resources.icons8_send_to_printer_16;
            BtnImprimir.Name = "BtnImprimir";
            BtnImprimir.Click += ImprimirToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(toolStripSeparator1, "toolStripSeparator1");
            toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // BtnDesfazer
            // 
            resources.ApplyResources(BtnDesfazer, "BtnDesfazer");
            BtnDesfazer.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BtnDesfazer.Image = Properties.Resources.icons8_undo_16;
            BtnDesfazer.Name = "BtnDesfazer";
            BtnDesfazer.Click += BtnDesfazer_Click;
            // 
            // BtnRefazer
            // 
            resources.ApplyResources(BtnRefazer, "BtnRefazer");
            BtnRefazer.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BtnRefazer.Image = Properties.Resources.icons8_redo_16;
            BtnRefazer.Name = "BtnRefazer";
            BtnRefazer.Click += BtnRefazer_Click;
            // 
            // BtnCopiar
            // 
            resources.ApplyResources(BtnCopiar, "BtnCopiar");
            BtnCopiar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BtnCopiar.Image = Properties.Resources.icons8_copy_16;
            BtnCopiar.Name = "BtnCopiar";
            BtnCopiar.Click += BtnCopiar_Click;
            // 
            // BtnCortar
            // 
            resources.ApplyResources(BtnCortar, "BtnCortar");
            BtnCortar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BtnCortar.Image = Properties.Resources.icons8_cut_16;
            BtnCortar.Name = "BtnCortar";
            BtnCortar.Click += BtnCortar_Click;
            // 
            // BtnColar
            // 
            resources.ApplyResources(BtnColar, "BtnColar");
            BtnColar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BtnColar.Image = Properties.Resources.icons8_paste_16;
            BtnColar.Name = "BtnColar";
            BtnColar.Click += BtnColar_Click;
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(toolStripSeparator2, "toolStripSeparator2");
            toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // cbFont
            // 
            resources.ApplyResources(cbFont, "cbFont");
            cbFont.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFont.DropDownWidth = 265;
            cbFont.Name = "cbFont";
            cbFont.SelectedIndexChanged += CbFont_SelectedIndexChanged;
            // 
            // cbFontSize
            // 
            resources.ApplyResources(cbFontSize, "cbFontSize");
            cbFontSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFontSize.Items.AddRange(new object[] { resources.GetString("cbFontSize.Items"), resources.GetString("cbFontSize.Items1"), resources.GetString("cbFontSize.Items2"), resources.GetString("cbFontSize.Items3"), resources.GetString("cbFontSize.Items4"), resources.GetString("cbFontSize.Items5"), resources.GetString("cbFontSize.Items6"), resources.GetString("cbFontSize.Items7"), resources.GetString("cbFontSize.Items8"), resources.GetString("cbFontSize.Items9"), resources.GetString("cbFontSize.Items10"), resources.GetString("cbFontSize.Items11"), resources.GetString("cbFontSize.Items12"), resources.GetString("cbFontSize.Items13") });
            cbFontSize.Name = "cbFontSize";
            cbFontSize.SelectedIndexChanged += CbFontSize_SelectedIndexChanged;
            // 
            // toolStripSeparator3
            // 
            resources.ApplyResources(toolStripSeparator3, "toolStripSeparator3");
            toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // BtnNegrito
            // 
            resources.ApplyResources(BtnNegrito, "BtnNegrito");
            BtnNegrito.CheckOnClick = true;
            BtnNegrito.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BtnNegrito.Image = Properties.Resources.icons8_bold_16;
            BtnNegrito.Name = "BtnNegrito";
            BtnNegrito.Click += BtnNegrito_Click;
            // 
            // BtnItalico
            // 
            resources.ApplyResources(BtnItalico, "BtnItalico");
            BtnItalico.CheckOnClick = true;
            BtnItalico.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BtnItalico.Image = Properties.Resources.icons8_italic_16;
            BtnItalico.Name = "BtnItalico";
            BtnItalico.Click += BtnItalico_Click;
            // 
            // BtnSublinhar
            // 
            resources.ApplyResources(BtnSublinhar, "BtnSublinhar");
            BtnSublinhar.CheckOnClick = true;
            BtnSublinhar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BtnSublinhar.Image = Properties.Resources.icons8_underline_16;
            BtnSublinhar.Name = "BtnSublinhar";
            BtnSublinhar.Click += BtnSublinhar_Click;
            // 
            // toolStripSeparator4
            // 
            resources.ApplyResources(toolStripSeparator4, "toolStripSeparator4");
            toolStripSeparator4.Name = "toolStripSeparator4";
            // 
            // BtnEsquerda
            // 
            resources.ApplyResources(BtnEsquerda, "BtnEsquerda");
            BtnEsquerda.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BtnEsquerda.Image = Properties.Resources.icons8_align_16__1_;
            BtnEsquerda.Name = "BtnEsquerda";
            BtnEsquerda.Click += BtnEsquerda_Click;
            // 
            // BtnCentro
            // 
            resources.ApplyResources(BtnCentro, "BtnCentro");
            BtnCentro.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BtnCentro.Image = Properties.Resources.icons8_center_16;
            BtnCentro.Name = "BtnCentro";
            BtnCentro.Click += BtnCentro_Click;
            // 
            // BtnDireita
            // 
            resources.ApplyResources(BtnDireita, "BtnDireita");
            BtnDireita.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BtnDireita.Image = Properties.Resources.icons8_align_16;
            BtnDireita.Name = "BtnDireita";
            BtnDireita.Click += BtnDireita_Click;
            // 
            // Dicas
            // 
            Dicas.IsBalloon = true;
            Dicas.ToolTipIcon = ToolTipIcon.Info;
            Dicas.ToolTipTitle = "Dica:";
            // 
            // timerControles
            // 
            timerControles.Interval = 1;
            timerControles.Tick += TimerControles_Tick;
            // 
            // MnuVertical
            // 
            resources.ApplyResources(MnuVertical, "MnuVertical");
            MnuVertical.Name = "MnuVertical";
            // 
            // toolStripMenuItem7
            // 
            resources.ApplyResources(toolStripMenuItem7, "toolStripMenuItem7");
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            // 
            // FrmMain
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmMain";
            Dicas.SetToolTip(this, resources.GetString("$this.ToolTip"));
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem novoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem salvarToolStripMenuItem;
        private ToolStripMenuItem salvarComoToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem imprimirToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem encerrarToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem desfazerToolStripMenuItem;
        private ToolStripMenuItem refazerToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem copiarToolStripMenuItem;
        private ToolStripMenuItem recortarToolStripMenuItem;
        private ToolStripMenuItem colarToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem selecionarTudoToolStripMenuItem;
        private ToolStripMenuItem inserirToolStripMenuItem;
        private ToolStripMenuItem formatarToolStripMenuItem;
        private ToolStripTextBox cxPesquisa;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem menuSobre;
        private ToolStrip toolStrip1;
        private ToolStripButton btnNovo;
        private ToolStripButton BtnAbrir;
        private ToolStripButton BtnSalvar;
        private ToolStripButton BtnImprimir;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton BtnDesfazer;
        private ToolStripButton BtnRefazer;
        private ToolStripButton BtnCopiar;
        private ToolStripButton BtnCortar;
        private ToolStripButton BtnColar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripComboBox cbFont;
        private ToolStripComboBox cbFontSize;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton BtnNegrito;
        private ToolStripButton BtnItalico;
        private ToolStripButton BtnSublinhar;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton BtnEsquerda;
        private ToolStripButton BtnCentro;
        private ToolStripButton BtnDireita;
        private ToolTip Dicas;
        private System.Windows.Forms.Timer timerControles;
        private ToolStripMenuItem Documentos;
        private ToolStripMenuItem fecharTodosOsDocumentosToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem9;
        private ToolStripMenuItem toolStripMenuItem8;
        private ToolStripMenuItem organizarDocumentosHorizontalmenteToolStripMenuItem;
        private ToolStripMenuItem MnuVertical;
        private ToolStripSeparator toolStripMenuItem7;
        private ToolStripMenuItem MnuDataHora;
        private ToolStripMenuItem MnuInserirImagem;
        private ToolStripMenuItem MnuFonte;
        private ToolStripMenuItem MnuMinimizarDocs;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem organizarDocumentosEmCascataToolStripMenuItem;
        private ToolStripMenuItem MnuOrgDocHorizontal;
        private ToolStripMenuItem organizarDocumentosVerticalmenteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem MnuConfigImpressao;
        private ToolStripMenuItem MnuVisualizarImpressao;
        private ToolStripMenuItem dataEHoraCompletaToolStripMenuItem;
        private ToolStripMenuItem apenasADataNoFormatoDDMMAAAAToolStripMenuItem;
        private ToolStripMenuItem apenasAHoraToolStripMenuItem;
    }
}