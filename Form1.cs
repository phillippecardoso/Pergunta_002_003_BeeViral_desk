using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pergunta_002_003_BeeViral_desk
{
  
  public partial class Form1 : Form
  {
    public bool ValidaEmail(string email)
    {
      try
      {
        Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        Match match = regex.Match(email);
        return true;
      }
      catch (Exception e)
      {
        return false;
      }
    }
    public void LimpaCamposCadastro(){
      TxtNome.Text = "";
      TxtNome.Enabled = true;
      TxtEmail.Text = "";
      TxtEmail.Enabled = false;
      TxtIdade.Value = 0;
      TxtIdade.Enabled = false;

      BttSalvar.Enabled = false;
      TxtNome.Focus();
    }
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    }

    private void TxtNome_TextChanged(object sender, EventArgs e)
    {
      if (TxtNome.Text != ""){
        TxtIdade.Enabled = true;
      } else {
        TxtIdade.Enabled = false;
      }
    }

    private void TxtIdade_ValueChanged(object sender, EventArgs e)
    {
      if (TxtIdade.Value > 0)
      {
        TxtEmail.Enabled = true;
      }
      else
      {
        TxtEmail.Enabled = false;
      }
    }

    private void TxtEmail_TextChanged(object sender, EventArgs e)
    {
      if (TxtEmail.Text != "")
      {
        if (ValidaEmail(TxtEmail.Text)){
          BttSalvar.Enabled = true;
        } else {
          BttSalvar.Enabled = false;
        }
      }
      else
      {
        BttSalvar.Enabled = false;
      }
    }

    private void BttCancelar_Click(object sender, EventArgs e)
    {
      pnnNovaPessoa.Enabled = false;
      pnnNovaPessoa.Visible = false;

      PnnTodasPessoas.Enabled = true;
      LimpaCamposCadastro();

    }

    private void BttSalvar_Click(object sender, EventArgs e)
    {
      pnnNovaPessoa.Enabled = false;
      pnnNovaPessoa.Visible = false;

      PnnTodasPessoas.Enabled = true;
      CadastroPessoa cadastroPessoa = new CadastroPessoa();
      cadastroPessoa.NovoCadastro(DtPessoas,
                                  TxtNome.Text,
                                  int.Parse(TxtIdade.Value.ToString()),
                                  TxtEmail.Text);
      cadastroPessoa.FiltraCadastro(DtPessoas, true);

    }

    private void BttCadastrar_Click(object sender, EventArgs e)
    {
      pnnNovaPessoa.Enabled = true;
      pnnNovaPessoa.Visible = true;

      PnnTodasPessoas.Enabled = false;
      LimpaCamposCadastro();
    }

    private void BttFiltraDados_Click(object sender, EventArgs e)
    {
      if (BttFiltraDados.Text == "Exibir apenas acima de 30 anos")
      {
        CadastroPessoa cadastroPessoa = new CadastroPessoa();
        cadastroPessoa.FiltraCadastro(DtPessoas, false);
        BttFiltraDados.Text = "Exibir todas as Pessoas";
      } 
      else 
      {
        CadastroPessoa cadastroPessoa = new CadastroPessoa();
        cadastroPessoa.FiltraCadastro(DtPessoas, true);
        BttFiltraDados.Text = "Exibir apenas acima de 30 anos";
      }
    }

    private void DtPessoas_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      if (DtPessoas.Columns[e.ColumnIndex].Name == "ClmRemover"){
        if (MessageBox.Show("Tem certeza que deseja remover essa pessoa?", "Remover item", MessageBoxButtons.YesNo) == DialogResult.Yes){
          CadastroPessoa cadastroPessoa = new CadastroPessoa();
          cadastroPessoa.RemoverCadastro(DtPessoas, e.RowIndex);
        }
      }
    }
  }
}
