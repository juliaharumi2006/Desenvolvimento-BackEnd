Arquivo aq1 = new Arquivo("Teste");
Console.WriteLine(aq1.Open());

aq1.Edit("Primeira entrada");
Console.WriteLine(aq1.Open());

aq1.Edit("Segunda entrada");
Console.WriteLine(aq1.Open());

aq1.Clear();
Console.WriteLine(aq1.Open());

aq1.Rename("Teste2");
Console.WriteLine(aq1.Open());