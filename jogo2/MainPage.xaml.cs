namespace jogo2;

public partial class MainPage : ContentPage
{
	Cavalo cavalo; Boi boi; Galinha galinha; Paiclass atual;
	Cavalo fome;
	public MainPage()
	{
		InitializeComponent();
		
		cavalo= new Cavalo();
		boi= new Boi();
		galinha= new Galinha();

		ImgBoi.Source= boi.GetArquivo();

		ImgGalinha.Source= galinha.GetArquivo();

		ImgCavalo.Source= cavalo.GetArquivo();
	}

	void QuandoOBotao(object sender, EventArgs args)
	{
		cavalo.SetFome(cavalo.GetFome()+0.1);
		botaofome.Progress=cavalo.GetFome();
	}

	void QuandoBotao(object sender, EventArgs args)
	{
		cavalo.SetSede(cavalo.GetSede()+0.1);
		botaosede.Progress=cavalo.GetSede();
	}

	void Botao(object sender, EventArgs args)
	{
		cavalo.SetFeliz(cavalo.GetFeliz()+0.1);
		feliz.Progress=cavalo.GetFeliz();
	}

	void setacavalo(object sender, EventArgs args)
	{
		if (atual==cavalo)
			atual=boi;
		else if (atual==boi)
			atual=galinha;
		else if (atual==galinha)
			atual=cavalo;
		
	}

}
