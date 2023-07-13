public class Locatie
{
    public string Nume {get; set;}
    
    public bool IsComplex {get; set;} = false;

    public List<Teren> Terenuri = new List<Teren>();
}