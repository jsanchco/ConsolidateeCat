namespace eCat.Repository.Mapped
{
    public class TPlanEditorialNiveleConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TPlanEditorialNivele>
    {
        public TPlanEditorialNiveleConfiguration()
            : this("dbo")
        {
        }

        public TPlanEditorialNiveleConfiguration(string schema)
        {
            ToTable("T_PlanEditorial_Niveles", schema);
            HasKey(x => x.IdNivel);

            Property(x => x.IdNivel).HasColumnName(@"IdNivel").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdCampaña).HasColumnName(@"IdCampaña").HasColumnType("int").IsRequired();
            Property(x => x.Nombre).HasColumnName(@"Nombre").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
            Property(x => x.Orden).HasColumnName(@"Orden").HasColumnType("int").IsRequired();
        }
    }
}