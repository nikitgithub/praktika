using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika
{
    internal class Program
    {   
        static void data()
        {
            string FullName = "Галимзянов Никита Сергеевич";
            int age = 18;
            string email = "n_kzn@mail.ru";
            int ProgrammingScores = 96;
            int MathScores = 95;
            int PhysicsScores = 100;
            Console.WriteLine($" Ф.И.О:{FullName},\n возраст:{age},\n email:{email},\n балл по информатике:{ProgrammingScores},\n балл по математике:{MathScores},\n балл по физике:{PhysicsScores} ");
        }
        static void Ball(int Value_1,int Value_2,int Value_3)
        {
            int score;
            score = (Value_1 + Value_2 + Value_3) / 3;
            Console.WriteLine($" средний балл:{score}");

        }
        static void Main(string[] args)
        {
            data();
            Ball(96,95,100);
            Console.ReadLine();
            
        }
    }
}
