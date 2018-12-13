namespace eCat.Repository.Mapped
{
    public class TTiposConsultasIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TTiposConsultasIdioma>
    {
        public TTiposConsultasIdiomaConfiguration()
            : this("dbo")
        {
        }

        public TTiposConsultasIdiomaConfiguration(string schema)
        {
            ToTable("T_TiposConsultas_Idioma", schema);
            HasKey(x => new { x.IdTipoConsulta, x.IdIdiomaInterface });

            Property(x => x.IdTipoConsulta).HasColumnName(@"IdTipoConsulta").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);

            // Foreign keys
            HasRequired(a => a.TIdiomasPlataforma).WithMany(b => b.TTiposConsultasIdiomas).HasForeignKey(c => c.IdIdiomaInterface).WillCascadeOnDelete(false); // FK_T_TiposConsultas_Idioma_T_Idiomas_Plataforma
            HasRequired(a => a.TTiposConsulta).WithMany(b => b.TTiposConsultasIdiomas).HasForeignKey(c => c.IdTipoConsulta).WillCascadeOnDelete(false); // FK_T_TiposConsultas_Idioma_T_TiposConsultas
        }
    }
}