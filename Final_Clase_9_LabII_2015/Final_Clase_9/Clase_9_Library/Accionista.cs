using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_8_Library
{
  public class Accionista : Persona
  {

    private int _porcionAccionaria;

    public Accionista(string nombre, string apellido, int porcionAccionaria) : base(nombre,apellido)
    {
      this.PorcionAccionaria = porcionAccionaria;
    }

    public int PorcionAccionaria //PorcionAccionaria público y de instancia. Validará que la porción sea un número entre 0 y 100.
    {
      set
      {
        if (value >= 0 && value <= 100)
        {
          this._porcionAccionaria = value;
        }
        else
        {
          this._porcionAccionaria = 0;
        }
      }
    }

    //PosicionSocietaria deberá retornar el texto “Accionista con el [porción accionaria]% de la porción accionaria”.
    public override string PosicionSocietaria()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine("Accionista con el "+this.PorcionAccionaria+"% de la porcion accionaria");
      return sb.ToString();
    }
   // Dos accionistas serán iguales si comparten todos sus datos.
  }
}
