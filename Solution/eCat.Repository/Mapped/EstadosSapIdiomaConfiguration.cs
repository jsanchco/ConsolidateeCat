namespace eCat.Repository.Mapped
{
    public class EstadosSapIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.EstadosSapIdioma>
    {
        public EstadosSapIdiomaConfiguration()
            : this("dbo")
        {
        }

        public EstadosSapIdiomaConfiguration(string schema)
        {
            ToTable("EstadosSAP_Idioma", schema);
            HasKey(x => new { x.IdEstadoSap, x.IdidiomaInterface });

            Property(x => x.IdEstadoSap).HasColumnName(@"IDEstadoSAP").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdidiomaInterface).HasColumnName(@"IdidiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);

            // Foreign keys
            HasRequired(a => a.EstadosSap).WithMany(b => b.EstadosSapIdiomas).HasForeignKey(c => c.IdEstadoSap).WillCascadeOnDelete(false); // FK_EstadosSAP_Idioma_EstadosSAP
            HasRequired(a => a.TIdiomasPlataforma).WithMany(b => b.EstadosSapIdiomas).HasForeignKey(c => c.IdidiomaInterface).WillCascadeOnDelete(false); // FK_EstadosSAP_Idioma_T_Idiomas_Plataforma
        }
    }
}