using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fazendas.Dominio
{
    public class Grupo
    {
        public int Id { get; set; }
        public int NuTipo { get; set; }
        public int NuOrdem { get; set; }
        public string Nome { get; set; }
    }
}