class Robot
{
    private string nombre;
    private string modelo;

    public Robot(string nombre, string modelo)
    {
        this.nombre = nombre;
        this.modelo = modelo;
    }

    public string ObtenerNombre()
    {
        return nombre;
    }

    public string ObtenerModelo()
    {
        return modelo;
    }
}
