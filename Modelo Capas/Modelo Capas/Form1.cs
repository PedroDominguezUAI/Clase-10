using BLL;
using Entity;

namespace Modelo_Capas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AlquilerBusiness aB = new AlquilerBusiness();
            TipoBicicletaBusiness tipoBicicletaBusiness = new TipoBicicletaBusiness();
            dataGridView1.DataSource = aB.GetAllAlquileres();
            comboBox1.ValueMember = "ID_Tipo1";
            comboBox1.DisplayMember = "Descripcion1";
            comboBox1.DataSource = tipoBicicletaBusiness.GetAllTipoBicicletas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlquilerBusiness alquilerBusiness = new AlquilerBusiness();
            Alquiler alquiler = new Alquiler();
            alquiler.Tipo_Bicicleta1 = Convert.ToInt32(comboBox1.SelectedValue);
            alquiler.DNI1 = Convert.ToInt32(textBox1.Text);
            alquiler.Importe1 = Convert.ToInt32(textBox2.Text);
            alquiler.Fecha_Registro1 = DateTime.Now;
            alquiler.Fecha_Vencimiento1 = dateTimePicker1.Value;
            alquilerBusiness.InsertarAlquiler(alquiler);
            dataGridView1.DataSource = alquilerBusiness.GetAllAlquileres();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Alquiler alquiler = new Alquiler();
            AlquilerBusiness alquilerBusiness = new AlquilerBusiness();
            alquiler.ID_Alquiler1 = Convert.ToInt32(textBox5.Text);
            alquiler.Fecha_Vencimiento1 = dateTimePicker2.Value;
            alquiler.Importe1 = Convert.ToInt32(textBox3.Text);
            alquilerBusiness.ModificarAlquiler(alquiler);
            dataGridView1.DataSource = alquilerBusiness.GetAllAlquileres();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Alquiler alquiler = new Alquiler();
            AlquilerBusiness alquilerBusiness = new AlquilerBusiness();
            alquiler.ID_Alquiler1 = Convert.ToInt32(textBox4.Text);
            alquilerBusiness.EliminarAlquiler(alquiler);
            dataGridView1.DataSource = alquilerBusiness.GetAllAlquileres();

        }
    }
}
