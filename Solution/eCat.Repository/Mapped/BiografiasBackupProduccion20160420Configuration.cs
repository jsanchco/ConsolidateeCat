namespace eCat.Repository.Mapped
{
    public class BiografiasBackupProduccion20160420Configuration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.BiografiasBackupProduccion20160420>
    {
        public BiografiasBackupProduccion20160420Configuration()
            : this("dbo")
        {
        }

        public BiografiasBackupProduccion20160420Configuration(string schema)
        {
            ToTable("__Biografias_Backup_Produccion_20160420", schema);
            HasKey(x => x.IdPersona);

            Property(x => x.IdPersona).HasColumnName(@"IDPersona").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Foto).HasColumnName(@"Foto").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(128);
            Property(x => x.Sinopsis).HasColumnName(@"Sinopsis").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.Comentarios).HasColumnName(@"Comentarios").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
        }
    }
}