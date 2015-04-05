﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICAPR_SVP
{
    public class Skata
    {
        static void Main(string[] args)
        {
            MLApp.MLApp matlab = new MLApp.MLApp();
            //matlab.Visible = 0;


            double[] data = {-0.0081,-0.0089,-0.0105,-0.011,-0.0125,-0.0139,-0.0147,-0.0161,-0.0168,-0.0183,-0.0205,-0.0205,-0.0219,-0.0241,-0.0241,-0.0263,-0.0284,-0.0294,-0.0306,-0.0364,-0.0386,-0.0386,-0.0408,-0.0422,-0.0473,-0.0488,-0.0502,-0.0509,-0.0524,-0.0531,-0.0547,-0.0553,-0.0567,-0.0589,-0.0589,-0.0604,-0.0625,-0.0647,-0.0655,-0.0669,-0.0676,-0.0691,-0.0705,-0.0712,-0.0728,-0.0734,-0.0749,-0.077,-0.0785,-0.0807,-0.0807,-0.0829,-0.0836,-0.085,-0.0858,-0.0872,-0.0887,-0.0894,-0.0909,-0.0916,-0.093,-0.0952,-0.0952,-0.0974,-0.0988,-0.1011,-0.1018,-0.1032,-0.1039,-0.1053,-0.1069,-0.1075,-0.109,-0.1111,-0.1111,-0.1133,-0.1155,-0.117,-0.1191,-0.1199,-0.1214,-0.122,-0.1235,-0.1242,-0.1257,-0.1271,-0.1293,-0.1351,-0.1402,-0.1417,-0.1484,-0.1542,-0.155,-0.1564,-0.1622,-0.163,-0.1646,-0.1666,-0.1666,-0.1688,-0.1746,-0.1804,-0.1811,-0.1825,-0.1847,-0.1847,-0.1869,-0.1876,-0.1936,-0.1949,-0.1956,-0.1971,-0.1992,-0.1992,-0.2007,-0.2029,-0.2029,-0.205,-0.2058,-0.2072,-0.2087,-0.2094,-0.2148,-0.2163,-0.223,-0.2301,-0.2345,-0.2366,-0.2366,-0.238,-0.2402,-0.2402,-0.2424,-0.2431,-0.2446,-0.2453,-0.2469,-0.2482,-0.2489,-0.2504,-0.2526,-0.2584,-0.2634,-0.2649,-0.2663,-0.2671,-0.2686,-0.2692,-0.2707,-0.2729,-0.2729,-0.275,-0.2765,-0.2765,-0.2787,-0.2794,-0.281,-0.2816,-0.283,-0.2845,-0.2852,-0.2867,-0.2874,-0.2888,-0.291,-0.291,-0.2932,-0.2932,-0.2946,-0.2968,-0.2975,-0.299,-0.2997,-0.3012,-0.3019,-0.3036,-0.3057,-0.3057,-0.3123,-0.3181,-0.325,-0.3399,-0.3406,-0.3422,-0.3443,-0.3443,-0.3465,-0.3472,-0.3486,-0.3501,-0.3522,-0.353,-0.3545,-0.3551,-0.3566,-0.3581,-0.3588,-0.3603,-0.3609,-0.3624,-0.3646,-0.3646,-0.3667,-0.3682,-0.4394,-0.3531,-0.432,-0.5083,-0.317,-0.261,-0.2616,-0.2329,-0.2127,-0.2009,-0.1855,-0.1844,-0.1762,-0.1787,-0.2491,-0.2985,-0.3091,-0.279,-0.2803,-0.3318,-0.3818,-0.2331,-0.2536,-0.2684,-0.2883,-0.3437,-0.3479,-0.3959,-0.3628,-0.4389,-0.2836,-0.3177,-0.3977,-0.3712,-0.369,-0.2332,-0.2382,-0.2342,-0.2262,-0.1224,-0.1248,-0.1369,-0.1401,-0.0402,-0.1272,-0.1751,-0.2091,-0.2188,-0.0921,-0.2133,-0.1589,-0.1911,-0.2007,-0.2265,-0.3114,-0.3434,-0.3697,-0.3738,-0.3957,-0.4544,-0.2972,-0.2677,-0.2967,-0.3188,-0.3725,-0.2279,-0.1509,-0.1608,-0.1521,-0.1689,-0.1529,-0.1668,-0.2329,-0.1953,-0.1812,-0.179,-0.179,-0.1625,-0.191,-0.2163,-0.1831,-0.1875,-0.2105,-0.2153,-0.2248,-0.239,-0.2533,-0.2628,-0.2628,-0.277,-0.2818,-0.2913,-0.2961,-0.3056,-0.3103,-0.3198,-0.3293,-0.3341,-0.3436,-0.2936,-0.2666,-0.2599,-0.2703,-0.2555,-0.2318,-0.2113,-0.2721,-0.2264,-0.28,-0.2753,-0.3108,-0.3444,-0.3404,-0.3534,-0.311,-0.3025,-0.3362,-0.3422,-0.4027,-0.3731,-0.3233,-0.2943,-0.2721,-0.2677,-0.2855,-0.2724,-0.311,-0.2803,-0.2951,-0.2887,-0.3048,-0.2788,-0.2558,-0.2818,-0.3717,-0.2861,-0.2774,-0.2394,-0.2255,-0.2354,-0.2082,-0.1232,-0.1521,-0.171,-0.2187,-0.2299,-0.2134,-0.2171,-0.2165,-0.2494,-0.2113,-0.2259,-0.2651,-0.1463,-0.2347,-0.2184,-0.1963,-0.152,-0.0805,-0.0898,-0.1638,-0.072,0.0142,-0.0241,-0.0478,0.0425,0.0077,0.0736,-0.0022,0.0319,0.0169,0.1074,0.0152,-0.014,-0.1082,-0.0892,-0.0893,-0.0984,-0.1714,-0.2238,-0.1468,-0.1357,-0.1817,-0.152,-0.2434,-0.2583,-0.2037,-0.2599,-0.1354,-0.1933,-0.0977,-0.0081,-0.0741,-0.1245,-0.0553,-0.1452,-0.1313,-0.0705,-0.1648,-0.0698,-0.1335,-0.1222,-0.0248,0.0038,-0.0473,-0.054,-0.071,-0.1527,-0.2125,-0.2959,-0.1731,-0.1004,-0.1519,-0.1234,-0.1299,-0.1163,-0.1225,-0.1654,-0.2185,-0.3013,-0.1428,-0.0994,-0.0491,-0.078,-0.0625,-0.1074,-0.1467,-0.1289,-0.1327,-0.1078,-0.1795,-0.1713,-0.1851,-0.1828,-0.1899,-0.2252,-0.2284,-0.2025,-0.217,-0.185,-0.2326,-0.2161,-0.2007,-0.2326,-0.1979,-0.1991,-0.1744,-0.2042,-0.2343,-0.2088,-0.2615,-0.2167,-0.2075,-0.2405,-0.2419,-0.2597,-0.2715,-0.249,-0.235,-0.2122,-0.2012,-0.1911,-0.196,-0.214,-0.1916,-0.2186,-0.1986,-0.1957,-0.2075,-0.1463,-0.2298,-0.1801,-0.2099,-0.184,-0.135,-0.1567,-0.1969,-0.2007,-0.1886,-0.1727,-0.1886,-0.191,-0.2598,-0.3151,-0.2524,-0.2104,-0.2116,-0.2471,-0.2112,-0.3004,-0.338,-0.3288,-0.2928,-0.2965,-0.2742,-0.2751,-0.2737,-0.1674,-0.1965,-0.1936,-0.183,-0.2248,-0.1901,-0.2011,-0.191,-0.2181,-0.2247,-0.2214,-0.2254,-0.2305,-0.2233,-0.234,-0.2958,-0.313,-0.2605,-0.1733,-0.2551,-0.2321,-0.2342,-0.241,-0.2439,-0.2209,-0.3038,-0.2538,-0.2515,-0.2317,-0.2684,-0.2177,-0.2638,-0.2512,-0.338,-0.3113,-0.3253,-0.2916,-0.2792,-0.2595,-0.274,-0.2844,-0.2819,-0.3034,-0.2879,-0.2504,-0.2299,-0.2481,-0.2471,-0.2466,-0.2702,-0.282,-0.273,-0.2449,-0.2582,-0.2706,-0.2804,-0.2961,-0.3045,-0.2515,-0.3169,-0.3002,-0.3309,-0.3184,-0.2954,-0.2837,-0.2634,-0.28,-0.2638,-0.2975,-0.2753,-0.2777,-0.2359,-0.2468,-0.2576,-0.2278,-0.265,-0.2353,-0.2265,-0.2292,-0.2268,-0.2484,-0.2652,-0.2402,-0.2672,-0.2956,-0.3025,-0.2769,-0.289,-0.2652,-0.2659,-0.2615,-0.2377,-0.2301,-0.2364,-0.2605,-0.2401,-0.278,-0.2803,-0.4702,-0.4963,-0.5062,-0.4932,-0.4484,-0.3899,-0.3421,-0.3537,-0.1963,-0.1378,-0.0398,-0.1213,-0.1126,-0.1282,-0.0179,0.0195,0.0838,0.1504,0.1982,0.2529,0.2785,0.0814,0.0741,0.0034,-0.104,-0.1523,-0.1697,-0.1566,-0.1791,-0.242,-0.2201,-0.2556,-0.2399,-0.2785,-0.2606,-0.2446,-0.226,-0.2161,-0.2433,-0.2625,-0.2438,-0.2677,-0.2966,-0.2844,-0.2887,-0.2407,-0.284,-0.2942,-0.3296,-0.3039,-0.3424,-0.3348,-0.3515,-0.3778,-0.3978,-0.4016,-0.417,-0.3781,-0.38,-0.3829,-0.3942,-0.3978,-0.4016,-0.4035,-0.405,-0.4061,-0.4067,-0.4073,-0.4078,-0.408,-0.4084,-0.4086,-0.4088,-0.4091,-0.4092,-0.4095,-0.4096,-0.439,-0.4467,-0.3999,-0.4009,-0.3423,-0.3559,-0.3941,-0.3695,-0.3805,-0.43,-0.3735,-0.3878,-0.3811,-0.4029,-0.3956,-0.3829,-0.4323,-0.3913,-0.3999,-0.3642,-0.3695,-0.3811,-0.3697,-0.4385,-0.4174,-0.4134,-0.4515,-0.3939,-0.4008,-0.4086,-0.4113,-0.4256,-0.4299,-0.4346,-0.4595,-0.4212,-0.4098,-0.4048,-0.4228,-0.3975,-0.3824,-0.3874,-0.3908,-0.3919,-0.4043,-0.3851,-0.4216,-0.3954,-0.3962,-0.3723,-0.3843,-0.3958,-0.3942,-0.3926,-0.3696,-0.3812,-0.3687,-0.3544,-0.3647,-0.333,-0.3406,-0.3829,-0.4066,-0.4361,-0.4414,-0.4255,-0.443,-0.4229,-0.4226,-0.4346,-0.4473,-0.4569,-0.447,-0.4624,-0.3808,-0.4424,-0.3956,-0.4272,-0.4354,-0.4457,-0.3941,-0.4061,-0.3706,-0.36,-0.3786,-0.3334,-0.3568,-0.3905,-0.3469,-0.3599,-0.4038,-0.3832,-0.4305,-0.4055,-0.4094,-0.4668,-0.4269,-0.4112,-0.4341,-0.3918,-0.3709,-0.3131,-0.3723,-0.4016,-0.4097,0.4998,0.2715,0.2466,0.121,0.0316,0.042,0.0361,-0.0212,-0.0354,-0.0162,-0.0819,-0.101,-0.1065,-0.0301,0.0315,0.0937,0.0785,0.1667,0.1311,0.2294,0.1142,0.0882,0,0.0384,-0.0104,-0.0288,0.0133,-0.0568,0.0053,-0.0844,0.0108,-0.0324,0.0659,-0.0199,0.0127,-0.0275,-0.015,0.027,0.0397,-0.022,0.0271,-0.0321,-0.0005,-0.0205,-0.0495,-0.0316,0.0347,-0.0362,-0.0084,-0.0931,-0.0631,-0.0069,-0.0553,-0.0849,-0.0896,-0.0189,-0.078,-0.0147,-0.0725,-0.0655,-0.1179,-0.1845,-0.0793,0.02,0.0373,0.1127,0.1168,0.1166,0.133,0.1626,0.2323,0.1197,0.1704,0.072,0.1102,0.1098,0.1816,0.1781,0.107,0.0271,0.0657,0.1122,0.1642,0.1814,0.2783,0.3428,0.1716,0.2025,0.1131,0.1349,0.1258,0.1646,0.1331,0.1144,0.1305,0.1215,0.0973,0.0296,0.0797,0.1497,0.1573,0.2491,0.1198,0.0274,0.1021,0.1005,0.102,0.1419,0.0695,0.1575,0.1801,0.1431,0.0921,0.1369,0.0928,0.0873,0.1,0.1775,0.0819,0.0579,0.0619,0.0699,0.0818,0.0937,0.0977,0.106,0.1136,0.1175,0.1255,0.1294,0.1374,0.1414,0.1493,0.1612,0.1692,0.1811,0.193,0.197,0.2049,0.2089,0.2168,0.2248,0.2287,0.2367,0.2407,0.2486,0.2605,0.2685,0.2804,0.2923,-0.0269,-0.0795,-0.1563,-0.1805,-0.1896,-0.1736,-0.2239,-0.1948,-0.13,-0.1463,-0.0567,-0.0967,-0.0089,-0.0557,-0.0841,-0.0505,-0.0906,-0.0292,-0.0505,-0.007,-0.0809,-0.1157,-0.0363,-0.0818,-0.1229,-0.2126,-0.179,-0.1893,-0.1842,-0.2586,-0.1323,-0.1053,-0.1584,-0.0781,-0.0672,-0.1063,-0.192,-0.2516,-0.1298,-0.1828,-0.2021,-0.2372,-0.2637,-0.3044,-0.1738,-0.1097,-0.0693,-0.0162,-0.0533,-0.0687,-0.058,-0.0987,-0.1632,-0.2081,-0.2603,-0.2257,-0.2252,-0.1047,-0.0294,-0.0477,-0.1096,-0.1175,-0.1121,-0.1217,-0.0572,-0.1017,-0.1751,-0.2202,-0.096,-0.1574,-0.075,-0.0298,-0.0389,-0.0215,0.0605,0.0729,0.0041,0.0244,-0.0351,-0.015,-0.0636,-0.076,-0.0843,-0.051,-0.0138,-0.1064,-0.0267,-0.0265,0.0339,0.0601,-0.0311,0.0657,-0.03,0.0493,-0.0289,-0.1206,-0.0282,0.0081,0.0332,0.1055,0.0644,0.1279,0.1903,0.2111,0.1829,0.1073,0.1902,0.1925,0.1259,0.1644,0.0783,0.1617,0.1145,0.1653,0.2586,0.1326,0.1533,0.072,0.0295,0.07,0.1108,0.0169,0.0682,0.0408,0.0073,-0.0284,-0.0469,0.0268,0.001,0.0419,-0.0269,-0.0596,-0.0845,0.0066,0.0273,0.0532,0.0641,0.1598,0.0587,0.1071,0.1263,0.1383,0.0523,0.0869,0.0519,0.0741,0.1646,0.0554,0.0376,0.0225,0.0784,0.0105,0.0661,0.0848,0.0562,-0.0137,0.0714,0.0427,0.0617,0.0409,-0.0155,0.0179,0.0637,0.0967,0.1554,0.1629,0.0903,0.1588,0.057,0.1255,0.0321,0.0176,0.0983,0.1224,0.1052,0.0569,-0.0274,0.033,0.035,0.0654,0.0217,0.1227,0.1027,0.1241,0.1403,0.1475,0.1621,0.1582,0.1697,0.2286,0.1844,0.1166,0.1359,0.1251,0.1229,0.1189,0.1338,0.2056,0.1363,0.1461,0.2185,0.2381,0.1723,0.1793,0.1992,0.2856,0.2438,0.145,0.087,0.0374,0.0592,0.0655,-0.0031,-0.0525,0.0508,0.031,0.1083,0.0283,0.0215,0.0822,0.0707,0.1039,0.1634,0.1413,0.1412,0.097,0.1625,0.0741,0.0143,-0.0615,0.0012,-0.0533,-0.0934,-0.026,-0.0357,-0.0066,-0.1183,-0.1923,-0.195,-0.2715,-0.0787,-0.017,-0.0606,-0.0697,-0.0123,0.0031,0.0739,-0.0131,0.0526,0.049,-0.0265,-0.1133,-0.0695,-0.0493,-0.0087,0.0013,-0.0239,0.0251,0.1053,0.1047,0.0446,0.0089,0.0262,-0.0198,0.0723,0.1556,0.1273,0.1363,0.1999,0.2128,0.1952,0.2558,0.2584,0.1103,0.089,0.0177,0.0566,0.0703,0.0758,0.0265,0.0516,0.0536,-0.0046,0.0599,0.0255,0.0663,0.0613,0.1331,0.0517,-0.0357,-0.0639,0.0306,-0.026,-0.0429,-0.015,-0.0623,-0.0921,-0.062,-0.1413,-0.0945,-0.1916,-0.1774,-0.1414,-0.0847,-0.1086,-0.1839,-0.0897,-0.124,-0.1118,-0.1136,-0.1159,-0.0355,-0.0638,-0.053,-0.1142,-0.0072,-0.069,0.0167,-0.04,0.0395,-0.0344,-0.0431,-0.1399,-0.0428,-0.0929,-0.0224,-0.0221,-0.0757,-0.0861,-0.1179,-0.1178,-0.2007,-0.1559,-0.1608,-0.1459,-0.1456,-0.0926,-0.1442,-0.0561,-0.0189,0.04,0.018,0.0454,0.0958,0.0678,0.1039,0.0367,0.016,0.1059,0.0314,0.0167,-0.0178,-0.0536,-0.0227,0.0604,0.0739,0.0791,0.1517,0.1476,0.085,0.1097,0.1215,0.2185,0.2093,0.1275,0.0755,0.0623,0.0116,0.055,0.0098,0.0421,0.0111,0.0897,0.0001,0.0348,0.0124,0.0648,-0.0334,0.0197,0.0024,-0.011,0.0807,0.1764,0.0784,0.1304,0.0127,-0.0563,-0.1073,-0.1014,-0.0034,0.0149,0.0324,0.0465,0.0598,0.0531,-0.0428,0.0424,-0.0157,-0.0847,-0.0348,0.0179,0.0132,0.1124,0.0239,0.0269,0.0299,0.0308,0.0328,0.0338,0.0358,0.0378,0.0388,0.0408,0.0418,0.0438,0.0467,0.0487,0.0517,0.0547,0.0557,0.0577,0.0586,0.0606,0.0626,0.0636,0.0656,0.0666,0.0686,0.0715,0.0715,0.0745,0.0765,0.0797,0.0866,0.0886,0.0916,0.1031,0.0278,0.0013,-0.0376,-0.0581,-0.1212,-0.1486,-0.0749,-0.0057,-0.0194,0.001,-0.0294,-0.0617,-0.0648,-0.1554,-0.1288,-0.1162,-0.0947,-0.0694,-0.0302,-0.0188,0.0065,0.0445,0.0571,0.1476,0.0613,-0.0018,-0.0185,0.056,-0.0156,0.0767,0.0203,0.1077,0.0979,0.1033,0.1574,0.1701,0.1506,0.1784,0.0989,0.1664,0.0715,0.038,-0.0021,0.0365,0.0274,0.0937,0.0262,-0.0029,0.0204,-0.0442,-0.0697,-0.1081,-0.1117,-0.2637,-0.2015,-0.1661,-0.2526,-0.1252,-0.1745,-0.1059,-0.0575,-0.1396,-0.0452,-0.0692,-0.0399,-0.0152,-0.0208,0.012,0.0678,-0.0087,-0.0359,-0.1187,-0.02,-0.0018,-0.0286,-0.0598,0.0201,0.0632,0.1221,0.1702,0.1933,0.21,0.1916,0.205,0.2084,0.1956,0.2493,-0.1135,0.135,0.0959,-0.2159,0.0861,-0.1438,0.0775,0.0601,0.1868,0.2688,0.276,0.3135,0.0441,0.5437,0.3246,0.3851,0.4007,0.4831,0.2635,0.2651,0.1491,0.1136,0.0848,0.0456,0.0954,0.1407,0.0512,0.1502,0.135,0.1649,0.165,0.1886,0.1629,0.2535,0.2498,0.2233,0.1838,0.2044,0.2537,0.3268,0.334,0.2905,0.2591,0.2507,0.2275,0.2573,0.2835,0.3278,0.278,0.3475,0.1954,0.1551,0.1542,0.1536,0.1528,0.1525,0.1519,0.1516,0.151,0.1507,0.1502,0.1496,0.1493,0.1487,0.1484,0.1478,0.1947,0.2063,0.3553,0.3449,0.3289 };

            matlab.PutWorkspaceData("data", "base", data);
            matlab.Execute(@"dwtmode('asym');");
            matlab.Execute(@"[c,l] = wavedec(data,5,'db4');");
            matlab.Execute(@"xd = wden(c, 'minimaxi', 'h', 'sln', 5, 'db4');");
            matlab.Execute(@"plot(xd);");

            object result = null;

            matlab.GetWorkspaceData("xd", "base", out result);

            Console.WriteLine(((double[,])result).Length);
            Console.ReadLine();
        }
    }
}
