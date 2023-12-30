using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections;

namespace VietGraph
{
    class ExpressionHelper
    {
        public static ArrayList _arrExpression = new ArrayList();
        public static bool _cartesian = false;
        public static bool _polar = false;
        public static double _xStartValue = -1;
        public static double _xEndValue = -1;
        public static bool _blnDo = false;
        public static bool _blnRadian = true;

        public static ArrayList ArrExpression
        {
            get { return _arrExpression; }
            set { _arrExpression = value; }
        }

        public static bool Cartesian
        {
            get { return _cartesian; }
            set { _cartesian = value; }
        }

        public static bool Polar
        {
            get { return _polar; }
            set { _polar = value; }
        }

        public static double XStartValue
        {
            get { return _xStartValue; }
            set { _xStartValue = value; }
        }

        public static double XEndValue
        {
            get { return _xEndValue; }
            set { _xEndValue = value; }
        }

        public static bool BlnDo
        {
            get { return _blnDo; }
            set { _blnDo = value; }
        }

        public static bool BlnRadian
        {
            get { return _blnRadian; }
            set { _blnRadian = value; }
        }
    }
}
