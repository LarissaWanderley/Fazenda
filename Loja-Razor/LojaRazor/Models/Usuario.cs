using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LojaRazor.Models
{
    public class Usuario
    {
        [Required]
        public String Nome { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, MinLength(3)]
        public string Senha { get; set; }

        [Required]
        public DateTime DataDeNascimento { get; set; }

        [Required]
        public string Endereco { get; set; }

        public string Complemento { get; set; }

        [Required, RegularExpression("\\d{5}-\\d{3}")]
        public string CEP { get; set; }

        public string Observacoes { get; set; }

        public bool RecebePromocoes { get; set; }

        public enum Sexo { Masculino, Feminino}
    }
}