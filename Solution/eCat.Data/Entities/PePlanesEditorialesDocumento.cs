namespace eCat.Data.Entities
{
    public class PePlanesEditorialesDocumento
    {
        public int IdPlanEditorial { get; set; } // IdPlanEditorial (Primary key)
        public long IdDocumento { get; set; } // IdDocumento (Primary key)
        public bool Principal { get; set; } // Principal

        // Foreign keys

        /// <summary>
        /// Parent PeDocumento pointed by [PE_PlanesEditoriales_Documentos].([IdDocumento]) (FK_PE_PlanesEditoriales_Documentos_PE_Documentos)
        /// </summary>
        public virtual PeDocumento PeDocumento { get; set; } // FK_PE_PlanesEditoriales_Documentos_PE_Documentos

        /// <summary>
        /// Parent PePlanesEditoriale pointed by [PE_PlanesEditoriales_Documentos].([IdPlanEditorial]) (FK_PE_PlanesEditoriales_Documentos_PE_PlanesEditoriales)
        /// </summary>
        public virtual PePlanesEditoriale PePlanesEditoriale { get; set; } // FK_PE_PlanesEditoriales_Documentos_PE_PlanesEditoriales

        public PePlanesEditorialesDocumento()
        {
            Principal = false;
        }
    }
}