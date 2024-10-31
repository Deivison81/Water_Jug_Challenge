using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Water_Jug_Challenge.Application.Models
{
    public class RequestJugs
    {
       [Required]
       public int Capacidad_x {  get; set; }
        
       [Required]
       public int Capcidadad_y {  get; set; }
       
        [Required]
        public int Volumen_z { get; set; }

    }
}
