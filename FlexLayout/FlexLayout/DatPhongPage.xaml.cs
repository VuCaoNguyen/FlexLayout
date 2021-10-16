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
    public partial class DatPhongPage : ContentPage
    {
        void FormInitializing(Hotel selectedHotel)
        {
            hotel.Text = selectedHotel.name;
            phoneHotel.Text = selectedHotel.phone;
        }
        public DatPhongPage()
        {
            InitializeComponent();
        }

        public DatPhongPage(Hotel selectedHotel)
        {
            InitializeComponent();
            FormInitializing(selectedHotel);
        }

        private void submit_Clicked(object sender, EventArgs e)
        {
          
            
            String ten = (String)username.Text;
            String email = (String)Email.Text;
            String phone = (String)Phone.Text;
            String nameHotel = (String)hotel.Text;
            String thongbao = "Tên: " + ten + "\nemail: " + email + "\nPhone: " + phone + "\nHotel: " + nameHotel;

            if(Email.Text == null || username.Text == null || Phone.Text == null)
            {
                DisplayAlert("Warning", "Must type all information in form", "OK");
                if (username.Text == null)
                {
                    username.Focus();
                }
               else if(Email.Text == null)
                {
                    Email.Focus();
                }
                else
                {
                    Phone.Focus();
                }
               
            }
            else if (!email.Contains("@"))
            {
                DisplayAlert("Error", "Email must be contain @", "OK");
                Email.Focus();
            }
            
            else if(phone.Length != 10)
            {
                DisplayAlert("Error", "Phone must 10 numbers", "OK");
                Phone.Focus();
            }
            else
            {
                DisplayAlert("Thông tin", thongbao, "OK");

                username.Text = "";
                Email.Text = "";
                Phone.Text = "";
            }


        }

        private void cancel_Clicked(object sender, EventArgs e)
        {
            username.Text = "";
            Email.Text = "";
            Phone.Text = "";
        }
    }
}