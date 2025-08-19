Conta c1 = new Conta(1, "Kiara");
Conta c2 = new Conta(2, "Lili");

Console.WriteLine(c1.Depositar(1000, 1));
Console.WriteLine(c1.Depositar(1000, 2));
Console.WriteLine(c1.Saldo);

Console.WriteLine(c2.Titular + c2.Saldo);

c2.Saldo = 1000000; 
Console.WriteLine(c2.Titular + c2.Saldo);