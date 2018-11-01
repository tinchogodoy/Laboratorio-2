using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class RobotDeCombate : Robot
    {
        private int caballosDeFuerza;

        public int CaballosDeFuerzas
        {
            get { return caballosDeFuerza; }
        }

        private bool lucho;

        public bool Lucho
        {
            get { return lucho; }
        }

        public RobotDeCombate() : base()
        {
            this.lucho = false;
        }

        public RobotDeCombate(int energia,string origen) : this()
        {
            this.caballosDeFuerza = 10;
        }

        public RobotDeCombate(int energia, string origen, int caballosDeFuerza) : this(energia,origen)
        {
            this.caballosDeFuerza = caballosDeFuerza;
        }
        public override string ServirHumanidad()
        {
            StringBuilder sb = new StringBuilder();
            if (this.Energia > 0)
            {
                sb.AppendFormat("Robot de combate {0} - disparando misiles...", this.Codigo);
            }
            else
            {
                sb.AppendFormat("Robot de combate {0} - sin energia", this.Codigo);
            }

            return sb.ToString();
        }




    }
}
