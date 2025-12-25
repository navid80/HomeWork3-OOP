using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    public class DoctorFactory : PersonFactory
    {

        private string _name;
        private int _age;
        private string _nationalId;
        private int _doctorId;
        private string _specialization;
        private IDiagnosisStrategy _strategy;

        public DoctorFactory(string name, int age, string nationalId, int doctorId, string specialization, IDiagnosisStrategy strategy)
        {
            this._name = name;
            this._age = age;
            this._nationalId = nationalId;
            this._doctorId = doctorId;
            this._specialization = specialization;
            this._strategy = strategy;
        }

        public override Doctor CreatePerson()
        {
            return new Doctor(_nationalId, _name, _age, _doctorId, _specialization, _strategy);
        }
    }
}
