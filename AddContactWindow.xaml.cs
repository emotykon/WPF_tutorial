using System.Windows;

namespace ContactManager
{
    public partial class AddContactWindow : Window
    {
        public Contact NewContact { get; set; }

        public AddContactWindow()
        {
            InitializeComponent();
            NewContact = new Contact();
            DataContext = NewContact;
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}