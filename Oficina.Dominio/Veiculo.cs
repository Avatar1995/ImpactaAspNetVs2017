using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Dominio
{// prop tab tab faz os comando do get e set abaixo
    public class Veiculo
    {

        /*public Veiculo()
        {
            Id = Guid.NewGuid();

        }*/
        public Guid Id { get; set; } = Guid.NewGuid();//indice automatico
        public string Placa { get; set; }
        public int Ano { get; set; }
        public string Observacao { get; set; }
        public Modelo Modelo { get; set; }
        public Cor Cor { get; set; }
        public Combustivel Combustivel { get; set; }
        public Cambio Cambio { get; set; }

    }
}
