class Car
{
    //Atributos
    public string Color { get; private set; }
    public int Speed { get; private set; }

    //Construtores
    public Car(string color)
    {
        Color = color;
        Speed = 0;
    }
    
    public Car(string color, int speed)
    {
        Color = color;
        Speed = speed;
    }

    public Car(int speed, string color):this(color, speed){}

    //Métodos
    public void Accelerate()
    {
        Speed++;
    }
    public void Accelerate(int value)
    {
        Speed += value;
    }

    public void Brake()
    {
        Speed--;
    }
    public void Brake(int value)
    {
        Speed -= value;
    }


    //ToString
    public override string ToString()
    {
        return $"Cor: {Color}, Velocidade: {Speed}";
    }
}