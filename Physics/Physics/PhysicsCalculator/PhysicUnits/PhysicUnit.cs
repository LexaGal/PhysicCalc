using System;
using System.Collections.Generic;

namespace Calculator.PhysicUnits
{
    public class PhysicUnit
    {
        public Unit Unit { get; private set; }

        private Func<double, double> _mappingToSi;
        private Func<double, double> _unmappingFromSi;
        private KeyValuePair<SiPhysicUnit, double> _siPhysicUnit;

        public KeyValuePair<SiPhysicUnit, double> SiPhysicUnit
        {
            get { return _siPhysicUnit; }
            set
            {
                if (_siPhysicUnit.Key == null)
                {
                    _siPhysicUnit = value;
                }
            }
        }

        public PhysicUnit(Unit unit, KeyValuePair<SiPhysicUnit, double> pair)
        {
            Unit = unit;
            _siPhysicUnit = pair;
            SetMappingCoeff(pair.Value);
        }

        private void SetMappingCoeff(double coeff)
        {
            _mappingToSi = x => x*coeff;
            _unmappingFromSi = x => x/coeff;
        }

        public double GetSiValueOf(double value)
        {
            return _mappingToSi(value);
        }

        public double GetFromSiValue(double value)
        {
            return _unmappingFromSi(value);
        }

        public override bool Equals(object obj)
        {
            PhysicUnit o = obj as PhysicUnit;
            return o != null && string.Equals(Unit, o.Unit);
        }

        public override int GetHashCode()
        {
            return Unit.GetHashCode();
        }

    }
}
