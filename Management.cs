using System.Security.Cryptography.X509Certificates;

public class Management 
{
    public List<Jucator> Jucatori = new();
    public List<Antrenor> Antrenori = new();
    public List<Adresa> Adrese = new();
    public List<Teren> Terenuri = new();
    public List<Locatie> Locatii = new();
    public List<Competitie> Competitii = new();
    public void AdaugaJucator()
    {   
        Jucator jucator= new Jucator();

        System.Console.WriteLine("Intoduceti numele jucatorului: ");
        jucator.Nume = Console.ReadLine();
        
        System.Console.WriteLine("Intoduceti prenumele jucatorului: ");
        jucator.Prenume = Console.ReadLine();

        System.Console.WriteLine("Intoduceti data de nastere a jucatorului: ");
        jucator.DataNastere = Console.ReadLine();

        System.Console.WriteLine("Intoduceti experienta jucatorului: ");
        jucator.Experienta= Console.ReadLine();

        Jucatori.Add(jucator);

    }

    public void StergeJucator()
    {
        System.Console.WriteLine("Introduceti numele jucatorului pe care vreti sa-l stergeti: ");
        string numeJucator = Console.ReadLine();
        bool jucatorGasit = false;

        foreach(Jucator jucator in Jucatori)
        {
            if(jucator.Nume.Equals(numeJucator))
            {
                Jucatori.Remove(jucator);
                System.Console.WriteLine("Jucatorul a fost eliminat cu succes!");
                jucatorGasit = true;
                break;
            }
        }

        if(jucatorGasit == false)
        {
            System.Console.WriteLine("Jucatorul nu a fost gasit!");
        }

    }

    public void AdaugaAnrenori()
    {
         Antrenor antrenor = new Antrenor();

        System.Console.WriteLine("Intoduceti numele antrenorului: ");
        antrenor.Nume = Console.ReadLine();
        
        System.Console.WriteLine("Intoduceti prenumele antrenorului: ");
        antrenor.Prenume = Console.ReadLine();

        System.Console.WriteLine("Intoduceti data de nastere a antrenorului: ");
        antrenor.DataNastere = Console.ReadLine();

        Antrenori.Add(antrenor);
    }

    public void StergeAntrenor()
    {
        System.Console.WriteLine("Introduceti numele antrenorului pe care vreti sa-l stergeti: ");
        string numeAntrenor = Console.ReadLine();
        bool antrenorGasit = false;

        foreach(Antrenor antrenor in Antrenori)
        {
            if(antrenor.Nume.Equals(numeAntrenor))
            {
                Antrenori.Remove(antrenor);
                System.Console.WriteLine("Antrenorul a fost eliminat cu succes!");
                antrenorGasit = true;
                break;
            }
        }

        if(antrenorGasit == false)
        {
            System.Console.WriteLine("Antrenorul nu a fost gasit!");
        }

}
    public void AsigneazaJucator()
    {
        System.Console.WriteLine("Introduceti numele Antrenorului pe care vreti sa-l asignati");
        string numeAntrenor = Console.ReadLine();
        
        System.Console.WriteLine($"Introduceti numele Jucatorului pe care vreti sa-l asignati antrenorului {numeAntrenor}");
        string numeJucator = Console.ReadLine();
        
        foreach(Antrenor antrenor in Antrenori)
        {
            if(antrenor.Nume == numeAntrenor)
            {
                foreach(Jucator jucator in Jucatori)
                {
                    if(jucator.Nume == numeJucator)
                    {
                        antrenor.JucatoriAsignati.Add(jucator);
                    }
                }
            }
        }

    }

    public void InsereazaAdrese()
    {
        Adresa adresa1 = new Adresa(){Denumire = "Adresa1", Numar = 1, Strada = "StradaA"};
        Adrese.Add(adresa1);

        Adresa adresa2 = new Adresa(){Denumire = "Adresa2", Numar = 2, Strada = "StradaB"};
        Adrese.Add(adresa2);

        Adresa adresa3 = new Adresa(){Denumire = "Adresa3", Numar = 3, Strada = "StradaC"};
        Adrese.Add(adresa3);
    }

    public void AfiseazaTerenuri()
    {
        foreach(Teren teren in Terenuri)
        {
            System.Console.WriteLine(teren.IdTeren + " " + teren.TipTeren + " " + teren.Dimensiune + " " + teren.adresa.Denumire + " " + teren.adresa.Numar + " " + teren.adresa.Strada);
        }
    }
    public void InsereazaTerenuri()
    {
        int counterIdTeren = 0;
        InsereazaAdrese();

        foreach(Adresa adresa in Adrese)
        {
            counterIdTeren++;
            Teren teren1 = new Teren(){IdTeren = counterIdTeren, TipTeren = "Iarba", Dimensiune = "8", adresa = adresa};
            Terenuri.Add(teren1);
        }

        AfiseazaTerenuri();
        AsigneazaTerenuri();


    }


    public void AfiseazaLocatii()
    {
        foreach(Locatie locatie in Locatii)
        {
            System.Console.Write(locatie.Nume + " " + locatie.IsComplex + " " );
            foreach(Teren teren in locatie.Terenuri)
            {
                
                System.Console.Write(teren.IdTeren + " " + teren.TipTeren + " " + teren.Dimensiune + " " + teren.adresa.Denumire + " " + teren.adresa.Numar + " " + teren.adresa.Strada);
            }
            System.Console.WriteLine("");
        }
    }
    public void AsigneazaTerenuri()
    {
        Locatie locatie1 = new Locatie(){Nume = "Locatie1", IsComplex = true};
        Locatie locatie2 = new Locatie(){Nume = "Locatie2", IsComplex = false};

        for(int i = 0; i < Terenuri.Count; i++)
        {
            if(i == 0 || i == 1)
            {
                locatie1.Terenuri.Add(Terenuri[i]);
            }
            else
            {
                locatie2.Terenuri.Add(Terenuri[i]);
            }
        }

        Locatii.Add(locatie1);
        Locatii.Add(locatie2);

        System.Console.WriteLine("Terenurile au fost asignate locatiilor cu succes!\n");
        AfiseazaLocatii();
    }
    public void adaugaMeciuri(Competitie competitie) 
    {
     
    }
    public void AsigneazaLocatiePentruCompetitie()
    {
        
        Competitie competitie1 = new Competitie() {Nume = "Competitia1",  DataInceput = "DataInceput1", DataFinal = "DataFinal1", locatie = Locatii[0] };
        Competitie competitie2 = new Competitie() { Nume = "Competitia2", DataInceput = "DataInceput2", DataFinal = "DataFinal2", locatie = Locatii[0] };

        adaugaMeciuri(competitie1);
    }


}