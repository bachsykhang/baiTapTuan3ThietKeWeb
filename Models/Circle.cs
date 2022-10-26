using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace baiTapTuan3.Models
{
    public class Circle
    {
        public Double BanKinh { get; set; }
        public Circle()
        {
            this.BanKinh = 0;
        }
        public Double DienTich()
        {
            return this.BanKinh * this.BanKinh * Math.PI;
        } 
        public Double ChuVi()
        {
            return 2 * this.BanKinh * Math.PI;
        }
    }
}