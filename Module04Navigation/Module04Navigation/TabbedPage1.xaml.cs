using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace Module04Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPage1 : Xamarin.Forms.TabbedPage
    {
        // Group Meals
        ObservableCollection<GroupMealsList> MangInasalGroupMeals = new ObservableCollection<GroupMealsList>();
        public ObservableCollection<GroupMealsList> GroupMealsCollection { get { return MangInasalGroupMeals; } }

        ObservableCollection<ChickenInasalList> MangInasalChickenInasal = new ObservableCollection<ChickenInasalList>();
        public ObservableCollection<ChickenInasalList> ChickenInasalCollection { get { return MangInasalChickenInasal; } }

        public TabbedPage1()
        {
            InitializeComponent();
            BindingContext = this;

            // Group Meals

            GroupMealsListView.ItemsSource = MangInasalGroupMeals;

            MangInasalGroupMeals.Add(new GroupMealsList
            {
                ItemName = "Chicken Inasal & Grilled Liempo Family Fiesta",
                Price = "₱963",
                Image = "https://lh3.googleusercontent.com/sI1sFevzG3WLQzDE68AfwNllq99wASwO_NgOC5Vjfu7FxBRdU6-wWBfpy1fgWWMiIqv7Vfhs7WXpTDmqOAdsBqULBDJ6G16Lv6rr=w500-rw"
            });

            MangInasalGroupMeals.Add(new GroupMealsList
            {
                ItemName = "Chicken Inasal & Pork BBQ Buddy Fiesta",
                Price = "₱447",
                Image = "https://lh3.googleusercontent.com/RVvHPza5nuDb6e602ed1o_xSEowsFDnStzSAcnoBB3Jv_Msn4qWWbBw2uYhjk1iDn-1RxPcCiOxgrnuCRciYDt5SxydUMO448qft=w500-rw"
            });

            MangInasalGroupMeals.Add(new GroupMealsList
            {
                ItemName = "Pork BBQ & Grilled Liempo Family Fiesta",
                Price = "₱918",
                Image = "https://lh3.googleusercontent.com/V1lzJAlDe6XXwyixIlXdA7c9NEAdv2jes_CPxxgVao5nLcgTU0av08I8yCpIS_MwP9W9ReKaBWRdOS4nM-UN92wt2_E9g5vRHYKBCw=w500-rw"
            });

            MangInasalGroupMeals.Add(new GroupMealsList
            {
                ItemName = "Chicken Inasal & Grilled Liempo Buddy Fiesta",
                Price = "₱492",
                Image = "https://lh3.googleusercontent.com/8haExHoTyDA1spQMl3TwOJawbOV2uB-w4_OrcvCN39aiPq7bv0PowhKfvKGsi9IiSwMFuyzCaF3ttwsoeUZzhYoHZtW2-kBZ06l-=w500-rw"
            });

            MangInasalGroupMeals.Add(new GroupMealsList
            {
                ItemName = "Chicken Inasal & Pork BBQ Family Fiesta",
                Price = "₱799",
                Image = "https://lh3.googleusercontent.com/H4tamZdeyjMN9ywoeujpG_pviQi5h98NkLXOMdflTcJt1GvsTqXDFFUBWdGY-pGYPYljd1w1JSoXw-6WILMkeKOynCYDEweC6SNQ=w500-rw"
            });

            // Chicken Inasal

            ChickenInasalListView.ItemsSource = MangInasalChickenInasal;

            MangInasalChickenInasal.Add(new ChickenInasalList
            {
                ItemName = "Chicken Inasal & 1 pc Pork BBQ Solo Fiesta",
                Price = "₱280",
                Image = "https://lh3.googleusercontent.com/r54XV2gp26zjvLupVUBkuo4-CzQXeX6b5DBTyQ5E_jommpovKJyQBDAIXht19u3o4KmrsHOBCyBx3X9xlPO4QEWP9OzFQJh-BsMvPg=w500-rw"
            });

            MangInasalChickenInasal.Add(new ChickenInasalList
            {
                ItemName = "Chicken Inasal Paa & Pork BBQ Buddy Size",
                Price = "₱368",
                Image = "https://lh3.googleusercontent.com/lqHdrbQc0VjCmFRVWXlyFgKvmVJDtzKgJI3HajBzzGeIprH5N_FeoHMVIkAMoWM2--3OcXnFMQiQYLHd_WdN5NiQIHWTWwaTbDPzBQ=w500-rw"
            });

            MangInasalChickenInasal.Add(new ChickenInasalList
            {
                ItemName = "Chicken Inasal Solo Fiesta",
                Price = "₱245",
                Image = "https://lh3.googleusercontent.com/4a6DzRtL7Wms20FnLOLdHFM2TzuygdMJisDK4vpyMp16IDrzFIWC66EeWpg6GGD3Bcd0fg07gA9hqtXo7OL_OM0NJ3y4eo-zpqrk=w500-rw"
            });

            MangInasalChickenInasal.Add(new ChickenInasalList
            {
                ItemName = "Paa Large - PM1",
                Price = "₱142",
                Image = "https://lh3.googleusercontent.com/1fB7bg4jg23KZ1YuvRgRWKDKfyrdrwsZgeGV9ntqQOIyYbtN6_2ir7ULyHvWdFmeAiwXLatRaKUdJOTGLn3P0Z9tNfsXOg6Nxkqo=w500-rw"
            });

            MangInasalChickenInasal.Add(new ChickenInasalList
            {
                ItemName = "Pecho Large - PM2",
                Price = "₱169",
                Image = "https://lh3.googleusercontent.com/Bh3QOS507bIvU2YP4H9CRbTwYQbHf3ynWqJu7cMX8xAy2_sVrfpEpMrZJ1Q9w7ES1aRPFJkgMAKw6jP7Pm3UdyOaIMTXcG4b825k=w500-rw"
            });
        }

        private void SubmitButton_Clicked(object sender, EventArgs e)
        {
            CurrentPage = Children[2];
        }
    }
}