using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasEstudiantePOO
{
    public partial class Form1 : Form
    {
       
        List<cEstudiante> ListaEstudiantes = new List<cEstudiante>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarEstudiante_Click(object sender, EventArgs e)
        {
            cEstudiante Estudiante = new cEstudiante();
            Estudiante.nombre = txtNombre.Text;
            Estudiante.edad = int.Parse(txtEdad.Text);
            

            
            ListaEstudiantes.Add(Estudiante);
            listBoxInformacion.Items.Add( Estudiante.nombre + "  tiene "+ Estudiante.edad+ "años");

           

        
        }

        public int SortByNameAscending(cEstudiante name1, cEstudiante name2)
        {

            return name1.edad.CompareTo(name2.edad);
        }

        private void btnORDEN_Click(object sender, EventArgs e)
        {
            ListaEstudiantes.Sort(SortByNameAscending);
            foreach (cEstudiante es in ListaEstudiantes)
            {
                listBoxordenado.Items.Add(es.nombre + "  tiene " + es.edad + "años");
            }
        }
    }
}

