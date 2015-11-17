using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercises
{
    public class CreditCard
    {
        private CreditCompany _company;
        private string _owner;
        private uint _number;
        private double _date;

        public CreditCard(CreditCompany company, string owner, uint number, double date)
        {
            _company = company;
            _owner = owner;
            _number = number;
            _date = date;
        }

        public void SetCompany(CreditCompany company)
        {
            _company = company;
        }

        public double GetDate()
        {
            return _date;
        }


    }

    public enum CreditCompany { Leumi, Hapoalim}
}
