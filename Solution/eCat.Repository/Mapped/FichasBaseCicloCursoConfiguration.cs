namespace eCat.Repository.Mapped
{
    public class FichasBaseCicloCursoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.FichasBaseCicloCurso>
    {
        public FichasBaseCicloCursoConfiguration()
            : this("dbo")
        {
        }

        public FichasBaseCicloCursoConfiguration(string schema)
        {
            ToTable("FichasBase_CicloCurso", schema);
            HasKey(x => new { x.IdInterno, x.IdCiclo, x.IdCurso });

            Property(x => x.IdInterno).HasColumnName(@"IdInterno").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdCiclo).HasColumnName(@"IdCiclo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdCurso).HasColumnName(@"IdCurso").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Orden).HasColumnName(@"Orden").HasColumnType("tinyint").IsRequired();

            // Foreign keys
            HasRequired(a => a.FichasBase).WithMany(b => b.FichasBaseCicloCursoes).HasForeignKey(c => c.IdInterno).WillCascadeOnDelete(false); // FK_FichasBase_CicloCurso_FichasBase
            HasRequired(a => a.TCategoriasCiclo).WithMany(b => b.FichasBaseCicloCursoes).HasForeignKey(c => c.IdCiclo).WillCascadeOnDelete(false); // FK_FichasBase_CicloCurso_T_CategoriasCiclos
            HasRequired(a => a.TEdadCurso).WithMany(b => b.FichasBaseCicloCursoes).HasForeignKey(c => c.IdCurso).WillCascadeOnDelete(false); // FK_FichasBase_CicloCurso_T_EdadCurso
        }
    }
}