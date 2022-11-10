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
            List<string> pri1 = new List<string>();
            List<string> pri2 = new List<string>();
            List<string> pri3 = new List<string>();
            int random;
            var assignment;

            foreach (string line in lines)
            {
                string[] parts = line.Split(';');
                email.Add(parts[0]);
                pri1.Add(parts[1]);
                pri2.Add(parts[2]);
                pri3.Add(parts[3]);

            }

       
            List<string> Zuteilung;
            for (int i = 0; i < email.Count; i++)
            {

                Random rnd = new Random();
                random = rnd.Next(1, 3);





                if (random == 1)
                    Zuteilung = pri1[i];
                if (random == 2)
                    Zuteilung = pri2[i];
                if (random == 3)
                    Zuteilung = pri3[i];



            }
            foreach (string entscheid in assignment)
            {



                int TanzenCounter = 0;
                int FussballCounter = 0;
                int SingenCounter = 0;
                int NähenCounter = 0;



                if (entscheid == "Tanzen")
                {
                    TanzenCounter++;
                }
                if (entscheid == "Fussball")
                {
                    FussballCounter++;
                }



                if (entscheid == "Nähen")
                {
                    NähenCounter++;
                }



                if (entscheid == "Singen")
                {
                    SingenCounter++;
                }

                if (TanzenCounter < 4 || TanzenCounter > 20)
                {
                    Console.WriteLine("Tut mir Leid, keine Tanzkurse mehr");
                }



                else
                {
                    Console.WriteLine("Yay, wir haben einen Kurs");
                    
                }




                if (NähenCounter < 4 || NähenCounter > 20)
                {
                    Console.WriteLine("Tut mir Leid, keine Nähkurse mehr");
                }



                else
                {
                    Console.WriteLine("Yay, wir haben einen Kurs");
                    
                }




                if (FussballCounter < 4 || FussballCounter > 20)
                {
                    Console.WriteLine("Tut mir Leid, keine Fusballkurse mehr");
                }



                else
                {
                    Console.WriteLine("Yay, wir haben einen Kurs");
                   
                }




                if (SingenCounter < 4 || SingenCounter > 20)
                {
                    Console.WriteLine("Tut mir Leid, keine Singkurse mehr");
                }



                else
                {
                    Console.WriteLine("Yay, wir haben einen Kurs");
                    
                }

                string outPath = @"C:\Users\chris\OneDrive\Desktop\Schule\BBB\Lernatelier\Endergebnis.txt";
                string outText = email + ": " entscheid + "\r\n"
                File.WriteAllText(outPath, outText);

                string fileoutput = "";

                int i = 0;




            }
        }
    }
}