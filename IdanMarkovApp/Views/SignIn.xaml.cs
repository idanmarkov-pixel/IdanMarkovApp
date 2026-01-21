using IdanMarkovApp.Helper;
using IdanMarkovApp.Service;
using IdanMarkovApp.ViewModels;
using static System.Net.Mime.MediaTypeNames;

namespace IdanMarkovApp.Views;

public partial class SignIn : ContentPage
{
    private DBMokup _db;
    private string _userName;
    private string _password;
    private string _loginMessage;
    private bool _signInMessageVisible;
    private Color _signInMessageColor;
    private bool _entryAsPassword;
    private string _passwordIconCode;
    public SignIn()
	{
        InitializeComponent();
        BindingContext = new SignInViewModel();
    }
}