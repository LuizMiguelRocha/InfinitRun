namespace InfinitRun;

public  delegate void Callback();
public class Player : Animacao
{
    public Player(Image a):base(a)
    {

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

    public void MoveY(int s)
    {
        ImageView.TranslationY += s;
    }

    public void GetY()
    {
        return ImageView.TranslationY;
    }

    public void SetY(double a)
    {
        ImageView.TranslationY = a;
    }
}