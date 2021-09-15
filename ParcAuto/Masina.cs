using System;
using System.Collections.Generic;
using System.Text;

namespace ParcAuto
{
    class Masina
    {
        private string marca;
        private int pret;
        private double motor;
        private string culoare;
        private int anFabricatie;
        private string tractiune;
        private bool status = false; //todo
        
       
        public Masina()
        {
        }

        public Masina(string marca, int pret, double motor, string culoare, int anFabricatie, string tractiune, bool status)
        {

            this.marca = marca;
            this.pret = pret;
            this.motor = motor;
            this.culoare = culoare;
            this.anFabricatie = anFabricatie;
            this.tractiune = tractiune;
            this.status = status;
        }

        public Masina(string marca)
        {
            this.marca = marca;
        }
        public void setMarca(string marca)
        {
            this.marca = marca;
        }
        public string getMarca()
        {
            return this.marca;
        }
        public void setPret(int pret)
        {
            this.pret = pret;
        }

        public int getPret()
        {
            return this.pret;
        }

        public void setMotor(double motor)
        {
            this.motor = motor;
        }

        public double getMotor()
        {
            return this.motor;
        }

        public void setCuloare(string culoare)
        {
            this.culoare = culoare;
        }

        public string getCuloare()
        {
            return this.culoare;
        }

        public void setAnFabricatie(int anFabricatie)
        {
            this.anFabricatie = anFabricatie;
        }

        public int getAnFabricatie()
        {
            return this.anFabricatie;
        }

        public void setTractiune(string tractiune)
        {
            this.tractiune = tractiune;
        }

        public string getTractiune()
        {
            return this.tractiune;
        }

        public void setStatus(bool status)
        {
            this.status = status;
        }
        public bool getStatus()
        {
            return this.status;
        }
        //descriere
        public string carDescription()
        {
            string carDetails = "";
            carDetails += "Marca: "         + this.marca + "\n";
            carDetails += "Pret: "          + this.pret + "\n";
            carDetails += "Motor: "         + this.motor + "\n";
            carDetails += "Culoare: "       + this.culoare + "\n";
            carDetails += "An fabricatie: " + this.anFabricatie + "\n";
            carDetails += "Tractiune: "     + this.tractiune + "\n";
            carDetails += "Status: " + this.status + "\n";
            return carDetails;
        }

        public void afisareMasina()
        {
            Console.WriteLine(this.carDescription());
        }

        //toSave
        public String toSave()
        {
            return marca + "," + pret + "," + motor + "," + culoare + "," + anFabricatie + "," + tractiune + "," + status;  
        }

    }

}
