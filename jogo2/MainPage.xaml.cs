namespace jogo2;

public partial class MainPage : ContentPage
{
	Cavalo cavalo;
	Cavalo fome;
	public MainPage()
	{
		InitializeComponent();
		
		cavalo= new Cavalo();

		ImgCavalo.Source= cavalo.GetArquivo();
	}

	void QuandoOBotao(object sender, EventArgs args)
	{
		cavalo.SetFome(cavalo.GetFome()+0.1);
	}

	void QuandoBotao(object sender, EventArgs args)
	{
		cavalo.SetSede(cavalo.GetSede()+0.1);
	}

	void Botao(object sender, EventArgs args)
	{
		cavalo.SetFeliz(cavalo.GetFeliz()+0.1);
	}

}
