using Heranca;
internal class Guerreiro : Personagem
{
    public int Defesa { get; set; }

    public Guerreiro(string nome, int pontosDeVida, int forcaDeAtaque, int defesa)
        : base(nome, pontosDeVida, forcaDeAtaque)
    {
        Defesa = defesa;
    }
    public override void Atacar(Personagem alvo)
    {
        int dano = (int)(ForcaDeAtaque * 1.20); 
        alvo.PontosDeVida = Math.Max(0, alvo.PontosDeVida - dano);
    }
}
