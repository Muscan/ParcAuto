using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ParcAuto
{

    class ControllerMasina
    {
        private List<Masina> masini;
        public ControllerMasina()
        {
            masini = new List<Masina>();




            readFileTxt();


        }
        //print cars

        public string printAllCars()

        {
            string text = "";
            Console.WriteLine("Descriere masina: ");
            for (int i = 0; i < masini.Count; i++)
            {
                text += masini[i].carDescription() + "\n";
            }

            return text;
        }
        //gasire index masina
        public int carIndex(string marca)
        {
            for (int i = 0; i < masini.Count; i++)
            {
                if (masini[i].getMarca().Equals(marca))
                {
                    return i;
                }

            }
            return -1;
        }

        public bool Update(string nume, int pret)
        {
            int index = carIndex(nume);
            if (index != -1)
            {
                masini[index].setPret(pret);
                Console.WriteLine("Pretul a fost updatat");
                return true;
            }
            Console.WriteLine("Masin anu a fost gasita");
            return false;
        }
        //Add
        public bool Add(Masina masina)
        {
            int index = carIndex(masina.getMarca());
            if (index == -1)
            {
                this.masini.Add(masina);
                Console.WriteLine("Item Added!");
                return true;
            }
            Console.WriteLine("Item exists");
            return false;
        }
        //delete
        public bool Delete(string masina)
        {
            int index = carIndex(masina);
            if (index != -1)
            {
                Console.WriteLine("Item " + masini[index].getMarca() + " deleted");
                this.masini.RemoveAt(index);
                return true;
            }
            Console.WriteLine("Item not deleted ");
            return false;
        }

        //stream reader

        public void readFileTxt()
        {
            StreamReader read = new StreamReader(@"../../../Masini.txt");
            String line = "";
            line = read.ReadLine();

            while (line != "" && line != null)
            {
                //(string marca, int pret, double motor, string culoare, int anFabricatie, string tractiune)
                String[] p = line.Split(",");
                String marca = p[0];
                int pret = int.Parse(p[1]);
                double motor = double.Parse(p[2]);
                string culoare = p[3];
                int anFabricatie = int.Parse(p[4]);
                string tractiune = p[5];
                bool status = bool.Parse(p[6]);

                Masina masina = new Masina(marca, pret, motor, culoare, anFabricatie, tractiune, status);
                masini.Add(masina);
                line = read.ReadLine();
            }
            read.Close();
        }
        public string toStringObjectFromFile()
        {
            string tot = "";
            for (int i = 0; i < masini.Count; i++)
            {
                tot += masini[i].toSave() + "\n";

            }
            return tot;
        }

        public void saveToFileTxt()
        {
            StreamWriter write = new StreamWriter(@"../../../Masini.txt");
            write.WriteLine(this.toStringObjectFromFile());
            write.Close();
        }
        
        
    }
}
