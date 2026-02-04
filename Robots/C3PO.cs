class C3PO: Robot
{
    private int idiomas;

    public C3PO(string nombre, int idiomas): base(nombre, "C3PO")
    {
        this.idiomas = idiomas;
    }

    public void AñadirIdioma()
    {
        this.idiomas++;
    }

    public void Saludar()
    {
    }

    public int ObtenerIdiomas()
    {
        return this.idiomas;
    }
}