namespace eCat.Repository.Mapped
{
    public class E2CamposConsultaIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2CamposConsultaIdioma>
    {
        public E2CamposConsultaIdiomaConfiguration()
            : this("dbo")
        {
        }

        public E2CamposConsultaIdiomaConfiguration(string schema)
        {
            ToTable("E2_CAMPOS_CONSULTA_Idioma", schema);
            HasKey(x => new { x.CodCampo, x.IdIdiomaInterface });

            Property(x => x.CodCampo).HasColumnName(@"COD_CAMPO").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);

            // Foreign keys
            HasRequired(a => a.E2CamposConsulta).WithMany(b => b.E2CamposConsultaIdioma).HasForeignKey(c => c.CodCampo).WillCascadeOnDelete(false); // FK_E2_CAMPOS_CONSULTA_Idioma_E2_CAMPOS_CONSULTA
            HasRequired(a => a.TIdiomasPlataforma).WithMany(b => b.E2CamposConsultaIdioma).HasForeignKey(c => c.IdIdiomaInterface).WillCascadeOnDelete(false); // FK_E2_CAMPOS_CONSULTA_Idioma_T_Idiomas_Plataforma
        }
    }
}