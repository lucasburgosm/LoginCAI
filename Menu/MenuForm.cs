using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginCAI.Menu
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void ordenesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Ordenes.OrdenesForm formOrdenes = new Ordenes.OrdenesForm();
                formOrdenes.ShowDialog();
                this.Hide(); // Hide current form or consider closing it
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while opening the Orders form: " + ex.Message);
            }
        }

        private void RemitosBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Remitos.RemitosForm formRemitos = new Remitos.RemitosForm();
                formRemitos.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while opening the Remitos form: " + ex.Message);
            }
        }
    }
}
