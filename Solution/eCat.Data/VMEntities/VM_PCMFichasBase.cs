namespace eCat.Data.VMEntities
{
    #region Using

    using Entities;

    #endregion

    // ReSharper disable once InconsistentNaming    
    public class VM_PCMFichasBase
    {
        public string Codigo { get; set; }
        public short? Pais { get; set; }
        public byte? LineaDeNegocio { get; set; }
        public string TituloeCat { get; set; }
        public string TituloDistribuidora { get; set; }
        public string Subtitulo { get; set; }
        public int? Coeditorial { get; set; }
        public byte? LenguaPrincipal { get; set; }
        public string LenguasSecundarias { get; set; }
        public string Rol { get; set; }
        public string Persona { get; set; }

        public VM_PCMFichasBase()
        {

        }

        public VM_PCMFichasBase(FichasBase fichasBase)
        {
            Codigo = fichasBase.IdInterno;
            Pais = fichasBase.IdPais;
            LineaDeNegocio = fichasBase.IdLineaNegocio;
            TituloeCat = fichasBase.Titulo;
            TituloDistribuidora = fichasBase.TituloDistribuidora;
            Subtitulo = fichasBase.Subtitulo;
            Coeditorial = fichasBase.Coeditorial;
            LenguaPrincipal = fichasBase.Idioma;

            foreach (var item in fichasBase.FichasBaseIdiomasSecundarios)
            {
                LenguasSecundarias += $"{item.IdIdioma},";
            }
            if (!string.IsNullOrEmpty(LenguasSecundarias))
                LenguasSecundarias = LenguasSecundarias.Substring(0, LenguasSecundarias.Length - 1);

            foreach (var item in fichasBase.RelFichasPersonas)
            {
                Rol += $"{item.IdRol},";
            }
            if (!string.IsNullOrEmpty(Rol))
                Rol = Rol.Substring(0, Rol.Length - 1);


        }

        public string ToCSV()
        {
            var lineCSV = $"{Codigo};";

            lineCSV += $"{Pais};";
            lineCSV += $"{LineaDeNegocio};";
            lineCSV += $"{TituloeCat};";
            lineCSV += $"{TituloDistribuidora};";
            lineCSV += $"{Subtitulo};";
            lineCSV += $"{Coeditorial};";
            lineCSV += $"{LenguaPrincipal};";
            lineCSV += $"{LenguasSecundarias};";
            lineCSV += $"{Rol};";
            lineCSV += $"{Persona};";

            return lineCSV;
        }
    }
}
