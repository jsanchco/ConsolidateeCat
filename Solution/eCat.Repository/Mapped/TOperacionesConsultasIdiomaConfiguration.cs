namespace eCat.Repository.Mapped
{
    public class TOperacionesConsultasIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TOperacionesConsultasIdioma>
    {
        public TOperacionesConsultasIdiomaConfiguration()
            : this("dbo")
        {
        }

        public TOperacionesConsultasIdiomaConfiguration(string schema)
        {
            ToTable("T_OperacionesConsultas_Idioma", schema);
            HasKey(x => new { x.IdOperacion, x.IdIdiomaInterface });

            Property(x => x.IdOperacion).HasColumnName(@"IdOperacion").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);

            // Foreign keys
            HasRequired(a => a.TIdiomasPlataforma).WithMany(b => b.TOperacionesConsultasIdiomas).HasForeignKey(c => c.IdIdiomaInterface).WillCascadeOnDelete(false); // FK_T_OperacionesConsultas_Idioma_T_Idiomas_Plataforma
            HasRequired(a => a.TOperacionesConsulta).WithMany(b => b.TOperacionesConsultasIdiomas).HasForeignKey(c => c.IdOperacion).WillCascadeOnDelete(false); // FK_T_OperacionesConsultas_Idioma_T_OperacionesConsultas
        }
    }
}