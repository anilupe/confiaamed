using Confiamed.Domain.Entity;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confiamed.Application.Application.Dto
{
    public class FormAndDetailDto
    {
        public Form Form { get; set; }

        public List<FormDetail> FormDetail { get; set; }
    }
}
