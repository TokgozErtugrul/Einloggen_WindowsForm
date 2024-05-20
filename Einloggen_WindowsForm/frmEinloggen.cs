
using System.Data.SqlClient;


namespace Einloggen_WindowsForm
{
    public partial class frmEinloggen : Form


    {
        //Sql Connection
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-D1VIK1G\\SQLEXPRESS;Initial Catalog=Test02;Integrated Security=TRUE");


        public frmEinloggen()
        {
            InitializeComponent();
        }

        private void bttn_X_Click(object sender, EventArgs e)
        {

            // X

            Application.Exit();


        }

        private void frmEinloggen_Load(object sender, EventArgs e)
        {

        }



        //Mouse bewegen 


        bool move;
        int mouse_x;
        int mouse_y;


        private void frmEinloggen_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void frmEinloggen_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void frmEinloggen_MouseMove(object sender, MouseEventArgs e)
        {


            if (move)
            {

                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);

            }

        }



        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Benutzername")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;

            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                textBox1.Text = "Benutzername";
                textBox1.ForeColor = Color.Gray;

            }
        }



        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Passwort")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;

                //Passwort als * ersetzen
                textBox2.PasswordChar = '*';

            }
        }


        char? none = null;

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Passwort";
                textBox2.ForeColor = Color.Gray;
                textBox2.PasswordChar = Convert.ToChar(none);

            }
        }




        bool isThere;
        private void button1_Click(object sender, EventArgs e)
        {

            string benutzername = textBox1.Text;
            string pass = textBox2.Text;

            connection.Open();
            SqlCommand command = new SqlCommand("Select *from Einloggen", connection);


            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if ((benutzername == reader["benutzername"].ToString().TrimEnd()) && (pass == reader["passwort"].ToString().TrimEnd()))
                {

                    isThere = true;
                    break;
                }
                else
                {
                    isThere = false;
                }
            }

            connection.Close();
            if (isThere)
            {
                MessageBox.Show("Angemeldet", "Programm");

            }
            else
            {
                MessageBox.Show("nicht angemeldet", "Programm");
            }



        }


    }
}
