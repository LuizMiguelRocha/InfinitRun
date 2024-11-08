namespace InfinitRun;

	public class Animacao : MainPage
	{
		protected List<String> Animacao1 = new List<String>();
		protected List<String> Animacao2 = new List<String>();
		protected List<String> Animacao3 = new List<String>();
		protected bool Loop = true;
		protected int AnimacaoAtiva = 1;
		bool Parado = true;
		int FrameAtual = 1;
		protected Image compImagem;

		public Animacao(Image A)
		{
			compImagem = A;
		}
    }        