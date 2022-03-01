using SODA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace TarjetasDebitoCreditoCol.Models
{
    [DataContract]
    public class Operacion
    {
        [Key]
        [DataMember(Name = "tipoentidad")]
        public int TipoEntidad { get; set; }

        [DataMember(Name = "codigoentidad")]
        public int CodigoEntidad { get; set; }

        [DataMember(Name = "nombreentidad")]
        public string NombreEntidad { get; set; }

        [DataMember(Name = "fechacorte")]
        public DateTime FechaCorte { get; set; }

        [DataMember(Name = "cod_uca")]
        public int CodigoUca { get; set; }

        [DataMember(Name = "nombre_uca")]
        public string  NombreUca { get; set; }

        [DataMember(Name = "subcuenta")]
        public int Subcuenta { get; set; }

        [DataMember(Name = "descripcion")]
        public string Descripcion { get; set; }

        [DataMember(Name = "persona_natural")]
        public double PersonaNatural { get; set; }

        [DataMember(Name = "persona_juridica")]
        public double PersonaJuridica { get; set; }

        [DataMember(Name = "total_tarjetas")]
        public double TotalTarjetas { get; set; }

        

        public LocationColumn Localizacion { get; set; }
        

    }
}
