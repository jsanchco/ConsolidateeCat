namespace eCat.Repository.Mapped
{
    public class PeProyectosEstadosIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.PeProyectosEstadosIdioma>
    {
        public PeProyectosEstadosIdiomaConfiguration()
            : this("dbo")
        {
        }

        public PeProyectosEstadosIdiomaConfiguration(string schema)
        {
            ToTable("PE_Proyectos_Estados_Idioma", schema);
            HasKey(x => x.IdEstado);

            Property(x => x.IdEstado).HasColumnName(@"IdEstado").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired();
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);

            // Foreign keys
            HasRequired(a => a.PeProyectosEstado).WithOptional(b => b.PeProyectosEstadosIdioma).WillCascadeOnDelete(false); // FK_PE_Proyectos_Estados_Idioma_PE_Proyectos_Estados
            HasRequired(a => a.TIdiomasPlataforma).WithMany(b => b.PeProyectosEstadosIdiomas).HasForeignKey(c => c.IdIdiomaInterface).WillCascadeOnDelete(false); // FK_PE_Proyectos_Estados_Idioma_T_Idiomas_Plataforma
        }
    }
}