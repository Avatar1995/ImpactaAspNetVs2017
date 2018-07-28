namespace Oficina.Dominio
{
    //Quando esquece de colocar o public, a classe fica definida como internal

    //internal:acessível apenas dentro do assembly.

    public class Cor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}