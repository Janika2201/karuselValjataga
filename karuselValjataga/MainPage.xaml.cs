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
        Button btn1, btn2, btn3, btn4, btn5;
        Label holeriklbl, sangviniklbl, flegmatiklbl, melanholiklbl;
        Uri ur;
        public MainPage()
        {
            btn1 = new Button
            {
                ImageSource = "holerik.jpg"
            };
            btn1.Clicked += Btn1_Clicked1;
            holeriklbl = new Label
            {
                IsVisible = false,
                Padding = 20,
                Text = "быстрый, страстный, порывистый, однако совершенно неуравновешенный, с резко меняющимся настроением с эмоциональными вспышками, быстро истощаемый. У него нет равновесия нервных процессов, это его резко отличает от сангвиника. ",
                FontSize = 12
            };
            btn2 = new Button
            {
                ImageSource = "sangvinik.png"
            };
            btn2.Clicked += Btn2_Clicked; ;
            sangviniklbl = new Label
            {
                IsVisible = false,
                Padding = 20,
                Text = "живой, горячий, подвижный человек, с частой сменой настроения, впечатлений, с быстрой реакцией на все события, происходящие вокруг него, довольно легко примиряющийся со своими неудачами и неприятностями.  "
            };
            btn3 = new Button
            {
                ImageSource = "flegmatik.png"
            };
            btn3.Clicked += Btn3_Clicked;
            flegmatiklbl = new Label
            {
                IsVisible = false,
                Padding = 20,
                Text = "неспешен, невозмутим, имеет устойчивые стремления и настроение, внешне скуп на проявление эмоций и чувств. Он проявляет упорство и настойчивость в работе, оставаясь спокойным и уравновешенным. В работе он производителен, компенсируя свою неспешность прилежанием."
            };
            btn4 = new Button
            {
                ImageSource = "melanholik.png"
            };
            btn4.Clicked += Btn4_Clicked;
            melanholiklbl = new Label
            {
                IsVisible = false,
                Padding = 20,
                Text = "человек легко ранимый, склонный к постоянному переживанию различных событий, он мало реагирует на внешние факторы. Свои астенические переживания он не может сдерживать усилием воли, он чересчур впечатлителен, легко эмоционально раним."
            };
            btn5 = new Button
            {
                Text = "Тест на  Темпераменты"
            };
            btn5.Clicked += Btn5_Clicked;






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
                        new Image {Source = "start.webp"},
                        btn5
                        
                    }
                }
            };
            var holerik = new ContentPage// название - холерик
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
                        btn1,
                        holeriklbl

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
                        btn2,
                        sangviniklbl
                        
                        
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
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                            HorizontalTextAlignment = TextAlignment.Center,
                            BackgroundColor=Color.Black,
                            Padding = 20
                        },
                        btn3,
                        flegmatiklbl
                       
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
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                            HorizontalTextAlignment = TextAlignment.Center,
                            BackgroundColor=Color.Black,
                            Padding = 20
                        },
                        btn4,
                        melanholiklbl

                    }
                }
            };

            Children.Add(start);
            Children.Add(holerik);
            Children.Add(sangvinik);
            Children.Add(flegmatik);
            Children.Add(melanholik);
        }

        private async void Btn5_Clicked(object sender, EventArgs e)
        {
            ur = new Uri("https://testometrika.com/personality-and-temper/the-formula-of-temperament-a-belov/");
            await Browser.OpenAsync(ur);
        }

        private void Btn4_Clicked(object sender, EventArgs e)
        {
           melanholiklbl.IsVisible = true;
        }

        private void Btn2_Clicked(object sender, EventArgs e)
        {
            sangviniklbl.IsVisible = true;
        }

        private void Btn3_Clicked(object sender, EventArgs e)
        {
            flegmatiklbl.IsVisible = true;//видимость 
        }

        private void Btn1_Clicked1(object sender, EventArgs e)
        {
            holeriklbl.IsVisible = true;
        }
    }
}
