using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fazendas.Dominio
{
    public class Perfil
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
    }
}