using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailCarbonFootprint
{
    public static class YearlyCarbonEmmisionUtills
    {
        public static double CarbonEmmissionForSpamEmailStorage(double sizeInMB)
        {
            return 5 * sizeInMB;
        }

        public static double CarbonEmmisionForEmailTransmission(double sizeInMB)
        {
            return 30 * sizeInMB;

        }

        public static double CarbonEmmisionForEmailStorage(double sizeInMB)
        {
            return 10 * sizeInMB;

        }

        
    }
}
