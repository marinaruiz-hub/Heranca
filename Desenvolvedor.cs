namespace Heranca
{
    internal class Desenvolvedor : Funcionario
    {
        public override double calcularBonusAnual()
        {
            return 0.12 * salario;
        }
    }
}