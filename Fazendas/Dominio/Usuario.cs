using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fazendas.Dominio
{
    [DBBroker.Mapping.DBMappedClass(Table = "Usuario", PrimaryKey = "IdUsuario")]
    public class Usuario
    {
        public int Id { get; set; }

        [StringLengthAttribute(20),Required]
        public string Login { get; set; }

        [StringLengthAttribute(50),Required]
        public string Nome { get; set; }

        [StringLengthAttribute(50)]
        public string Senha { get; set; }

        [StringLengthAttribute(50), Required]
        public string Email { get; set; }

        public bool Ativo { get; set; }

        public Perfil Perfil { get; set; }
        [Required]
        public DateTime DataDeNascimento { get; set; }

        [Required]
        public String Endereco { get; set; }

        public String Complemento { get; set; }

        public Estado Estado { get; set; }

        [Required, RegularExpression("\\d{5}-\\d{3}")]
        public String CEP { get; set; }

        public string Observacoes { get; set; }

        public bool RecebePromocoes { get; set; }

        public Sexo Sexo { get; set; }
    }
}