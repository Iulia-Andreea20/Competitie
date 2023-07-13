Management management = new Management();

while(true)
{
    System.Console.WriteLine("Introduceti optiunea dorita: ");
    char option = Console.ReadLine()[0];
    
    switch(option)
    {
        case '1':
            management.AdaugaJucator();
            break;
        case '2':
            management.StergeJucator();
            break;
        case '3':   
            management.AdaugaAnrenori();
            break;
        case '4':
            management.StergeAntrenor();
            break;
        case '5':
            management.InsereazaTerenuri();
            break;
        case '6':
            
            break;
        default:
            break;
    }
}