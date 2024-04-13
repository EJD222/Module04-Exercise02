using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module04Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselPage1 : CarouselPage
    {

        ObservableCollection<MangInasalPromos> MangInasalPromosList = new ObservableCollection<MangInasalPromos>();
        public ObservableCollection<MangInasalPromos> ThePromos { get { return MangInasalPromosList; } }
        public CarouselPage1()
        {
            InitializeComponent();

            Promos.ItemsSource = MangInasalPromosList;

            ThePromos.Add(new MangInasalPromos
            {
                Name = "NEW! Solo Fiesta",
                Description = "Chicken Inasal Paa & 1pc. Pork BBQ"
            });

            ThePromos.Add(new MangInasalPromos
            {
                Name = "Takeout & Delivery Exclusive",
                Description = "NEW! Chicken Inasal & Pork BBQ Budy Size"
            });

            ThePromos.Add(new MangInasalPromos
            {
                Name = "Family Fiesta",
                Description = "Bigating Ihaw-Sarap Solb sa Bawat Handaan!"
            });

            ThePromos.Add(new MangInasalPromos
            {
                Name = "Extra Creamy Halo-Halo",
                Description = "Level up Sangkap, Extra Creamy Sarap!"
            });

            ThePromos.Add(new MangInasalPromos
            {
                Name = "NEW! Pork BBQ",
                Description = "Juicy-Lammmbot Sarap!"
            });

            ThePromos.Add(new MangInasalPromos
            {
                Name = "NEW! Palabok Party Size",
                Description = "Good for 10"
            });

            ThePromos.Add(new MangInasalPromos
            {
                Name = "NEW! Buddy Size",
                Description = "Ihaw-Sarap favorites perfect for sharing!"
            });

            ThePromos.Add(new MangInasalPromos
            {
                Name = "NEW! Sizzling Liempo",
                Description = "Tender-grilled, Pork Belly Sarap!"
            });

            ThePromos.Add(new MangInasalPromos
            {
                Name = "Family Fiesta",
                Description = "Ihaw-Sarap Favorites na pang Salu-Salo"
            });

            ThePromos.Add(new MangInasalPromos
            {
                Name = "Chicken Inasal Value Meal",
                Description = "Complete meal with rice and drinks"
            });

            ThePromos.Add(new MangInasalPromos
            {
                Name = "Halo-Halo Supreme",
                Description = "A delightful mix of ingredients topped with ice cream"
            });

            ThePromos.Add(new MangInasalPromos
            {
                Name = "Sizzling Bangus Belly",
                Description = "Fresh bangus belly grilled to perfection"
            });

            ThePromos.Add(new MangInasalPromos
            {
                Name = "Pork BBQ Party Platter",
                Description = "Ideal for large gatherings"
            });

            ThePromos.Add(new MangInasalPromos
            {
                Name = "Classic Pinoy Merienda",
                Description = "Selection of traditional Filipino snacks"
            });

            ThePromos.Add(new MangInasalPromos
            {
                Name = "Extra Rice Unlimited",
                Description = "Enjoy unlimited servings of rice with any meal"
            });

            ThePromos.Add(new MangInasalPromos
            {
                Name = "Inihaw na Pusit",
                Description = "Grilled squid served with Mang Inasal's signature sauce"
            });

            ThePromos.Add(new MangInasalPromos
            {
                Name = "Palabok Party Tray",
                Description = "Perfect for sharing at parties or events"
            });

            ThePromos.Add(new MangInasalPromos
            {
                Name = "Pancit Bam-i",
                Description = "A flavorful mix of noodles and vegetables"
            });

            ThePromos.Add(new MangInasalPromos
            {
                Name = "Lechon Kawali Sisig",
                Description = "Crispy pork belly sisig served sizzling hot"
            });
        }
    }
}