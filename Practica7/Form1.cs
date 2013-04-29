using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int puntos=0;

            if(this.naranja.Checked){
                puntos++;
        }
            if(this.cuatro.Text=="4"){
                puntos++;
            }
            if(this.peru.Checked){
                puntos++;
            }
            if(this.mexico.Checked){
                puntos++;
            }
            DateTime fecha = this.calendario.GetDate();
		string fechaSeleccionada = fecha.ToShortDateString();
		if(fechaSeleccionada=="16/09/1810"){
		puntos++;	
		}
       }
     }
   }
 

