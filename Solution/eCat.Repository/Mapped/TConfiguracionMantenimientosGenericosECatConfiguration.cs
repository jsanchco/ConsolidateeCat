namespace eCat.Repository.Mapped
{
    public class TConfiguracionMantenimientosGenericosECatConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<eCat.Data.Entities.TConfiguracionMantenimientosGenericosECat>
    {
        public TConfiguracionMantenimientosGenericosECatConfiguration()
            : this("dbo")
        {
        }

        public TConfiguracionMantenimientosGenericosECatConfiguration(string schema)
        {
            ToTable("T_Configuracion_MantenimientosGenericos_eCat", schema);
            HasKey(x => x.IdObjeto);

            Property(x => x.IdObjeto).HasColumnName(@"ID_OBJETO").HasColumnType("nvarchar").IsRequired().HasMaxLength(10).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Titulo).HasColumnName(@"Titulo").HasColumnType("nvarchar").IsOptional().HasMaxLength(500);
            Property(x => x.Tabla).HasColumnName(@"Tabla").HasColumnType("nvarchar").IsRequired().HasMaxLength(200);
            Property(x => x.ColumnaId).HasColumnName(@"ColumnaId").HasColumnType("nvarchar").IsRequired().HasMaxLength(200);
            Property(x => x.ColumnaValor).HasColumnName(@"ColumnaValor").HasColumnType("nvarchar").IsRequired().HasMaxLength(200);
            Property(x => x.TamanyoValor).HasColumnName(@"TamanyoValor").HasColumnType("int").IsRequired();
            Property(x => x.ProcedureComprobacion).HasColumnName(@"ProcedureComprobacion").HasColumnType("nvarchar").IsOptional().HasMaxLength(500);
            Property(x => x.ConMultilenguaje).HasColumnName(@"ConMultilenguaje").HasColumnType("bit").IsRequired();
            Property(x => x.ActualizarSap).HasColumnName(@"ActualizarSAP").HasColumnType("bit").IsRequired();
        }
    }
}