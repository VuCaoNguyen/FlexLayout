using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FlexLayout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HotelPage : ContentPage
    {

        void HotelInitializing(City selectedCity)
        {
            List<Hotel> listHotels = new List<Hotel>();

            if (selectedCity.id == "HCM")
            {
                listHotels.Add(new Hotel { cityID = selectedCity.id, id = "1", description = "Tọa lạc trên đường Thủ Khoa Huân, Silverland Yen Hotel nằm cách Chợ Bến Thành chỉ 6 phút đi bộ. Khách sạn có bể sục nước ấm ngoài trời và tiện nghi phòng xông hơi khô/phòng xông hơi ướt.", image = "hcm1.jpg", name = "Silverland Yen HotelMở trong cửa sổ mới", phone = "123123123" });
                listHotels.Add(new Hotel { cityID = selectedCity.id, id = "2", description = "Tọa lạc tại Thành phố Hồ Chí Minh, Hera Hotel Airport cung cấp chỗ nghỉ 3 sao với ban công riêng. Khách sạn 3 sao này có dịch vụ trợ giúp đặc biệt và WiFi miễn phí.", image = "hcm2.jpg", name = "Hera Hotel Airport", phone = "123123123" });

            }
            if (selectedCity.id == "HN")
            {
                listHotels.Add(new Hotel { cityID = selectedCity.id, id = "3", description = "Hanoi Paradise hotel & Spa nằm trong Phố Cổ mang tính biểu tượng của thành phố Hà Nội.", image = "hn1.jpg", name = "Acoustic Hotel & Spa", phone = "123123123" });
                listHotels.Add(new Hotel { cityID = selectedCity.id, id = "4", description = "Tọa lạc tại thành phố Hà Nội, nằm trong bán kính 1,1 km từ Nhà Thờ Lớn, Acoustic Hotel & Spa có dịch vụ nhận phòng/trả phòng cấp tốc, phòng nghỉ không gây dị ứng, nhà hàng, WiFi miễn phí và trung tâm", image = "hn2.jpg", name = "Le Grand Hanoi Hotel ", phone = "123123123" });

            }
            if (selectedCity.id == "DN")
            {
                listHotels.Add(new Hotel { cityID = selectedCity.id, id = "5", description = "Tọa lạc tại thành phố Đà Nẵng, cách Bãi biển Mỹ Khê 200 m, Sea Corner Boutique Hotel & Apartment cung cấp chỗ nghỉ bên bờ biển với nhiều tiện nghi như nhà hàng, hồ bơi ngoài trời và trung tâm thể dục", image = "dn1.jpg", name = "Sea Corner Boutique Hotel & Apartment", phone = "123123123" });
                listHotels.Add(new Hotel { cityID = selectedCity.id, id = "6", description = "Tọa lạc tại thành phố Đà Nẵng, Seashore Hotel & Apartment có nhà hàng, hồ bơi ngoài trời, quầy bar và sảnh khách chung. Khách sạn này có các phòng gia đình và sân hiên tắm nắng.", image = "dn2.jpg", name = "Seashore Hotel & Apartment", phone = "123123123" });

            }
            listHotel.ItemsSource = listHotels;


        }
        public HotelPage()
        {
            InitializeComponent();
        }

        public HotelPage(City selectedCity)
        {
            InitializeComponent();
            HotelInitializing(selectedCity);
        }

        private void listHotel_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (listHotel.SelectedItem != null)
            {
                
                Navigation.PushAsync(new DatPhongPage(selectedHotel: (Hotel)listHotel.SelectedItem));
            }
        }
    }
}