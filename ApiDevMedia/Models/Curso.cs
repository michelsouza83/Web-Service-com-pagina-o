﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ApiDevMedia.Models
{    
    [Table("Cursos")]
    public class Curso
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O título do curso deve ser preenchido.")]
        [MaxLength(100, ErrorMessage = "O título do curso só pode conter até 100 caracteres.")]
        public string Titulo  { get; set; }

        [Required(ErrorMessage = "A URL do curso deve ser preenchida.")]
        [Url(ErrorMessage = "A URL do curso deve conter um endereço válido.")]
        public string Url { get; set; }
        
        [Required(ErrorMessage = "O canal do curso deve ser preenchido")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Canal canal { get; set; }

        [Required(ErrorMessage = "A data de publicação do curso deve ser preenchida")]
        public DateTime Datapublicacao { get; set; }



        [Required(ErrorMessage = "A carga horária do curso deve ser preenchida.")]
        [Range(1, Int32.MaxValue, ErrorMessage = "A carga horária deve ser de pelo menos 1h")]
        public int CargaHoraria { get; set; }

        
    }
}