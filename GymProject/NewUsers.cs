namespace GymProject
{
    public partial class NewUsers : Form
    {
        public NewUsers()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            string nombre = txtName.Text;
            string apellido = txtLastName.Text;
            int edad;

            if (int.TryParse(textBox3.Text, out edad))
            {
                GymProject.BaseDatos.GymDB.InsertClient(nombre, apellido, edad);
                MessageBox.Show("Cliente guardado exitosamente");
            }
            else
            {
                MessageBox.Show("Por favor ingrese edad valida");
            }
        }
    }
}
