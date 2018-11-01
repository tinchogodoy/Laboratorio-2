using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class RobotSirviente : Robot
    {
        public override bool CargarEnergia(int energia)
        {
            if(this.Energia == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public RobotSirviente(): base()
        {

        }

        public RobotSirviente(int energia, string origen): base(energia,origen)
        {

        }

        public override string ServirHumanidad()
        {
            StringBuilder sb = new StringBuilder();
            if(this.Energia > 0)
            {
                int energia = this.Energia;
                energia--;
                
                sb.AppendFormat("{0} haciendo masajes...", this.Codigo);
            }
            else
            {
                sb.AppendFormat("{0} sin energia", this.Codigo);
            }
            return sb.ToString();
        }





    }
}
