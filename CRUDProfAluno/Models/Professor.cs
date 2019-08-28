﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace CRUDProfAluno.Models
{
    public class Professor
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }       
        
        public virtual ICollection<Aluno> Alunos { get; set; }
    }
}