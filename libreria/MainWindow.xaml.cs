using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace libreria
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        static int numeroLibri = 0;
        List<libro> listaLibri = new List<libro>();
        private void btnAggiungiLibro_Click(object sender, RoutedEventArgs e)
        {
            int valoreAnno= int.Parse(txtAnno.Text);
            int valoreNumeroPagine=int.Parse(txtNumeroPagine.Text);
            libro LibroDaAggiungere = new libro(txtAutore.Text, txtTitolo.Text, valoreAnno, txtEditor.Text, valoreNumeroPagine);
            numeroLibri++;
            lblNumeroLibri.Content = "libri presenti: " + numeroLibri;
            
            listaLibri.Add(LibroDaAggiungere);

        }
//commento aggiunto da gitHub
        private void btnCercaLibro_Click(object sender, RoutedEventArgs e)
        {
            for(int i = 0; i < listaLibri.Count; i++)
            {
                if (listaLibri[i].titolo == txtLibroDaCercare.Text)
                {
                    lblLibroTrovato.Content = listaLibri[i].titolo;
                }
            }
        }

        private void btnCercaAutore_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < listaLibri.Count; i++)
            {
                if (listaLibri[i].autore == txtAutore.Text)
                {
                    lblLibriAutore.Items.Add(listaLibri[i].autore);
                }
            }
        }
    }
}
