using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29._09._2023_Картв_Марафон_Скиллс
{
    public partial class FormMap : Form
    {
        public FormMap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBoxInf.Visible = false;
            pictureBoxRest.Visible = false;
            pictureBoxMed.Visible = false;
            pictureBoxRest.Visible = false;
            pictureBoxFood.Visible = false;
            pictureBoxEnergy.Visible = false;
        }

        private void pictureBoxStart1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxStart2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxStart3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "Avenida Rudge";
            pictureBoxInf.Visible = false;
            pictureBoxRest.Visible = false;
            pictureBoxMed.Visible = false;
            pictureBoxFood.Visible = true;
            pictureBoxEnergy.Visible = true;

            labelInfo.Visible = false;
            labelRest.Visible = false;
            labelMed.Visible = false;
            labelDrinks.Visible = true;
            labelEner.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Theatro Municipal";
            pictureBoxInf.Visible = true;
            pictureBoxRest.Visible = true;
            pictureBoxMed.Visible = true;
            pictureBoxFood.Visible = true;
            pictureBoxEnergy.Visible = true;

            labelInfo.Visible = true;
            labelRest.Visible = true;
            labelMed.Visible = true;
            labelDrinks.Visible = true;
            labelEner.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "Parque do Ibirapuera";
            pictureBoxInf.Visible = false;
            pictureBoxRest.Visible = true;
            pictureBoxMed.Visible = false;
            pictureBoxFood.Visible = true;
            pictureBoxEnergy.Visible = true;

            labelInfo.Visible = false;
            labelRest.Visible = true;
            labelMed.Visible = false;
            labelDrinks.Visible = true;
            labelEner.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = "Jardim Luzitania";
            pictureBoxInf.Visible = false;
            pictureBoxRest.Visible = true;
            pictureBoxMed.Visible = true;
            pictureBoxFood.Visible = true;
            pictureBoxEnergy.Visible = true;

            labelInfo.Visible = false;
            labelRest.Visible = true;
            labelMed.Visible = true;
            labelDrinks.Visible = true;
            labelEner.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text = "Iguatemi";
            pictureBoxInf.Visible = true;
            pictureBoxRest.Visible = true;
            pictureBoxMed.Visible = false;
            pictureBoxFood.Visible = true;
            pictureBoxEnergy.Visible = true;

            labelInfo.Visible = true;
            labelRest.Visible = true;
            labelMed.Visible = false;
            labelDrinks.Visible = true;
            labelEner.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label2.Text = "Rua Lisboa";
            pictureBoxInf.Visible = false;
            pictureBoxRest.Visible = true;
            pictureBoxMed.Visible = false;
            pictureBoxFood.Visible = true;
            pictureBoxEnergy.Visible = true;

            labelInfo.Visible = false;
            labelRest.Visible = true;
            labelMed.Visible = false;
            labelDrinks.Visible = true;
            labelEner.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label2.Text = "Cemitério da Consolação";
            pictureBoxInf.Visible = true;
            pictureBoxRest.Visible = true;
            pictureBoxMed.Visible = true;
            pictureBoxFood.Visible = true;
            pictureBoxEnergy.Visible = true;

            labelInfo.Visible = true;
            labelRest.Visible = true;
            labelMed.Visible = true;
            labelDrinks.Visible = true;
            labelEner.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label2.Text = "Cemitério da Consolação";
            pictureBoxInf.Visible = true;
            pictureBoxRest.Visible = true;
            pictureBoxMed.Visible = true;
            pictureBoxFood.Visible = true;
            pictureBoxEnergy.Visible = true;

            labelInfo.Visible = true;
            labelRest.Visible = true;
            labelMed.Visible = true;
            labelDrinks.Visible = true;
            labelEner.Visible = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
