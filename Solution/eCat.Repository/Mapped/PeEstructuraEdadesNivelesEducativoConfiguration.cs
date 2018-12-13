namespace eCat.Repository.Mapped
{
    public class PeEstructuraEdadesNivelesEducativoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.PeEstructuraEdadesNivelesEducativo>
    {
        public PeEstructuraEdadesNivelesEducativoConfiguration()
            : this("dbo")
        {
        }

        public PeEstructuraEdadesNivelesEducativoConfiguration(string schema)
        {
            ToTable("PE_EstructuraEdades_NivelesEducativos", schema);
            HasKey(x => new { x.IdEstructura, x.CodEdad });

            Property(x => x.IdEstructura).HasColumnName(@"IdEstructura").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CodEdad).HasColumnName(@"CodEdad").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CodEtapa).HasColumnName(@"CodEtapa").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5);
            Property(x => x.CodCiclo).HasColumnName(@"CodCiclo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5);
            Property(x => x.CodCurso).HasColumnName(@"CodCurso").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5);
            Property(x => x.FechaAlta).HasColumnName(@"FechaAlta").HasColumnType("datetime").IsRequired();
            Property(x => x.FechaUltimaModificacion).HasColumnName(@"FechaUltimaModificacion").HasColumnType("datetime").IsOptional();

            // Foreign keys
            HasRequired(a => a.PeEstructuraEdade).WithMany(b => b.PeEstructuraEdadesNivelesEducativoes).HasForeignKey(c => c.IdEstructura).WillCascadeOnDelete(false); // FK_PE_Edades_NivelesEducativos_PE_Edades
            HasRequired(a => a.TCategoriasCiclo).WithMany(b => b.PeEstructuraEdadesNivelesEducativoes).HasForeignKey(c => c.CodCiclo).WillCascadeOnDelete(false); // FK_PE_Edades_NivelesEducativos_T_CategoriasCiclos
            HasRequired(a => a.TEdadCurso_CodCurso).WithMany(b => b.PeEstructuraEdadesNivelesEducativoes_CodCurso).HasForeignKey(c => c.CodCurso).WillCascadeOnDelete(false); // FK_PE_Edades_NivelesEducativos_T_EdadCurso1
            HasRequired(a => a.TEdadCurso_CodEdad).WithMany(b => b.PeEstructuraEdadesNivelesEducativoes_CodEdad).HasForeignKey(c => c.CodEdad).WillCascadeOnDelete(false); // FK_PE_Edades_NivelesEducativos_T_EdadCurso
            HasRequired(a => a.TEtapasRangoEdad).WithMany(b => b.PeEstructuraEdadesNivelesEducativoes).HasForeignKey(c => c.CodEtapa).WillCascadeOnDelete(false); // FK_PE_Edades_NivelesEducativos_T_EtapasRangoEdad
        }
    }
}