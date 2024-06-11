using Business.Concrete;
using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
        

        Citizen citizen1 = new Citizen();

        citizen1.FirstName = "Ali Osman";
        citizen1.LastName = "Demirkollu";
        citizen1.NationalIdentity = 23123;
        citizen1.DateOfBirthYear = 2001;
        

        PttService pttService = new PttService(new CitizenService());
        pttService.GiveMask(citizen1);




    }

}