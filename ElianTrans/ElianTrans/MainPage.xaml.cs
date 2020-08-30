
using Couchbase.DataStructures;
using System;
using System.ComponentModel;
using System.IO;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ElianTrans
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
            saveElianAsync();
        }
        
        private async void Button_Clicked(object sender, EventArgs e)//takes user input and translates it to elian
        {
            
        if(Translate.Text == "a" || Translate.Text == "A")
         { 
            Trans.Text = "ﬧ";
            }
            else if (Translate.Text == "b" || Translate.Text == "B")
          {
            Trans.Text = "コ";
          }
            else if (Translate.Text == "c" || Translate.Text == "C")
            {
                Trans.Text = "┘";
            }
            else if (Translate.Text == "d" || Translate.Text == "D")
            {
                Trans.Text = "п";
            }
            else if (Translate.Text == "e" || Translate.Text == "E")
            {
                Trans.Text = "ߛ";
            }
            else if (Translate.Text == "f" || Translate.Text == "F")
            {
                Trans.Text = "ப";
            }
            else if (Translate.Text == "g" || Translate.Text == "G")
            {
                Trans.Text = "厂";
            }
            else if (Translate.Text == "h" || Translate.Text == "H")
            {
                Trans.Text = "ⵎ";
            }
            else if (Translate.Text == "i" || Translate.Text == "I")
            {
                Trans.Text = "ட";
            }
            else if (Translate.Text == "j" || Translate.Text == "J")
            {
                Trans.Text = "ᒣ";
            }
            else if (Translate.Text == "k" || Translate.Text == "K")
            {
                Trans.Text = "ᓗ";
            }
            else if (Translate.Text == "l" || Translate.Text == "L")
            {
                Trans.Text = "ᒧ";
            }
            else if (Translate.Text == "m" || Translate.Text == "M")
            {
                Trans.Text = "ᒉ";
            }
            else if (Translate.Text == "n" || Translate.Text == "N")
            {
                Trans.Text = "ᑭ";
            }
            else if (Translate.Text == "o" || Translate.Text == "O")
            {
                Trans.Text = "ᘂ";
            }
            else if (Translate.Text == "p" || Translate.Text == "P")
            {
                Trans.Text = "ᒥ";
            }
            else if (Translate.Text == "q" || Translate.Text == "Q")
            {
                Trans.Text = "ᓕ";
            }
            else if (Translate.Text == "r" || Translate.Text == "R")
            {
                Trans.Text = "ᒪ";
            }
            else if (Translate.Text == "s" || Translate.Text == "S")
            {
                Trans.Text = "ᒭ";
            }
            else if (Translate.Text == "t" || Translate.Text == "T")
            {
                Trans.Text = "ᓘ";
            }
            else if (Translate.Text == "u" || Translate.Text == "U")
            {
                Trans.Text = "ᒨ";
            }
            else if (Translate.Text == "v" || Translate.Text == "V")
            {
                Trans.Text = "ᒕ";
            }
            else if (Translate.Text == "w" || Translate.Text == "W")
            {
                Trans.Text = "ᑮ";
            }
            else if (Translate.Text == "x" || Translate.Text == "X")
            {
                Trans.Text = "ᒎ";
            }
            else if (Translate.Text == "y" || Translate.Text == "Y")
            {
                Trans.Text = "ᓟ";
            }
            else if (Translate.Text == "z" || Translate.Text == "Z")
            {
                Trans.Text = "ᓛ";
            }

            try
            {
                await SecureStorage.SetAsync("elian", Trans.Text);
            }
            catch (Exception ex)
            {
                // Possible that device doesn't support secure storage on device.
            }
            try
            {
                await SecureStorage.SetAsync("lexicon", Translate.Text);
            }
            catch (Exception ex)
            {
                // Possible that device doesn't support secure storage on device.
            }



        }

        private async void saveElianAsync()
        {
            try
            {
                var oauthToken = await SecureStorage.GetAsync("elian");
                saved.Text = oauthToken;
            }
            catch (Exception ex)
            {
                // Possible that device doesn't support secure storage on device.
            }
            try
            {
                var english = await SecureStorage.GetAsync("lexicon");
                savedLex.Text = english;
            }
            catch (Exception ex)
            {
                // Possible that device doesn't support secure storage on device.
            }

        }
        
    }
}

