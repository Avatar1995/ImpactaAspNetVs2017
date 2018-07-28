using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaDeArquivos
{
    public class MarcaRepositorio
    {
        private string _caminhoArquivo = ConfigurationManager.AppSettings["caminhoArquivoMarca"];

        public List<Marca> Selecionar()
        {
            var marcas = new List<Marca>();

            foreach (var linha in File.ReadAllLines(_caminhoArquivo))//File para ler o arquivo texto
            {
                var propriedades = linha.Split('|');//O Split funciona como definir um vetor, onde deve ser informado o separador no
                                                    //o campo dentro desse método 
                var marca = new Marca();
                marca.Id = Convert.ToInt32(propriedades[0]);//o indice zero é o ID
                marca.Nome = propriedades[1];//desse jeito pega dessa posição inicial até o final
                marcas.Add(marca);
            }
            return marcas;



        }

        public Marca Selecionar(int marcaID)
        {

            Marca marca = null;

            foreach (var linha in File.ReadAllLines(_caminhoArquivo))
            {
                var propriedades = linha.Split('|');
                if (propriedades[0] == marcaID.ToString())
                {
                    marca = new Marca();
                    marca.Id = marcaID;
                    marca.Nome = propriedades[1];

                    break;
                }
            }

            return marca;


        }
    }
}
