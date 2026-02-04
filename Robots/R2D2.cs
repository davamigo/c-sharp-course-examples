class R2D2: Robot
{
    private int energía;

    public R2D2(string nombre, int energia): base(nombre, "R2D2")
    {
        this.energía = energia;
    }

    public void ActivarRadar()
    {        
    }
    public void Rodar()
    {        
    }

    public int ObtenerEnergia()
    {
        return energía;
    }
}
