﻿using System;
using System.ComponentModel.DataAnnotations;

namespace CRUDProfAluno.Models
{
    public class Aluno
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public int ProfessorID { get; set; }

        public virtual Professor Professor { get; set; }

        public int getIdade()
        {
            int idade = DateTime.Now.Year - DataNascimento.Year;

            if ((DateTime.Now.Month < DataNascimento.Month) || (DateTime.Now.Month == DataNascimento.Month && DateTime.Now.Day < DataNascimento.Day ))
            {
                idade--;
            }

            return idade;
        }
    }
}