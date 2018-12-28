// ReSharper disable InconsistentNaming
namespace eCat.TestConsole
{
    #region Using

    using System;
    using System.Threading.Tasks;

    #endregion

    class Program
    {
        static void Main()
        {
            Console.Title = "eCat - PCM";
            MenuStart().GetAwaiter().GetResult();
        }

        private static async Task MenuStart()
        {
            Console.Clear();
            Console.WriteLine("*********************************");
            Console.WriteLine("*         Menú eCat-PCM         *");
            Console.WriteLine("*********************************");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("1 - Migración");
            Console.WriteLine("2 - Añadir Género Terror");
            Console.WriteLine("3 - Codificación Jerarquías");
            Console.WriteLine("4 - Prueba de Servicios");
            Console.WriteLine("0 - Salir");
            Console.WriteLine("");
            Console.WriteLine("Elige una opción ...");

            var option = Console.ReadKey();
            switch (option.KeyChar)
            {
                case '0':                    
                    Environment.Exit(0);
                    break;

                case '1':
                    await MenuMigracion();
                    break;

                case '2':
                    await MenuAddGeneroTerror();
                    break;

                case '3':
                    await MenuCodificacionJerarquias();
                    break;

                case '4':
                    await MenuPruebaServiciosAsync();
                    break;

                default:
                    await MenuStart();
                    break;
            }
        }

        private static async Task MenuMigracion()
        {
            Console.Clear();
            Console.WriteLine("*****************************");
            Console.WriteLine("*         Migración         *");
            Console.WriteLine("*****************************");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Escoge un pais para iniciar la Migración ó [0] para regresar al menú anterior ... ");

            var option = Console.ReadLine();
            switch (option)
            {
                case "4":
                    var migrationToPCM = new MigrationToPCM();
                    migrationToPCM.ProcessQ(Convert.ToInt16(option));

                    Console.WriteLine("");
                    Console.WriteLine("Presiona cualquier tecla para regresar al Menú inicial ...");
                    Console.ReadKey();
                    await MenuStart();

                    break;

                case "0":
                    await MenuStart();
                    break;

                default:
                    await MenuMigracion();
                    break;
            }
        }

        private static async Task MenuAddGeneroTerror()
        {
            Console.Clear();
            Console.WriteLine("*******************************************");
            Console.WriteLine("*         Añadir Género de Terror         *");
            Console.WriteLine("*******************************************");
            Console.WriteLine("");
            Console.WriteLine("");

            Util.AddGeneroTerror();

            Console.WriteLine("");
            Console.WriteLine("Presiona cualquier tecla para regresar al Menú inicial ...");
            Console.ReadKey();
            await MenuStart();
        }

        private static async Task MenuCodificacionJerarquias()
        {
            Console.Clear();
            Console.WriteLine("**********************************************");
            Console.WriteLine("*         Codificación de Jerarquías         *");
            Console.WriteLine("**********************************************");
            Console.WriteLine("");
            Console.WriteLine("");

            Util.CodificacionJerarquias();

            Console.WriteLine("");
            Console.WriteLine("Presiona cualquier tecla para regresar al Menú inicial ...");
            Console.ReadKey();
            await MenuStart();
        }

        private static async Task MenuPruebaServiciosAsync()
        {
            Console.Clear();
            Console.WriteLine("***************************************");
            Console.WriteLine("*         Prueba de Servicios         *");
            Console.WriteLine("***************************************");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("1 - echoping");
            Console.WriteLine("2 - echouser");
            Console.WriteLine("3 - authenticate");
            Console.WriteLine("4 - FichasBase por Id");
            Console.WriteLine("0 - Salir");
            Console.WriteLine("");
            Console.Write("Elige una opción ... ");

            var option = Console.ReadKey();
            switch (option.KeyChar)
            {
                case '1':
                    Console.WriteLine("");
                    await TestSevices.Test_echoping();

                    Console.WriteLine("");
                    Console.WriteLine("Presiona cualquier tecla para regresar al Menú inicial ...");
                    Console.ReadKey();
                    await MenuStart();

                    break;

                case '2':
                    Console.WriteLine("");
                    await TestSevices.Test_echouser();

                    Console.WriteLine("");
                    Console.WriteLine("Presiona cualquier tecla para regresar al Menú inicial ...");
                    Console.ReadKey();
                    await MenuStart();

                    break;

                case '3':
                    Console.WriteLine("");
                    await TestSevices.Test_authenticate();

                    Console.WriteLine("");
                    Console.WriteLine("Presiona cualquier tecla para regresar al Menú inicial ...");
                    Console.ReadKey();
                    await MenuStart();

                    break;

                case '4':
                    Console.WriteLine("");
                    Console.Write("Introduce el Id de FichasBase ... ");
                    var idFichasBase = Console.ReadLine();
                    await TestSevices.Test_FichasBaseGet(idFichasBase);

                    Console.WriteLine("");
                    Console.WriteLine("Presiona cualquier tecla para regresar al Menú inicial ...");
                    Console.ReadKey();
                    await MenuStart();

                    break;

                case '0':
                    await MenuStart();
                    break;

                default:
                    await MenuPruebaServiciosAsync();
                    break;
            }
        }
    }
}
