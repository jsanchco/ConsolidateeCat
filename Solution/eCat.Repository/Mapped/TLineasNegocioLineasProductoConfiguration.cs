namespace eCat.Repository.Mapped
{
    public class TLineasNegocioLineasProductoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TLineasNegocioLineasProducto>
    {
        public TLineasNegocioLineasProductoConfiguration()
            : this("dbo")
        {
        }

        public TLineasNegocioLineasProductoConfiguration(string schema)
        {
            ToTable("T_LineasNegocio_LineasProducto", schema);
            HasKey(x => new { x.IdPais, x.IdLineaNegocio, x.IdLineaProducto });

            Property(x => x.IdPais).HasColumnName(@"IdPais").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdLineaNegocio).HasColumnName(@"IdLineaNegocio").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdLineaProducto).HasColumnName(@"IdLineaProducto").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Baja).HasColumnName(@"Baja").HasColumnType("bit").IsRequired();

            // Foreign keys
            HasRequired(a => a.E2AclDominio).WithMany(b => b.TLineasNegocioLineasProductoes).HasForeignKey(c => c.IdPais).WillCascadeOnDelete(false); // FK_T_LineasNegocio_LineasProducto_E2_ACL_DOMINIOS
            HasRequired(a => a.E2Lineasproducto).WithMany(b => b.TLineasNegocioLineasProductoes).HasForeignKey(c => c.IdLineaProducto).WillCascadeOnDelete(false); // FK_T_LineasNegocio_LineasProducto_E2_LINEASPRODUCTO
            HasRequired(a => a.LineaNegocio).WithMany(b => b.TLineasNegocioLineasProductoes).HasForeignKey(c => c.IdLineaNegocio).WillCascadeOnDelete(false); // FK_T_LineasNegocio_LineasProducto_LineaNegocio
        }
    }
}