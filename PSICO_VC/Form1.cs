using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PSICO_VC
{
    public partial class frmCadPaciente : Form
    {
        public frmCadPaciente()
        {
            InitializeComponent();

            cmbStatus.Items.Add("ATIVO");
            cmbStatus.Items.Add("INATIVO");
            cmbStatus.Items.Add("ALTA");

            cmbStatus.Text = "ATIVO";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente();

            paciente.Nome = txtNome.Text;

            paciente.CPF = txtCPF.Text;

            paciente.DataNascimento =
                dtDtNasc.Value;

            paciente.Status =
                cmbStatus.Text;

            MessageBox.Show(
                $"Nome: {paciente.Nome}\n" +
                $"CPF: {paciente.CPF}\n" +
                $"Status: {paciente.Status}"
            );
        }

        private void frmCadPaciente_Load(object sender, EventArgs e)
        {

        }
    }
}
