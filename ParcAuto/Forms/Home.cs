using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ParcAuto
{
    public partial class Home : Form
    {

        private ControllerMasina controller;



       
        public Home()
        {
            InitializeComponent();

            controller = new ControllerMasina();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (btnPrint.Enabled == true)
            {

                MessageBox.Show(controller.printAllCars());
            }
        }

        private void txtBoxNume_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAddCuloare_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Enabled == true)
            {

                createCar(txtBoxAddMarca, txtBoxAddPret, txtBoxAddMotor, txtBoxAddCuloare, txtBoxAnFabricatie,
                          txtBoxAddTractiune);
            }
        }

        private void updateCar(TextBox Marca, TextBox Pret)
        {
            String marca = Marca.Text;
            int pret = int.Parse(Pret.Text);
            controller.Update(marca, pret);
            controller.saveToFileTxt();
        }

        public static bool isSelected( RadioButton rdo2, RadioButton rdo1)
        {
            if (rdo1.Checked == false && rdo2.Checked == false)
            {
                return false;
            }
            return true;
        }


        public void createCar(TextBox txtMarca, TextBox txtPret, TextBox txtMotor, TextBox txtCuloare,
                              TextBox txtAnFabricatie, TextBox txtTractiune)
        {



            String marca = txtMarca.Text;
            int pret = int.Parse(txtPret.Text);
            double motor = double.Parse(txtMotor.Text);
            String culoare = txtCuloare.Text;
            int anFabricatie = int.Parse(txtAnFabricatie.Text);
            string tractiune = txtTractiune.Text;
            bool status = isSelected(rdoBtnTrue, rdoBtnFalse);

            Masina masina = new Masina(marca, pret, motor, culoare, anFabricatie, tractiune, status);
            controller.Add(masina);
            controller.toStringObjectFromFile();
            controller.saveToFileTxt();

        }
        public void deleteCar(TextBox marca)
        {


            controller.Delete(marca.Text);


        }
        private void btnDeleteMarca_Click(object sender, EventArgs e)
        {
            if (btnDeleteMarca.Enabled == true)
            {
                deleteCar(txtBoxDeleteMarca);


                controller.saveToFileTxt();
             
                controller.printAllCars();
                
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Enabled == true)
            {
                updateCar(txtBoxNume, txtBoxPret);
            }
        }
    }
}
