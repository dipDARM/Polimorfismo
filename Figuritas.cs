class Figura
{
    public virtual string Nombre()
    {
        return "Figura genérica";
    }

    public virtual double Area()
    {
        return 0;
    }
}

class Rectangulo : Figura
{
    private double ancho;
    private double alto;

    public Rectangulo(double ancho, double alto)
    {
        this.ancho = ancho;
        this.alto = alto;
    }

    public override string Nombre()
    {
        return "Rectángulo";
    }

    public override double Area()
    {
        return ancho * alto;
    }
}

class Triangulo : Figura
{
    private double b;
    private double h;

    public Triangulo(double b, double h)
    {
        this.b = b;
        this.h = h;
    }

    public override string Nombre()
    {
        return "Triángulo";
    }

    public override double Area()
    {
        return b * h / 2;
    }
}