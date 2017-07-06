using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fazendas.Dominio
{
    public class Movimento
    {
        public int Id { get; set; }
        public int data { get; set; }
        public int historico { get; set; }
        public double receita { get; set; }
        public double despesa { get; set; }
        public SubGrupo subGrupo { get; set; }
        public int Dt_Cadastro { get; set; }
    }
}