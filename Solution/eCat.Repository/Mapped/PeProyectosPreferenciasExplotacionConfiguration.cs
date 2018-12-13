namespace eCat.Repository.Mapped
{
    public class PeProyectosPreferenciasExplotacionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.PeProyectosPreferenciasExplotacion>
    {
        public PeProyectosPreferenciasExplotacionConfiguration()
            : this("dbo")
        {
        }

        public PeProyectosPreferenciasExplotacionConfiguration(string schema)
        {
            ToTable("PE_Proyectos_PreferenciasExplotacion", schema);
            HasKey(x => x.IdProyecto);

            Property(x => x.IdProyecto).HasColumnName(@"IdProyecto").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Color).HasColumnName(@"Color").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(6);

            // Foreign keys
            HasRequired(a => a.PeProyecto).WithOptional(b => b.PeProyectosPreferenciasExplotacion).WillCascadeOnDelete(false); // FK_PE_Proyectos_PreferenciasExplotacion_PE_Proyectos
        }
    }
}