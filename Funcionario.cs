namespace Heranca
{
    internal class Funcionario
    {
        string nome;
        public double salario { get; set; }
        public virtual double calcularBonusAnual()
        {
            return 0.1 * salario;
        }
    }
}
