namespace eCat.Repository.Mapped
{
    public class TTiposTituloAfinConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TTiposTituloAfin>
    {
        public TTiposTituloAfinConfiguration()
            : this("dbo")
        {
        }

        public TTiposTituloAfinConfiguration(string schema)
        {
            ToTable("T_TiposTituloAfin", schema);
            HasKey(x => x.IdTipoTituloAfin);

            Property(x => x.IdTipoTituloAfin).HasColumnName(@"IdTipoTituloAfin").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.TipoTituloAfin).HasColumnName(@"TipoTituloAfin").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);
        }
    }
}