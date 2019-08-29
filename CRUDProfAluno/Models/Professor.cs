using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CRUDProfAluno.Models
{
    public class Professor
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }       
        
        public virtual ICollection<Aluno> Alunos { get; set; }

        public double mediaIdadeAlunos()
        {
            double somaIdades = Alunos.Sum(x => x.getIdade());
            double media = somaIdades / Alunos.Count;
            return media;
        }
    }
}