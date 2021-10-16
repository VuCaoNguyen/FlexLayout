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
    public partial class ListAnimal : ContentPage
    {
        void listAnimalInitializing()
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Animal { id = "1", description = "To warn potential predators, the most toxic amphibians are also the most brightly colored. Curare [kyoo-RAW-ree], for example, is found on the skin of colorful poison dart frogs. Another special feature of most amphibians is their egg-larva-adult life cycle. The larvae are aquatic and free-swimming—frogs and toads at this stage are called tadpoles. At a certain size, the young develop limbs and lungs. Some also lose their tails. Eventually, they hop or climb out of the water as adults, and spend the rest of their lives on land. This process is known as metamorphosis.", image = "animal1.jpg", name = "Penguin south" });
            animals.Add(new Animal { id = "2", description = "The giant panda lives in a few mountain ranges in central China, mainly in Sichuan, but also in neighbouring Shaanxi and Gansu.[10] As a result of farming, deforestation, and other development, the giant panda has been driven out of the lowland areas where it once lived, and it is a conservation-reliant vulnerable species.[11][12] A 2007 report showed 239 pandas living in captivity inside China and another 27 outside the country.[13] As of December 2014, 49 giant pandas lived in captivity outside China, living in 18 zoos in 13 different countries", image = "animal2.jpg", name = "Giant panda" });
            animals.Add(new Animal { id = "3", description = "Penguins (order Sphenisciformes /sfɪˈnɪsɪfɔːrmiːz/, family Spheniscidae /sfɪˈnɪsɪdiː/) are a group of aquatic flightless birds. They live almost exclusively in the southern hemisphere: only one species, the Galápagos penguin, is found north of the Equator. Highly adapted for life in the water, penguins have countershaded dark and white plumage and flippers for swimming. Most penguins feed on krill, fish, squid and other forms of sea life which they catch while swimming underwater. They spend roughly half of their lives on land and the other half in the sea.", image = "animal3.jpg", name = "Penguin" });
            animals.Add(new Animal { id = "4", description = "Elephants are the largest existing land animals. Three living species are currently recognised: the African bush elephant, the African forest elephant, and the Asian elephant. They are an informal grouping within the family Elephantidae of the order Proboscidea. Elephantidae is the only surviving family of proboscideans; extinct members include the mastodons. Elephantidae also contains several extinct groups, including the mammoths and straight-tusked elephants. African elephants have larger ears and concave backs, whereas Asian elephants have smaller ears, and convex or level backs", image = "animal4.jpg", name = "Elephant" });
            listAnimal.ItemsSource = animals;
        }
        public ListAnimal()
        {
            InitializeComponent();
             listAnimalInitializing();
        }

        private void listAnimal_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            Navigation.PushAsync(new FormAnimal(animal: (Animal)listAnimal.SelectedItem));
        }
    }
}