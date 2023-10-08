using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace student_exam_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double exam1, exam2, proje, average;
            string durum;
            exam1 = Convert.ToDouble(textBox1.Text);
            exam2 = Convert.ToDouble(textBox2.Text);
            proje = Convert.ToDouble(textBox3.Text);

            average = (exam1 + exam2 + proje) / 3;


            if (average >= 50)
            {
                durum = "Geçti";

            }
            else
            {
                durum = "Kaldý";

            }
            textBox4.Text = average.ToString("0.00") + " / " + durum;



        }
    }
}