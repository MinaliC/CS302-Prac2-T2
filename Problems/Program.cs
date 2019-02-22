using System;

namespace Problems
{
    public class Program

    {

        public string Prefix(string input)
        {
           
            int len=input.Length;
            
            string temp=input;
            string [] totalwords=temp.Split(" ");
            int counter=totalwords.Length;
                if(input=="")
            {
             int total=0;
                return ($"{len},{total}:{input}");
            }

            foreach(string s in totalwords)
            {
                if(s=="")
                {
                    counter--;
                }
            }
                return ($"{len},{counter}:{input}");

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           
        }
    }
}
