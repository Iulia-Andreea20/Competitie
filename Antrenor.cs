public class Antrenor : Persoana
{
    public string Nume { get; set; }

    public string Prenume { get; set; }

    public string DataNastere { get; set; }

    public List<Jucator> JucatoriAsignati = new List<Jucator>();
}