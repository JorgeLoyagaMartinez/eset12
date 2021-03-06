﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EstadisticasEscuelaFrontEnd.Login;
using EstadisticasEscuelaFrontEnd.Alumnos;
using EstadisticasEscuelaFrontEnd.Usuarios;
using EstadisticasEscuelaFrontEnd.Cursos;
using EstadisticasEscuelaFrontEnd.Database;

namespace EstadisticasEscuelaFrontEnd
{
    public partial class Escritorio : Form
    {
        public Escritorio()
        {
            InitializeComponent();

            FormLogin login = new FormLogin();
            
            login.ShowDialog(this);

            Objeto.ConectionString("localhost", "3306", "mydb", "root", "telesca1234");
        }

        private void adsaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void adasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumnoNuevo unfrmAlumnoNuevo=new frmAlumnoNuevo();
            unfrmAlumnoNuevo.ShowDialog(this);
        }

        private void nUEVOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario unfrmUsuario = new frmUsuario();
            unfrmUsuario.ShowDialog(this);
        }

        private void dasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCurso unfrmCurso= new frmCurso();
            unfrmCurso.ShowDialog(this);
        }

        private void dasdasdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlumnoBuscar buscarAlumno = new AlumnoBuscar();
            buscarAlumno.ShowDialog(this);
        }

        private void adasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BuscarCurso buscarCurso = new BuscarCurso();
            buscarCurso.ShowDialog(this);
        }

        private void bUSCARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmrBuscarUsuario buscarUsuario = new fmrBuscarUsuario();
            buscarUsuario.ShowDialog(this);
        }

       
    }
}
