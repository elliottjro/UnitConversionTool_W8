using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4
{
    public class CBConversionType_data
    {
        public List<string> conversionTypeList = new List<string>();
        public string currentSelectedType = "Area";

        public void initConversionData()
        {
            string[] conversionTypeArr = { "Area", "Temperatue", "Speed" };
            conversionTypeList.Add(conversionTypeArr[0]);
            conversionTypeList.Add(conversionTypeArr[1]);
            conversionTypeList.Add(conversionTypeArr[2]);
        }
    }
    public class CBConversionTypeArea_data
    {
        public List<string> conversionTypeList = new List<string>();

        public void initConversionData()
        {
            string[] conversionTypeArr = { "m", "cm", "km" };
            conversionTypeList.Add(conversionTypeArr[0]);
            conversionTypeList.Add(conversionTypeArr[1]);
            conversionTypeList.Add(conversionTypeArr[2]);
        }
    }


}
