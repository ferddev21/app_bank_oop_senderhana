using bank_oop_sederhana.entity;
using System.Collections.Generic;

namespace bank_oop_sederhana.service
{
    public class ServiceAuth
    {
        public static bool CheckLogin(string inputUsername, string inputPassword)
        {
            if (inputUsername != "" && inputPassword != "")
            {
                var user = AccountImplement.GetAll();

                for (int i = 0; i < user.Count; i++)
                {
                    if (user[i].Username == inputUsername && user[i].Password == inputPassword)
                    {
                        //user login set ke auth data
                        if (AuthImplement.Save(user[i].Id, user[i].Username))
                        {
                            return false;
                        }

                        return true;
                    }
                }

            }
            return true;
        }
    }
}