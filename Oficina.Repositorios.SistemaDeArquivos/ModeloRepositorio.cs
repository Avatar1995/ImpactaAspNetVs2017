using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Oficina.Repositorios.SistemaDeArquivos
{
    public class ModeloRepositorio
    {
        XDocument _arquivoXml = XDocument.Load(ConfigurationManager.AppSettings["caminhoArquivoModelo"]);//Carregar o arquivo xml

        public List<Modelo> SelecionarPorMarca(int marcaId)
        {
            var modelos = new List<Modelo>();
            foreach (var elemento in _arquivoXml.Descendants("modelo"))//sintaxe para xml
            {
                if (elemento.Element("marcaId").Value == marcaId.ToString() )
                {
                    var modelo = new Modelo();
                    modelo.Id = Convert.ToInt32(elemento.Element("id").Value);
                    modelo.Nome = elemento.Element("nome").Value;
                    modelo.Marca = new MarcaRepositorio().Selecionar(marcaId);
                    modelos.Add(modelo);
                }

            }

            return modelos;

        }

        public Modelo SelecionarporID(int modeloId)
        {
            Modelo modelo = null;

            foreach (var elemento in _arquivoXml.Descendants("modelo"))//sintaxe para xml
            {
                if (elemento.Element("id").Value == modeloId.ToString())
                {
                     modelo = new Modelo();
                    modelo.Id = Convert.ToInt32(elemento.Element("id").Value);
                    modelo.Nome = elemento.Element("nome").Value;
                    var marcaId = Convert.ToInt32(elemento.Element("marcaId").Value);
                    modelo.Marca = new MarcaRepositorio().Selecionar(marcaId);
                    break;
                    //modelo.Add(modelo);
                }
                
            }
            return modelo;


        }
    }
}
