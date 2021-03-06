﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EstadisticasEscuelaFrontEnd;
using EstadisticasEscuelaFrontEnd.Database;
using EstadisticasEscuelaFrontEnd.Dominio;

namespace EstadisticasEscuelaFrontEnd.Alumnos
{
    public partial class frmAlumnoNuevo : Form
    {
        public frmAlumnoNuevo()
        {
            InitializeComponent();           
        }

        private void btnAlumnoNuevo_Click(object sender, EventArgs e)
        {
            bool error = true;

            if (!checkData(txtAlumnoNuevoNombre, lblAlumnoNuevoNombreError)) error = false;

            if (!checkData(txtAlumnoNuevoApellido, lblAlumnoNuevoApellidoError)) error = false;

            if (!checkData(txtAlumnoNuevoDNI, lblAlumnoNuevoDniError)) error = false;

            if (!checkData(txtAlumnoNuevoLegajo, lblAlumnoNuevoLegajoError)) error = false;

            //checkData(cmbAlumnoNuevoCurso, cmbAlumnoNuevoDivision, lblAlumnoNuevoCursoError);

            //checkData(cmbAlumnoNuevoEspecialidad, lblAlumnoNuevoEspecialidadError);

            if (error)
            {
                Alumno.Add(new Alumno(txtAlumnoNuevoNombre.Text, txtAlumnoNuevoApellido.Text, txtAlumnoNuevoLegajo.Text, txtAlumnoNuevoDNI.Text));

                lblMessage.Text = "ALUMNO GUARDADO CON EXITO";
            }            
        }
        
        private bool checkData(ComboBox comboA, ComboBox comboB, Label label)
        {
            label.Text = "";

            if (comboA.SelectedIndex < 0 && comboB.SelectedIndex < 0)
            {
                label.Text = "Seleccione Curso y División";
            }
            else
            {
                if (comboA.SelectedIndex < 0)
                {
                    label.Text = "Seleccione Curso";

                    return false;
                }

                if (comboB.SelectedIndex < 0)
                {
                    label.Text += "Seleccione División";

                    return false;
                }
            }

            return true;
        }

        private bool checkData(ComboBox combo, Label label)
        {
            label.Text = "";

            if (combo.SelectedIndex < 0)
            {
                label.Text = "Seleccione Especialidad";

                return false;
            }

            return true;
        }

        private bool checkData(TextBox textBox, Label label)
        {
            label.Text = "";

            if (!textBox.Text.Equals(""))
            {
                if (textBox.Name.Equals("txtAlumnoNuevoNombre") || textBox.Name.Equals("txtAlumnoNuevoApellido"))
                {
                    if (!Util.todasLetras(textBox.Text))
                    {
                        label.Text = "Valores Incorrectos";

                        return false;
                    }
                }

                if (textBox.Name.Equals("txtAlumnoNuevoDNI") || textBox.Name.Equals("txtAlumnoNuevoLegajo"))
                {
                    if (!Util.todasNumeros(textBox.Text))
                    {
                        label.Text = "Valores Incorrectos";

                        return false;
                    }
                }
            }
            else
            {
                label.Text = "Vacio";

                return false;
            }

            return true;
        }

        private void btnAlumnoNuevoLimpiar_Click(object sender, EventArgs e)
        {
            txtAlumnoNuevoNombre.Clear();
            
            txtAlumnoNuevoApellido.Clear();

            txtAlumnoNuevoLegajo.Clear();
            
            txtAlumnoNuevoDNI.Clear();

            lblMessage.Text = "";

            lblAlumnoNuevoNombreError.Text = "";

            lblAlumnoNuevoApellidoError.Text = "";

            lblAlumnoNuevoLegajoError.Text = "";

            lblAlumnoNuevoDniError.Text = "";

        }

        private void btnAlumnoNuevoCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }      
    }
}
