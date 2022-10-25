namespace ConverstionAgeToDays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_age_Click(object sender, EventArgs e)
        {
            var age = Convert.ToInt32(txt_age.Text);
            var days = age * 365;
            txt_days.Text = days.ToString("#,##0 Days");

        }

        private void btn_days_Click(object sender, EventArgs e)
        {
            var days = Convert.ToInt32(txt_days.Text);
            var age = days / 365;
            txt_age.Text = age.ToString("#,##0 Yr Old");

        }
    }
}