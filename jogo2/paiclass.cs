namespace jogo2;

public class paiclass  
{
    protected double Fome;
    protected double Sede;
    protected double Feliz;

    protected string Arquivo;

    public string GetArquivo()
    {
        return Arquivo;
    }
    public string Getarquivo()
    {
        return arquivo;
    }

    public paiclass()

{
    Fome=10;
    Sede=10;
    Feliz=5;
}
    public void SetFome(double f)
{
    if (f <=1.0 || f >=0)
        Fome = f;
    else if (f > 1.0)
        Fome = 1.0;
    else
        Fome = 0;
}
    public void SetSede(double f)
{
    if (f <=10 || f >=0)
        Sede = f;
    else if (f > 10)
        Sede = 10;
    else
        Sede = 0;
}

    public void SetFeliz(double f)
{
    if (f <=10 || f >=0)
        Feliz = f;
    else if (f > 10)
        Feliz = 10;
    else
        Feliz = 0;
}
    public double GetFome()
{
    return Fome;
}
    public double GetSede()
{
    return Sede;
}
    public double GetFeliz()
{
    return Feliz;
}

}