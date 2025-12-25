using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    internal class GeneralDiagnosis : IDiagnosisStrategy
    {
        public string Diagnose()
        {
            return "Flu";
        }
    }
}
