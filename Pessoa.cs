using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pergunta_002_003_BeeViral_desk
{


  public class Pessoa
  {
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Email { get; set; }
    public Pessoa(DataGridView dt, string Nome, int Idade, string Email)
    {
      this.Nome = Nome;
      this.Idade = Idade;
      this.Email = Email;
      dt.Rows.Add(Nome, Email, Idade, "Excluir");
    }

  }

}
