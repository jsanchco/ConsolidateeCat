namespace eCat.Repository.Mapped
{
    public class VwLirInformesJerarquiaECatConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.VwLirInformesJerarquiaECat>
    {
        public VwLirInformesJerarquiaECatConfiguration()
            : this("dbo")
        {
        }

        public VwLirInformesJerarquiaECatConfiguration(string schema)
        {
            ToTable("vw_LIR_Informes_Jerarquia_ECat", schema);
            HasKey(x => new { x.IdInterno, x.IdClasificacion });

            Property(x => x.IdInterno).HasColumnName(@"IDInterno").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdClasificacion).HasColumnName(@"ID_CLASIFICACION").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(60).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CodPropietario).HasColumnName(@"CodPropietario").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(5);
            Property(x => x.CodMercado).HasColumnName(@"CodMercado").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(5);
            Property(x => x.CodNegocio).HasColumnName(@"CodNegocio").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(5);
            Property(x => x.CodEtapaEdad).HasColumnName(@"CodEtapaEdad").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(5);
            Property(x => x.CodCategoriaCiclo).HasColumnName(@"CodCategoriaCiclo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(5);
            Property(x => x.CodSubcategoriaMateria).HasColumnName(@"CodSubcategoriaMateria").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(5);
            Property(x => x.CodEdadCurso).HasColumnName(@"CodEdadCurso").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(5);
            Property(x => x.Propietario).HasColumnName(@"propietario").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Mercado).HasColumnName(@"mercado").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Negocio).HasColumnName(@"negocio").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.EtapaEdad).HasColumnName(@"etapaEdad").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.CategoriaCiclo).HasColumnName(@"categoriaCiclo").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.SubcategoriaMateria).HasColumnName(@"subcategoriaMateria").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.EdadCurso).HasColumnName(@"edadCurso").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
        }
    }
}