class Producto
{
    private string nombre;
    private decimal precio;

    public Producto(string nombre, decimal precio)
    {
        this.nombre = nombre;
        this.precio = precio;
    }

    public override string ToString()
    {
        return $"{nombre} - {precio}";
    }
}