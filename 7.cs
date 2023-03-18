using System; 

  class Program { 
    static void Main(string[] args) { 
      string input = ("Если бы голод был человеком, то он бы был самым негативным"); 
      string[]str = input.Split(new Char[]{',','.',' ',':','!','?',';'}, StringSplitOptions.RemoveEmptyEntries); 
        
      int MaxLen =0, ArrIndex = 0; 
      for (int i = 0; i < str.Length; i++) { 
        if (str[i].Length > MaxLen) { 
                MaxLen = str[i].Length; 
                ArrIndex = i; 
        } 
      } 
        
      int index = input.IndexOf(str[ArrIndex]);
      string strRemoved = input.Remove(index, MaxLen);

      string result = str[ArrIndex] + " " + strRemoved;
      result = result.ToLower();
      result = result.Insert(0,result.Substring(0,1).ToUpper());
      result = result.Remove(1,1);
          
    Console.Write(result);
    Console.ReadLine(); 
  } 
}