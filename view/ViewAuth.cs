using bank_oop_sederhana.service;

namespace bank_oop_sederhana.view
{
    public class ViewAuth
    {
        public static bool isCheck = true;

        public static void Login()
        {
            isCheck = true;
            while (isCheck)
            {
                System.Console.Write("Username : ");
                string inputUsername = System.Console.ReadLine();
                System.Console.Write("Password : ");
                string inputPassword = System.Console.ReadLine();
                System.Console.Clear();
                isCheck = ServiceAuth.CheckLogin(inputUsername, inputPassword);
            }
        }

        public static void Logout()
        {
            System.Console.Clear();
            System.Console.WriteLine("Berhasil Logout");
            isCheck = !ServiceAuth.ClearAuth();
        }

    }
}