using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace onboarding_backend.Dtos.Tag
{
    public class TagCreateDto
    {
        [Required(ErrorMessage = "Name tidak boleh kosong")]
        public string Name { get; set; }
    }
}