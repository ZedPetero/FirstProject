using ClassLibrary1;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Class1> classList = new List<Class1> {
                new Class1 { Id = 2, Name = "Juan Dela Cruz" },
                new Class1 { Id = 3, Name = "Maria Clara" },
                new Class1 { Id = 4, Name = "Jose Rizal"},
                new Class1 { Id = 5, Name = "Andres Bonifacio"},
                new Class1 { Id = 6, Name = "Emilio Aguinaldo"}
        };
        public Form1()
        {
            InitializeComponent();
            loadClassList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var class1 = new Class1();
            MessageBox.Show(class1.Name);
            var student = new Student();
            student.Gender = Gender.Male;
        }

        private void loadClassList()
        {
            dataGridView1.DataSource = classList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var class1 = new Class1();
            textBox1.Text = class1.Id.ToString();
            textBox2.Text = class1.Name;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
