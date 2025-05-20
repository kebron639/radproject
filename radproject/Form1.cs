using System.Data;
using System.Windows.Forms;
using radproject.UserControls;
namespace radproject
{
    public partial class Form1 : Form
    {
        DataTable table = new DataTable("table");

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            table.Columns.Add("Product Id", Type.GetType("system.Int32"));
            table.Columns.Add("Product Name", Type.GetType("system.String"));
            table.Columns.Add("Product Image", Type.GetType("system.Image"));
            table.Columns.Add("Catagory", Type.GetType("system.String"));
            table.Columns.Add("Price", Type.GetType("system.Double"));
            table.Columns.Add("Quantity", Type.GetType("system.Int32"));
            table.Columns.Add("Status", Type.GetType("system.String"));
            table.Columns.Add("Action", Type.GetType("system.Button"));
            table.Columns.Add("Edit", Type.GetType("system.Button"));
            table.Columns.Add("Remove", Type.GetType("system.Button"));
            dataGridView.DataSource = table;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabAddproduct_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
