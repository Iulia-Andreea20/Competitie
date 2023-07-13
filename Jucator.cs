using System.ComponentModel.Design.Serialization;

public class Jucator: Persoana
{
    public string Nume { get; set; }

    public string Prenume { get; set; }

    public string DataNastere { get; set; }

    public string Experienta { get; set; }//Junior sau Senior

    public List<Competitie> CompetitiiAsignate = new List<Competitie>();
}