namespace eCat.Repository.Mapped
{
    public class DilveFormatoProductoDetallePresentacionEquivalenciaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.DilveFormatoProductoDetallePresentacionEquivalencia>
    {
        public DilveFormatoProductoDetallePresentacionEquivalenciaConfiguration()
            : this("dbo")
        {
        }

        public DilveFormatoProductoDetallePresentacionEquivalenciaConfiguration(string schema)
        {
            ToTable("DILVE_FormatoProducto_DetallePresentacion_Equivalencias", schema);
            HasKey(x => x.IdDilveFormatoProducto);

            Property(x => x.IdDilveFormatoProducto).HasColumnName(@"IdDilveFormatoProducto").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdSoporte).HasColumnName(@"IdSoporte").HasColumnType("tinyint").IsRequired();
            Property(x => x.IdTipoEncuadernacion).HasColumnName(@"IdTipoEncuadernacion").HasColumnType("tinyint").IsOptional();
            Property(x => x.IdFormatoProducto).HasColumnName(@"IdFormatoProducto").HasColumnType("int").IsRequired();
            Property(x => x.IdDetallePresentacionProducto).HasColumnName(@"IdDetallePresentacionProducto").HasColumnType("int").IsOptional();

            // Foreign keys
            HasOptional(a => a.DilveDetallePresentacionProducto).WithMany(b => b.DilveFormatoProductoDetallePresentacionEquivalencias).HasForeignKey(c => c.IdDetallePresentacionProducto).WillCascadeOnDelete(false); // FK_DILVE_FormatoProducto_Equivalencias_DILVE_DetallePresentacionProducto
            HasOptional(a => a.TiposEncuadernacion).WithMany(b => b.DilveFormatoProductoDetallePresentacionEquivalencias).HasForeignKey(c => c.IdTipoEncuadernacion).WillCascadeOnDelete(false); // FK_DILVE_FormatoProducto_Equivalencias_TiposEncuadernacion
            HasRequired(a => a.DilveFormatoProducto).WithMany(b => b.DilveFormatoProductoDetallePresentacionEquivalencias).HasForeignKey(c => c.IdFormatoProducto).WillCascadeOnDelete(false); // FK_DILVE_FormatoProducto_Equivalencias_DILVE_FormatoProducto
            HasRequired(a => a.TSoporte).WithMany(b => b.DilveFormatoProductoDetallePresentacionEquivalencias).HasForeignKey(c => c.IdSoporte).WillCascadeOnDelete(false); // FK_DILVE_FormatoProducto_Equivalencias_T_Soportes
        }
    }
}