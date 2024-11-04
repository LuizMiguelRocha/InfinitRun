namespace InfinitRun;

public partial class MainPage : ContentPage
{
	int count = 0;

	bool EstaMorto = false;
	bool EstaPulando = false;
	const int TempoEntreFrames = 25;
	int Velocidade1 = 0;
	int Velocidade2 = 0;
	int Velocidade3 = 0;
	int Velocidade = 0;
	int LarguraJanela = 0;
	int AlturaJanela = 0;

	protected override void OnSizeAllocated(Double w, Double h)
	{
		base.OnSizeAllocated(w,h);
		CorrigeTamanhoCenario(w,h);
		CalculaVelocidade(w);
	}

	void CalculaVelocidade(Double w)
	{
		Velocidade1 = (int)(w * 0.001);
		Velocidade2 = (int)(w * 0.004);
		Velocidade3 = (int)(w * 0.008);
		Velocidade = (int)(w * 0.01);
	}

	void CorrigeTamanhoCenario(Double w, Double h)
	{
		foreach (var a in HSLayer1.Children)
		(a as Image).WidthRequest = w;
		foreach (var a in HSLayer2.Children)
		(a as Image).WidthRequest = w;
		foreach (var a in HSLayerChao.Children)
		(a as Image).WidthRequest = w;

		HSLayer1.WidthRequest = w * 1.5;
		HSLayer2.WidthRequest = w * 1.5;	
		HSLayerChao.WidthRequest = w * 1.5;
	}

	void GerenciaCenarios()
	{
		MoveCenario();
		GerenciaCenario(HSLayer1);
		GerenciaCenario(HSLayer2);
		GerenciaCenario(HSLayerChao);

	}

	void MoveCenario()
	{
		HSLayer1.TranslationX -= Velocidade1;
		HSLayer2.TranslationX -= Velocidade2;
		HSLayerChao.TranslationX -= Velocidade;
	}

	void GerenciaCenario(HorizontalStackLayout HSL)
	{
		var view = (HSL.Children.First() as Image);
		if (view.WidthRequest + HSL.TranslationX < 0)
		{
			HSL.Children.Remove(view);
			HSL.Children.Add(view);
			HSL.TranslationX = view.TranslationX;
		}
	}



	public MainPage()
	{
		InitializeComponent();
	}

}

