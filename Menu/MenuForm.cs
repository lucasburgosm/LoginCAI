using System.ComponentModel;

namespace LoginCAI.Menu
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }
        private void MenuForm_Load(object sender, EventArgs e)
        {

        }
        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            BackgroundWorker myBackgroundWorker = new BackgroundWorker();
            if (myBackgroundWorker.IsBusy)
            {
                myBackgroundWorker.CancelAsync();
                Application.Exit();
            }
            Application.Exit();
        }

        private void OrdenesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Ordenes.OrdenesForm formOrdenes = new Ordenes.OrdenesForm();
                formOrdenes.Show();
                this.Hide(); // Hide current form or consider closing it
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while opening the Orders form: " + ex.Message);
            }
        }


        private void RemitosBtn_Click(object sender, EventArgs e)
        {
            // Create an instance of Form2 located in the Forms folder
            Remitos.RemitosForm formRemitos = new Remitos.RemitosForm();
            // Show Form2

            formRemitos.Show();
            this.Hide();
        }
    }
}
