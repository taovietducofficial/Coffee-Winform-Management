using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DTO
{
    public class ImportedIngredientDTO
    {
        public int idImport {  get; set; }
        public int idIngredient { get; set; }
        public int number { get; set; }
        public ImportedIngredientDTO(int idImport, int idIngredient, int number)
        {
            this.idImport = idImport;
            this.idIngredient = idIngredient;
            this.number = number;
        }
    }
}

