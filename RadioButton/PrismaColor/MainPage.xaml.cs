using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PrismaColor.Resources;
using System.Windows.Media;

namespace PrismaColor
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            rectangulo.Fill = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
            // Código de ejemplo para traducir ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void rojo_Checked(object sender, RoutedEventArgs e)
        {
            Color rojo = new Color();
            rojo = Color.FromArgb(255,255,0,0);
            rectangulo.Fill = new SolidColorBrush(rojo); 
        }

        private void verde_Checked(object sender, RoutedEventArgs e)
        {
            Color verde = new Color();
            verde = Color.FromArgb(255, 255, 255, 0);
            rectangulo.Fill = new SolidColorBrush(verde);
        }

        private void azul_Checked(object sender, RoutedEventArgs e)
        {
            Color azul = new Color();
            azul = Color.FromArgb(255, 0, 0, 255);
            rectangulo.Fill = new SolidColorBrush(azul);
        }

        private void blanco_Unchecked(object sender, RoutedEventArgs e)
        {
            Color blanco = new Color();
            blanco = Color.FromArgb(255, 0, 0, 0);
            rectangulo.Fill = new SolidColorBrush(blanco);
        }

        // Código de ejemplo para compilar una ApplicationBar traducida
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Establecer ApplicationBar de la página en una nueva instancia de ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Crear un nuevo botón y establecer el valor de texto en la cadena traducida de AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Crear un nuevo elemento de menú con la cadena traducida de AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}