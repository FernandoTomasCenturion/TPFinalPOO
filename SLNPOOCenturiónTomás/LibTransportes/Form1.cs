using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibTransportes;

namespace LibTransportes
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCamion_Click(object sender, EventArgs e)
        {
            Camion camion = new Camion(11,"abc123");
            MessageBox.Show(camion.Kilometros.ToString());
            MessageBox.Show(camion.Patente);
        }

        private void buttonRemolque_Click(object sender, EventArgs e)
        {
            Remolque remolque = new Remolque("abc124", 4);
            MessageBox.Show(remolque.Patente);
            MessageBox.Show(remolque.CantRuedas.ToString());
        }
    }

    public class Program
        {
            static async Task Main()
            { }
        }

        
}
