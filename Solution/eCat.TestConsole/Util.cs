namespace eCat.TestConsole
{
    #region Using

    using Repository;
    using Service.Services;
    using Data.Entities;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    #endregion

    public class Util
    {
        public static bool AddGeneroTerror()
        {
            Console.WriteLine("Add Genero -> 'Terror' ...");
            var serviceTGeneroes = new ServiceTGeneroes(new RepositoryTGeneroes());

            if (serviceTGeneroes.SaveTGenero(new TGenero {IdGenero = 25, Descripcion = "Terror"}) == null)
            {
                Console.WriteLine("Error!!!!");
                return false;
            }

            Console.WriteLine("OK");
            return true;
        }

        public static IEnumerable<TCampañas> Get_TCampanas()
        {
            Console.WriteLine("Get_TCampanas ...");
            var serviceTCampanas = new ServiceTCampanas(new RepositoryTCampanas());

            return serviceTCampanas.Get();
        }

        public static void CodificacionJerarquias()
        {
            Console.WriteLine("CodificacionJerarquias ...");
            var serviceE2RamasClasificacionesGestion = new ServiceE2RamasClasificacionesGestion(new RepositoryE2RamasClasificacionesGestion());

            var listTotal = new List<E2RamasClasificacionesGestion>();
            var listJerarquias = serviceE2RamasClasificacionesGestion.GetAll().ToArray();
            listTotal.AddRange(listJerarquias.Where(x =>
                x.TPropietario.Nombre == "España-Ikasmina Argitaletxea" &&
                x.TMercado != null &&
                x.TMercado.Nombre == "Educativo" &&
                x.TEtapasRangoEdad != null &&
                x.TEtapasRangoEdad.Nombre == "Primaria" &&
                x.TSubcategoriasMateria != null &&
                x.TSubcategoriasMateria.Nombre == "Proyectos" &&
                x.TCategoriasCiclo != null &&
                x.TCategoriasCiclo.Nombre == "1º")
                .ToArray());

            listTotal.AddRange(listJerarquias.Where(x =>
                    x.TPropietario.Nombre == "España-Ikasmina Argitaletxea" &&
                    x.TMercado != null &&
                    x.TMercado.Nombre == "Educativo" &&
                    x.TEtapasRangoEdad != null &&
                    x.TEtapasRangoEdad.Nombre == "Primaria" &&
                    x.TSubcategoriasMateria != null &&
                    x.TSubcategoriasMateria.Nombre == "Proyectos" &&
                    x.TCategoriasCiclo != null &&
                    x.TCategoriasCiclo.Nombre == "2º")
                .ToArray());

            listTotal.AddRange(listJerarquias.Where(x =>
                    x.TPropietario.Nombre == "España-Ikasmina Argitaletxea" &&
                    x.TMercado != null &&
                    x.TMercado.Nombre == "Educativo" &&
                    x.TEtapasRangoEdad != null &&
                    x.TEtapasRangoEdad.Nombre == "Primaria" &&
                    x.TSubcategoriasMateria != null &&
                    x.TSubcategoriasMateria.Nombre == "Proyectos" &&
                    x.TCategoriasCiclo != null &&
                    x.TCategoriasCiclo.Nombre == "3º")
                .ToArray());

            listTotal.AddRange(listJerarquias.Where(x =>
                    x.TPropietario.Nombre == "España-Ikasmina Argitaletxea" &&
                    x.TMercado != null &&
                    x.TMercado.Nombre == "Educativo" &&
                    x.TEtapasRangoEdad != null &&
                    x.TEtapasRangoEdad.Nombre == "Primaria" &&
                    x.TSubcategoriasMateria != null &&
                    x.TSubcategoriasMateria.Nombre == "Proyectos" &&
                    x.TCategoriasCiclo != null &&
                    x.TCategoriasCiclo.Nombre == "4º")
                .ToArray());

            listTotal.AddRange(listJerarquias.Where(x =>
                    x.TPropietario.Nombre == "España-Ikasmina Argitaletxea" &&
                    x.TMercado != null &&
                    x.TMercado.Nombre == "Educativo" &&
                    x.TEtapasRangoEdad != null &&
                    x.TEtapasRangoEdad.Nombre == "Primaria" &&
                    x.TSubcategoriasMateria != null &&
                    x.TSubcategoriasMateria.Nombre == "Proyectos" &&
                    x.TCategoriasCiclo != null &&
                    x.TCategoriasCiclo.Nombre == "5º")
                .ToArray());

            listTotal.AddRange(listJerarquias.Where(x =>
                    x.TPropietario.Nombre == "España-Ikasmina Argitaletxea" &&
                    x.TMercado != null &&
                    x.TMercado.Nombre == "Educativo" &&
                    x.TEtapasRangoEdad != null &&
                    x.TEtapasRangoEdad.Nombre == "Primaria" &&
                    x.TSubcategoriasMateria != null &&
                    x.TSubcategoriasMateria.Nombre == "Proyectos" &&
                    x.TCategoriasCiclo != null &&
                    x.TCategoriasCiclo.Nombre == "6º")
                .ToArray());

            var nameFile = $"..\\Migration\\Jerarquias.txt";
            if (File.Exists(nameFile))
                File.Delete(nameFile);

            using (var file = new StreamWriter(nameFile, false))
            {
                foreach (var jerarquia in listTotal)
                {
                    file.WriteLine($"{jerarquia.TPropietario.Nombre}\t" +
                                   $"{jerarquia.TMercado.Nombre}\t" +
                                   $"{jerarquia.TEtapasRangoEdad.Nombre}\t" +
                                   $"{jerarquia.TSubcategoriasMateria.Nombre}\t" +
                                   $"{jerarquia.TCategoriasCiclo.Nombre}\t" +
                                   $"{jerarquia.IdClasificacion}");
                }
            }

            Console.WriteLine("OK");
        }
    }
}

