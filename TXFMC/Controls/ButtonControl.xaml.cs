using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TXFMC.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ButtonControl : ContentView
    {
        public ButtonControl()
        {
            InitializeComponent();
        }

        BindableProperty ImageProperty = BindableProperty.Create(nameof(Image),
                                                                 typeof(ImageSource),
                                                                 typeof(ButtonControl),
                                                                 default(ImageSource),
                                                                 BindingMode.TwoWay);

        BindableProperty TextProperty = BindableProperty.Create(nameof(Text),
                                                                 typeof(string),
                                                                 typeof(ButtonControl),
                                                                 default(string),
                                                                 BindingMode.TwoWay);

        BindableProperty BtnBackgroundColorProperty = BindableProperty.Create(nameof(BtnBackgroundColor),
                                                                 typeof(Color),
                                                                 typeof(ButtonControl),
                                                                 default(Color),
                                                                 BindingMode.TwoWay);

        BindableProperty TextColorProperty = BindableProperty.Create(nameof(TextColor),
                                                                 typeof(Color),
                                                                 typeof(ButtonControl),
                                                                 default(Color),
                                                                 BindingMode.TwoWay);

        public ImageSource Image
        {
            get { return (ImageSource)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public Color BtnBackgroundColor
        {
            get { return GetValue(BtnBackgroundColorProperty) != null ? (Color)GetValue(BtnBackgroundColorProperty) : Color.Transparent; }
            set { SetValue(BtnBackgroundColorProperty, value); }
        }

        public Color TextColor
        {
            get { return GetValue(TextColorProperty) != null ? (Color)GetValue(TextColorProperty) : Color.Black; }
            set { SetValue(TextColorProperty, value); }
        }
    }
}
