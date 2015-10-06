using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator.PhysicUnits
{
    public class SiPhysicUnit
    {
        public SiUnit SiUnit { get; private set; }
        public UnitType UnitType { get; private set; }
        public IDictionary<PhysicUnit, double> PhysicUnits { get; private set; }

        public SiPhysicUnit(SiUnit siUnit, UnitType unitType, IDictionary<PhysicUnit, double> dictionary)
        {
            SiUnit = siUnit;
            UnitType = unitType;
            PhysicUnits = dictionary;
        }
        
        public override bool Equals(object obj)
        {
            SiPhysicUnit o = obj as SiPhysicUnit;
            return o != null && string.Equals(SiUnit, o.SiUnit);
        }

        public override int GetHashCode()
        {
            return SiUnit.GetHashCode();
        }
    }
}
