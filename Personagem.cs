//namespace Heranca
//{
//    public class Personagem
//    {
//        public string Nome { get; set; }
//        public int PontoDeVida { get; set; }

//        public int ForcaDeAtaque { get; set; }

//        public Personagem(string nome, int PV, int ATK)
//        {
//            nome = Nome;
//            PV = PontoDeVida;
//            ATK = ForcaDeAtaque;
//        }
//        public virtual void Atacar(Personagem alvo)
//        {
//            if (PontoDeVida <= 0)
//            {
//                Console.WriteLine("Você morreu!");
//            }
//            else
//            {
//                PontoDeVida -= ForcaDeAtaque;
//                Console.WriteLine($"Vida restante: {PontoDeVida}");
//            }
//        }
//        public bool EstarVivo()
//        {
//            return PontoDeVida > 0;
//        }
//    }
//}
namespace Heranca
{
    public class Personagem
    {
        public string Nome { get; set; }
        public int PontosDeVida { get; set; }
        public int ForcaDeAtaque { get; set; }

        public Personagem(string nome, int pontosDeVida, int forcaDeAtaque)
        {
            Nome = nome;
            PontosDeVida = pontosDeVida;
            ForcaDeAtaque = forcaDeAtaque;
        }

        public virtual void Atacar(Personagem alvo)
        {
            int dano = ForcaDeAtaque;
            alvo.PontosDeVida = Math.Max(0, alvo.PontosDeVida - dano);
        }

        public bool EstaVivo()
        {
            return PontosDeVida > 0;
        }
    }
}
