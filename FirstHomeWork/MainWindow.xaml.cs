﻿using System.Net;
using System.Windows;

namespace FirstHomeWork
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void EnterButtonClick(object sender, RoutedEventArgs e)
        {
            if (userText.Text == null)
            {
                MessageBox.Show("Заполните текстовое поле!");
                return;
            }

            var ipHostEntry = Dns.GetHostEntry(userText.Text);

            ipAddressList.Items.Clear();

            foreach (var item in ipHostEntry.AddressList)
            {
                ipAddressList.Items.Add(item);
            }

            hostNameText.Text = ipHostEntry.HostName;
        }
    }
}
