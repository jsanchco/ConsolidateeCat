namespace eCat.Repository.Mapped
{
    public class TMaterialesreferenciaTiposIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TMaterialesreferenciaTiposIdioma>
    {
        public TMaterialesreferenciaTiposIdiomaConfiguration()
            : this("dbo")
        {
        }

        public TMaterialesreferenciaTiposIdiomaConfiguration(string schema)
        {
            ToTable("T_Materialesreferencia_Tipos_Idioma", schema);
            HasKey(x => new { x.IdTipoMaterialReferencia, x.IdIdiomaInterface });

            Property(x => x.IdTipoMaterialReferencia).HasColumnName(@"IdTipoMaterialReferencia").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);

            // Foreign keys
            HasRequired(a => a.TIdiomasPlataforma).WithMany(b => b.TMaterialesreferenciaTiposIdiomas).HasForeignKey(c => c.IdIdiomaInterface).WillCascadeOnDelete(false); // FK_T_Materialesreferencia_Tipos_Idioma_T_Idiomas_Plataforma
            HasRequired(a => a.TMaterialesReferenciaTipos).WithMany(b => b.TMaterialesreferenciaTiposIdiomas).HasForeignKey(c => c.IdTipoMaterialReferencia).WillCascadeOnDelete(false); // FK_T_Materialesreferencia_Tipos_Idioma_T_MaterialesReferencia_Tipos
        }
    }
}