namespace eCat.Repository.Mapped
{
    public class TPlanEditorialSubNiveleConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TPlanEditorialSubNivele>
    {
        public TPlanEditorialSubNiveleConfiguration()
            : this("dbo")
        {
        }

        public TPlanEditorialSubNiveleConfiguration(string schema)
        {
            ToTable("T_PlanEditorial_SubNiveles", schema);
            HasKey(x => x.IdSubNivel);

            Property(x => x.IdSubNivel).HasColumnName(@"IdSubNivel").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdNivel).HasColumnName(@"IdNivel").HasColumnType("bigint").IsRequired();
            Property(x => x.Nombre).HasColumnName(@"Nombre").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
            Property(x => x.Orden).HasColumnName(@"Orden").HasColumnType("int").IsRequired();
        }
    }
}