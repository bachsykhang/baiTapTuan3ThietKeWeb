using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace baiTapTuan3.Models
{
    public class Triangle
    {
        public float CanhThu1 { get; set; }
        public float CanhThu2 { get; set; }
        public float CanhThu3 { get; set; }
        public Triangle()
        {
            this.CanhThu1 = 0;
            this.CanhThu2 = 0;
            this.CanhThu3 = 0;
        }
        // Check xem có phải tam giác không ?
        public bool isTamGiac()
        {
            return (this.CanhThu1 + this.CanhThu2) > this.CanhThu3 &&
                (this.CanhThu2 + this.CanhThu3) > this.CanhThu1 &&
                (this.CanhThu3 + this.CanhThu1) > this.CanhThu2;
        }

        public double ChuViTamGiac()
        {
            return (this.CanhThu1 + this.CanhThu2 + this.CanhThu3);
        }
        public double DienTichTamGiac()
        {
            double cv = this.ChuViTamGiac()/2;
            return Math.Sqrt(cv * (cv - this.CanhThu1) * (cv - this.CanhThu2) * (cv - this.CanhThu3));
        }
        
    }
}