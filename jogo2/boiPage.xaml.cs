namespace jogo2;

public partial class boiPage : ContentPage
{
	Boi boi;
	Boi fome;
	public boiPage()
	{
		InitializeComponent();
		
		boi= new Boi();

		ImgVaca.Source= boi.Getarquivo();
	}

	void Botaovaca(object sender, EventArgs args)
	{
		boi.SetFome(boi.GetFome()+0.1);
	}

	void Vacasede(object sender, EventArgs args)
	{
		boi.SetSede(boi.GetSede()+0.1);
	}

	void Botao(object sender, EventArgs args)
	{
		boi.SetFeliz(boi.GetFeliz()+0.1);
	}

}
