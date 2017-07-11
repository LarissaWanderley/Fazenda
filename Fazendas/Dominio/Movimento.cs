using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Fazendas.Dominio
{
    public class Movimento
    {
        public int Id { get; set; }

        [DisplayName("Data do movimento")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "O campo data é obrigatório.")]
        public DateTime Data { get; set; }

        public string Historico { get; set; }

        public decimal Receita { get; set; }

        public decimal Despesa { get; set; }

        public SubGrupo SubGrupo { get; set; }

        public Usuario Usuario { get; set; }

        public DateTime Dt_Cadastro { get; set; }
    }
}