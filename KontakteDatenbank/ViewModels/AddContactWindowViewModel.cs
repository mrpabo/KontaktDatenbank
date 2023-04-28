using KontakteDatenbank.Models;

namespace KontakteDatenbank.ViewModels
{
    public class AddContactWindowViewModel : ViewModelBase
    {
        public AddContactWindowViewModel()
        {
            SelectedContact = new Contact()
            {
                FirstName = "Neuer Kontakt",
                ImageFileName = @"D:\Benutzerdateien\Desktop\person.png"
            };

            SelectedContact.LoadImage();
        }

        public Contact SelectedContact { get; set; } = new Contact();
    }
}
