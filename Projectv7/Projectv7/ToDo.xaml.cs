using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projectv7
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ToDo : ContentPage
	{

        string _fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "_LifeNotes.txt");

        public ToDo ()
		{
			InitializeComponent ();
            if (File.Exists(_fileName))
            {
                _editor.Text = File.ReadAllText(_fileName);
            }

        }

        private void _Save(object sender, EventArgs e)
        {
            string x = _editor.Text;
            string y = editor.Text;
            string all = x +"\n"+ y;
            File.WriteAllText(_fileName, all);
            DisplayAlert("Saved Successfull !","Add to Memo","Ok");
            _editor.Text = File.ReadAllText(_fileName);
            editor.Text = "";

        }
    }
}