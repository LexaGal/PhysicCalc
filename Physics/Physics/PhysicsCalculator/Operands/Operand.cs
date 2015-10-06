using System;
using System.Collections.Generic;
using Calculator.Operations;
using Calculator.PhysicUnits;

namespace Calculator.Operands
{
    public class Operand
    {
        public double Value { get; }

        private PhysicUnit _physicUnit;
        public  PhysicUnit PhysicUnit
        {
            get { return new PhysicUnit(_physicUnit.Unit, 
                new KeyValuePair<SiPhysicUnit, double>(_physicUnit.SiPhysicUnit.Key, _physicUnit.SiPhysicUnit.Value)); }
            private set { _physicUnit = value; }
        }

        public Operand(double value, PhysicUnit physicUnit)
        {
            Value = value;
            PhysicUnit = physicUnit;
        }

        public static Operand operator +(Operand operand1, Operand operand2)
        {
            return operand1.ApplyOperation(operand2, Operation.Add);
        }

        public static Operand operator -(Operand operand1, Operand operand2)
        {
            return operand1.ApplyOperation(operand2, Operation.Subtract);
        }

        public static Operand operator *(Operand operand, double val)
        {
            return new Operand(operand.Value*val, operand.PhysicUnit);
        }

        public static Operand operator *(double val, Operand operand)
        {
            return new Operand(operand.Value*val, operand.PhysicUnit);
        }

        public static Operand operator *(Operand operand1, Operand operand2)
        {
            return operand1.ApplyOperation(operand2, Operation.Multiply);
        }

        public static Operand operator /(Operand operand, double val)
        {
            return new Operand(operand.Value/val, operand.PhysicUnit);
        }

        public static Operand operator /(Operand operand1, Operand operand2)
        {
            return operand1.ApplyOperation(operand2, Operation.Divide);
        }

        public override string ToString()
        {
            return Value.ToString("F2") + ' ' + PhysicUnit.Unit;
        }

        public override bool Equals(object obj)
        {
            Operand operand = obj as Operand;
            return operand != null && PhysicUnit.Equals(operand.PhysicUnit);
        }

        public override int GetHashCode()
        {
            return PhysicUnit.GetHashCode();
        }
    }
}