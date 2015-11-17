using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercises
{
    public class SafetyBox
    {
        private SafetyBoxStatus _status;
        private double _money;

        public SafetyBox()
        {
            _status = SafetyBoxStatus.Closed;
            _money = 0;
        }

        public SafetyBoxStatus Status()
        {
            return _status;
        }

        public void Close()
        {
            _status = SafetyBoxStatus.Closed;
        }

        public void Open()
        {
            _status = SafetyBoxStatus.Open;
        }

        private void changeMoney(double money)
        {
            _money += money;
        }

        public void Deposit(double money)
        {
            if(_status == SafetyBoxStatus.Open)
            changeMoney(money);
        }
        public double Withdraw(double money)
        {
            if(_status == SafetyBoxStatus.Open)
            {
                changeMoney(-money);
                return money;
            }

            return 0;
        }

        public override string ToString()
        {
            if(_status == SafetyBoxStatus.Open)
                return string.Format("An open safe that contains {0} money.",_money);
            return "The safe appears to be closed.";
        }

    }

    public enum SafetyBoxStatus { Open, Closed}
}
