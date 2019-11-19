using System;
using SQLite;
using System.Collections.Generic;
using System.Text;


namespace lab13
{
    public class TodoPersona
    {

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string dni { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string fechaNacimiento { get; set; }


    }
}
