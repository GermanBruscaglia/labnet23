using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica1
{
    public class Taxi : TransportePublico
    {
        public Taxi(int pasajeros, string nombreVehiculo) : base(pasajeros, nombreVehiculo)
        {
        }

        public override string Avanzar()
        {
            return $"Soy un Taxi y avanzo con {pasajeros} pasajeros";
        }

        public override string Detenerse()
        {
            return $"Soy un Taxi y me detengo con {pasajeros} pasajeros";
        }

        public override string Listarvehivulos()
        {
            return $"{nombreVehiculo}: {pasajeros}";
        }
    }
}
