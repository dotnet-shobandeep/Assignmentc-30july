using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Game
    {
        int noOfPlayers;
        string country;
        int year;
     
        public int NoOfPlayers
        {
            get { return noOfPlayers; }
            set { value = noOfPlayers; }
        }
        public string Country
        {
            get { return country; }
            set { value = country; }
        }
        public Game()
        {

        }
        public Game(int _noOfPlayers,string _country)
        {
            noOfPlayers = _noOfPlayers;
            country = _country;
        }
        public void WorldCup(string country,string game)
        {
            Console.WriteLine("{0} have won the {1}  WorldCup : {2}", country,game, year);
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
    }

    class Cricket:Game
    {
        string coachname;
        public string Coachname
        {
            get { return coachname; }
            set { value = coachname; }
        }
        public Cricket()
        {

        }
        public Cricket(int _noOfPlayers, string _country, string _coachname) : base(_noOfPlayers,_country)
        {

        }
    }

    class Football : Game
    {
        string leaugename;
        public string Leaugename
        {
            get { return leaugename; }
            set { value = leaugename; }
        }
        public Football()
        {

        }
        public Football(int _noOfPlayers, string _country, string _leaugename) : base(_noOfPlayers, _country)
        {

        }
    }
    class ShowGameDetails
    {
        public void ShowCricketDetails( string Country,int NoOfPlayers,string Coachname)
        {
            Console.WriteLine("Country:{0}  No of players:{1} Coachname:{2}", Country, NoOfPlayers, Coachname);
        }
        public void ShowFootballDetails(string Country,int NoOfPlayers,string Leaugename)
        {
            Console.WriteLine("Country:{0}  No of players:{1} Leaugename:{2}", Country, NoOfPlayers, Leaugename);
        }
    }
    class GameInheritence
    {
        static void Main()
        {
            Cricket india = new Cricket();
            Cricket australia = new Cricket();
            Football england  = new Football();
            Football spain = new Football();

            ShowGameDetails d = new ShowGameDetails();
            Console.WriteLine("-----------------Cricket Information----------------------");
            d.ShowCricketDetails("India", 11, "Ravi Shastri");
            d.ShowCricketDetails("Australia", 11, "Micle Clark");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-----------------Cricket Information----------------------");

            d.ShowFootballDetails("England", 14, "English League");
            d.ShowFootballDetails("Spain", 13, "Spainish League");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            Game g = new Game();
            g.Year = 2011;
            g.WorldCup("India","Cricket");
            g.WorldCup("Spain","Football");
            Console.ReadLine();

        }
    }
}
