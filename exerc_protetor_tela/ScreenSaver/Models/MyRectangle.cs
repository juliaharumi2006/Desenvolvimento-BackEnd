using System.Drawing;

namespace Models.BaseShapes;

public class MyRectangle : Shape
{
    //Atributos


    //Contrutores
    public MyRectangle(int x, int y, int width, int height) : base(x, y, width, height)
    {}
    public MyRectangle(int screenWidth, int screenHeight) : base(screenWidth, screenHeight)
    {}

    //Métodos
    public override void Draw(Graphics g)
    {
        SolidBrush brush = new SolidBrush(ColorShape);
        g.FillRectangle(brush, X, Y, Width, Height);
    }

}