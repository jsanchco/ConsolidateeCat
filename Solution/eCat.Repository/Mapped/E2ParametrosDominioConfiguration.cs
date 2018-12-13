namespace eCat.Repository.Mapped
{
    public class E2ParametrosDominioConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.E2ParametrosDominio>
    {
        public E2ParametrosDominioConfiguration()
            : this("dbo")
        {
        }

        public E2ParametrosDominioConfiguration(string schema)
        {
            ToTable("E2_PARAMETROS_DOMINIO", schema);
            HasKey(x => new { x.Dominio, x.Parametro });

            Property(x => x.Dominio).HasColumnName(@"Dominio").HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Parametro).HasColumnName(@"Parametro").HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("nvarchar").IsRequired().HasMaxLength(200);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(1000);

            // Foreign keys
            HasRequired(a => a.Parametro_Parametro).WithMany(b => b.E2ParametrosDominio).HasForeignKey(c => c.Parametro).WillCascadeOnDelete(false); // FK_E2_PARAMETROS_DOMINIO_Parametros
        }
    }
}