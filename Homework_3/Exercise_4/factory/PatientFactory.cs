using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    public class PatientFactory : PersonFactory
    {
        private string _name;
        private int _age;
        private string _nationalId;
        private int _patientId;

        public PatientFactory(string name, int age, string nationalId, int patientId)
        {
            this._name = name;
            this._age = age;
            this._nationalId = nationalId;
            this._patientId = patientId;
        }

        public override Patient CreatePerson()
        {
            return new Patient(_nationalId, _name, _age, _patientId);
        }
    }
}
