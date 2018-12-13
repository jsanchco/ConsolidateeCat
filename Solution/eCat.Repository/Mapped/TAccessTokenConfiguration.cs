namespace eCat.Repository.Mapped
{
    public class TAccessTokenConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TAccessToken>
    {
        public TAccessTokenConfiguration()
            : this("dbo")
        {
        }

        public TAccessTokenConfiguration(string schema)
        {
            ToTable("T_Access_Token", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.TokenId).HasColumnName(@"TokenId").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.Usuario).HasColumnName(@"Usuario").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Origen).HasColumnName(@"Origen").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1000);
            Property(x => x.Validez).HasColumnName(@"Validez").HasColumnType("int").IsRequired();
            Property(x => x.FechaCreacion).HasColumnName(@"FechaCreacion").HasColumnType("datetime").IsRequired();
            Property(x => x.Parametros).HasColumnName(@"Parametros").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
        }
    }
}