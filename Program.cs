class Program {
    static void Main(string[] args) {
          Console.Write("Password :" );
          int x = int.Parse(Console.ReadLine());

          Console.Write("agency :" );
          string z = (Console.ReadLine());

          if(x <= 999999 && x >= 0) {
            
            int saen = x / 100000 % 10;
            int meun = x / 10000 % 10;
            int pun = x / 1000 % 10;
            int roy = x / 100 % 10;
            int cim = x / 10 % 10;
            int noy = x % 10;

          if(z == "CIA") {
            if(pun >= 6 && pun != 8 && cim != 1 && cim != 3 && cim != 5 && noy % 3 == 0) {
                Console.WriteLine("True");
            }
            else {
                Console.WriteLine("False");
            }
          }
          if(z == "FBI") {
            if(saen >= 4 && saen <= 7 && roy % 2 == 0 && roy != 6 && meun % 2 != 0) {
                Console.WriteLine("True");
            }
            else {
                Console.WriteLine("False");
            }
          }
          if(z == "NSA") {
            if(noy % 30 == 0 && roy % 3 == 0 && roy % 2 != 0 && noy == 7 || cim == 7 || roy == 7 || pun == 0 || meun == 7 || saen == 7) {
                Console.WriteLine("True");
            }
            else {
                Console.WriteLine("False");
            }
          }
          else {
                Console.WriteLine("False");
          }
    }
}
            }
