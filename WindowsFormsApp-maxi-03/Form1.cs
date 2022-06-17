using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_maxi_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elem = textNombre.Text;
            listElemento.Items.Add(elem);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboColor.Items.Add("ROJO");
            cboColor.Items.Add("VERDE");
            cboColor.Items.Add("NEGRO");
            cboColor.Items.Add("AZUL");

        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = textNombre.Text;
            DateTime fecha = fechaNacimiento.Value;
            string chocolate = checkBoxChocolate.Checked == true ? "le gusta el chocolate" : "odia el chocolate";
            string pais;
            if (rbtArgentina.Checked)
            {
                pais = "Argentina";

            }else if (rbtVenezuela.Checked) {
                pais = "Venezuela";
            }
            else if (rtbperu.Checked)
            {
                pais = "Peru";
            };
            string colorFavorito = cboColor.SelectedItem.ToString();
            
                
            
        }
    }
}
