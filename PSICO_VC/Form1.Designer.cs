namespace PSICO_VC
{
    partial class frmCadPaciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNome = new Label();
            txtNome = new TextBox();
            lblCPF = new Label();
            lblDtNasc = new Label();
            dtDtNasc = new DateTimePicker();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            btnSalvar = new Button();
            txtCPF = new MaskedTextBox();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(48, 27);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(53, 20);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(216, 31);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(572, 27);
            txtNome.TabIndex = 1;
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(48, 71);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(36, 20);
            lblCPF.TabIndex = 2;
            lblCPF.Text = "CPF:";
            lblCPF.Click += label1_Click;
            // 
            // lblDtNasc
            // 
            lblDtNasc.AutoSize = true;
            lblDtNasc.Location = new Point(48, 104);
            lblDtNasc.Name = "lblDtNasc";
            lblDtNasc.Size = new Size(148, 20);
            lblDtNasc.TabIndex = 4;
            lblDtNasc.Text = "Data de Nascimento:";
            lblDtNasc.Click += label1_Click_1;
            // 
            // dtDtNasc
            // 
            dtDtNasc.Format = DateTimePickerFormat.Short;
            dtDtNasc.Location = new Point(216, 104);
            dtDtNasc.Name = "dtDtNasc";
            dtDtNasc.Size = new Size(117, 27);
            dtDtNasc.TabIndex = 5;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(48, 149);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(52, 20);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Status:";
            lblStatus.Click += label1_Click_2;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(216, 149);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(151, 28);
            cmbStatus.TabIndex = 7;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(75, 219);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(156, 56);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(217, 64);
            txtCPF.Mask = "000.000.000-00";
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(150, 27);
            txtCPF.TabIndex = 9;
            // 
            // frmCadPaciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCPF);
            Controls.Add(btnSalvar);
            Controls.Add(cmbStatus);
            Controls.Add(lblStatus);
            Controls.Add(dtDtNasc);
            Controls.Add(lblDtNasc);
            Controls.Add(lblCPF);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Name = "frmCadPaciente";
            Text = "Cadastro do Paciente";
            Load += frmCadPaciente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private Label lblCPF;
        private Label lblDtNasc;
        private DateTimePicker dtDtNasc;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private Button btnSalvar;
        private MaskedTextBox txtCPF;
    }
}