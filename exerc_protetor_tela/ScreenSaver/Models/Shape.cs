using System.Drawing;

namespace Models.BaseShapes;

public abstract class Shape
{
    //Atributos
    protected int X;
    protected int Y;
    protected int SpeedX;
    protected int SpeedY;
    protected int Width;
    protected int Height;
    public Color ColorShape { get; protected set; }


    //Contrutor
    public Shape(int x, int y, Color color, int width, int height)
    {
        X = x;
        Y = y;
        SpeedX = 2;
        SpeedY = 2;
        Width = width;
        Height = height;
        ColorShape = color;
    }

    //Método
    public void Move(int xLimit, int yLimit)
    {
        if (X > xLimit - Width || X < 0)
            SpeedX = -SpeedX;

        if (Y > yLimit - Height || Y < 0)
            SpeedY = -SpeedY;

        X += SpeedX;
        Y += SpeedY;
    }

    //ToString
    public override string ToString()
    {
        return $"Pos X: {X}, Pos Y: {Y}, Cor: {ColorShape}";
    }
}