class Arquivo
{
    //Atributos
    public string Name { get; private set; }
    public int Size { get; private set; }

    private string Content;

    //Contrutor
    public Arquivo(string name)
    {
        Name = name;
        Content = "";
        Size = CalculateSize();
    }

    //Métodos
    public string Open()
    {
        return $"Nome: {Name}\nConteudo: {Content}\nTamanho = {Size}bits";
    }

    public void Edit(string newContent)
    {
        Content += newContent;
        Size = CalculateSize();
    }

    public bool Rename(string newName)
    {
        if (newName == null)
            return false;

        Name = newName;
        return true;
    }

    public void Clear()
    {
        Content = "";
        Size = CalculateSize();
    }
    private int CalculateSize()
    {
        return Content.Length * 8;
    }
    
}