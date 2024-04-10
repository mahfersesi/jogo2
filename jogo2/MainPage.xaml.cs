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

		atual = cavalo;

		ImgBoi.Source= atual.GetArquivo();
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
		felicidade.Progress=cavalo.GetFeliz();
	}

	void setacavalo(object sender, EventArgs args)
	{
		if (atual==boi)
			atual=cavalo;
		else if (atual==cavalo)
			atual=galinha;
		else if (atual==galinha)
			atual=boi;

		ImgBoi.Source= atual.GetArquivo();
		botaofome.Progress=atual.GetFome();
		botaosede.Progress=atual.GetFome();
		felicidade.Progress=atual.GetFome();

		
	}

}
