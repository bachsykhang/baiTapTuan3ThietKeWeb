using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace baiTapTuan3.Models
{
    public class Rectangle
    {
        //[Required(ErrorMessage = "Vui lòng nhập Chiều Dài")]
        //[Display(Name = "Mời nhập chiều dài: ")]
        public float ChieuDai { get; set; }
        public float ChieuRong { get; set; }
        public Rectangle()
        {
            this.ChieuDai = 0;
            this.ChieuRong = 0;
        }

        public double DienTichHCN()
        {
            return this.ChieuDai * this.ChieuRong;
        }
        public double ChuViHCN()
        {
            return 2 * (this.ChieuDai + this.ChieuRong);
        }

    }
}