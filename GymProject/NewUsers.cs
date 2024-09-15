using GymProject.Entities;

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
            txtIdNumber.KeyPress += new KeyPressEventHandler(txtIdNumber_KeyPress);

        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            User user = new User();
            user = new User
            {
                NumberId = txtIdNumber.Text,
                Name = txtName.Text,
                LastName = txtLastName.Text,
                Email = txtEmail.Text,
                phoneNumber = txtPhoneNumber.Text,
                entryDate = DateTime.Now.Date
            };

            BaseDatos.GymDB.InsertClient(user);
            MessageBox.Show("Cliente guardado exitosamente");

        }

        private void txtIdNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permite números, letras y el carácter de control (como backspace)
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela la tecla si no es válida
            }
        }


    }
}
