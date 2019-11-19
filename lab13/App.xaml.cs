using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lab13
{
    public partial class App : Application
    {
        static TodoPersonaBaseDatos database;
        public App()
        {
            //InitializeComponent();

            Resources = new ResourceDictionary();
            Resources.Add("primaryGreen", Color.FromHex("91CA47"));
            Resources.Add("primaryDarkGreen", Color.FromHex("6FA22E"));

            var nav = new NavigationPage(new paginaListaPersona());
            nav.BarBackgroundColor = (Color)App.Current.Resources["primaryGreen"];
            nav.BarTextColor = Color.White;

            MainPage = nav;

            //MainPage = new MainPage();
        }
        public static TodoPersonaBaseDatos Database
        {
            get
            {
                if (database == null)
                {
                    database = new TodoPersonaBaseDatos(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TodoSQLite.db3"));
                }
                return database;
            }
        }

        public int ResumeAtTodoId { get; set; }
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}