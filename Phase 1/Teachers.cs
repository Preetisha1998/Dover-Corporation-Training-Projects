using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Assessment__Phase_1
{
    /// <summary>
    /// this is the model class for data type Teacher
    /// </summary>
    class Teachers
    {
        public int id { get; set; }
        public string name { get; set; }
        public string clas { get; set; }
        public string section { get; set; }

        public Teachers(int id, string name, string clas, string section)
        {
            this.id = id;
            this.name = name;
            this.clas = clas;
            this.section = section;
        }

        public override string ToString()
        {
            return $"Id : {id}, Name : {name}, Class : {clas}, Section : {section}";
        }
    }
}

