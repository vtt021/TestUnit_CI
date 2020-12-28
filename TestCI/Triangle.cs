using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCI
{
    class Triangle
    {

        private double a;
        private double b;
        private double c;
        public string checkValid()
        {
            if (a <= 0 || b <= 0 || c <= 0 || a + b <= c || b + c <= a || a + c <= b)
            {
                return "KHONG PHAI TAM GIAC";
            }
            else
            {
                if (
                    (abs(a - b) <= 0.000001 && abs(a * a * 2 - c * c) <= 0.000001)
                    || (abs(a - c) <= 0.000001 && abs(a * a * 2 - b * b) <= 0.000001)
                    || (abs(b - c) <= 0.000001 && abs(b * b * 2 - a * a) <= 0.000001)
                    )
                {
                    return "LA TAM GIAC VUONG CAN";
                }
                else
                {
                    if (abs(a - b) <= 0.000001 && abs(a - c) <= 0.000001 && abs(b - c) <= 0.000001)
                    {
                        return "LA TAM GIAC DEU";
                    }
                    else
                    {
                        if (abs(a - b) <= 0.000001 || abs(a - c) <= 0.000001 || abs(b - c) <= 0.000001)
                        {
                            return "LA TAM GIAC CAN";
                        }
                        else
                        {
                            if (abs(a * a + b * b - c * c) <= 0.000001 || abs(a * a + c * c - b * b) <= 0.000001 || abs(b * b + c * c - a * a) <= 0.000001)
                            {
                                return "LA TAM GIAC VUONG";
                            }
                            else
                            {
                                return "LA TAM GIAC THUONG";
                            }
                        }
                    }
                }
            }
        }

        private double abs(double v)
        {
            if (v < 0)
            {
                return v * -1;
            }
            else
                return v;

            throw new NotImplementedException();
        }

        public string tinhChuVi()
        {
            var check = checkValid();
            if (check != "KHONG PHAI TAM GIAC")
            {
                var result = (a + b + c).ToString();
                return result;
            }
            else
                return "KHONG CO CHU VI";
        }
        public Triangle(double x, double y, double z)
        {
            a = x;
            b = y;
            c = z;
        }
    }
}
