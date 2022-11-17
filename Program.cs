namespace Blobfisch
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            
           
            string inPath = @"C:\Users\chris\OneDrive\Desktop\Schule\BBB\Lernatelier\Workshop.txt";
            string text = File.ReadAllText(inPath);

            string[] lines = text.Split("\r\n");




            Console.WriteLine(text);

            List<string> email = new List<string>();
            List<string> FirstPriority = new List<string>();
            List<string> SecondPriority = new List<string>();
            List<string> ThirdPriority = new List<string>();
            int random;
            var assignment;

            foreach (string line in lines)
            {
                string[] parts = line.Split(';');
                email.Add(parts[0]);
                FirstPriority.Add(parts[1]);
                SecondPriority.Add(parts[2]);
                ThirdPriority.Add(parts[3]);

            }

       
            List<string> Allocation;
            for (int i = 0; i < email.Count; i++)
            {

                Random rnd = new Random();
                random = rnd.Next(1, 3);





                if (random == 1)
                    Allocation = FirstPriority[i];
                if (random == 2)
                    Allocation = SecondPriority[i];
                if (random == 3)
                    Allocation = ThirdPriority[i];



            }
            foreach (string Decision in assignment)
            {



                int DanceCounter = 0;
                int SoccerCounter = 0;
                int SingCounter = 0;
                int SewCounter = 0;



                if (Decision == "Dance")
                {
                    DanceCounter++;
                }
                if (Decision == "Soccer")
                {
                    SoccerCounter++;
                }



                if (Decision == "Sew")
                {
                    SewCounter++;
                }



                if (Decision == "Sing")
                {
                    SingCounter++;
                }

                if (DanceCounter < 4 || DanceCounter > 20)
                {
                    Console.WriteLine("Tut mir Leid, keine Tanzkurse mehr");
                }



                else
                {
                    Console.WriteLine("Wir haben einen Kurs");
                    
                }




                if (SewCounter < 4 || SewCounter > 20)
                {
                    Console.WriteLine("Tut mir Leid, keine Nähkurse mehr");
                }



                else
                {
                    Console.WriteLine("Wir haben einen Kurs");
                    
                }




                if (SoccerCounter < 4 || SoccerCounter > 20)
                {
                    Console.WriteLine("Tut mir Leid, keine Fusballkurse mehr");
                }



                else
                {
                    Console.WriteLine("Wir haben einen Kurs");
                   
                }




                if (SingCounter < 4 || SingCounter > 20)
                {
                    Console.WriteLine("Tut mir Leid, keine Singkurse mehr");
                }



                else
                {
                    Console.WriteLine("Wir haben einen Kurs");
                    
                }

                string outPath = @"C:\Users\chris\OneDrive\Desktop\Schule\BBB\Lernatelier\Endergebnis.txt";
                string outText = email + ": " Decision + "\r\n"
                File.WriteAllText(outPath, outText);

                string fileoutput = "";

                int i = 0;




            }
        }
    }
}
