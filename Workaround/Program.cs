using Business.Concrete;
using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
        Citizen citizen1 = new Citizen();
        citizen1.NationalIdentity = 12345;
        citizen1.FirstName = "BERKAY";
        citizen1.LastName = "ŞAHİN";
        citizen1.DateOfBirth = 2000;

        PttManager pttManager = new PttManager(new CitizenManager());
        pttManager.GiveMask(citizen1 );
        Console.ReadLine();
    }
}