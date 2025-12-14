using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurity
{
    internal class PasswordInformation
    {
        public int HaveDigit { get; init; }
        public int HaveLower { get; init; }
        public int HaveSymble { get; init; }
        public int HaveUpper { get; init; }
        public int TotalRange => HaveUpper + HaveDigit + HaveLower + HaveSymble;

    }
}
