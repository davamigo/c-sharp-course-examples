class BB8: Robot
{
    public int blindaje;

    public BB8(string nombre, int blindaje): base(nombre, "BB8")
    {
        this.blindaje = blindaje;
    }

    public void ActivarArmas()
    {
    }

    public void Disparar()
    {
    }
    public int ObtenerBlindaje()
    {
        return this.blindaje;
    }
}
