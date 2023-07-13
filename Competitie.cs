public class Competitie
{
    public string Nume {get; set;}

    public string DataInceput {get; set;}

    public string DataFinal {get; set;}

    public Locatie locatie;

    public List<Meci> Meciuri = new List<Meci>();

}