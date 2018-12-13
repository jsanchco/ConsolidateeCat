namespace eCat.Repository.Mapped
{
    public class TProyectosIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TProyectosIdioma>
    {
        public TProyectosIdiomaConfiguration()
            : this("dbo")
        {
        }

        public TProyectosIdiomaConfiguration(string schema)
        {
            ToTable("T_Proyectos_Idioma", schema);
            HasKey(x => new { x.IdProyecto, x.IdIdiomaInterface });

            Property(x => x.IdProyecto).HasColumnName(@"IdProyecto").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            // Foreign keys
            HasRequired(a => a.TIdiomasPlataforma).WithMany(b => b.TProyectosIdiomas).HasForeignKey(c => c.IdIdiomaInterface).WillCascadeOnDelete(false); // FK_T_Proyectos_Idioma_T_Idiomas_Plataforma
        }
    }
}