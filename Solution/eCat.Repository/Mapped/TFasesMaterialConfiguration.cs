namespace eCat.Repository.Mapped
{
    public class TFasesMaterialConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TFasesMaterial>
    {
        public TFasesMaterialConfiguration()
            : this("dbo")
        {
        }

        public TFasesMaterialConfiguration(string schema)
        {
            ToTable("T_FasesMaterial", schema);
            HasKey(x => x.IdFase);

            Property(x => x.IdFase).HasColumnName(@"IdFase").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Fase).HasColumnName(@"Fase").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
        }
    }
}