namespace Models.BaseShapes;

public class MyRectangle : Shape
{
    //Atributos


    //Contrutores
    public MyRectangle(int x, int y, Color color, int width, int height) : base(x, y, color, width, height)
    {}

    //Métodos
    public void Draw(Graphics g)
    {
        SolidBrush brush = new SolidBrush(ColorShape);
        g.FillRectangle(brush, X, Y, Width, Height);
    }

}