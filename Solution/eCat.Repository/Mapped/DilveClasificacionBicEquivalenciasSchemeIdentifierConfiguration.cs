namespace eCat.Repository.Mapped
{
    public class DilveClasificacionBicEquivalenciasSchemeIdentifierConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.DilveClasificacionBicEquivalenciasSchemeIdentifier>
    {
        public DilveClasificacionBicEquivalenciasSchemeIdentifierConfiguration()
            : this("dbo")
        {
        }

        public DilveClasificacionBicEquivalenciasSchemeIdentifierConfiguration(string schema)
        {
            ToTable("DILVE_ClasificacionBIC_Equivalencias_SchemeIdentifier", schema);
            HasKey(x => x.IdClasificacionBic);

            Property(x => x.IdClasificacionBic).HasColumnName(@"IdClasificacionBIC").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.SchemeIdentifier).HasColumnName(@"SchemeIdentifier").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);

            // Foreign keys
            HasRequired(a => a.ClasificacionEci).WithOptional(b => b.DilveClasificacionBicEquivalenciasSchemeIdentifier).WillCascadeOnDelete(false); // FK_DILVE_ClasificacionBIC_Equivalencias_SchemeIdentifier_Clasificacion_ECI
        }
    }
}