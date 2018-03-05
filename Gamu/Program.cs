using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gamu
{
    class Program
    {
        static void Main(string[] args)
        {
            Player nu = new Player();
            Console.WriteLine("Choose class");
            Console.WriteLine("Warrior");
            Console.WriteLine("Mage");
            Console.WriteLine("Thief");
            string Job = Console.ReadLine();
            if (Job == "Warrior")
            {
                nu.Warrior();
            }
            else if (Job == "Mage")
            {
                nu.Mage();
            }
            else if (Job == "Thief")
            {
                nu.Thief();
            }
            Console.WriteLine("You have chosen " + Job + " and these are your stats " + "HP: " + nu.MaxHP + " SP: " + nu.SP);
            Console.ReadLine();
        }
    }
    public class Game
    {
        public void Battle()
        {
            Enemy[] Enemy = new Enemy[10];
            Enemy[1] = new Enemy();
            do
            {
              Console.WriteLine("You have entered battle with " + Slime + "!");

            } while (Slime.MaxHP > 0);
            
        }
    }
    public class Player
    {
        public int CurrentHitPoints { get; set; }
        public int MaxHP { get; set; }
        public int SP { get; set; }
        public int Yen { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Int { get; set; }
        public int Ability { get; set; }
        public int EXP = 0;
        public int LVL = 1;
        public void Warrior()
        {
            MaxHP = 50;
            SP = 50;
            Attack = 20;
            Int = 5;
            Ability = 10;
        }
        public void Mage()
        {
            MaxHP = 25;
            SP = 100;
            Attack = 5;
            Int = 20;
            Ability = 15;
        }
        public void Thief()
        {
            MaxHP = 35;
            SP = 75;
            Attack = 10;
            Int = 5;
            Ability = 25;
        }
        }
    public class Enemy : Player
    {
        public void Enemy()
        {
            
        }
    }
    }