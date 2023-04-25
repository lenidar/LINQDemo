using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LINQDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {

        LoginSampleDataContext db_con
            = new LoginSampleDataContext(
                Properties.Settings.Default.LogInOnlySampleConnectionString);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string uName = tbUName.Text;
            string uPass = tbPass.Text;
            string UID = "";
            string userLastName = "";
            string userFirstName = "";
            string lastLogin = "";
            List<uspActualLoginResult> thing = new List<uspActualLoginResult>();

            // notes on the datatype
            // XXResult where XX is the name of the USP
            // is an automatically generated datatype that is a SINGULAR
            // collection of the result, in this case it is the UID, LN, FN and LLD
            // by making it the datatype of the LIST we are implying that the return
            // of the usp is One or More getting this to work.
            // source:
            // https://social.msdn.microsoft.com/Forums/en-US/fe7c4848-69ad-4367-a860-6befc2ae52a9/working-with-usp-and-linq?forum=aspadoentitylinq

            if (uName.Length > 0 && uPass.Length > 0)
            {
                // substituting the list for var which I guess is a better
                // way of doing things
                // the .ToList tells the compiler that the result of the 
                // usp execution can hold a return of more than 1
                thing = db_con.uspActualLogin(uName, uPass).ToList();

                if(thing.Count == 1)
                {
                    // this is to get the things from the result
                    foreach(var login in thing)
                    {
                        UID = login.UID;
                        userLastName = login.ULastName; 
                        userFirstName = login.UFirstName;
                        lastLogin = login.ULastLogin.ToString();
                    }

                    MessageBox.Show("Login Success! Welcome back " 
                        + userLastName + ", " + userFirstName + "!" +
                        "\nHavent seen you since " + lastLogin);

                    db_con.uspActualInsertLog(UID, 5, "Login Successful");
                    db_con.uspActualUpdateLastLog(UID);
                }
                else
                {
                    MessageBox.Show("Username/password is wrong");
                }
            }
            else
            {
                MessageBox.Show("Username/password is too short");
                tbUName.Text = "";
                tbPass.Text = "";
            }
        }
    }
}
