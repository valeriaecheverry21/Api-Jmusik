﻿using JMusik.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JMusik.Dtos
{

    public class OrdenDto
    {
        public OrdenDto()
        {
            DetalleOrden = new List<DetalleOrdenDto>();
        }

        public int Id { get; set; }
        public decimal CantidadArticulos { get; set; }
        public decimal Importe { get; set; }        
        public DateTime? FechaRegistro { get; set; }
        public int UsuarioId { get; set; }
        public string Usuario { get; set; }
        //public EstatusOrden EstatusOrden { get; set; }
        public List<DetalleOrdenDto> DetalleOrden { get; set; }
    }

}
