
namespace _4M05RadioCheckLody
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnOblicz(object sender, EventArgs e) 
        {
            double cena = 0;
            int ileGalek = 0;
            if(int.TryParse(entCount.Text, out ileGalek)) 
                cena = ileGalek * 7.50;
            else
            {
                lblCena.Text = "Podaj liczbę gałek";
                return;
            }
            if(ileGalek <= 0)
            {
                lblCena.Text = "Podaj liczbę gałek";
                return;
            }
            if (rbtDunski.IsChecked)
                cena += 3;
            if (chkPolewa.IsChecked)
                cena += 1;
            if (chkPosypka.IsChecked)
                cena += 1;
            lblCena.Text = $"Cena: {cena.ToString("#.00")} zł";
        }
    }

}
