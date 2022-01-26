using System;
using System.Collections.Generic;

namespace TwentFourHours
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Times = new List<string>();
            List<string> SortedTimes = new List<string>();
            for (; ; )
            {
                Console.Write("Input time in 24hours format e.g (13:45) enter s to stop: ");
                string userInput = Console.ReadLine().Trim();
                if (userInput == "s")
                {
                    break;
                }
                Times.Add(userInput);
            }
            // for (int j = 0; j < Times.Count; j++)
            // {
            //     string smallest = " ";
            //     for (int i = 0; i < Times.Count; i++)
            //     {  
            //         string[] userInput = Times[i].Split(':');
            //         string[] smallSplit = Times[0].Split(':');
            //         int timeSort = int.Parse(userInput[0] + userInput[1]);
            //         int smallestTime = int.Parse(smallSplit[0] + smallSplit[1]);

            //         if (timeSort <= smallestTime)
            //         {
            //             smallest = $"{userInput[0]}:{userInput[1]}";
            //             // Times.Remove(smallest);
            //         }
            //     }
            //     SortedTimes.Add(smallest);
   
            // }
            // foreach (var t in SortedTimes)
            // {
            //     Console.WriteLine(t);
            // }
            
            foreach (var time in Times)
            {
                string[] user24hour = time.Split(':');
                int item = int.Parse(user24hour[0]);
                if (item == 12)
                {
                    Console.WriteLine($"Your time in 12Hours format = 12:{user24hour[1]}pm");
                }
                else if (item == 00)
                {
                    Console.WriteLine($"Your time in 12Hours format = 12:{user24hour[1]}am");
                }
                else if (item > 12)
                {
                    Console.WriteLine($"Your time in 12Hours format = 0{item % 12}:{user24hour[1]}pm");
                }
                else if (item > 10)
                {
                    Console.WriteLine($"Your time in 12Hours format = {item}:{user24hour[1]}am");
                }
                else
                {
                    Console.WriteLine($"Your time in 12Hours format = 0{item}:{user24hour[1]}am");
                }
            }
        }

        static List<string> SortTimes(List<string> times){
            List<string> sortedTimes = new List<string>();

            for(int i = 0; i < times.Count(); i++){
                
                for(int j = 0; j < times.Count() - 1; j++){


                }

            }
        }
    }
}
