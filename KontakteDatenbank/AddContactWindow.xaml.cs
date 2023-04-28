using KontakteDatenbank.Models;
using KontakteDatenbank.ViewModels;
using MahApps.Metro.Controls;
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
using System.Windows.Shapes;


namespace KontakteDatenbank
{
    /// <summary>
    /// Interaktionslogik für AddContactWindow.xaml
    /// </summary>
    public partial class AddContactWindow : MetroWindow
    {
        private AddContactWindowViewModel viewModel;

        public AddContactWindow()
        {
            viewModel = new AddContactWindowViewModel();

            InitializeComponent();

            DataContext = viewModel;
        }

        private void Cmd_Save_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.DialogResult = true;
            AddedContact = viewModel.SelectedContact;
        }

        private void Cmd_Save_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        public Contact AddedContact { get; set; }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void Cmd_Close_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }
    }
}
