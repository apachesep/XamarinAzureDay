﻿using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFDoggy.Models
{
    public class 請假紀錄項目 : BindableBase
    {
        public string ID { get; set; }
        public string 申請人 { get; set; }
        public DateTime 請假日期 { get; set; }
        public TimeSpan 開始時間 { get; set; }
        public int 請假時數 { get; set; }
        public string 假別 { get; set; }
        public string 請假理由 { get; set; }
        public string 職務代理人 { get; set; }
    }
}
