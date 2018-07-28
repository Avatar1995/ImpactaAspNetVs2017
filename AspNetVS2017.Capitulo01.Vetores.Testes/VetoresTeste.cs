using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspNetVS2017.Capitulo01.Vetores.Testes
{
    [TestClass]
    public class VetoresTeste
    {
        [TestMethod]
        public void InicializacaoTeste()
        {
            //Vetores
            string[] strings = new string[10];//Zero a nove
            strings[0] = "Vitor";

            var decimais = new decimal[] { 0.5m, 1, 1.59m };

            int[] inteiros = { 1, 58, 10, 0 };

            foreach (var inteiro in inteiros)
            {
                Console.WriteLine(inteiro);
            }
            Console.WriteLine($"Tamanho do vetor:{inteiros.Length}");
        }

        [TestMethod]
        public void RedimensionamentoTeste()
        {
            var decimais = new decimal[] { 0.5m, 1, 1.59m };

            Array.Resize(ref decimais, 5);//Redefinindo o tamanho do vetor

            decimais[4] = 2.1m;
        }


        [TestMethod]
        public void OrdenacaoTeste()
        {
            var decimais = new decimal[] { 0.5m, 1, 1.59m,0.4m };

            Array.Sort(decimais);//Ordenando

            Assert.AreEqual(decimais[0],0.4m);//Assert é um comando do test method que significa afirmação, ou seja, se é verdade que no vetor 0 existe a informação 0.4

        }

        [TestMethod]
        public void ParamsTest()
        {
            var decimais = new decimal[] { 0.5m, 1, 1.59m, 0.4m };
            Console.WriteLine(Media(decimais));
            Console.WriteLine(Media(2,3.5m,8));


        }

        private decimal CalcularMedia(decimal valor1, decimal valor2)

        {
            return (valor1 + valor2) / 2;


        }

        private decimal Media(params decimal[] decimais)//o params faz com quê quando o método for chamado, você pode colocar os valores diretamente

        {
            var soma = 0m;
            foreach (var @decimal in decimais)
            {
                soma += @decimal;
                //soma = soma + @decimal;

            }
            return soma / decimais.Length;


        }
        [TestMethod]
        public void TodaStringEhUmVetorTeste()
        {
            var nome = "Vitor";

            foreach (var caractere in nome)
            {
                Console.WriteLine(caractere);

            }

             Assert.AreEqual(nome[0], 'V');
  

        }

    }
}
