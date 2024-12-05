namespace INF_Übungsbeispiel_Tankstellenrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtBenzinPreis.Focus(); // Fokus auf die erste Textbox setzen
        }

        private void btnBerechnen_Click(object sender, EventArgs e)
        {
            try
            {
                // Eingabewerte aus den TextBoxen lesen
                decimal benzinPreis = Convert.ToDecimal(txtBenzinPreis.Text);
                decimal getankteMenge = Convert.ToDecimal(txtGetankteMenge.Text);
                decimal kilometerLetzterTank = Convert.ToDecimal(txtKilometerLetzterTank.Text);
                decimal kilometerAktuell = Convert.ToDecimal(txtKilometerAktuell.Text);
                decimal tankVolumen = Convert.ToDecimal(txtTankVolumen.Text);

                // Berechnungen
                decimal gefahreneKilometer = kilometerAktuell - kilometerLetzterTank;
                decimal durchschnittsverbrauch = (getankteMenge / gefahreneKilometer) * 100; // L/100km
                decimal zuErwartendeReichweite = (tankVolumen / durchschnittsverbrauch) * 100; // km
                decimal kilometerstandFuerTankempfehlung = kilometerAktuell + ((15 / durchschnittsverbrauch) * 100); // km

                // Ergebnisse in Labels anzeigen
                lblGefahreneKilometer.Text = $"Gefahrene Kilometer: {gefahreneKilometer:F2} km";
                lblDurchschnittsverbrauch.Text = $"Durchschnittsverbrauch: {durchschnittsverbrauch:F2} l/100km";
                lblReichweite.Text = $"Erwartete Reichweite: {zuErwartendeReichweite:F2} km";
                lblTankempfehlung.Text = $"Tankempfehlung bei: {kilometerstandFuerTankempfehlung:F2} km";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler bei der Berechnung: {ex.Message}");
            }
        }


    }
}
