namespace eCat.Repository.Mapped
{
    public class PeProyectosMarcoPreferenciasExplotacionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.PeProyectosMarcoPreferenciasExplotacion>
    {
        public PeProyectosMarcoPreferenciasExplotacionConfiguration()
            : this("dbo")
        {
        }

        public PeProyectosMarcoPreferenciasExplotacionConfiguration(string schema)
        {
            ToTable("PE_ProyectosMarco_PreferenciasExplotacion", schema);
            HasKey(x => x.IdProyectoMarco);

            Property(x => x.IdProyectoMarco).HasColumnName(@"IdProyectoMarco").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Color).HasColumnName(@"Color").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(6);

            // Foreign keys
            HasRequired(a => a.PeProyectosMarco).WithOptional(b => b.PeProyectosMarcoPreferenciasExplotacion).WillCascadeOnDelete(false); // FK_PE_Proyectos_PreferenciasExplotacion_PE_ProyectosMarco
        }
    }
}