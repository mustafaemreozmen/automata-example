using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomataExample
{
    public interface IDurum
    {
        string DurumAdi { get; }
        bool BitisDurumuMu { get; }
    }
}
