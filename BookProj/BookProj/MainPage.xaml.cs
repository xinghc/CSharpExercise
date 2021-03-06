﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BookProj
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btOk_Click(object sender, RoutedEventArgs e)
        {
            TextBlock tbkRes = new TextBlock();
            tbkRes.Width = 350;
            tbkRes.Height = 80;

            SolidColorBrush scb = new SolidColorBrush();
            scb.Color = Colors.Red;

            tbkRes.Foreground = scb;
            tbkRes.FontSize = 20;
            tbkRes.Text = "Username = " + tbName.Text + "\n" +
                          "Password = " + pbPassWd.Password;
            tbkRes.Margin = new Thickness(0, 170, 5, 0);
            ContentPanel.Children.Add(tbkRes);
        }
    }
}
