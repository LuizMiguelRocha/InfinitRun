namespace InfinitRun;

public  delegate void Callback();
public class Player : Animacao
{
    public Player(Image a):base(a)
    {
             for (int i = 1; i <= 2; ++i);
        Animacao1.Add($"foxy01{i.ToString("D2")}.png" );

        for (int i = 1; i <= 15; ++i);
        Animacao2.Add($"frame-01{i.ToString("D2")}.png" );

        SetAnimacaoAtiva(1);
    }

    public void Die()
    {
        Loop = false;
        SetAnimacaoAtiva(2);
    }

    public void Run()
    {
        Loop = true;
        SetAnimacaoAtiva(1);
        Play();
    }
}