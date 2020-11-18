using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace karuselValjataga
{
    public partial class MainPage : CarouselPage
    {
        Button btn;
        Uri ur;
        public MainPage()
        {
            btn = new Button { Text = "Пройти тест", BackgroundColor = Color.Yellow, HorizontalOptions = LayoutOptions.Center };
            Button btn1 = new Button { 
                Text = "Пройти тест", BackgroundColor = Color.Yellow, HorizontalOptions = LayoutOptions.Center };
            Button btn2 = new Button { 
                Text = "Пройти тест", BackgroundColor = Color.Yellow, HorizontalOptions = LayoutOptions.Center };
            Button btn3 = new Button { 
                Text = "Пройти тест", BackgroundColor = Color.Yellow, HorizontalOptions = LayoutOptions.Center };

            btn.Clicked += Btn_Clicked;
            btn1.Clicked += Btn1_Clicked;
            btn2.Clicked += Btn2_Clicked; btn3.Clicked += Btn3_Clicked;
            InitializeComponent();
            var start = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {

                        new Label
                        {
                            Text = "Стартовая страница\nВиды темперамента",
                            TextColor = Color.White,
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                            HorizontalTextAlignment = TextAlignment.Center,
                            BackgroundColor=Color.DarkGray
                        },
                        new Image {Source = "start.webp"}
                    }
                }
            };
            var holerik = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Холерик",
                            TextColor = Color.White,
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                            HorizontalTextAlignment = TextAlignment.Center,
                            BackgroundColor=Color.Black,
                            Padding = 20
                            
                        },
                        new Image {Source = "holerik.png",
                        HeightRequest = 250,
                        WidthRequest = 250},
                        btn,
                        new Label
                        {
                            Padding = 20,
                            Text = "Холерик — это эмоционально вспыльчивый и чрезвычайно активный тип темперамента, склонный к лидерству и доминированию. Само слово «холерик» древнегреческого происхождения. По представлениям Гиппократа, который согласно преобладающему «жизненному соку» выделил четыре типа темперамента, у холериков доминирует «желтая желчь». Языком оригинала она именуется «холе». Отсюда и пошло название.",
                            FontSize = 12
                        }
                    }
                }
            };
            var sangvinik = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Сангвиник",
                            TextColor = Color.White,
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                            HorizontalTextAlignment = TextAlignment.Center,
                            BackgroundColor=Color.Black,
                            Padding = 20
                            
                        },
                        new Image {Source = "sangvinik.png",
                        HeightRequest = 250,
                        WidthRequest = 250},
                        btn1,
                        new Label
                        {
                            Padding = 20,
                            Text = "К сангвиникам относятся жизнерадостные люди, которые легко адаптируются в любой компании и в результате оказываются в центре внимания. Они нравятся многим людям и поэтому им прощают промахи или неудачные шутки. Представители этого типа темперамента любят похвастаться. О своих достижениях они молчать не будут, а тут же расскажут о них своим друзьям и близким. "
                        }
                    }
                }
            };
            var flegmatik = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Флегматик",
                            TextColor = Color.White,
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                            HorizontalTextAlignment = TextAlignment.Center,
                            BackgroundColor=Color.Black,
                            Padding = 20
                        },
                        new Image {Source = "flegmatik.png",
                        HeightRequest = 250,
                        WidthRequest = 250},
                        btn2,
                        new Label
                        {
                            Padding = 20,
                            Text = "Флегматики - это  сдержанные люди,  не склонные к риску и  невозмутимы в любой ситуации. Прежде чем принять решение, они обдумывают всё до мелочей. Флегматик всегда сдержанно выражает свои эмоции. Они стараются избежать конфликта, поэтому могут уступить в споре. Представители этого типа, видят жизнь в реальных красках. Именно поэтому  их цели в большинстве случаев достигаются. "
                        }
                    }
                }
            };
            var melanholik = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Меланхолик",
                            TextColor = Color.White,
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                            HorizontalTextAlignment = TextAlignment.Center,
                            BackgroundColor=Color.Black,
                            Padding = 20
                            
                        },
                        new Image {Source = "melanholik.jpg",
                        HeightRequest = 250,
                        WidthRequest = 250},
                        btn3,

                        new Label
                        {
                            Padding = 20,
                            Text = "Меланхолик - это пассивный тип темперамента, которому свойственны глубокие переживания на любые события, высокая чувствительность, обидчивость и эмоциональность. "
                        },
                    }
                }
            };
            Children.Add(start);
            Children.Add(holerik);
            Children.Add(sangvinik);
            Children.Add(flegmatik);
            Children.Add(melanholik);
        }

        private async void Btn3_Clicked(object sender, EventArgs e)
        {
            ur = new Uri("https://testometrika.com/personality-and-temper/the-formula-of-temperament-a-belov/");
            await Browser.OpenAsync(ur);
        }

        private async void Btn2_Clicked(object sender, EventArgs e)
        {
            ur = new Uri("https://testometrika.com/personality-and-temper/the-formula-of-temperament-a-belov/");
            await Browser.OpenAsync(ur);
        }

        private async void Btn1_Clicked(object sender, EventArgs e)
        {
            ur = new Uri("https://testometrika.com/personality-and-temper/the-formula-of-temperament-a-belov/");
            await Browser.OpenAsync(ur);
        }

        private async void Btn_Clicked(object sender, EventArgs e)
        {
            ur = new Uri("https://testometrika.com/personality-and-temper/the-formula-of-temperament-a-belov/");
            await Browser.OpenAsync(ur);
        }
    }
}
