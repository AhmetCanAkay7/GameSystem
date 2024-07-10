using GameSystem.Abstract;
using GameSystem.Concrete;
using GameSystem.Entities;

namespace GameSystem
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Gamer gamer1 =new Gamer();
            gamer1.Id = 1;
            gamer1.FirstName = "Ahmet Can";
            gamer1.LastName = "Akay";
            gamer1.NationalityId = "15730522050";
            gamer1.DateOfBirth = new System.DateTime(2003, 9, 4);
            gamer1.Balance = 1000;

            IGamerCheckService gamerCheckManager = new GamerCheckManager();

            GamerManager gamerManager = new GamerManager(gamerCheckManager);
            gamerManager.Add(gamer1);

            Console.ReadLine();

            
        }
    }
}