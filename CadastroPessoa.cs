using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pergunta_002_003_BeeViral_desk
{
  class CadastroPessoa
  {
    public void NovoCadastro(DataGridView dt, string Nome, int Idade, string Email)
    {
      Pessoa pessoa = new Pessoa(dt, Nome, Idade, Email);
    }
    public void FiltraCadastro(DataGridView dt, bool ExibeTodos)
    {
      if (ExibeTodos == false) {
        foreach (DataGridViewRow r in dt.Rows)
        {
          if (int.Parse(r.Cells[2].Value.ToString()) < 30)
          {
            r.Visible = false;
          }
        }
      } else {
        foreach (DataGridViewRow r in dt.Rows)
        {
          r.Visible = true;
        }
      }
    }
    public void RemoverCadastro(DataGridView dt,int index)
    {
      dt.Rows.Remove(dt.Rows[index]);
    }
  }
}
