﻿using System;
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
	public partial class FrmAbout : Form
	{
		public FrmAbout()
		{
			InitializeComponent();
		}

		private void btnFechar_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
