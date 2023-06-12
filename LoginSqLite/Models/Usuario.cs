using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSqLite.Models
{
    public class Usuario
    {
        //Configurar a propriedade abxaido da TAG
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public String Nome { get; set; }
        public String Email { get; set; }
        public String Senha { get; set; }
    }
}
