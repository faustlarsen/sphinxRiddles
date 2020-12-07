using System;

namespace Sphinx
{
    public class Program
    {
        public static void Main()
        {
          Riddle riddle1 = new Riddle("If I had four eggs; Lesile gives me three eggs; My farm rooster lays five eggs...How many eggs do I have?", "three");

          Riddle riddle2 = new Riddle("The more of this there is, the less you see...What is it?", "darkness");

          Riddle riddle3 = new Riddle("What has 1 in every corner, 2 in every room, but only 1 in the world?", "o");

          Riddle[] arrayOfQuestions = {riddle1 ,riddle2, riddle3};

          for (int i=0; i < arrayOfQuestions.Length; i++)
          {
              Console.WriteLine(arrayOfQuestions[i].Question);
              string userAnswer = Console.ReadLine();
              
              if (userAnswer == arrayOfQuestions[i].Answer)
              {
                if (i == arrayOfQuestions.Length-1){
                Console.WriteLine("You have exhausted my riddles...you may pass.");
                }
                else
                {
                Console.WriteLine("Correct...Here's another one:");
                }
              }
              else
              {
                Console.WriteLine("You suck! You have been eaten by the sphinx!");
              }
            
          }
        }
    }
}