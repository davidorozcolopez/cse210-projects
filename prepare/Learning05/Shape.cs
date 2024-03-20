public class Shape
{
    private string color;

    public string GetColor()
    {
        return color;
    }

    public void SetColor(string color)
    {
        this.color = color;
    }

    public Shape(string color)
    {
        this.color = color;
    }

    public virtual double GetArea()
    {
        return -1; // return a default value to check that the custom behaviors in the derived classes worked well.
    }

    // another option
    // public abstract double GetArea();
}