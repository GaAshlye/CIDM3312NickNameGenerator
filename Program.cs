
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace NickNameGenerator
{
    class Program
    {
        
        static void Main(string[] args)
        {  
            //variables and arrays 
            string name;   
            string[] firstNickName = new string[4] { "master", "wizard", "ghost", "whiteKnight"};
            string[] lastNickName = new string[4] { "mind", "necromancer", "blaster", "darkknight"};

            //prompting user for name to generate nickname                      
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine().ToLower();
            string[] nameParts = name.Split(new char[] { ' ' });            
            //this will split the name in half that way the user only has to enter a value in once
            if (name.Contains(' '))
            {
                Console.WriteLine("Hello {0} your name is:  {1} {2}", name, NameGenerator(nameParts[0], firstNickName), NameGenerator(nameParts[1], lastNickName));
            }
           else
            {
                Console.WriteLine("Hello {0}, your nickname is {1}", name, NameGenerator(nameParts[0], firstNickName));
            }


        }
        static string NameGenerator(string name, string[]nicknames)
        {
            /*This method will return a nickname for the user. It will take the score it got from Vowelscore and translate that to a name. */
            string funName = " ";
            int score = VowelScore(name);
            if (score <= 1)
            {
                funName = nicknames[0];
            }
            if (score > 1 && score <= 3)
            {
                funName = nicknames[1];
            }
            if (score == 4 || score == 5)
            {
                funName = nicknames[2];
            }
            if (score >= 6)
            {
                funName = nicknames[3];
            }        
            
            return funName;

        }
        static int VowelScore(string name)
        {
            /*This will give you a total score for the number of vowels present, it only will give you a certain amount of points for each letter. For example
            the if your name is alejandra, you will only get one point for have 3 a's.  */
            //a = 1pt
            //e = 2pt
            //i = 3pt
            //o = 4pt
            //u = 5pt
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            HashSet<char> hSet1 = new HashSet<char>(vowels);           
            
            //initialize score keeping variables 
            int scoreA = 0;
            int scoreE = 0;
            int scoreI = 0;
            int scoreO = 0;
            int scoreU = 0;

            if (name.Contains('a'))
            {
                 scoreA = scoreA + 1;
            }
            if (name.Contains('e'))
            {
                scoreE = scoreE + 2;
            }
            if (name.Contains('i'))
            {
                scoreI = scoreI + 3;
            }
            if (name.Contains('o'))
            {
                scoreO = scoreO + 4;
            }
             if (name.Contains('u'))
            {
                scoreU = scoreU + 5;
            }

            int totalScore = scoreA + scoreE + scoreI + scoreO + scoreU ;
            //Console.WriteLine("your total score is: {0}", totalScore);
            return totalScore; 
        }
    }
}
