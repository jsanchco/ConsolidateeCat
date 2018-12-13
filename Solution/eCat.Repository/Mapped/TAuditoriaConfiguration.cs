namespace eCat.Repository.Mapped
{
    public class TAuditoriaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TAuditoria>
    {
        public TAuditoriaConfiguration()
            : this("dbo")
        {
        }

        public TAuditoriaConfiguration(string schema)
        {
            ToTable("T_Auditoria", schema);
            HasKey(x => x.IdAuditoria);

            Property(x => x.IdAuditoria).HasColumnName(@"IdAuditoria").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdInterno).HasColumnName(@"IdInterno").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12);
            Property(x => x.Usuario).HasColumnName(@"Usuario").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Fecha).HasColumnName(@"Fecha").HasColumnType("datetime").IsRequired();
            Property(x => x.Modificacion).HasColumnName(@"Modificacion").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
        }
    }
}