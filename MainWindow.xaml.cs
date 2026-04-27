using System.Windows;
using System.Collections.ObjectModel;

namespace ContactManager
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Contact> Contacts { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Contacts = new ObservableCollection<Contact>();
            DataContext = this;
        }

        private void MenuItem_Exit(object sender, RoutedEventArgs e) => Close();

        private void MenuItem_About(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Contact Manager v1.0", "About", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void MenuItem_ClearContacts(object sender, RoutedEventArgs e) => Contacts.Clear();

        private void MenuItem_AddContact(object sender, RoutedEventArgs e)
        {
            this.Opacity = 0.5;
            AddContactWindow addWin = new AddContactWindow();
            if (addWin.ShowDialog() == true)
            {
                Contacts.Add(addWin.NewContact);
            }
            this.Opacity = 1.0;
        }
    }
}