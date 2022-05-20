namespace WinFormsVadim
{
    public partial class Form1 : Form
    {
        DateTime myDate;
        int check = 0;
        public Form1()
        {
            InitializeComponent();
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.ShowUpDown = true;
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime localDate = DateTime.Now;
            myDate = dateTimePicker1.Value.Date + dateTimePicker2.Value.TimeOfDay;
            if (localDate.CompareTo(myDate) > 0)
                MessageBox.Show("Вы установили дату которая уже прошла", "Ошибка");
            else
                check = 1;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime localDate = DateTime.Now;
            label1.Text = localDate.ToString();
            if (localDate.CompareTo(myDate) > 0 && check != 0)
            {
                check = 0;
                mes();
            }
        }
        public void mes()
        {
            string txt = "";
            for (int i = 0; i < listBox1.Items.Count; i++)
                txt = txt + listBox1.Items[i].ToString() + "\n";
            txt = txt + richTextBox1.Text;
            MessageBox.Show(txt, "Напоминание");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}