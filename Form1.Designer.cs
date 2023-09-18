
namespace Pergunta_002_003_BeeViral_desk
{
  partial class Form1
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      this.pnnNovaPessoa = new System.Windows.Forms.Panel();
      this.TxtIdade = new System.Windows.Forms.NumericUpDown();
      this.BttSalvar = new System.Windows.Forms.Button();
      this.BttCancelar = new System.Windows.Forms.Button();
      this.TxtEmail = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.TxtNome = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.PnnTodasPessoas = new System.Windows.Forms.Panel();
      this.DtPessoas = new System.Windows.Forms.DataGridView();
      this.ClmNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ClmIdade = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ClmRemover = new System.Windows.Forms.DataGridViewButtonColumn();
      this.panel2 = new System.Windows.Forms.Panel();
      this.BttImprimir = new System.Windows.Forms.Button();
      this.BttCadastrar = new System.Windows.Forms.Button();
      this.BttFiltraDados = new System.Windows.Forms.Button();
      this.label8 = new System.Windows.Forms.Label();
      this.pnnNovaPessoa.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.TxtIdade)).BeginInit();
      this.PnnTodasPessoas.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.DtPessoas)).BeginInit();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnnNovaPessoa
      // 
      this.pnnNovaPessoa.Controls.Add(this.TxtIdade);
      this.pnnNovaPessoa.Controls.Add(this.BttSalvar);
      this.pnnNovaPessoa.Controls.Add(this.BttCancelar);
      this.pnnNovaPessoa.Controls.Add(this.TxtEmail);
      this.pnnNovaPessoa.Controls.Add(this.label4);
      this.pnnNovaPessoa.Controls.Add(this.label3);
      this.pnnNovaPessoa.Controls.Add(this.TxtNome);
      this.pnnNovaPessoa.Controls.Add(this.label2);
      this.pnnNovaPessoa.Controls.Add(this.label1);
      this.pnnNovaPessoa.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnnNovaPessoa.Location = new System.Drawing.Point(0, 0);
      this.pnnNovaPessoa.Name = "pnnNovaPessoa";
      this.pnnNovaPessoa.Size = new System.Drawing.Size(847, 193);
      this.pnnNovaPessoa.TabIndex = 1;
      this.pnnNovaPessoa.Visible = false;
      // 
      // TxtIdade
      // 
      this.TxtIdade.Location = new System.Drawing.Point(545, 61);
      this.TxtIdade.Name = "TxtIdade";
      this.TxtIdade.Size = new System.Drawing.Size(150, 27);
      this.TxtIdade.TabIndex = 1;
      this.TxtIdade.ValueChanged += new System.EventHandler(this.TxtIdade_ValueChanged);
      // 
      // BttSalvar
      // 
      this.BttSalvar.Enabled = false;
      this.BttSalvar.Location = new System.Drawing.Point(501, 143);
      this.BttSalvar.Name = "BttSalvar";
      this.BttSalvar.Size = new System.Drawing.Size(94, 29);
      this.BttSalvar.TabIndex = 3;
      this.BttSalvar.Text = "Salvar";
      this.BttSalvar.UseVisualStyleBackColor = true;
      this.BttSalvar.Click += new System.EventHandler(this.BttSalvar_Click);
      // 
      // BttCancelar
      // 
      this.BttCancelar.Location = new System.Drawing.Point(601, 143);
      this.BttCancelar.Name = "BttCancelar";
      this.BttCancelar.Size = new System.Drawing.Size(94, 29);
      this.BttCancelar.TabIndex = 4;
      this.BttCancelar.Text = "Cancelar";
      this.BttCancelar.UseVisualStyleBackColor = true;
      this.BttCancelar.Click += new System.EventHandler(this.BttCancelar_Click);
      // 
      // TxtEmail
      // 
      this.TxtEmail.Location = new System.Drawing.Point(213, 94);
      this.TxtEmail.Name = "TxtEmail";
      this.TxtEmail.Size = new System.Drawing.Size(482, 27);
      this.TxtEmail.TabIndex = 2;
      this.TxtEmail.TextChanged += new System.EventHandler(this.TxtEmail_TextChanged);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(134, 97);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(52, 20);
      this.label4.TabIndex = 5;
      this.label4.Text = "E-mail";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(492, 64);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(47, 20);
      this.label3.TabIndex = 4;
      this.label3.Text = "Idade";
      // 
      // TxtNome
      // 
      this.TxtNome.Location = new System.Drawing.Point(213, 61);
      this.TxtNome.Name = "TxtNome";
      this.TxtNome.Size = new System.Drawing.Size(273, 27);
      this.TxtNome.TabIndex = 0;
      this.TxtNome.TextChanged += new System.EventHandler(this.TxtNome_TextChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(134, 64);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(50, 20);
      this.label2.TabIndex = 2;
      this.label2.Text = "Nome";
      // 
      // label1
      // 
      this.label1.BackColor = System.Drawing.Color.LightSlateGray;
      this.label1.Dock = System.Windows.Forms.DockStyle.Top;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(847, 37);
      this.label1.TabIndex = 1;
      this.label1.Text = "Nova Pessoa";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // PnnTodasPessoas
      // 
      this.PnnTodasPessoas.Controls.Add(this.DtPessoas);
      this.PnnTodasPessoas.Controls.Add(this.panel2);
      this.PnnTodasPessoas.Controls.Add(this.label8);
      this.PnnTodasPessoas.Dock = System.Windows.Forms.DockStyle.Fill;
      this.PnnTodasPessoas.Location = new System.Drawing.Point(0, 193);
      this.PnnTodasPessoas.Name = "PnnTodasPessoas";
      this.PnnTodasPessoas.Size = new System.Drawing.Size(847, 416);
      this.PnnTodasPessoas.TabIndex = 2;
      // 
      // DtPessoas
      // 
      this.DtPessoas.AllowUserToAddRows = false;
      this.DtPessoas.AllowUserToDeleteRows = false;
      this.DtPessoas.AllowUserToResizeColumns = false;
      this.DtPessoas.AllowUserToResizeRows = false;
      this.DtPessoas.BackgroundColor = System.Drawing.SystemColors.Control;
      this.DtPessoas.BorderStyle = System.Windows.Forms.BorderStyle.None;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.DtPessoas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
      this.DtPessoas.ColumnHeadersHeight = 29;
      this.DtPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.DtPessoas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmNome,
            this.Email,
            this.ClmIdade,
            this.ClmRemover});
      this.DtPessoas.Dock = System.Windows.Forms.DockStyle.Fill;
      this.DtPessoas.EnableHeadersVisualStyles = false;
      this.DtPessoas.Location = new System.Drawing.Point(0, 34);
      this.DtPessoas.Name = "DtPessoas";
      this.DtPessoas.ReadOnly = true;
      this.DtPessoas.RowHeadersWidth = 51;
      this.DtPessoas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.DtPessoas.RowTemplate.Height = 29;
      this.DtPessoas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.DtPessoas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.DtPessoas.ShowCellErrors = false;
      this.DtPessoas.ShowCellToolTips = false;
      this.DtPessoas.ShowEditingIcon = false;
      this.DtPessoas.ShowRowErrors = false;
      this.DtPessoas.Size = new System.Drawing.Size(847, 271);
      this.DtPessoas.TabIndex = 10;
      this.DtPessoas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtPessoas_CellContentClick);
      // 
      // ClmNome
      // 
      this.ClmNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.ClmNome.DataPropertyName = "Nome";
      this.ClmNome.HeaderText = "Nome";
      this.ClmNome.MinimumWidth = 6;
      this.ClmNome.Name = "ClmNome";
      this.ClmNome.ReadOnly = true;
      // 
      // Email
      // 
      this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.Email.DataPropertyName = "Email";
      this.Email.HeaderText = "Email";
      this.Email.MinimumWidth = 6;
      this.Email.Name = "Email";
      this.Email.ReadOnly = true;
      // 
      // ClmIdade
      // 
      this.ClmIdade.DataPropertyName = "Idade";
      this.ClmIdade.HeaderText = "Idade";
      this.ClmIdade.MinimumWidth = 6;
      this.ClmIdade.Name = "ClmIdade";
      this.ClmIdade.ReadOnly = true;
      this.ClmIdade.Width = 125;
      // 
      // ClmRemover
      // 
      this.ClmRemover.HeaderText = "";
      this.ClmRemover.MinimumWidth = 6;
      this.ClmRemover.Name = "ClmRemover";
      this.ClmRemover.ReadOnly = true;
      this.ClmRemover.Width = 80;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.BttImprimir);
      this.panel2.Controls.Add(this.BttCadastrar);
      this.panel2.Controls.Add(this.BttFiltraDados);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel2.Location = new System.Drawing.Point(0, 305);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(847, 111);
      this.panel2.TabIndex = 11;
      // 
      // BttImprimir
      // 
      this.BttImprimir.Location = new System.Drawing.Point(3, 38);
      this.BttImprimir.Name = "BttImprimir";
      this.BttImprimir.Size = new System.Drawing.Size(841, 29);
      this.BttImprimir.TabIndex = 7;
      this.BttImprimir.Text = "Imprimir Lista de pessoas com mais de 30 anos";
      this.BttImprimir.UseVisualStyleBackColor = true;
      this.BttImprimir.Click += new System.EventHandler(this.BttImprimir_Click);
      // 
      // BttCadastrar
      // 
      this.BttCadastrar.Location = new System.Drawing.Point(3, 73);
      this.BttCadastrar.Name = "BttCadastrar";
      this.BttCadastrar.Size = new System.Drawing.Size(841, 29);
      this.BttCadastrar.TabIndex = 6;
      this.BttCadastrar.Text = "Cadastrar Nova Pessoa";
      this.BttCadastrar.UseVisualStyleBackColor = true;
      this.BttCadastrar.Click += new System.EventHandler(this.BttCadastrar_Click);
      // 
      // BttFiltraDados
      // 
      this.BttFiltraDados.Location = new System.Drawing.Point(3, 3);
      this.BttFiltraDados.Name = "BttFiltraDados";
      this.BttFiltraDados.Size = new System.Drawing.Size(841, 29);
      this.BttFiltraDados.TabIndex = 5;
      this.BttFiltraDados.Text = "Exibir apenas acima de 30 anos";
      this.BttFiltraDados.UseVisualStyleBackColor = true;
      this.BttFiltraDados.Click += new System.EventHandler(this.BttFiltraDados_Click);
      // 
      // label8
      // 
      this.label8.BackColor = System.Drawing.Color.LightSlateGray;
      this.label8.Dock = System.Windows.Forms.DockStyle.Top;
      this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.label8.Location = new System.Drawing.Point(0, 0);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(847, 34);
      this.label8.TabIndex = 1;
      this.label8.Text = "Todas as Pessoas";
      this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(847, 609);
      this.Controls.Add(this.PnnTodasPessoas);
      this.Controls.Add(this.pnnNovaPessoa);
      this.ForeColor = System.Drawing.Color.SlateGray;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Teste BeeViral";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.pnnNovaPessoa.ResumeLayout(false);
      this.pnnNovaPessoa.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.TxtIdade)).EndInit();
      this.PnnTodasPessoas.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.DtPessoas)).EndInit();
      this.panel2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel pnnNovaPessoa;
    private System.Windows.Forms.Button BttSalvar;
    private System.Windows.Forms.Button BttCancelar;
    private System.Windows.Forms.TextBox TxtEmail;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox TxtNome;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel PnnTodasPessoas;
    private System.Windows.Forms.Button BttFiltraDados;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.DataGridView DtPessoas;
    private System.Windows.Forms.NumericUpDown TxtIdade;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Button BttCadastrar;
    private System.Windows.Forms.DataGridViewTextBoxColumn ClmNome;
    private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    private System.Windows.Forms.DataGridViewTextBoxColumn ClmIdade;
    private System.Windows.Forms.DataGridViewButtonColumn ClmRemover;
    private System.Windows.Forms.Button BttImprimir;
  }
}

