using Heranca;
internal class Mago : Personagem
{
    public int PontosDeMagia { get; set; }
    public Mago(string nome, int pontosDeVida, int forcaDeAtaque)
        : base(nome, pontosDeVida, forcaDeAtaque)
    {
        PontosDeMagia = 0;
    }
    public override void Atacar(Personagem alvo)
    {
        int dano = ForcaDeAtaque;
        alvo.PontosDeVida = Math.Max(0, alvo.PontosDeVida - dano);

        int mpRecuperado = (int)(dano * 0.10);
        PontosDeMagia += mpRecuperado;
    }
}
