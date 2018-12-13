namespace eCat.Repository.Mapped
{
    public class TEdicionaPlusVisorParametrizacionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TEdicionaPlusVisorParametrizacion>
    {
        public TEdicionaPlusVisorParametrizacionConfiguration()
            : this("dbo")
        {
        }

        public TEdicionaPlusVisorParametrizacionConfiguration(string schema)
        {
            ToTable("T_EdicionaPlus_Visor_Parametrizacion", schema);
            HasKey(x => x.IdParametrizacion);

            Property(x => x.IdParametrizacion).HasColumnName(@"IdParametrizacion").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Nombre).HasColumnName(@"Nombre").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.IdPais).HasColumnName(@"IdPais").HasColumnType("smallint").IsRequired();
            Property(x => x.Query).HasColumnName(@"Query").HasColumnType("nvarchar(max)").IsRequired();
            Property(x => x.IdPlataforma).HasColumnName(@"IdPlataforma").HasColumnType("int").IsRequired();
            Property(x => x.IdCarpeta).HasColumnName(@"IdCarpeta").HasColumnType("bigint").IsRequired();
            Property(x => x.IdUsuario).HasColumnName(@"IdUsuario").HasColumnType("int").IsRequired();
            Property(x => x.ListaDitribucionInforme).HasColumnName(@"ListaDitribucionInforme").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.ListaDitribucionTerminado).HasColumnName(@"ListaDitribucionTerminado").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.IdTipoMaterial).HasColumnName(@"IdTipoMaterial").HasColumnType("smallint").IsOptional();
            Property(x => x.IdGrupoArticulo).HasColumnName(@"IdGrupoArticulo").HasColumnType("int").IsOptional();
            Property(x => x.IdLineaNegocio).HasColumnName(@"IdLineaNegocio").HasColumnType("tinyint").IsOptional();
            Property(x => x.Orden).HasColumnName(@"Orden").HasColumnType("int").IsRequired();
        }
    }
}