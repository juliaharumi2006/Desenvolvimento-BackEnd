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
        private Random random = new Random();
        public Color ColorShape { get; protected set; }


    //Contrutor
    public Shape(int x, int y, int width, int height)
    {
        X = x;
        Y = y;
        Width = width;
        Height = height;
        SpeedX = 2;
        SpeedY = 2;
        ColorShape = ColorGenerate();
    }

    public Shape(int screenWidth, int screenHeight)
    {
        Width = random.Next(50, 250);
        Height = random.Next(50, 250);

        X = random.Next(0, screenWidth-Width);
        Y = random.Next(0, screenHeight - Height);
        
        SpeedX = random.Next(-10, 10);
        if (SpeedX == 0)
            SpeedX = 1;

        SpeedY = random.Next(-10, 10);
        if (SpeedY == 0)
            SpeedY = 1;

        ColorShape = ColorGenerate();
    }
        

    //Método
    public void Move(int xLimit, int yLimit)
    {
    if (X > xLimit - Width || X < 0)
    {
        SpeedX = -SpeedX;
        ColorShape = ColorGenerate();
    }

    if (Y > yLimit - Height || Y < 0)
    {
        SpeedY = -SpeedY;
        ColorShape = ColorGenerate();
    }
        X += SpeedX;
        Y += SpeedY;
    }

    private Color ColorGenerate()
    {
        return Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));       
    }

    public abstract void Draw(Graphics g);
    //ToString
    public override string ToString()
    {
        return $"Pos X: {X}, Pos Y: {Y}, Cor: {ColorShape}";
    }

    }