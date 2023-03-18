using System; 

class Program {
  static void Main(string[] args) {
    
   string input = ("Метаыамовмовами");  
    input = input.ToLower();
    char FirstChar = input.Substring(0, 1)[0];
    char LastChar = input.Substring(input.Length - 1, 1)[0];

    int First = 0, Last = 0;
    for (int i = 0; i < input.Length; i++) {
      if (input.Substring(i,1)[0] == FirstChar) {
        First += 1;
      }
      if (input.Substring(i,1)[0] == LastChar) {
        Last += 1;
      }
    }

    if (FirstChar == LastChar) {
      Console.WriteLine("В начале и в конце стоит одна и та же буква, она встречается {0} раз(а)", Last);
    }
    else if (First > Last) {
      Console.WriteLine("Чаще встречается первая буква - {0}, всего {1} раз(а)", FirstChar, First);
    }
    else if (Last > First) {
      Console.WriteLine("Чаще встречается последняя буква - {0}, всего {1} раз(а)", LastChar, Last);
    }
    else if (First == Last) {
      Console.WriteLine("Первая и последняя буквы встречаются одинаково часто, каждая по {0} раз(а)", First);
    }
    else {
      Console.WriteLine("Ошибка");
    }
  Console.ReadKey();
  }
}