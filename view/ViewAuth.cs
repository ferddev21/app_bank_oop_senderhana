using bank_oop_sederhana.service;

namespace bank_oop_sederhana.view
{
    public class ViewAuth
    {
        public static bool check = true;

        public static void Login()
        {
            while (check)
            {
                System.Console.Clear();
                System.Console.Write("Username : ");
                string inputUsername = System.Console.ReadLine();
                System.Console.Write("Password : ");
                string inputPassword = System.Console.ReadLine();

                check = ServiceAuth.CheckLogin(inputUsername, inputPassword);
            }
        }

    }
}