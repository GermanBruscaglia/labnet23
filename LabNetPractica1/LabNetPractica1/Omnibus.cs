﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica1
{
    public class Omnibus : TransportePublico
    {

        public Omnibus(int pasajeros, string nombreVehiculo) : base(pasajeros, nombreVehiculo)
        {
        }

        public override string Avanzar()
        {
            return $"Soy un Omnibus y avanzo con {pasajeros} pasajeros";
        }

        public override string Detenerse()
        {
            return $"Soy un Omnibus y me detengo con {pasajeros} pasajeros";
        }

        public override string Listarvehivulos()
        {
            return $"{nombreVehiculo}: {pasajeros}";
        }

    }
}
