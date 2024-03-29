﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Dominio;
using Oficina.Repositorios.SistemaDeArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaDeArquivos.Tests
{
    [TestClass()]
    public class VeiculoRepositorioTests
    {
        [TestMethod()]
        public void InserirTest()
        {
          //  var repositorio = new VeiculoRepositorio();

            var veiculo = new Veiculo();

            veiculo.Ano = 2014;
            veiculo.Cambio = Cambio.Manual;//Quando se usa enum
            veiculo.Combustivel = Combustivel.Flex;
            veiculo.Cor = new CorRepositorio().Selecionar(1);
            //veiculo.Id = 1;
            veiculo.Modelo = new ModeloRepositorio().SelecionarporID(3);
            veiculo.Placa = "ABC1234";

            new VeiculoRepositorio().Inserir(veiculo);
        }
    }
}