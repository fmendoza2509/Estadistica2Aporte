using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estadistica2Aporte
{
    public partial class Estadística : Form
    {
        public Estadística()
        {
            InitializeComponent();
        }

        private void Estadística_Load(object sender, EventArgs e)
        {

        }

        private void iBtnCerrar_Click(object sender, EventArgs e){
            Application.Exit();
        }
    }
}
