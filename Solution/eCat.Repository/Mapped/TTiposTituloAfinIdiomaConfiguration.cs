namespace eCat.Repository.Mapped
{
    public class TTiposTituloAfinIdiomaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TTiposTituloAfinIdioma>
    {
        public TTiposTituloAfinIdiomaConfiguration()
            : this("dbo")
        {
        }

        public TTiposTituloAfinIdiomaConfiguration(string schema)
        {
            ToTable("T_TiposTituloAfin_Idioma", schema);
            HasKey(x => new { x.IdTipoTituloAfin, x.IdIdiomaInterface });

            Property(x => x.IdTipoTituloAfin).HasColumnName(@"IdTipoTituloAfin").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdIdiomaInterface).HasColumnName(@"IdIdiomaInterface").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valor).HasColumnName(@"Valor").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(255);

            // Foreign keys
            HasRequired(a => a.TIdiomasPlataforma).WithMany(b => b.TTiposTituloAfinIdiomas).HasForeignKey(c => c.IdIdiomaInterface).WillCascadeOnDelete(false); // FK_T_TiposTituloAfin_Idioma_T_Idiomas_Plataforma
            HasRequired(a => a.TTiposTituloAfin).WithMany(b => b.TTiposTituloAfinIdiomas).HasForeignKey(c => c.IdTipoTituloAfin).WillCascadeOnDelete(false); // FK_T_TiposTituloAfin_Idioma_T_TiposTituloAfin
        }
    }
}