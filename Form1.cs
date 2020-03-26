using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Votacion
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show(" BIEN VENIDO A \n GESTION DE VOTOS 2020 \n \r INGRESE EL CANDIDATO \n CON SUS RESPECTIVOS VOTOS ");

        }
        ListaVotacion ListaCandidato = new ListaVotacion();
        int cont = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cont<2)
            {
                label3.Text = ListaCandidato.CargarDatos(textBox1.Text, textBox2.Text);
                textBox1.Text = "";
                textBox2.Text = "";
                MessageBox.Show(label3.Text + "\r" + "INGRESE EL SIGUIENTE CANDIDATO ");
                cont++;

               
                
            }
            else
            {
                label3.Text = ListaCandidato.CargarDatos(textBox1.Text, textBox2.Text);
                textBox1.Text = "";
                textBox2.Text = "";
                MessageBox.Show(label3.Text + "\r" + "HA LLEGADO EL LIMITE DE CANDIDATOS");
                button1.Enabled = false;
                textBox1.Enabled = false;
                textBox2.Enabled = false;

                ListaCandidato.Ordenar();
                label3.Text = ListaCandidato.registro();
                label5.Text = "EL CONTEO TOTAL DE VOTOS ES DE "+ListaCandidato.recuento();
                label6.Text = ListaCandidato.ganador();
                label7.Text = ListaCandidato.porcentaje();
                label8.Text = ListaCandidato.perdedor();

            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            button1.Enabled = true;
        }
    }
}
