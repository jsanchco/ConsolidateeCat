namespace eCat.Data.Entities
{
    public class EstadosSap
    {
        public string IdEstadoSap { get; set; } // IDEstadoSAP (Primary key) (length: 2)
        public string EstadoSap { get; set; } // EstadoSAP (length: 30)
        public bool EnWeb { get; set; } // EnWeb
        public byte IdEstadoBusqueda { get; set; } // IdEstadoBusqueda
        public bool RevisarStock { get; set; } // RevisarStock

        ///<summary>
        /// Valor que ha de tomar el campo Baja en FichasBase al hacer un cambio de estado por Mantenimiento Externo
        ///</summary>
        public bool Baja { get; set; } // Baja

        ///<summary>
        /// Valor que ha de tomar el campo BajaSoloECat en FichasBase al hacer un cambio de estado por Mantenimiento Externo
        ///</summary>
        public bool BajaSoloECat { get; set; } // BajaSoloECat

        // Reverse navigation

        /// <summary>
        /// Child DilveDisponibilidads (Many-to-Many) mapped by table [DILVE_Disponibilidad_Equivalencias]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<DilveDisponibilidad> DilveDisponibilidads { get; set; } // Many to many mapping
        /// <summary>
        /// Child DilveEstadoes (Many-to-Many) mapped by table [DILVE_Estados_Equivalencias]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<DilveEstado> DilveEstadoes { get; set; } // Many to many mapping
        /// <summary>
        /// Child DilveSituacionCatalogoEditorials (Many-to-Many) mapped by table [DILVE_SituacionCatalogoEditorial_Equivalencias]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<DilveSituacionCatalogoEditorial> DilveSituacionCatalogoEditorials { get; set; } // Many to many mapping
        /// <summary>
        /// Child EstadosSapIdiomas where [EstadosSAP_Idioma].[IDEstadoSAP] point to this entity (FK_EstadosSAP_Idioma_EstadosSAP)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<EstadosSapIdioma> EstadosSapIdiomas { get; set; } // EstadosSAP_Idioma.FK_EstadosSAP_Idioma_EstadosSAP
        /// <summary>
        /// Child FichasBases where [FichasBase].[IDEstadoSAP] point to this entity (FK_FichasBase_EstadosSAP)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FichasBase> FichasBases { get; set; } // FichasBase.FK_FichasBase_EstadosSAP

        // Foreign keys

        /// <summary>
        /// Parent TBusquedaGeneralEstado pointed by [EstadosSAP].([IdEstadoBusqueda]) (FK_EstadosSAP_T_BusquedaGeneral_Estados)
        /// </summary>
        public virtual TBusquedaGeneralEstado TBusquedaGeneralEstado { get; set; } // FK_EstadosSAP_T_BusquedaGeneral_Estados

        public EstadosSap()
        {
            EnWeb = false;
            RevisarStock = true;
            Baja = false;
            BajaSoloECat = false;
            EstadosSapIdiomas = new System.Collections.Generic.List<EstadosSapIdioma>();
            FichasBases = new System.Collections.Generic.List<FichasBase>();
            DilveDisponibilidads = new System.Collections.Generic.List<DilveDisponibilidad>();
            DilveSituacionCatalogoEditorials = new System.Collections.Generic.List<DilveSituacionCatalogoEditorial>();
            DilveEstadoes = new System.Collections.Generic.List<DilveEstado>();
        }
    }
}