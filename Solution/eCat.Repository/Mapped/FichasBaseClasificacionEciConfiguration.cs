namespace eCat.Repository.Mapped
{
    public class FichasBaseClasificacionEciConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.FichasBaseClasificacionEci>
    {
        public FichasBaseClasificacionEciConfiguration()
            : this("dbo")
        {
        }

        public FichasBaseClasificacionEciConfiguration(string schema)
        {
            ToTable("FichasBase_ClasificacionECI", schema);
            HasKey(x => new { x.IdInterno, x.IdcLasificacionEci });

            Property(x => x.IdInterno).HasColumnName(@"IDInterno").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdcLasificacionEci).HasColumnName(@"IDCLasificacionECI").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Clasificacion).HasColumnName(@"Clasificacion").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.IdFichasBaseClasificacionEci).HasColumnName(@"IdFichasBaseClasificacionECI").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            // Foreign keys
            HasRequired(a => a.ClasificacionEci).WithMany(b => b.FichasBaseClasificacionEcis).HasForeignKey(c => c.IdcLasificacionEci).WillCascadeOnDelete(false); // FK_FichasBase_ClasificacionECI_Clasificacion_ECI
            HasRequired(a => a.FichasBase).WithMany(b => b.FichasBaseClasificacionEcis).HasForeignKey(c => c.IdInterno).WillCascadeOnDelete(false); // FK_FichasBase_ClasificacionECI_FichasBase
        }
    }
}