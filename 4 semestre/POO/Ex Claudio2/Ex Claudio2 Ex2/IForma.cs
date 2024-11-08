using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Claudio2_Ex2
{
    public interface IForma
    {
        void CriarForma(int NumPontas);
        void CalculaArea();

        int NumPontas { get; set; }
    }
}
