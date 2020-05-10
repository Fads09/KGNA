using System.Collections.ObjectModel;
using System.ComponentModel;

namespace KGNA
{
    public class CarouselPageModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<PageModel> _pages;

        private string _pageTitle;
        public CarouselPageModel()
        {
            _pageTitle = "CarouselViewChallege";
            _pages = new ObservableCollection<PageModel>();
            _pages.Add(new PageModel { Title = "Welcome to KGNA", Description= "Welcome to the KGNA app built with the help of volunteers living in North America!" });
            _pages.Add(new PageModel { Title = "Join The Fun", Description= "Use this app to stay informed with Notifications, get Directions, and view a Live Feed of KGNA on social media" });


        }

        public ObservableCollection<PageModel> Pages
        {
            get
            {
                return _pages;
            }
            set
            {
                if (_pages != value)
                {
                    _pages = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Pages"));
                }
            }
        }


        private void OnPropertyChanged(PropertyChangedEventArgs eventArgs)
        {
            PropertyChanged?.Invoke(this, eventArgs);
        }
    }

}
