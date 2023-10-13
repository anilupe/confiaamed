using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confiamed.Domain.Entity
{
    public class FormDetail
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public TypeForm Type { get; set; }


        public int FormId { get; set; }

        public  Form Form { get; set; }
    }

    public enum TypeForm
    {
        Input,
        Date,
        Dropdownlist
    }
}
