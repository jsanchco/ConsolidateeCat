namespace eCat.Repository.Mapped
{
    public class DilveTerritorioConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.DilveTerritorio>
    {
        public DilveTerritorioConfiguration()
            : this("dbo")
        {
        }

        public DilveTerritorioConfiguration(string schema)
        {
            ToTable("DILVE_Territorios", schema);
            HasKey(x => x.IdTerritorioDilve);

            Property(x => x.IdTerritorioDilve).HasColumnName(@"IdTerritorioDILVE").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CodigoTerritorioDilve).HasColumnName(@"CodigoTerritorioDILVE").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(128);
        }
    }
}