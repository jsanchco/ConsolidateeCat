namespace eCat.Repository.Mapped
{
    public class TProyectosGestionIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TProyectosGestionIdioma>
    {
        public TProyectosGestionIdiomaConfiguration()
            : this("dbo")
        {
        }

        public TProyectosGestionIdiomaConfiguration(string schema)
        {
            ToTable("T_ProyectosGestion_Idioma", schema);
            HasKey(x => new { x.IdProyectoGestion, x.IdIdiomainterface });

            Property(x => x.IdProyectoGestion).HasColumnName(@"IdProyectoGestion").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
            Property(x => x.IdIdiomainterface).HasColumnName(@"IdIdiomainterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            // Foreign keys
            HasRequired(a => a.TIdiomasPlataforma).WithMany(b => b.TProyectosGestionIdiomas).HasForeignKey(c => c.IdIdiomainterface).WillCascadeOnDelete(false); // FK_T_ProyectosGestion_Idioma_T_Idiomas_Plataforma
            HasRequired(a => a.TProyectosGestion).WithMany(b => b.TProyectosGestionIdiomas).HasForeignKey(c => c.IdProyectoGestion).WillCascadeOnDelete(false); // FK_T_ProyectosGestion_Idioma_T_ProyectosGestion
        }
    }
}