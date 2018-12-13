namespace eCat.Repository.Mapped
{
    public class TSeriesConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TSeries>
    {
        public TSeriesConfiguration()
            : this("dbo")
        {
        }

        public TSeriesConfiguration(string schema)
        {
            ToTable("T_Series", schema);
            HasKey(x => x.IdSerie);

            Property(x => x.IdSerie).HasColumnName(@"IdSerie").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdColeccion).HasColumnName(@"IdColeccion").HasColumnType("int").IsOptional();
            Property(x => x.Nombre).HasColumnName(@"Nombre").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);
            Property(x => x.Orden).HasColumnName(@"Orden").HasColumnType("tinyint").IsOptional();

            // Foreign keys
            HasOptional(a => a.TColeccione).WithMany(b => b.TSeries).HasForeignKey(c => c.IdColeccion).WillCascadeOnDelete(false); // FK_T_Series_T_Colecciones
        }
    }
}