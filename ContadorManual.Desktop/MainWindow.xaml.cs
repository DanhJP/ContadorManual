using System.Windows;
namespace ContadorManual.Desktop.Model;


namespace ContadorManual.Desktop
{
   
    public partial class MainWindow : Window
    {
        private int _Conteo;
        private Contador contador;

        public MainWindow()
        {
            InitializeComponent();
                
        }

        private void ReiniciarButton_Click(object sender, RoutedEventArgs e)
        {
            _Conteo = 0;
            ConteoLabel.Content = _Conteo;
        }

        private void ContarButton_Click(object sender, RoutedEventArgs e)
        {
            _Conteo++;
            ConteoLabel.Content = _Conteo;
        }

        private void SalirButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
