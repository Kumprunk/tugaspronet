namespace Aplikasihotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void txtJenisroom_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (txtJenisroom.Text)
            {
                case "VIP":
                    txtPriceroom.Text = 750000.ToString();
                    break;
                case "KELAS I":
                    txtPriceroom.Text = 500000.ToString();
                    break;
                case "KELAS II":
                    txtPriceroom.Text = 300000.ToString();
                    break;
                case "KELAS III":
                    txtPriceroom.Text = 150000.ToString();
                    break;
            }
        }

        private void txtLamainap_KeyPress(object sender, EventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return)
            {

            }
        }
    }
}