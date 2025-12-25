using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    internal class NeurologistsDiagnosis : IDiagnosisStrategy
    {
        public string Diagnose()
        {
            return "Possible Brain Damage";
        }
    }
}
