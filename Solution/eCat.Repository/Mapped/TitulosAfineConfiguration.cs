namespace eCat.Repository.Mapped
{
    public class TitulosAfineConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TitulosAfine>
    {
        public TitulosAfineConfiguration()
            : this("dbo")
        {
        }

        public TitulosAfineConfiguration(string schema)
        {
            ToTable("TitulosAfines", schema);
            HasKey(x => new { x.IdInterno, x.IdObraAfin, x.IdTipoTituloAfin });

            Property(x => x.IdInterno).HasColumnName(@"IDInterno").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Orden).HasColumnName(@"Orden").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdObraAfin).HasColumnName(@"IDObraAfin").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdTipoTituloAfin).HasColumnName(@"IdTipoTituloAfin").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            // Foreign keys
            HasRequired(a => a.FichasBase).WithMany(b => b.TitulosAfines).HasForeignKey(c => c.IdInterno).WillCascadeOnDelete(false); // FK_TitulosAfines_FichasBase
            HasRequired(a => a.TTiposTituloAfin).WithMany(b => b.TitulosAfines).HasForeignKey(c => c.IdTipoTituloAfin).WillCascadeOnDelete(false); // FK_TitulosAfines_T_TiposTituloAfin
        }
    }
}