namespace s13l4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool validOperation = true;
            while (validOperation)
            {
                Console.WriteLine("Scegli l'operazione da effettuare e digita il numero corrispondente");
                Console.WriteLine("1) Login // 2) Logout // 3) Verifica ora e data di login // 4) Lista degli accessi // 5) Esci");
                int scelta = int.Parse(Console.ReadLine());
                if (scelta == 1)
                {
                    validOperation = true;
                    Utente.LoginOperation();
                }
                if (scelta == 2) {
                    validOperation = true;
                    Utente.LogOutOperation();
                }
                if (scelta == 3) {
                    validOperation = true;
                    Utente.VerificaUltimoAccesso();                
                }
                if (scelta == 4) {
                    validOperation = true;
                    Utente.VerificaListaAccessi();                
                }
                if (scelta == 5)
                {
                    validOperation = false;
                }
            }
              
        }

        public static class Utente
        {
            const string userName = "paride";
            const string passWord = "ettore";
            static bool loggedIn = false;
            static DateTime ultimoAccesso;
            static List<DateTime> listaDate = new List<DateTime>();
            public static void LoginOperation()
            {
                if (!loggedIn)
                {
                    Console.WriteLine("Benvenuto, effettua il login: ");
                    Console.WriteLine("Inserisci Username : ");
                    string user = Console.ReadLine();
                    Console.WriteLine("Inserisci Password : ");
                    string pass = Console.ReadLine();
                    if (user == userName && pass == passWord)
                    {
                        Console.WriteLine($"Benvenuto {user}, conferma la tua password : ");
                        string confermaPass = Console.ReadLine();
                        if (confermaPass == pass)
                        {
                            Console.WriteLine("Password confermata, hai effettuato il login");
                            loggedIn = true;
                            ultimoAccesso = DateTime.Now;
                            listaDate.Add(ultimoAccesso);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Hai già effettuato l'accesso!");
                }
            }
            public static void LogOutOperation()
            {
                if (loggedIn)
                {
                    Console.WriteLine("Vuoi effettuare il Log Out? <si/no>");
                    string logOutFlag = Console.ReadLine();
                    if (logOutFlag == "si")
                    {
                        loggedIn = false;
                    }
                    else
                    {
                        Console.WriteLine("Non hai ancora effettuato l'accesso");
                    }
                }
            }

            public static void VerificaUltimoAccesso()
            {
                if (loggedIn)
                {
                    Console.WriteLine($"Il tuo ultimo accesso è : {ultimoAccesso}");
                }
                else
                {
                    Console.WriteLine("Devi prima effettuare l'accesso");
                }
            }

            public static void VerificaListaAccessi()
            {
                if(loggedIn)
                {
                    Console.WriteLine($"La lista dei tuoi accessi è : {listaDate}");
                }

                else 
                {
                      Console.WriteLine("Devi prima effettuare l'accesso");
                }
            }
        }
    }
}
