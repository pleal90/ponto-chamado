﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ponto_Chamados
{
    public partial class Ponto : Form
    {
        public Ponto()
        {
            InitializeComponent();
        }

        private void Ponto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pCDataSet1_PONTO.DGV_PONTO' table. You can move, or remove it, as needed.
            this.dGV_PONTOTableAdapter.Fill(this.pCDataSet1_PONTO.DGV_PONTO);

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            IniciarDia proj = new IniciarDia();
            proj.Show();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIncHor_Click(object sender, EventArgs e)
        {
            HORARIO horario = new HORARIO();
            horario.Show();
        }
    }
}
