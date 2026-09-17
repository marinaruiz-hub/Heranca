namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Atividade 1

            Cachorro c = new Cachorro();
            Gato g = new Gato();

            c.Nome = "Gabriel Felix";
            g.Nome = "Garnica";
            g.miar();
            g.Comer();
            c.latir();
            c.Comer();
           
            //Atividade 2

            Funcionario Fu = new Funcionario();
            Funcionario Ge = new Gerente();
            Funcionario De = new Desenvolvedor();

            Fu.salario = 3500;
            Ge.salario = 50000;
            De.salario = 5500;

            Console.WriteLine(Fu.calcularBonusAnual());
            Console.WriteLine(Ge.calcularBonusAnual());
            Console.WriteLine(De.calcularBonusAnual());
        }
    }
}
