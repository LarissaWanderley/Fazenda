using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fazendas.Dominio
{
    public class SubGrupo
    {
        public int  Id  { get; set; }
        public Grupo Grupo { get; set; }
        public int NuOrdem { get; set; }
        public string Nome { get; set; }
        public int Imposto { get; set; }
    }
}