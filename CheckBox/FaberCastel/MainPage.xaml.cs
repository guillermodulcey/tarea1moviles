using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using FaberCastel.Resources;
using System.Windows.Media;

namespace FaberCastel
{
    public partial class MainPage : PhoneApplicationPage
    {
        Color color_rectangulo = new Color();
        byte rgb_rojo = 0;
        byte rgb_verde = 0;
        byte rgb_azul = 0;

        bool red = false;
        bool yellow = false;
        bool blue = false;

        // Constructor
        public MainPage()
        {
            InitializeComponent();
            color_rectangulo = Color.FromArgb(255, rgb_rojo, rgb_verde, rgb_azul);
            rectangulo.Fill = new SolidColorBrush(color_rectangulo);
            // Código de ejemplo para traducir ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void rojo_Checked(object sender, RoutedEventArgs e)
        {
            //rojo:
            rgb_rojo = 255;
            //rojo + amarillo = naranja:
            if (yellow && !blue) {
                rgb_rojo = 230;
                rgb_verde = 95;
                rgb_azul = 0;
            }
            //rojo + azul = morado:
            if (!yellow && blue) {
                rgb_rojo = 255;
                rgb_azul = 255;
                rgb_verde = 0;
            }
            //rojo + amarillo + azul = blanco
            if (yellow && blue) {
                rgb_rojo = 255;
                rgb_verde = 255;
                rgb_azul = 255;
            }
            red = true;
            color_rectangulo = Color.FromArgb(255, rgb_rojo, rgb_verde, rgb_azul);
            rectangulo.Fill = new SolidColorBrush(color_rectangulo);
        }

        private void verde_Checked(object sender, RoutedEventArgs e)
        {
            //amarillo
            rgb_rojo = 255;
            rgb_verde = 255;
            //amarillo + rojo = naranja:
            if (red && !blue) {
                rgb_rojo = 230;
                rgb_verde = 95;
                rgb_azul = 0;
            }
            //amarillo + azul = verde:
            if (!red && blue) {
                rgb_rojo = 0;
                rgb_verde = 255;
                rgb_azul = 0;
            }
            //amarillo + rojo + azul = blanco:
            if (red && blue) {
                rgb_rojo = 255;
                rgb_verde = 255;
                rgb_azul = 255;
            }
            yellow = true;
            color_rectangulo = Color.FromArgb(255, rgb_rojo, rgb_verde, rgb_azul);
            rectangulo.Fill = new SolidColorBrush(color_rectangulo);
        }

        private void azul_Checked(object sender, RoutedEventArgs e)
        {
            //azul
            rgb_azul = 255;
            //azul + rojo = morado:
            if (red && !yellow) {
                rgb_rojo = 255;
                rgb_azul = 255;
                rgb_verde = 0;
            }
            //azul + amarillo = verde:
            if (!red && yellow) {
                rgb_rojo = 0;
                rgb_verde = 255;
                rgb_azul = 0;
            }
            //azul + rojo + amarillo = blanco:
            if (red && yellow) {
                rgb_rojo = 255;
                rgb_verde = 255;
                rgb_azul = 255;
            }
            blue = true;
            color_rectangulo = Color.FromArgb(255, rgb_rojo, rgb_verde, rgb_azul);
            rectangulo.Fill = new SolidColorBrush(color_rectangulo);
        }

        private void rojo_Unchecked(object sender, RoutedEventArgs e)
        {
            // - rojo:
            rgb_rojo = 0;
            //amarillo + azul = verde:
            if (yellow && blue) {
                rgb_rojo = 0;
                rgb_verde = 255;
                rgb_azul = 0;
            }
            //amarillo
            if (yellow && !blue) {
                rgb_rojo = 255;
                rgb_verde = 255;
            }
            red = false;
            color_rectangulo = Color.FromArgb(255, rgb_rojo, rgb_verde, rgb_azul);
            rectangulo.Fill = new SolidColorBrush(color_rectangulo);
        }

        private void verde_Unchecked(object sender, RoutedEventArgs e)
        {
            // - amarillo
            rgb_rojo = 0;
            rgb_verde = 0;
            //rojo + azul = morado:
            if (red && blue) {
                rgb_rojo = 255;
                rgb_azul = 255;
                rgb_verde = 0;
            }
            //rojo
            if (red && !blue) {
                rgb_rojo = 255;
            }
            yellow = false;
            color_rectangulo = Color.FromArgb(255, rgb_rojo, rgb_verde, rgb_azul);
            rectangulo.Fill = new SolidColorBrush(color_rectangulo);
        }

        private void azul_Unchecked(object sender, RoutedEventArgs e)
        {
            // - azul
            rgb_azul = 0;
            //
            if (yellow && red) {
                rgb_rojo = 230;
                rgb_verde = 95;
                rgb_azul = 0;
            }
            if (yellow && !red) {
                rgb_rojo = 255;
                rgb_verde = 255;
            }
            blue = false;
            color_rectangulo = Color.FromArgb(255, rgb_rojo, rgb_verde, rgb_azul);
            rectangulo.Fill = new SolidColorBrush(color_rectangulo);
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