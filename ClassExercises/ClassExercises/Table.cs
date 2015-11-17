using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercises
{
    public class Table
    {
        private TableShape _shape;
        private uint _tableLegs;
        private uint _maxSeats;

        public Table(TableShape shape, uint tableLegs, uint maxSeats)
        {
            this._shape = shape;
            this._tableLegs = tableLegs;
            this._maxSeats = maxSeats;
        }

        public TableShape Shape
        {
            get { return _shape; }
            set { _shape = value; }
        }

        public uint Legs
        {
            get { return _tableLegs; }
            set { _tableLegs = value; }
        }

        public uint MaxSeats
        {
            get { return _maxSeats; }
            set { _maxSeats = value; }
        }

        public override string ToString()
        {
            return string.Format("A {0} table with {1} legs on which. at most {2} can sit at once.", _shape, _tableLegs, _maxSeats);
        }

        public uint aroundTheTable(uint n)
        {
            return (uint)(n / _maxSeats);
        }

        public uint leftOver(uint n)
        {
            return (uint)(n % _maxSeats);
        }

        public uint numOfTable(int n)
        {
            return (uint)Math.Ceiling((double)n / _maxSeats);
        }


    }

    public enum TableShape { Square, Round}
}
