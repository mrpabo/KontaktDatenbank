using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace KontakteDatenbank.Models
{
    public class ModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}


// MVVM trennt die Logik der Benutzeroberfläche von der Geschäftslogik und Datenverwaltung und besteht aus drei Hauptkomponenten:
//-------------------------------------------------------------------------------------------------------------------------------
//
// Model: Es repräsentiert den Zustand und die Verwaltung der Daten. Dies können Klassen sein, die Datenbankabfragen ausführen,
//        Netzwerkanforderungen senden oder andere Datenverarbeitungsaufgaben durchführen.

//
// View: Es repräsentiert die Benutzeroberfläche, mit der der Benutzer interagieren kann. Die View ist verantwortlich für die Anzeige der Daten,
//       die vom ViewModel bereitgestellt werden, und für die Verarbeitung von Benutzerinteraktionen wie Klicks oder Tastatureingaben.

//
// ViewModel: Es fungiert als Vermittler zwischen View und Model und stellt die Daten für die View bereit, indem es auf
//            das Model zugreift und diese in eine für die View geeignete Form transformiert. Das ViewModel ist auch für die Verarbeitung von
//            Benutzeraktionen verantwortlich und aktualisiert die Modelldaten entsprechend.MVVM bietet mehrere Vorteile, darunter eine klare Trennung
//            von Verantwortlichkeiten, die Unterstützung von Testbarkeit, die Flexibilität zur Erstellung von mehreren Ansichten für dieselben Daten und
//            die Möglichkeit, die Anwendung einfacher zu warten und zu erweitern.
