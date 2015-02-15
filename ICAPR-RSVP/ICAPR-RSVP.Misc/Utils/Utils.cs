﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using ICAPR_RSVP;

namespace ICAPR_RSVP.Misc.Utils
{
    public class Utils
    {
        public static long MilliTimeStamp()
        {
            DateTime d1 = new DateTime(1970, 1, 1);
            DateTime d2 = DateTime.UtcNow;
            TimeSpan ts = new TimeSpan(d2.Ticks - d1.Ticks);

            return (long)ts.TotalMilliseconds;
        }

        public static double DateTimeToUnixTimestamp(DateTime dateTime)
        {
            return (dateTime - new DateTime(1970, 1, 1).ToLocalTime()).TotalSeconds;
        }


        public static void launchEyeTribeCalibration()
        {
            Process.Start(Config.EYETRIBE_CALIBRATION_EXE);
        }

        public static void launchEyeTribeServer()
        {
            Process.Start(Config.EYETRIBE_SERVER_EXE);
            Thread.Sleep(3000);
        }
    }
}
