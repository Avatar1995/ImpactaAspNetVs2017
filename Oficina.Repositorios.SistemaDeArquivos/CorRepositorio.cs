using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace Oficina.Repositorios.SistemaDeArquivos
{
    public class CorRepositorio
    {
        private string _caminhoArquivo = ConfigurationManager.AppSettings["caminhoArquivoCor"] ;

        public List<Cor> Selecionar()
      {
            var cores = new List<Cor>();

            foreach (var linha in File.ReadAllLines(_caminhoArquivo))//File para ler o arquivo texto
            {
                var cor = new Cor();
                cor.Id = Convert.ToInt32(linha.Substring(0,5));//a partir do indice zero e copiando ele e mais 4 campos posteriores(5)
                cor.Nome = linha.Substring(5);//desse jeito pega dessa posição inicial até o final
                cores.Add(cor);
            }
            return cores;



      }

        public Cor Selecionar(int corID)
        {

            Cor cor = null;

            foreach (var linha in File.ReadAllLines(_caminhoArquivo))
            {
                var linhaId = Convert.ToInt32(linha.Substring(0, 5));//Copiando os cinco primeiros registros

                if (linhaId == corID)
                {
                    cor = new Cor();
                    cor.Id = linhaId;
                    cor.Nome = linha.Substring(5);

                    break;
                }
            }

            return cor;


        }



    }
}
