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

        [StringLengthAttribute(20)]
        public string Login { get; set; }

        [StringLengthAttribute(50)]
        public string Nome { get; set; }

        [StringLengthAttribute(50)]
        public string Senha { get; set; }

        public bool Ativo { get; set; }

        public Perfil Perfil { get; set; }
    }
}