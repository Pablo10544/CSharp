using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Batman:SuperHeroi
    {
        public override void ObterDados()
        {
            this.NomeFicticio = "Batman";
            this.Identidade = "Bruce Wayne";
            this.Cidade = "Gothan";
        }
    }
}
