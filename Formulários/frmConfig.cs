﻿using EditorTextos.Serviços;
using System.Data;

namespace EditorTextos
{
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
            FillFontCombobox();

            chUseMargins.Checked = Config.Settings().settings().UseMargins;
            chDetectURLS.Checked = Config.Settings().settings().DetectURLs;
            cbFontSize.SelectedIndex = cbFontSize.Items.IndexOf(Config.Settings().settings().DefaultFontSize.ToString());
            cbFont.SelectedIndex = cbFont.Items.IndexOf(Config.Settings().settings().DefaultFont);
            ZoomEdit.Value = Config.Settings().settings().Zoom;
        }

        private void FillFontCombobox()
        {
            IList<string> fontNames = FontFamily.Families.Select(f => f.Name).ToList();
            foreach (string fontName in fontNames)
            {
                cbFont.Items.Add(fontName);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbFontSize.Text))
            {
                MessageBox.Show("Não é possível salvar configurações sem informar ou selecionar tamanho padrão para fonte dos documentos", "Ocorreu um problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Config.Settings().settings().DetectURLs = chDetectURLS.Checked;
            Config.Settings().settings().UseMargins = chUseMargins.Checked;
            Config.Settings().settings().DefaultFont = cbFont.Text;
            Config.Settings().settings().DefaultFontSize = Convert.ToInt32(cbFontSize.Text);
            Config.Settings().settings().Zoom = Convert.ToInt32(ZoomEdit.Value);
            Config.Settings().SaveSettings();
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }


}
