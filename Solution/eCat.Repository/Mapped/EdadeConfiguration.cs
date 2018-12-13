namespace eCat.Repository.Mapped
{
    public class EdadeConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.Edade>
    {
        public EdadeConfiguration()
            : this("dbo")
        {
        }

        public EdadeConfiguration(string schema)
        {
            ToTable("Edades", schema);
            HasKey(x => x.IdEdad);

            Property(x => x.IdEdad).HasColumnName(@"IdEdad").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Numero).HasColumnName(@"Numero").HasColumnType("int").IsRequired();
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(64);
            Property(x => x.Desde).HasColumnName(@"Desde").HasColumnType("tinyint").IsRequired();
            Property(x => x.Hasta).HasColumnName(@"Hasta").HasColumnType("tinyint").IsRequired();
        }
    }
}