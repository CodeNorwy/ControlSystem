using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirHeatModel_Sim
{
    class PidController
    {
        public double r;
        public double Kp;
        public double Ti;
        public double Ts;
        private double z;
        public double PiController(double y)
        {
            double e;
            double u;

            e = r - y;
            u = Kp * e + (Kp / Ti) * z;
            z = z + Ts * e;
            return u;
        }

    }
}
