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
            // Create an instance of Form2 located in the Forms folder
            Ordenes.OrdenesForm formOrdenes = new Ordenes.OrdenesForm();
            // Show Form2
       
            formOrdenes.Show();
            this.Hide();
        }
    }
}
