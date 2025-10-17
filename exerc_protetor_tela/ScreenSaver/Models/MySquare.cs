namespace Models.BaseShapes;
public class MySquare : MyRectangle
{
    public MySquare(int screenWidth, int screenHeight) : base(screenWidth, screenHeight)
    {
        Width = Height;
    }
}