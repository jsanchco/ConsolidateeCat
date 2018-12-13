namespace eCat.Repository.Mapped
{
    public class PeAreasGlobalesMateriaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.PeAreasGlobalesMateria>
    {
        public PeAreasGlobalesMateriaConfiguration()
            : this("dbo")
        {
        }

        public PeAreasGlobalesMateriaConfiguration(string schema)
        {
            ToTable("PE_AreasGlobales_Materias", schema);
            HasKey(x => new { x.IdAreaGlobal, x.CodMateria });

            Property(x => x.IdAreaGlobal).HasColumnName(@"IdAreaGlobal").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CodMateria).HasColumnName(@"CodMateria").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Baja).HasColumnName(@"Baja").HasColumnType("bit").IsRequired();

            // Foreign keys
            HasRequired(a => a.PeAreasGlobale).WithMany(b => b.PeAreasGlobalesMaterias).HasForeignKey(c => c.IdAreaGlobal).WillCascadeOnDelete(false); // FK_PE_AreasGlobales_Materias_PE_AreasGlobales
            HasRequired(a => a.TSubcategoriasMateria).WithMany(b => b.PeAreasGlobalesMaterias).HasForeignKey(c => c.CodMateria).WillCascadeOnDelete(false); // FK_PE_AreasGlobales_Materias_T_SubcategoriasMaterias
        }
    }
}