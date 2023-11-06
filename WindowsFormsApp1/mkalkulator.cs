using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class mkalkulator
    {
        public double angka1, angka2;
        private double hasil;
        public String pilihan;

        public double getHasil()
        {
            switch (pilihan)
            {
                case "+":
                    hasil = Jumlah(); break;
                case "-":
                    hasil = Kurang(); break;
                case "*":
                    hasil = Kali(); break;
                case "/":
                    hasil = Bagi(); break;
                case "√":
                    hasil = Akar(); break;
                case "^":
                    hasil = Pangkat(); break;
            }
            return hasil;
        }
        public double Jumlah()
        {
            return hasil = angka1 + angka2;
        }
        public double Kurang()
        {
            return hasil = angka1 - angka2;
        }
        public double Kali()
        {
            return hasil = angka1 * angka2;
        }
        public double Bagi()
        {
            return hasil = angka1 / angka2;
        }
        public double Pangkat()
        {
            return Math.Pow(angka1, angka2);
        }
        public double Akar()
        {
            return Math.Sqrt(angka1);
        }
    }
}
