using MahApps.Metro.Controls;
using Ookii.Dialogs.Wpf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using MessageBox = System.Windows.MessageBox;

namespace Windows_Toolware
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 


    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
          
            Hide();
            CredentialDialog creddialog = new CredentialDialog();
                // The window title will not be used on Vista and later; there the title will always be "Windows Security".
                creddialog.WindowTitle = "Credential dialog sample";
                creddialog.MainInstruction = "Microsoft Windows Toolware";
                creddialog.Content = "Welcome to Windows Toolware. Please sign in to your account.";
                creddialog.ShowSaveCheckBox = true;
                creddialog.ShowUIForSavedCredentials = true;
                // The target is the key under which the credentials will be stored.
                // It is recommended to set the target to something following the "Company_Application_Server" pattern.
                // Targets are per user, not per application, so using such a pattern will ensure uniqueness.
                creddialog.Target = "Microsoft.WindowsToolware_x64__CREDDIALOG.21387";
                if (creddialog.ShowDialog(this))
                {
                    // Normally, you should verify if the credentials are correct before calling ConfirmCredentials.
                    // ConfirmCredentials will save the credentials if and only if the user checked the save checkbox.
                    creddialog.ConfirmCredentials(true);
                }
            Show();
            InitializeComponent();
            UsernameText.Text = "Hello, " + creddialog.Credentials.UserName;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\sreer\source\repos\Windows Toolware\Windows Toolware\Sounds\Windows Toolware startup.wav");
            player.Play();
        }

        public void WindowsExtendExpiryBuild()
        {
            ExpiryDate expiry = ExpiryDate.GetExpiryDate(20211031);
            ExpiryDate expiry11 = ExpiryDate.GetExpiryDate(20220915);
            string build = Environment.OSVersion.Version.Build.ToString();
            if (build == expiry)
            {

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("taskmgr.exe");
        }

        private void Button_Click_Logout(object sender, RoutedEventArgs e)
        {
            Hide();
            using (CredentialDialog dialog = new CredentialDialog())
            {
                // The window title will not be used on Vista and later; there the title will always be "Windows Security".
                dialog.WindowTitle = "Credential dialog sample";
                dialog.MainInstruction = "Microsoft Windows Toolware";
                dialog.Content = "Welcome to Windows Toolware. Please sign in to your account.";
                dialog.ShowSaveCheckBox = true;
                dialog.ShowUIForSavedCredentials = true;
                // The target is the key under which the credentials will be stored.
                // It is recommended to set the target to something following the "Company_Application_Server" pattern.
                // Targets are per user, not per application, so using such a pattern will ensure uniqueness.
                dialog.Target = "Microsoft.WindowsToolware_x64__CREDDIALOG.21387";
                if (dialog.ShowDialog(this))
                {
                    // Normally, you should verify if the credentials are correct before calling ConfirmCredentials.
                    // ConfirmCredentials will save the credentials if and only if the user checked the save checkbox.
                    dialog.ConfirmCredentials(true);
                    UsernameText.Text = "Hello, " + dialog.Credentials.UserName;
                }
            }
            Show();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\sreer\source\repos\Windows Toolware\Windows Toolware\Sounds\Windows Toolware startup.wav");
            player.Play();
        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)

        {

            if (txtSearch.Text != "")
            {

                txtSearchPlaceholder.Visibility

           = Visibility.Hidden;

            }
            else
            {

                txtSearchPlaceholder.Visibility

            = Visibility.Visible;

            }

        }


        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }
    }
}
