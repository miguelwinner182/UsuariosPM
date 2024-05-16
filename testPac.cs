using System;

class Program
{
    static void Main()
    {
        // Definición de variables
        string email = "test0@pacifico.com.pe";
        string password = "1LY203@#@@ss3";
        string email1 = "test1@pacifico.com.pe";
        string password1 = "1LY23@#@@ss3";
        string email2 = "test2@pacifico.com.pe";
        string password2 = "%&&1LY23@#@@ss3";

        // Bucle para imprimir las variables cinco veces
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("mail: {0}, password: {0}", email, password);
            Console.WriteLine("mail: {1}, password: {1}", email1, password1);
            Console.WriteLine("mail: {2}, password: {2}", email2, password2);
        }
    }
}
