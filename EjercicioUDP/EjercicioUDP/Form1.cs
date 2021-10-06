using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioUDP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cliente.Alerta += Cliente_Alerta;
            cliente.Advert += Cliente_Advert;
            cliente.Normal += Cliente_Normal;
        }

        private void Cliente_Normal(string obj)
        {
            if (lblTipo != null)
            {
                lblTipo.Text = "";
                label2.Text = "";
            }
            lblTipo.Text = "Nuevo Mensaje";
            label2.Text = obj;
            btnLeido.Enabled = true;
            //Normal.ShowBalloonTip(200, "Nuevo mensaje", "Servidor mandó un nuevo mensaje", ToolTipIcon.Info);
        }

        private void Cliente_Advert(string obj)
        {
            if (lblTipo != null)
            {
                lblTipo.Text = "";
                label2.Text = "";
            }
            lblTipo.Text = "Mensaje de Advertencia";
            label2.Text = obj;
            btnLeido.Enabled = true;
            //Advertencia.ShowBalloonTip(200, "¡Advertencia!", "Servidor mandó mensaje de advertencia", ToolTipIcon.Warning);

        }

        private void Cliente_Alerta(string obj)
        {
            if (lblTipo != null)
            {
                lblTipo.Text = "";
                label2.Text = "";
            }
            lblTipo.Text = "Mensaje de alerta";
            label2.Text = obj;
            btnLeido.Enabled = true;
            //Alerta.ShowBalloonTip(200, "¡Alerta!", "Servidor mandó mensaje de alerta", ToolTipIcon.Warning);
        }

        ClienteUDP cliente = new ClienteUDP();
        private void Form1_Load(object sender, EventArgs e)
        {
            cliente.Iniciar();
            this.Hide();

        }

        private void aBRIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void cERRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLeido_Click(object sender, EventArgs e)
        {
            lblTipo.Text = "";
            label2.Text = "";
        }
    }
}
