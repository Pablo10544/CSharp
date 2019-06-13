using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class SuperMan:SuperHeroi, ISuperPoder
    {
        public override void ObterDados()
        {
            this.NomeFicticio = "Super-Homem";
            this.Identidade = "Clark Kent";
            this.Cidade = "SmallVille";
            this.Poderes = ObterPoder();
            
        }
        public List<string> ObterPoder() {
            List<string> Poderes = new List<string>();
            Poderes.Add("Voar");
            Poderes.Add("Visao Laser");
            Poderes.Add("SuperForça");
            return Poderes;
        }

    }
}
