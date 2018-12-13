namespace eCat.Repository.Mapped
{
    public class FichasAplicacionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.FichasAplicacion>
    {
        public FichasAplicacionConfiguration()
            : this("dbo")
        {
        }

        public FichasAplicacionConfiguration(string schema)
        {
            ToTable("FichasAplicacion", schema);
            HasKey(x => new { x.IdInterno, x.IdAplicacion });

            Property(x => x.IdInterno).HasColumnName(@"IDInterno").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdAplicacion).HasColumnName(@"IDAplicacion").HasColumnType("nvarchar").IsRequired().HasMaxLength(5).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Sinopsis).HasColumnName(@"Sinopsis").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Resumen).HasColumnName(@"Resumen").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Indice).HasColumnName(@"Indice").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Caracteristicas).HasColumnName(@"Caracteristicas").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.MaterialComunicacion).HasColumnName(@"MaterialComunicacion").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.InformacionAdicional).HasColumnName(@"InformacionAdicional").HasColumnType("nvarchar(max)").IsOptional();

            // Foreign keys
            HasRequired(a => a.Aplicacione).WithMany(b => b.FichasAplicacions).HasForeignKey(c => c.IdAplicacion).WillCascadeOnDelete(false); // FK_FichasAplicacion_Aplicaciones
            HasRequired(a => a.FichasBase).WithMany(b => b.FichasAplicacions).HasForeignKey(c => c.IdInterno).WillCascadeOnDelete(false); // FK_FichasAplicacion_FichasBase
        }
    }
}