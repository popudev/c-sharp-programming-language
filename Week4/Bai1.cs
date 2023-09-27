using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Week4
{
    public partial class Bai1 : Form
    {

        public Bai1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            if (int.TryParse(soA.Text, out a) && int.TryParse(soB.Text, out b))
            {

                int gcd = GCD(a, b);
                ucln.Text = gcd.ToString();
                int lcm = LCM(a, b);
                bcnn.Text = lcm.ToString();
            }
            else
            {
                MessageBox.Show("Số A và Số B phải là kiểu sô nguyên!!!", "Thông báo");
            }
        }

        private void Tittle_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^\d+$"; // Dấu ^ và $ để kiểm tra toàn bộ chuỗi.
            if (Regex.IsMatch(soB.Text, pattern))
            {
                // Chuỗi là số nguyên.
            }
            else
            {
                errA = new ErrorProvider();
                errA.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errA.SetError(soB, "error");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            string pattern = @"^\d+$"; // Dấu ^ và $ để kiểm tra toàn bộ chuỗi.

            if (Regex.IsMatch(soA.Text, pattern))
            {
                // Chuỗi là số nguyên.
                errA = new ErrorProvider();
            }
            else
            {
                errB = new ErrorProvider();
                errB.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errB.SetError(soA, "error");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private int LCM(int a, int b)
        {
            return a * b / GCD(a, b);
        }

        private void buttonTT_Click(object sender, EventArgs e)
        {
            soA.Text = "";
            soB.Text = "";
            ucln.Text = "";
            bcnn.Text = "";
        }

        private void buttonT_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình", "Cảnh báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }


        }
    }
}