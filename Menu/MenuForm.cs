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
            try
            {
                Remitos.RemitosForm formRemitos = new Remitos.RemitosForm();
                formRemitos.Show();
                this.Hide(); // Hide current form or consider closing it
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while opening the Remitos form: " + ex.Message);
            }
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
