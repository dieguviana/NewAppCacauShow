﻿using System;
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

namespace NewAppCacauShow.Telas
{
    /// <summary>
    /// Lógica interna para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            WindowState = WindowState.Maximized;
            WindowStyle = WindowStyle.SingleBorderWindow;
            InitializeComponent();
        }

        private void Vendas_Click(object sender, RoutedEventArgs e)
        {
            VendaListar vendas = new VendaListar();
            vendas.Show();
            this.Close();
        }

        private void Estoque_Click(object sender, RoutedEventArgs e)
        {
            CompraListar compras = new CompraListar();
            compras.Show();
            this.Close();
        }

        private void Produtos_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Clientes_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Funcionarios_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Fornecedores_Click(object sender, RoutedEventArgs e)
        {
            FornecedorListar fornecedor = new FornecedorListar();
            fornecedor.Show();
            this.Close();
        }
    }
}
