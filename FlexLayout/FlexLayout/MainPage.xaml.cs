using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FlexLayout
{
    public partial class MainPage : ContentPage
    {
        void ListInitializing()
        {
            List<City> images = new List<City>();
            images.Add(new City { id = "HCM", image = "hcm.JPG", name = "Ha Noi" });
            images.Add(new City { id = "HN", image = "hn.JPG", name = "Ho Chi Minh" });
            images.Add(new City { id = "DN", image = "dn.JPG", name = "Da Nang" });
            listImage.ItemsSource = images;
        }
     
        public MainPage()
        {
            InitializeComponent();
            ListInitializing();
        }

        private void btnlistanimal_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListAnimal());
        }

        private void listImage_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(listImage.SelectedItem != null)
            {
                City selected = (City)listImage.SelectedItem;
                Navigation.PushAsync(new HotelPage(selectedCity: selected));
            }
          
        }
    }
}
