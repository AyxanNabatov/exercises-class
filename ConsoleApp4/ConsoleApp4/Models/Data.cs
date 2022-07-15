using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Models
{
    public class Data<T> where T : Base
    {
        public List<T> FilterDatas(List<T> datas, int price, int price2)
        {
            return datas.FindAll(m => m.Price > price && m.Price < price2);
        }

    }
}
