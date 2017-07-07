using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fazendas.Dominio
{
    public class Movimento
    {
        public int Id { get; set; }
        public DateTime data { get; set; }
        public string historico { get; set; }
        public decimal receita { get; set; }
        public decimal despesa { get; set; }
        public SubGrupo subGrupo { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime Dt_Cadastro { get; set; }
    }
}