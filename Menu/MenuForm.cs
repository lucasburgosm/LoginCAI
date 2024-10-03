namespace LoginCAI.Menu
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
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
