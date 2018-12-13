namespace eCat.Repository.Mapped
{
    public class DilvePaisConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.DilvePais>
    {
        public DilvePaisConfiguration()
            : this("dbo")
        {
        }

        public DilvePaisConfiguration(string schema)
        {
            ToTable("DILVE_Paises", schema);
            HasKey(x => x.IdPaisDilve);

            Property(x => x.IdPaisDilve).HasColumnName(@"IdPaisDILVE").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CodigoPaisDilve).HasColumnName(@"CodigoPaisDILVE").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("nvarchar").IsRequired().HasMaxLength(128);
        }
    }
}