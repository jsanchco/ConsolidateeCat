namespace eCat.Repository.Mapped
{
    public class ConsultassqlConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.Consultassql>
    {
        public ConsultassqlConfiguration()
            : this("dbo")
        {
        }

        public ConsultassqlConfiguration(string schema)
        {
            ToTable("consultassql", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"id").HasColumnType("nvarchar").IsRequired().HasMaxLength(5).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Descripcion).HasColumnName(@"descripcion").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.Consulta).HasColumnName(@"consulta").HasColumnType("nvarchar(max)").IsRequired();
        }
    }
}