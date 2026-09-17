namespace Heranca
{
    internal class Gerente : Funcionario
    {
        public override double calcularBonusAnual()
        {
            return (0.15 * salario) + 1000;
        }
    }
}