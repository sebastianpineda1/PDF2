using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFClase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void abrir_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(this);
            PDF1.src = openFileDialog1.FileName;
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hasta luego");
            this.Close();
        }
    }
}
