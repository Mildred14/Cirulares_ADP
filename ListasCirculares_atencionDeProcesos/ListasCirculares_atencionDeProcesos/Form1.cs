﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasCirculares_atencionDeProcesos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Procedimiento p1 = new Procedimiento();
            p1.comenzarCiclos();
            textBox1.Text = "Número máximos de procesos formados: " + p1.pFinalizados().ToString();
            textBox2.Text = "Procesos atendidos en totalidad: " + p1.pRealizados().ToString();
            textBox3.Text = "Procesos pendientes: " + p1.pPendientes().ToString();
            textBox4.Text = "Suma de ciclos pendientes: " + p1.cPendientes();
            textBox5.Text = "Ciclos vacíos: " + p1.ciclosVacios();

        }
    }
}
