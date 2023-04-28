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
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private MainWindowViewModel viewModel;

        public MainWindow()
        {
            viewModel = new MainWindowViewModel();

            InitializeComponent();

            DataContext = viewModel;
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            await viewModel.LoadProfilePicturesAsync();
        }

        private void Cmd_AddContact_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            AddContactWindow window = new AddContactWindow();
            window.ShowDialog();

            if(window.DialogResult == true)
            {
                viewModel.Contacts.Add(window.AddedContact);
            }
        }

        private void Cmd_AddContact_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void Cmd_DeleteContact_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            viewModel.DeleteContact(viewModel.SelectedContact);
        }

        private void Cmd_DeleteContact_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if(viewModel.SelectedContact != null)
            {
                e.CanExecute = true;
            }
        }

        private void Cmd_Close_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }
    }
}
