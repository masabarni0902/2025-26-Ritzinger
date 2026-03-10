namespace Fájlbairás
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fajl = "szoveg.txt";

            //Irás
            using (StreamWriter sw = new StreamWriter(fajl))
            {
                sw.WriteLine("Első sor");
                sw.WriteLine("Második sor");
            }

            //Olvasás

            using(StreamReader sr = new StreamReader(fajl))
            {
                string sor;
                while((sor = sr.ReadLine()) != null)
                {
                    Console.WriteLine(sor);
                }
            }

            //Hozzáfűzés
            using(StreamWriter sw = File.AppendText(fajl))
            {
                sw.WriteLine("Hozzáűzött sor");
            }
        }
    }
}
