using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AspNetVS2017.Capitulo01.Vetores.Testes
{
    [TestClass]
    public class ColecoesTeste
    {
        [TestMethod]
        public void Listteste()
        {
            var inteiros = new List<int>(50);//50 é o tamanho de itens da lista
            inteiros.Add(5);//para list, se usa o add para adicionar os itens nela
            inteiros.Add(3);
            inteiros.Add(28);
            //inteiros[10] = 27;

            var maisInteiros = new List<int> {1,3,2,9 };

            inteiros.AddRange(maisInteiros);//Adiciona valores de uma lista na outra
            inteiros.Insert(0, 32);//0 é a posíção e 32 é o valor
            inteiros.Remove(3);//Remove o valor
            inteiros.RemoveAt(0);//Remove de acordo com a posição
            inteiros.Sort();

            var primeiro = inteiros[0];
            var ultimo =   inteiros[inteiros.Count - 1];//Conta quantos registros tem, como começa do zero, para apresentar o último registro, deve - se colocar - 1

            foreach (var inteiro in inteiros)
            {
                Console.WriteLine($"{inteiros.IndexOf(inteiro)}:{inteiro}");//IndexOf Traz o indice que se encontra o valor
                

            }

        }
        [TestMethod]
        public void DictionaryTeste()
        {   //Para dicionario, o indice não precisa ser integer, pode ser string como o caso abaixo
            var feriados = new Dictionary<DateTime,string>();//para dicionário, o tipo do conteúdo é definido primeiro(DateTime) e depois o tipo do Indice(string)
            feriados.Add(new DateTime(2018,12,25),"Natal");
            feriados.Add(new DateTime(2019,01,01), "Ano Novo");
            feriados.Add(new DateTime(2019,01,25), "Aniversário de São Paulo");

            var natal = feriados[new DateTime(2018, 12, 25)];//atribuindo o valor na variavel natal

            foreach (var datas in feriados)
            {
                Console.WriteLine($"{datas.Key.ToString("dd-MM-yyyy")} : {datas.Value}");//key é a informação atribuida e value é o indice

            }
            //Retorna True ou false.Método de conter ou não a informação
            Console.WriteLine(feriados.ContainsKey(new DateTime(2018,12,25)));
            Console.WriteLine(feriados.ContainsValue("Ano Novo"));

        }
        [TestMethod]
        public void StackTeste()//Pilha
        {
            var pilha = new Stack<int>();
            pilha.Push(1);
            pilha.Push(4);
            pilha.Push(7);

            Assert.AreEqual(pilha.Pop(), 7);//pop remove
            Assert.AreEqual(pilha.Peek(),4);//verificar quem tá no topo da pilha

            Console.WriteLine($"A pilha está vazia?{pilha.Count==0}");

        }
        [TestMethod]
        public void QueueTeste()//fila
        {
            var fila = new Queue<int>();
            fila.Enqueue(1);//Incrementa na lista
            fila.Enqueue(4);
            fila.Enqueue(2);

            Assert.AreEqual(fila.Dequeue(), 1);//Dequeue remove da lista
            Assert.AreEqual(fila.Peek(), 4);

        }
    }
    
}
