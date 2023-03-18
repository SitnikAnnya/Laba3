using System;

class Program
{
    static void Main(string[] args)    
{
        string input = ("арпоарк ваырА чмвАрпра паер");     

        input = input.Replace('а', '$');
        input = input.Replace('А', 'а');
        input = input.Replace('$', 'А');
  
    Console.WriteLine(input);        
    Console.ReadKey();
    }
}