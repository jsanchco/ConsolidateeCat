namespace eCat.Data.Entities
{
    public class PublicoObjetivo
    {
        public int IdPublicoObjetivo { get; set; } // IDPublicoObjetivo (Primary key)
        public string PublicoObjetivo_ { get; set; } // PublicoObjetivo (length: 50)
        public string IdAplicacion { get; set; } // IDAplicacion (length: 5)

        // Reverse navigation

        /// <summary>
        /// Child RelFrasesDescriptivas where [RelFrasesDescriptivas].[IDPublicoObjetivo] point to this entity (FK_RelFrasesDescriptivas_PublicoObjetivo)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<RelFrasesDescriptiva> RelFrasesDescriptivas { get; set; } // RelFrasesDescriptivas.FK_RelFrasesDescriptivas_PublicoObjetivo

        // Foreign keys

        /// <summary>
        /// Parent Aplicacione pointed by [PublicoObjetivo].([IdAplicacion]) (FK_PublicoObjetivo_Aplicaciones)
        /// </summary>
        public virtual Aplicacione Aplicacione { get; set; } // FK_PublicoObjetivo_Aplicaciones

        public PublicoObjetivo()
        {
            RelFrasesDescriptivas = new System.Collections.Generic.List<RelFrasesDescriptiva>();
        }
    }
}