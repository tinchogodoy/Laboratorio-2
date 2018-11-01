using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Arena
    {
        public int espacioDisponible;
        public string nombre;
        public List<RobotDeCombate> robotsDeCombate;
        public List<RobotSirviente> robotsSirvientes;

        private Arena()
        {
            robotsDeCombate = new List<RobotDeCombate>();
            robotsSirvientes = new List<RobotSirviente>();
        }

        public Arena(string nombre, int espacioDisponible)
        {
            this.nombre = nombre;
            this.espacioDisponible = espacioDisponible;
        }

        public string Combate(RobotDeCombate Combatiente)
        {
            if(this!=null)
            {
                foreach (RobotDeCombate robotDeCombate in this.robotsDeCombate)
                {
                    
                }

            }

            return "";
        }

        public static implicit operator string(Arena arena)
        {
            return "";
        }


        public string ServirEspectadores()
        {
            foreach (RobotSirviente robotSirviente in this.robotsSirvientes)
            {
                
              
            }

            return "";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Arena {0}", this.nombre);
            sb.AppendFormat("Robots de combates: \n");
            foreach (RobotDeCombate robotDeCombate in this.robotsDeCombate)
            {
                sb.AppendLine(robotDeCombate.ServirHumanidad());
            }
            sb.AppendFormat("Robots sirvientes: \n");
            foreach (RobotSirviente robotSirviente in this.robotsSirvientes)
            {
                sb.AppendLine(robotSirviente.ServirHumanidad());
            }
            return sb.ToString();
            
        }

        public static bool operator ==(Arena arena, Robot robot)
        {
            foreach (RobotDeCombate robotDeCombate in arena.robotsDeCombate)
            {
                if (robotDeCombate.Equals(arena.robotsDeCombate))
                {
                    return true;
                }
            }
            foreach (RobotSirviente robotSirviente in arena.robotsSirvientes)
            {
                if (robotSirviente.Equals(arena.robotsSirvientes))
                {
                    return true;
                }
            }
            
            return false;
        }

        public static bool operator !=(Arena arena, Robot robot)
        {
            return !(arena == robot);
        }

        public static bool operator +(Arena arena, Robot robot)
        {
            return true;
        }

        public static bool operator -(Arena arena, Robot robot)
        {
            return true;
        }



    }
}
