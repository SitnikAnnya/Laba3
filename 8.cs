using System;

class Program {
  static void Main(string[] args) {
    string input = ("ауауау_ауауау");  
    input = input.ToLower();

    int count = 0;
    for (int i = 1; i < input.Length; i += 2) {
      if (input.Substring(i,1) == "у" ) {
        count ++;
      }
    }
    Console.WriteLine(count);        
    Console.ReadKey();
  }
}