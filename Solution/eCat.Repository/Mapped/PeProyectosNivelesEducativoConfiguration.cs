namespace eCat.Repository.Mapped
{
    public class PeProyectosNivelesEducativoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.PeProyectosNivelesEducativo>
    {
        public PeProyectosNivelesEducativoConfiguration()
            : this("dbo")
        {
        }

        public PeProyectosNivelesEducativoConfiguration(string schema)
        {
            ToTable("PE_Proyectos_NivelesEducativos", schema);
            HasKey(x => new { x.IdProyecto, x.IdEstructura, x.CodEdad });

            Property(x => x.IdProyecto).HasColumnName(@"IdProyecto").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdEstructura).HasColumnName(@"IdEstructura").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CodEdad).HasColumnName(@"CodEdad").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            // Foreign keys
            HasRequired(a => a.PeEstructuraEdadesNivelesEducativo).WithMany(b => b.PeProyectosNivelesEducativoes).HasForeignKey(c => new { c.IdEstructura, c.CodEdad }).WillCascadeOnDelete(false); // FK_PE_Proyectos_NivelesEducativos_PE_EstructuraEdades_NivelesEducativos
            HasRequired(a => a.PeProyecto).WithMany(b => b.PeProyectosNivelesEducativoes).HasForeignKey(c => c.IdProyecto).WillCascadeOnDelete(false); // FK_PE_Proyectos_NivelesEducativos_PE_Proyectos
        }
    }
}