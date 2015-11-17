using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercises
{
    public class Taxi
    {
        private int _taxiId;
        private string _driverName;
        private int _numPass;
        private int _currentPass;
        private bool _isAvailable;

        public Taxi(string driverName, int taxiId)
        {
            _taxiId = taxiId;
            _driverName = driverName;
            _numPass = 4;
            _currentPass = 0;
            _isAvailable = true;
        }

        public int getId()
        {
            return _taxiId;
        }

        public string getName()
        {
            return _driverName;
        }

        public int getNumPass()
        {
            return _numPass;
        }

        public bool isAvailable()
        {
            return _isAvailable;
        }

        public void setCurrentPass(int p)
        {
            _currentPass = p;
        }

        public void taxiBusy()
        {
            _currentPass = _numPass;
            _isAvailable = false;
        }

        public int numberOfTaxi(int pass)
        {
            return pass / _numPass;
        }

        public int addPassenger(int pass)
        {
            return 4 - (pass - numberOfTaxi(pass) * _numPass);
        }
    }
}
