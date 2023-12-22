using lab15.Models;
using lab15.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace lab15.ViewModels
{
    public class AirbnbViewModel : INotifyPropertyChanged
    {
        private List<AirbnbListing> _listings;
        public List<AirbnbListing> Listings
        {
            get { return _listings; }
            set { _listings = value; OnPropertyChanged(); }
        }

        public Command LoadListingsCommand { get; set; }

        public AirbnbViewModel()
        {
            LoadListingsCommand = new Command(async () => await LoadListings());
            Listings = new List<AirbnbListing>();
        }

        async Task LoadListings()
        {
            var apiService = new AirbnbApiService();
            Listings = await apiService.GetListingsAsync("https://estefany-janyna.github.io/AirbnbTT-JSON/airbnbApi.json");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}