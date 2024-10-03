using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginCAI.Menu.Remitos
{
    public partial class RemitosForm : Form
    {
        public RemitosForm()
        {
            InitializeComponent();
        }
        private void RemitosForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void RemitosForm_Load(object sender, EventArgs e)
        {

        }
    }
}
