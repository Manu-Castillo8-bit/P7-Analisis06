namespace P7_Analisis06
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
        // Toma el texto de ambos Entry y lo muestra en el Label
        string nombre = NombreEntry.Text;
        string apellido = ApellidoEntry.Text;
        NombreCompletoLabel.Text = $"¡Hola, {nombre} {apellido}!";

        }
    }
}
