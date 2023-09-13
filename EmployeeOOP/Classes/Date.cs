﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP.Classes
{
    internal class Date
    {


        #region Fields
        private int _year;
        private int _month;
        private int _day;


        #endregion


        #region Methods

        public Date(int day, int month, int year)
        {
            _year = year;
            _month = month;
            _day = day;

        }

        public override string ToString()
        {
            //dia/mes/año
            var dateConcatenated = _day + "/" + _month + "/" + _year;
            var dateConcatenated2 = $"{_day}/{_month}/{_year}"; //interpolacion
            var dateConcatenated3 = String.Format("{0}/{1}/{2}", _day, _month, _year);

            //return dateConcatenated
            return dateConcatenated3;
        }

        #endregion

    }
}
