using System;
using System.Configuration;



using ConsoleApp1;


namespace GSM_bun
{
    class Program
    {
        static void Main(string[] args)
        {

            string optiune;
            do
            {
                Console.WriteLine("C. Citire model de la tastatura");
                Console.WriteLine("D. Citire furnizor de la tastatura");
                Console.WriteLine("A. Cautare model dupa nume");
                Console.WriteLine("V. Cautare furnizor dupa nume");
                Console.WriteLine("F. Afisare produselor din fisier");
                Console.WriteLine("W. Afisare furnizorilor din fisier");
                Console.WriteLine("S. Salvare produs in fisier");
                Console.WriteLine("M. Salvare furnizor in fisier");
                Console.WriteLine("X. Inchidere program");
                Console.WriteLine("Alegeti o optiune");
                optiune = Console.ReadLine();
                switch (optiune.ToUpper())
                {
                    case "C":
                        int ModelNou
                     Model= CitireModelTastatura();

                        break;

                    case "D":
                     Furnizori = CitireFurnizorTastatura();

                        break;

                    case "A":
                        Console.Write("Dati numele modelului cautat: ");
                        string model_cautat = Console.ReadLine();
                        Model[] lista = adminModel.GetModel(out int nrModel);
                        cautareModelNume(lista, nrModel, model_cautat);

                        break;

                    case "V":
                        Console.Write("Dati numele furnizorului cautat: ");
                        string furnizor_cautat = Console.ReadLine();
                        Furnizori[] listaf = adminFurnizori.GetFurnizori(out nrFurnizori);
                        cautareFurnizorNume(listaf, nrFurnizori, furnizor_cautat);

                        break;



                    case "F":
                        Model[] lista_modele = Model.GetIdModel(out nrModel);
                        AfisareProduse(lista_modele, nrModel);

                        break;

                    case "W":
                        Furnizori[] lista_furnizori = adminFurnizori.GetFurnizori(out nrFurnizori);
                        AfisareFurnizori(lista_furnizori, nrFurnizori);

                        break;





                    case "S":
                       
                        int idModel = nrModel + 1;
                        Model.GetIdModel(idModel);
                        Model.GetIdModel(ModelNou);

                        nrModel = nrModel + 1;

                        break;

                    case "M":
                        int furniz =  nrFurnizori + 1;
                        adminFurnizori.AddFurnizor(furnizorNou);

                        nrFurnizori = nrFurnizori + 1;

                        break;





                    case "X":
                        return;
                    default:
                        Console.WriteLine("Optiune inexistenta");
                        break;
                }
            } while (optiune.ToUpper() != "X");

            Console.ReadKey();


        }

        //Citire produs de la tastatura

        public static Model CitireModelTastatura()
        {
            Console.WriteLine("Introduceti numele produsului:");
            string nume = Console.ReadLine();
            Console.WriteLine("Introduceti tipul produsului:");
            string tip_model     = Console.ReadLine();
            Console.WriteLine("Introduceti data de expirare :");
            string data_exp = Console.ReadLine();
            Model model = new Model(0, nume, tip_model);

            return Model;
        }


        //Citire furnizor de la tastatura

        public static Furnizori CitireFurnizorTastatura()
        {
            Console.WriteLine("Introduceti numele furnizorului:");
            string nume_fur = Console.ReadLine();
            Console.WriteLine("Introduceti adresa furnizorului :");
            string adresa_fur = Console.ReadLine();
            Console.WriteLine("Introduceti numarul de telefon :");
            string nr_tel = Console.ReadLine();
            Furnizori furnizori = new Furnizori(nume_fur, adresa_fur, nr_tel);

            return furnizori;
        }
        //Afisare produs
        public static void AfisareModele(Model Model)
        {
            string infoModel = string.Format("Id: {0}, Denumire: {1}, Tip: {2}, ")
                   Model.GetIdModel(),
                   Model.Get_nume() ?? " Necunoscut ",
                   Model.Get_tip() ?? " Necunoscut "
                   );

            Console.WriteLine(infoModel);
        }

        public static void AfisareModele    (Model[] lista_modele, int nrModele)
        {
            Console.WriteLine("Modelele sunt: ");
            for (int contor = 0; contor < nrModele; contor++)
                AfisareProdus(lista_modele[contor]);
        }

        //Afisare furnizor
        public static void AfisareFurnizor(Furnizori furnizori)
        {
            string infoFurnizori = string.Format("Nume: {0}, Adresa: {1}, Numar de telefon: {2}",
                   furnizori.GetNumeFurnizori() ?? "Necunoscut",
                   furnizori.GetAdresaFurnizori() ?? " Necunoscut ",
                   furnizori.GetNumarTelefon() ?? " Necunoscut ");

            Console.WriteLine(infoFurnizori);
        }

        public static void AfisareFurnizori(Furnizori[] lista_furnizori, int nrFurnizori)
        {
            Console.WriteLine("Furnizorii sunt: ");
            for (int contor = 0; contor < nrFurnizori; contor++)
                AfisareFurnizor(lista_furnizori[contor]);
        }

    }

}