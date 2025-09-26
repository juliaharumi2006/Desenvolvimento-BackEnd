Car[] cars = new Car[3];

for (int i = 0; i < cars.Length; i++)
{
    cars[i] = new Car("vermelho", i);
    Console.WriteLine(cars[i]);
}



Car c1 = new Car("Vermelho");
Car c2 = new Car("Azul", 40);

Console.WriteLine(c1);

try
{
    int n = Convert.ToInt32(Console.ReadLine());
    cars[n].Accelerate(20);
}
catch (Exception e)
{
    //Mensagem de erro (tanto para usuário final quanto para programador)
    Console.WriteLine("Você digitou uma entrada inválida!");
    Console.WriteLine(e.Message);
}


Console.WriteLine(c1);