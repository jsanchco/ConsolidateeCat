namespace eCat.Repository.Mapped
{
    public class FichasBaseCodigoCduConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.FichasBaseCodigoCdu>
    {
        public FichasBaseCodigoCduConfiguration()
            : this("dbo")
        {
        }

        public FichasBaseCodigoCduConfiguration(string schema)
        {
            ToTable("FichasBase_CodigoCDU", schema);
            HasKey(x => new { x.IdInterno, x.IdCodigoCdu });

            Property(x => x.IdInterno).HasColumnName(@"IDInterno").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdCodigoCdu).HasColumnName(@"IDCodigoCDU").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Clasificacion).HasColumnName(@"Clasificacion").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.IdFichasBaseCodigoCdu).HasColumnName(@"IdFichasBaseCodigoCDU").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            // Foreign keys
            HasRequired(a => a.CodigoCdu).WithMany(b => b.FichasBaseCodigoCdus).HasForeignKey(c => c.IdCodigoCdu).WillCascadeOnDelete(false); // FK_FichasBase_CodigoCDU_Codigo_CDU
            HasRequired(a => a.FichasBase).WithMany(b => b.FichasBaseCodigoCdus).HasForeignKey(c => c.IdInterno).WillCascadeOnDelete(false); // FK_FichasBase_CodigoCDU_FichasBase
        }
    }
}