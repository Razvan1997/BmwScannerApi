using BmwScannerApi.Models;

namespace BmwScannerApi.Services
{
    public class WheelsImageService
    {
        public static Task<List<Wheel>> GetData()
        {
            List<Wheel> wheelInfos = new List<Wheel>
                {
                //e87
                    new Wheel
                    {
                        BtnTabId = "E87",
                        WheelStyleName = "style 32",
                        WheelPicture = "https://i.imgur.com/m8G7vQ3t.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E87",
                        WheelStyleName = "style 139",
                        WheelPicture = "https://i.imgur.com/v6t1pCTt.jpg",
                        MostPopular = false,
                    },

                    new Wheel
                    {
                        BtnTabId = "E87",
                        WheelStyleName = "style 140",
                        WheelPicture = "https://i.imgur.com/CmttUTDt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E87",
                        WheelStyleName = "style 141",
                        WheelPicture = "https://i.imgur.com/zBRMvixt.jpg",
                        MostPopular = true
                    },
                    new Wheel
                    {
                        BtnTabId = "E87",
                        WheelStyleName = "style 142",
                        WheelPicture = "https://i.imgur.com/KRsaXJzt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E87",
                        WheelStyleName = "style 151",
                        WheelPicture = "https://i.imgur.com/GLvsRM7t.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E87",
                        WheelStyleName = "style 178",
                        WheelPicture = "https://i.imgur.com/5l49JfHt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E87",
                        WheelStyleName = "style 179",
                        WheelPicture = "https://i.imgur.com/2PPicjut.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E87",
                        WheelStyleName = "style 180",
                        WheelPicture = "https://i.imgur.com/neJUWNyt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E87",
                        WheelStyleName = "style 181",
                        WheelPicture = "https://i.imgur.com/YdRyVOHt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E87",
                        WheelStyleName = "style 182",
                        WheelPicture = "https://i.imgur.com/pUlfGkOt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E87",
                        WheelStyleName = "style 207",
                        WheelPicture = "https://i.imgur.com/pGwrBySt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E87",
                        WheelStyleName = "style 208",
                        WheelPicture = "https://i.imgur.com/zQnJbSOt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E87",
                        WheelStyleName = "style 216",
                        WheelPicture = "https://i.imgur.com/2ac7dGEt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E87",
                        WheelStyleName = "style 217",
                        WheelPicture = "https://i.imgur.com/2ac7dGEt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E87",
                        WheelStyleName = "style 222",
                        WheelPicture = "https://i.imgur.com/OGCQJQut.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E87",
                        WheelStyleName = "style 229",
                        WheelPicture = "https://i.imgur.com/00zTiuCt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E87",
                        WheelStyleName = "style 255",
                        WheelPicture = "https://i.imgur.com/eBEJBl4t.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E87",
                        WheelStyleName = "style 256",
                        WheelPicture = "https://i.imgur.com/SIggDl4t.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E87",
                        WheelStyleName = "style 261",
                        WheelPicture = "https://i.imgur.com/v8GkG0Gt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E87",
                        WheelStyleName = "style 262",
                        WheelPicture = "https://i.imgur.com/yiTRzdot.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E87",
                        WheelStyleName = "style 263",
                        WheelPicture = "https://i.imgur.com/4613efst.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E87",
                        WheelStyleName = "style 264",
                        WheelPicture = "https://i.imgur.com/adVWaDjt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E87",
                        WheelStyleName = "style 269",
                        WheelPicture = "https://i.imgur.com/46SVKdLt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E87",
                        WheelStyleName = "style 270",
                        WheelPicture = "https://i.imgur.com/xq4Xc2Mt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E87",
                        WheelStyleName = "style 311",
                        WheelPicture = "https://i.imgur.com/Zr34Y6Wt.jpg",
                        MostPopular = true
                    },
                    new Wheel
                    {
                        BtnTabId = "E87",
                        WheelStyleName = "style 313",
                        WheelPicture = "https://i.imgur.com/NZceG4vt.jpg",
                        MostPopular = false
                    },
                    new Wheel
                    {
                        BtnTabId = "E87",
                        WheelStyleName = "style 359",
                        WheelPicture = "https://i.imgur.com/7DkTR78t.jpg",
                        MostPopular = true,
                    },
                    new Wheel
                    {
                        BtnTabId = "E87",
                        WheelStyleName = "style 360",
                        WheelPicture = "https://i.imgur.com/8JGZc0Ot.jpg",
                        MostPopular = true,
                    },

                    //f20
                    new Wheel
                    {
                        BtnTabId = "F20",
                        WheelStyleName = "style 361",
                        WheelPicture = "https://i.imgur.com/K6XWvZzt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "F20",
                        WheelStyleName = "style 376",
                        WheelPicture = "https://i.imgur.com/VjJelcKt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "F20",
                        WheelStyleName = "style 377",
                        WheelPicture = "https://i.imgur.com/aTlnGNwt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "F20",
                        WheelStyleName = "style 378",
                        WheelPicture = "https://i.imgur.com/GG9m9Ert.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "F20",
                        WheelStyleName = "style 379",
                        WheelPicture = "https://i.imgur.com/6uXhYbCt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "F20",
                        WheelStyleName = "style 380",
                        WheelPicture = "https://i.imgur.com/Hrrb8l6t.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "F20",
                        WheelStyleName = "style 381",
                        WheelPicture = "https://i.imgur.com/Atnmr0Rt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "F20",
                        WheelStyleName = "style 382",
                        WheelPicture = "https://i.imgur.com/r4ew93at.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "F20",
                        WheelStyleName = "style 385",
                        WheelPicture = "https://i.imgur.com/9pj1u0jt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "F20",
                        WheelStyleName = "style 388",
                        WheelPicture = "https://i.imgur.com/IMV03Rdt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "F20",
                        WheelStyleName = "style 405",
                        WheelPicture = "https://i.imgur.com/arfLhEKt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "F20",
                        WheelStyleName = "style 411",
                        WheelPicture = "https://i.imgur.com/BnEWgFst.jpg",
                        MostPopular = false,
                    },
                    //e30
                    new Wheel
                    {
                        BtnTabId = "E30",
                        WheelStyleName = "style 5",
                        WheelPicture = "https://i.imgur.com/q4c4fTMt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E30",
                        WheelStyleName = "style 10",
                        WheelPicture = "https://i.imgur.com/NvB8c4et.jpg",
                        MostPopular = false,
                    },
                    //e36
                    new Wheel
                    {
                        BtnTabId = "E36",
                        WheelStyleName = "style 5",
                        WheelPicture = "https://i.imgur.com/q4c4fTMt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E36",
                        WheelStyleName = "style 6",
                        WheelPicture = "https://i.imgur.com/ojIk8nAt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E36",
                        WheelStyleName = "style 10",
                        WheelPicture = "https://i.imgur.com/NvB8c4et.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E36",
                        WheelStyleName = "style 13",
                        WheelPicture = "https://i.imgur.com/6y7jjWct.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E36",
                        WheelStyleName = "style 14",
                        WheelPicture = "https://i.imgur.com/SQV9n3ft.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E36",
                        WheelStyleName = "style 16",
                        WheelPicture = "https://i.imgur.com/pY7TWXSt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E36",
                        WheelStyleName = "style 17",
                        WheelPicture = "https://i.imgur.com/Ab75Ii4t.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E36",
                        WheelStyleName = "style 18",
                        WheelPicture = "https://i.imgur.com/Ud6xE7Kt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E36",
                        WheelStyleName = "style 19",
                        WheelPicture = "https://i.imgur.com/13rgKo8t.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E36",
                        WheelStyleName = "style 22",
                        WheelPicture = "https://i.imgur.com/fJyeBEwt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E36",
                        WheelStyleName = "style 23",
                        WheelPicture = "https://i.imgur.com/Upv5gw0t.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E36",
                        WheelStyleName = "style 24",
                        WheelPicture = "https://i.imgur.com/uUORV0Nt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E36",
                        WheelStyleName = "style 25",
                        WheelPicture = "https://i.imgur.com/t3RxvsXt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E36",
                        WheelStyleName = "style 26",
                        WheelPicture = "https://i.imgur.com/PtqlLwMt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E36",
                        WheelStyleName = "style 27",
                        WheelPicture = "https://i.imgur.com/cefMsTTt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E36",
                        WheelStyleName = "style 28",
                        WheelPicture = "https://i.imgur.com/HETZI5Jt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E36",
                        WheelStyleName = "style 29",
                        WheelPicture = "https://i.imgur.com/YSi6q3Nt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E36",
                        WheelStyleName = "style 30",
                        WheelPicture = "https://i.imgur.com/UPIeKtKt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E36",
                        WheelStyleName = "style 32",
                        WheelPicture = "https://i.imgur.com/m8G7vQ3t.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E36",
                        WheelStyleName = "style 34",
                        WheelPicture = "https://i.imgur.com/UOBIcYJt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E36",
                        WheelStyleName = "style 35",
                        WheelPicture = "https://i.imgur.com/TqpRh0Ut.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E36",
                        WheelStyleName = "style 36",
                        WheelPicture = "https://i.imgur.com/zUoqHFnt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E36",
                        WheelStyleName = "style 38",
                        WheelPicture = "https://i.imgur.com/PNB8Vkct.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E36",
                        WheelStyleName = "style 39",
                        WheelPicture = "https://i.imgur.com/lgWRkfat.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E36",
                        WheelStyleName = "style 40",
                        WheelPicture = "https://i.imgur.com/DRitMQut.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E36",
                        WheelStyleName = "style 41",
                        WheelPicture = "https://i.imgur.com/kPfmmWKt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E36",
                        WheelStyleName = "style 42",
                        WheelPicture = "https://i.imgur.com/T9WHjDft.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E36",
                        WheelStyleName = "style 43",
                        WheelPicture = "https://i.imgur.com/Sq0waJ3t.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E36",
                        WheelStyleName = "style 44",
                        WheelPicture = "https://i.imgur.com/6mR5Qdct.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E36",
                        WheelStyleName = "style 45",
                        WheelPicture = "https://i.imgur.com/CXkmRtwt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E36",
                        WheelStyleName = "style 47",
                        WheelPicture = "https://i.imgur.com/smndUyit.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E36",
                        WheelStyleName = "style 50",
                        WheelPicture = "https://i.imgur.com/NTMYTaKt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E36",
                        WheelStyleName = "style 51",
                        WheelPicture = "https://i.imgur.com/9QVKQ42t.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E36",
                        WheelStyleName = "style 55",
                        WheelPicture = "https://i.imgur.com/xfvHmu4t.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E36",
                        WheelStyleName = "style 64",
                        WheelPicture = "https://i.imgur.com/R9UoxK8t.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E36",
                        WheelStyleName = "style 71",
                        WheelPicture = "https://i.imgur.com/JSW1vZct.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E36",
                        WheelStyleName = "style 78",
                        WheelPicture = "https://i.imgur.com/wGXRyNHt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E36",
                        WheelStyleName = "style 85",
                        WheelPicture = "https://i.imgur.com/dPbeh5Xt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E36",
                        WheelStyleName = "style 86",
                        WheelPicture = "https://i.imgur.com/LQzuXzmt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E36",
                        WheelStyleName = "style 88",
                        WheelPicture = "https://i.imgur.com/EihyrSat.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E36",
                        WheelStyleName = "style 89",
                        WheelPicture = "https://i.imgur.com/UOle4qRt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E36",
                        WheelStyleName = "style 96",
                        WheelPicture = "https://i.imgur.com/PhPJGVUt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E36",
                        WheelStyleName = "style 133",
                        WheelPicture = "https://i.imgur.com/yIbS0xRt.jpg",
                        MostPopular = false,
                    },
                     new Wheel
                    {
                        BtnTabId = "E36",
                        WheelStyleName = "style 136",
                        WheelPicture = "https://i.imgur.com/iaklo30t.jpg",
                        MostPopular = false,
                    },
                     new Wheel
                    {
                        BtnTabId = "E36",
                        WheelStyleName = "style 137",
                        WheelPicture = "https://i.imgur.com/XVcMMQDt.jpg",
                        MostPopular = false,
                    },
                     //e46
                      new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 10",
                        WheelPicture = "https://i.imgur.com/NvB8c4et.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 18",
                        WheelPicture = "https://i.imgur.com/Ud6xE7Kt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 25",
                        WheelPicture = "https://i.imgur.com/t3RxvsXt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 26",
                        WheelPicture = "https://i.imgur.com/PtqlLwMt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 27",
                        WheelPicture = "https://i.imgur.com/cefMsTTt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 28",
                        WheelPicture = "https://i.imgur.com/HETZI5Jt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 29",
                        WheelPicture = "https://i.imgur.com/YSi6q3Nt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 30",
                        WheelPicture = "https://i.imgur.com/UPIeKtKt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 32",
                        WheelPicture = "https://i.imgur.com/m8G7vQ3t.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 34",
                        WheelPicture = "https://i.imgur.com/UOBIcYJt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 35",
                        WheelPicture = "https://i.imgur.com/TqpRh0Ut.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 36",
                        WheelPicture = "https://i.imgur.com/zUoqHFnt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 41",
                        WheelPicture = "https://i.imgur.com/kPfmmWKt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 42",
                        WheelPicture = "https://i.imgur.com/T9WHjDft.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 43",
                        WheelPicture = "https://i.imgur.com/Sq0waJ3t.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 44",
                        WheelPicture = "https://i.imgur.com/6mR5Qdct.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 45",
                        WheelPicture = "https://i.imgur.com/CXkmRtwt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 46",
                        WheelPicture = "https://i.imgur.com/1akyjKrt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 47",
                        WheelPicture = "https://i.imgur.com/smndUyit.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 50",
                        WheelPicture = "https://i.imgur.com/NTMYTaKt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 51",
                        WheelPicture = "https://i.imgur.com/9QVKQ42t.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 53",
                        WheelPicture = "https://i.imgur.com/LSV9p7Dt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 54",
                        WheelPicture = "https://i.imgur.com/6DLWzP5t.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 55",
                        WheelPicture = "https://i.imgur.com/xfvHmu4t.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 64",
                        WheelPicture = "https://i.imgur.com/R9UoxK8t.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 67",
                        WheelPicture = "https://i.imgur.com/Yj1YlXKt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 68",
                        WheelPicture = "https://i.imgur.com/gxntWeyt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 71",
                        WheelPicture = "https://i.imgur.com/JSW1vZct.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 72",
                        WheelPicture = "https://i.imgur.com/8rx6XrAt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 73",
                        WheelPicture = "https://i.imgur.com/KP4tWByt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 73",
                        WheelPicture = "https://i.imgur.com/KP4tWByt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 78",
                        WheelPicture = "https://i.imgur.com/wGXRyNHt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 79",
                        WheelPicture = "https://i.imgur.com/vRlsvg0t.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 85",
                        WheelPicture = "https://i.imgur.com/dPbeh5Xt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 86",
                        WheelPicture = "https://i.imgur.com/LQzuXzmt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 88",
                        WheelPicture = "https://i.imgur.com/EihyrSat.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 89",
                        WheelPicture = "https://i.imgur.com/UOle4qRt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 96",
                        WheelPicture = "https://i.imgur.com/PhPJGVUt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 97",
                        WheelPicture = "https://i.imgur.com/obYRG2ht.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 98",
                        WheelPicture = "https://i.imgur.com/v0zS2YRt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 101",
                        WheelPicture = "https://i.imgur.com/C2Ud8M6t.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 119",
                        WheelPicture = "https://i.imgur.com/2jzy7Ygt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 125",
                        WheelPicture = "https://i.imgur.com/T5GUr1yt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 127",
                        WheelPicture = "https://i.imgur.com/GnMtwTct.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 133",
                        WheelPicture = "https://i.imgur.com/yIbS0xRt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 135",
                        WheelPicture = "https://i.imgur.com/5kWYM9Ft.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 136",
                        WheelPicture = "https://i.imgur.com/iaklo30t.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 137",
                        WheelPicture = "https://i.imgur.com/XVcMMQDt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 152",
                        WheelPicture = "https://i.imgur.com/SnuPSqQt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 163",
                        WheelPicture = "https://i.imgur.com/CPOaGGOt.jpg",
                        MostPopular = true,
                    },
                       new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 164",
                        WheelPicture = "https://i.imgur.com/JEMN1sVt.jpg",
                        MostPopular = true,
                    },
                        new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 169",
                        WheelPicture = "https://i.imgur.com/qjXx6Ptt.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 170",
                        WheelPicture = "https://i.imgur.com/NlMWSftt.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 171",
                        WheelPicture = "https://i.imgur.com/nwHRC3Ht.jpg",
                        MostPopular = true,
                    },
                        new Wheel
                    {
                        BtnTabId = "E46",
                        WheelStyleName = "style 269",
                        WheelPicture = "https://i.imgur.com/46SVKdLt.jpg",
                        MostPopular = false,
                    },
                    //e90
                     new Wheel
                    {
                        BtnTabId = "E90",
                        WheelStyleName = "style 32",
                        WheelPicture = "https://i.imgur.com/m8G7vQ3t.jpg",
                        MostPopular = false,
                    },
                     new Wheel
                    {
                        BtnTabId = "E90",
                        WheelStyleName = "style 101",
                        WheelPicture = "https://i.imgur.com/C2Ud8M6t.jpg",
                        MostPopular = false,
                    },
                     new Wheel
                    {
                        BtnTabId = "E90",
                        WheelStyleName = "style 152",
                        WheelPicture = "https://i.imgur.com/SnuPSqQt.jpg",
                        MostPopular = false,
                    },
                     new Wheel
                    {
                        BtnTabId = "E90",
                        WheelStyleName = "style 154",
                        WheelPicture = "https://i.imgur.com/rNieN53t.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E90",
                        WheelStyleName = "style 155",
                        WheelPicture = "https://i.imgur.com/NHMkzE2t.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E90",
                        WheelStyleName = "style 156",
                        WheelPicture = "https://i.imgur.com/CLYV4Wtt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E90",
                        WheelStyleName = "style 157",
                        WheelPicture = "https://i.imgur.com/WixR00Wt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E90",
                        WheelStyleName = "style 158",
                        WheelPicture = "https://i.imgur.com/2T85IFMt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E90",
                        WheelStyleName = "style 159",
                        WheelPicture = "https://i.imgur.com/uDBujbLt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E90",
                        WheelStyleName = "style 160",
                        WheelPicture = "https://i.imgur.com/zuCcNIQt.jpg",
                        MostPopular = true,
                    },
                      new Wheel
                    {
                        BtnTabId = "E90",
                        WheelStyleName = "style 161",
                        WheelPicture = "https://i.imgur.com/rVG6UTIt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E90",
                        WheelStyleName = "style 162",
                        WheelPicture = "https://i.imgur.com/3HXpHqat.jpg",
                        MostPopular = true,
                    },
                      new Wheel
                    {
                        BtnTabId = "E90",
                        WheelStyleName = "style 179",
                        WheelPicture = "https://i.imgur.com/2PPicjut.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E90",
                        WheelStyleName = "style 185",
                        WheelPicture = "https://i.imgur.com/5dphYE8t.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E90",
                        WheelStyleName = "style 187",
                        WheelPicture = "https://i.imgur.com/rOyaSfht.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E90",
                        WheelStyleName = "style 188",
                        WheelPicture = "https://i.imgur.com/rgovlAjt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E90",
                        WheelStyleName = "style 189",
                        WheelPicture = "https://i.imgur.com/Un0WLdCt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E90",
                        WheelStyleName = "style 189",
                        WheelPicture = "https://i.imgur.com/Un0WLdCt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E90",
                        WheelStyleName = "style 190",
                        WheelPicture = "https://i.imgur.com/xRYNWTPt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E90",
                        WheelStyleName = "style 193",
                        WheelPicture = "https://i.imgur.com/99Qg7pGt.jpg",
                        MostPopular = true,
                    },
                      new Wheel
                    {
                        BtnTabId = "E90",
                        WheelStyleName = "style 194",
                        WheelPicture = "https://i.imgur.com/mHvbiqnt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E90",
                        WheelStyleName = "style 195",
                        WheelPicture = "https://i.imgur.com/u0Lm1W1t.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E90",
                        WheelStyleName = "style 196",
                        WheelPicture = "https://i.imgur.com/REST7i3t.jpg",
                        MostPopular = true,
                    },
                      new Wheel
                    {
                        BtnTabId = "E90",
                        WheelStyleName = "style 197",
                        WheelPicture = "https://i.imgur.com/irnvqhNt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E90",
                        WheelStyleName = "style 198",
                        WheelPicture = "https://i.imgur.com/vzw1z1At.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E90",
                        WheelStyleName = "style 199",
                        WheelPicture = "https://i.imgur.com/8A55D1ut.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E90",
                        WheelStyleName = "style 216",
                        WheelPicture = "https://i.imgur.com/2ac7dGEt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E90",
                        WheelStyleName = "style 219",
                        WheelPicture = "https://i.imgur.com/1Fa6gUft.jpg",
                        MostPopular = true,
                    },
                      new Wheel
                    {
                        BtnTabId = "E90",
                        WheelStyleName = "style 220",
                        WheelPicture = "https://i.imgur.com/giIulbst.jpg",
                        MostPopular = true,
                    },
                      new Wheel
                    {
                        BtnTabId = "E90",
                        WheelStyleName = "style 225",
                        WheelPicture = "https://i.imgur.com/ErrwasFt.jpg",
                        MostPopular = true,
                    },
                      new Wheel
                    {
                        BtnTabId = "E90",
                        WheelStyleName = "style 228",
                        WheelPicture = "https://i.imgur.com/YRyv81st.jpg",
                        MostPopular = true,
                    },
                      new Wheel
                    {
                        BtnTabId = "E90",
                        WheelStyleName = "style 230",
                        WheelPicture = "https://i.imgur.com/0jbQcv7t.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E90",
                        WheelStyleName = "style 260",
                        WheelPicture = "https://i.imgur.com/9ZnQYn3t.jpg",
                        MostPopular = true,
                    },
                      new Wheel
                    {
                        BtnTabId = "E90",
                        WheelStyleName = "style 268",
                        WheelPicture = "https://i.imgur.com/M80d21Wt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E90",
                        WheelStyleName = "style 269",
                        WheelPicture = "https://i.imgur.com/46SVKdLt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E90",
                        WheelStyleName = "style 270",
                        WheelPicture = "https://i.imgur.com/xq4Xc2Mt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E90",
                        WheelStyleName = "style 282",
                        WheelPicture = "https://i.imgur.com/ytOeDlCt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E90",
                        WheelStyleName = "style 283",
                        WheelPicture = "https://i.imgur.com/esAbTR8t.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E90",
                        WheelStyleName = "style 284",
                        WheelPicture = "https://i.imgur.com/KPA37A8t.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E90",
                        WheelStyleName = "style 285",
                        WheelPicture = "https://i.imgur.com/4w1ne0pt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "E90",
                        WheelStyleName = "style 286",
                        WheelPicture = "https://i.imgur.com/nDR6hY8t.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "E90",
                        WheelStyleName = "style 287",
                        WheelPicture = "https://i.imgur.com/WJ2HuIvt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "E90",
                        WheelStyleName = "style 306",
                        WheelPicture = "https://i.imgur.com/jOWcNlyt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "E90",
                        WheelStyleName = "style 313",
                        WheelPicture = "https://i.imgur.com/NZceG4vt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "E90",
                        WheelStyleName = "style 338",
                        WheelPicture = "https://i.imgur.com/tvksXPCt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "E90",
                        WheelStyleName = "style 339",
                        WheelPicture = "https://i.imgur.com/VEiFQhOt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "E90",
                        WheelStyleName = "style 340",
                        WheelPicture = "https://i.imgur.com/FBeYPwEt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "E90",
                        WheelStyleName = "style 342",
                        WheelPicture = "https://i.imgur.com/TU8OeD6t.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "E90",
                        WheelStyleName = "style 360",
                        WheelPicture = "https://i.imgur.com/8JGZc0Ot.jpg",
                        MostPopular = false,
                    },
                       //f30
                       new Wheel
                    {
                        BtnTabId = "F30",
                        WheelStyleName = "style 306",
                        WheelPicture = "https://i.imgur.com/jOWcNlyt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "F30",
                        WheelStyleName = "style 361",
                        WheelPicture = "https://i.imgur.com/K6XWvZzt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "F30",
                        WheelStyleName = "style 390",
                        WheelPicture = "https://i.imgur.com/x157OHF.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "F30",
                        WheelStyleName = "style 391",
                        WheelPicture = "https://i.imgur.com/M7NM2vft.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "F30",
                        WheelStyleName = "style 392",
                        WheelPicture = "https://i.imgur.com/UifWJvet.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "F30",
                        WheelStyleName = "style 393",
                        WheelPicture = "https://i.imgur.com/vWAcYqqt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "F30",
                        WheelStyleName = "style 394",
                        WheelPicture = "https://i.imgur.com/wGZrxmVt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "F30",
                        WheelStyleName = "style 395",
                        WheelPicture = "https://i.imgur.com/6bIRYix.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "F30",
                        WheelStyleName = "style 397",
                        WheelPicture = "https://i.imgur.com/W6HSkMyt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "F30",
                        WheelStyleName = "style 398",
                        WheelPicture = "https://i.imgur.com/Noi4ZNft.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "F30",
                        WheelStyleName = "style 401",
                        WheelPicture = "https://i.imgur.com/b6wGNhit.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "F30",
                        WheelStyleName = "style 404",
                        WheelPicture = "https://i.imgur.com/buHwxp5t.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "F30",
                        WheelStyleName = "style 405",
                        WheelPicture = "https://i.imgur.com/arfLhEKt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "F30",
                        WheelStyleName = "style 413",
                        WheelPicture = "https://i.imgur.com/DV71lsCt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "F30",
                        WheelStyleName = "style 414",
                        WheelPicture = "https://i.imgur.com/bvG3Q2tt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "F30",
                        WheelStyleName = "style 415",
                        WheelPicture = "https://i.imgur.com/6rqE9bSt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "F30",
                        WheelStyleName = "style 416",
                        WheelPicture = "https://i.imgur.com/q9V61ept.jpg",
                        MostPopular = false,
                    },
                       //28
                       new Wheel
                    {
                        BtnTabId = "E28",
                        WheelStyleName = "style 5",
                        WheelPicture = "https://i.imgur.com/q4c4fTMt.jpg",
                        MostPopular = false,
                    },
                       //e34
                       new Wheel
                    {
                        BtnTabId = "E34",
                        WheelStyleName = "style 2",
                        WheelPicture = "https://i.imgur.com/K9SySrut.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "E34",
                        WheelStyleName = "style 3",
                        WheelPicture = "https://i.imgur.com/pkKXp5wt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "E34",
                        WheelStyleName = "style 4",
                        WheelPicture = "https://i.imgur.com/lbT5SLNt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "E34",
                        WheelStyleName = "style 5",
                        WheelPicture = "https://i.imgur.com/q4c4fTMt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "E34",
                        WheelStyleName = "style 7",
                        WheelPicture = "https://i.imgur.com/fSOd4blt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "E34",
                        WheelStyleName = "style 7",
                        WheelPicture = "https://i.imgur.com/fSOd4blt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "E34",
                        WheelStyleName = "style 10",
                        WheelPicture = "https://i.imgur.com/NvB8c4et.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "E34",
                        WheelStyleName = "style 14",
                        WheelPicture = "https://i.imgur.com/SQV9n3ft.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "E34",
                        WheelStyleName = "style 16",
                        WheelPicture = "https://i.imgur.com/pY7TWXSt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "E34",
                        WheelStyleName = "style 18",
                        WheelPicture = "https://i.imgur.com/Ud6xE7Kt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "E34",
                        WheelStyleName = "style 19",
                        WheelPicture = "https://i.imgur.com/13rgKo8t.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "E34",
                        WheelStyleName = "style 20",
                        WheelPicture = "https://i.imgur.com/8PYFsYAt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "E34",
                        WheelStyleName = "style 21",
                        WheelPicture = "https://i.imgur.com/F9EgqL2t.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "E34",
                        WheelStyleName = "style 26",
                        WheelPicture = "https://i.imgur.com/PtqlLwMt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "E34",
                        WheelStyleName = "style 29",
                        WheelPicture = "https://i.imgur.com/YSi6q3Nt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "E34",
                        WheelStyleName = "style 32",
                        WheelPicture = "https://i.imgur.com/m8G7vQ3t.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "E34",
                        WheelStyleName = "style 37",
                        WheelPicture = "https://i.imgur.com/34T4PJFt.jpg",
                        MostPopular = false,
                    },

                      //e39
                      new Wheel
                    {
                        BtnTabId = "E39",
                        WheelStyleName = "style 16",
                        WheelPicture = "https://i.imgur.com/pY7TWXSt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E39",
                        WheelStyleName = "style 18",
                        WheelPicture = "https://i.imgur.com/Ud6xE7Kt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E39",
                        WheelStyleName = "style 19",
                        WheelPicture = "https://i.imgur.com/Ud6xE7Kt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E39",
                        WheelStyleName = "style 25",
                        WheelPicture = "https://i.imgur.com/13rgKo8t.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E39",
                        WheelStyleName = "style 29",
                        WheelPicture = "https://i.imgur.com/YSi6q3Nt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E39",
                        WheelStyleName = "style 31",
                        WheelPicture = "https://i.imgur.com/dmx4HNBt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E39",
                        WheelStyleName = "style 32",
                        WheelPicture = "https://i.imgur.com/m8G7vQ3t.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E39",
                        WheelStyleName = "style 33",
                        WheelPicture = "https://i.imgur.com/D8a7WHct.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E39",
                        WheelStyleName = "style 37",
                        WheelPicture = "https://i.imgur.com/34T4PJFt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E39",
                        WheelStyleName = "style 38",
                        WheelPicture = "https://i.imgur.com/PNB8Vkct.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E39",
                        WheelStyleName = "style 48",
                        WheelPicture = "https://i.imgur.com/J10C2Bht.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E39",
                        WheelStyleName = "style 49",
                        WheelPicture = "https://i.imgur.com/RHR0AuQt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E39",
                        WheelStyleName = "style 50",
                        WheelPicture = "https://i.imgur.com/NTMYTaKt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E39",
                        WheelStyleName = "style 65",
                        WheelPicture = "https://i.imgur.com/4S4giSmt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E39",
                        WheelStyleName = "style 66",
                        WheelPicture = "https://i.imgur.com/wL1q233t.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E39",
                        WheelStyleName = "style 69",
                        WheelPicture = "https://i.imgur.com/R8Pe2fvt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E39",
                        WheelStyleName = "style 71",
                        WheelPicture = "https://i.imgur.com/JSW1vZct.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E39",
                        WheelStyleName = "style 77",
                        WheelPicture = "https://i.imgur.com/zybAyRmt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E39",
                        WheelStyleName = "style 80",
                        WheelPicture = "https://i.imgur.com/Km0l64xt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E39",
                        WheelStyleName = "style 81",
                        WheelPicture = "https://i.imgur.com/09LCASht.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E39",
                        WheelStyleName = "style 82",
                        WheelPicture = "https://i.imgur.com/MCeRVR7t.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E39",
                        WheelStyleName = "style 83",
                        WheelPicture = "https://i.imgur.com/Urax34nt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E39",
                        WheelStyleName = "style 85",
                        WheelPicture = "https://i.imgur.com/dPbeh5Xt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E39",
                        WheelStyleName = "style 86",
                        WheelPicture = "https://i.imgur.com/LQzuXzmt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E39",
                        WheelStyleName = "style 89",
                        WheelPicture = "https://i.imgur.com/UOle4qRt.jpg",
                        MostPopular = false,
                    },
                    //E60
                    new Wheel
                    {
                        BtnTabId = "E60",
                        WheelStyleName = "style 32",
                        WheelPicture = "https://i.imgur.com/m8G7vQ3t.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E60",
                        WheelStyleName = "style 50",
                        WheelPicture = "https://i.imgur.com/NTMYTaKt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E60",
                        WheelStyleName = "style 71",
                        WheelPicture = "https://i.imgur.com/JSW1vZct.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E60",
                        WheelStyleName = "style 89",
                        WheelPicture = "https://i.imgur.com/UOle4qRt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E60",
                        WheelStyleName = "style 101",
                        WheelPicture = "https://i.imgur.com/C2Ud8M6t.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E60",
                        WheelStyleName = "style 115",
                        WheelPicture = "https://i.imgur.com/OZAmnMit.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E60",
                        WheelStyleName = "style 116",
                        WheelPicture = "https://i.imgur.com/ggd385xt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E60",
                        WheelStyleName = "style 122",
                        WheelPicture = "https://i.imgur.com/yEAirVGt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E60",
                        WheelStyleName = "style 123",
                        WheelPicture = "https://i.imgur.com/sRvgDFDt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E60",
                        WheelStyleName = "style 124",
                        WheelPicture = "https://i.imgur.com/9dddKtat.jpg",
                        MostPopular = true,
                    },
                    new Wheel
                    {
                        BtnTabId = "E60",
                        WheelStyleName = "style 125",
                        WheelPicture = "https://i.imgur.com/T5GUr1yt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E60",
                        WheelStyleName = "style 128",
                        WheelPicture = "https://i.imgur.com/xFYKGH2t.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E60",
                        WheelStyleName = "style 129",
                        WheelPicture = "https://i.imgur.com/BxktbUwt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E60",
                        WheelStyleName = "style 134",
                        WheelPicture = "https://i.imgur.com/5oj9X1st.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E60",
                        WheelStyleName = "style 134",
                        WheelPicture = "https://i.imgur.com/5oj9X1st.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E60",
                        WheelStyleName = "style 135",
                        WheelPicture = "https://i.imgur.com/5kWYM9Ft.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E60",
                        WheelStyleName = "style 138",
                        WheelPicture = "https://i.imgur.com/9EEDUOut.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E60",
                        WheelStyleName = "style 144",
                        WheelPicture = "https://i.imgur.com/YNPvMIft.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E60",
                        WheelStyleName = "style 152",
                        WheelPicture = "https://i.imgur.com/SnuPSqQt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E60",
                        WheelStyleName = "style 166",
                        WheelPicture = "https://i.imgur.com/T6eXZsVt.jpg",
                        MostPopular = true,
                    },
                    new Wheel
                    {
                        BtnTabId = "E60",
                        WheelStyleName = "style 167",
                        WheelPicture = "https://i.imgur.com/v2YPpP3t.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E60",
                        WheelStyleName = "style 172",
                        WheelPicture = "https://i.imgur.com/kpfUtSct.jpg",
                        MostPopular = true,
                    },
                    new Wheel
                    {
                        BtnTabId = "E60",
                        WheelStyleName = "style 172",
                        WheelPicture = "https://i.imgur.com/2PPicjut.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E60",
                        WheelStyleName = "style 179",
                        WheelPicture = "https://i.imgur.com/kpfUtSct.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E60",
                        WheelStyleName = "style 184",
                        WheelPicture = "https://i.imgur.com/njEnX81t.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E60",
                        WheelStyleName = "style 190",
                        WheelPicture = "https://i.imgur.com/xRYNWTPt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E60",
                        WheelStyleName = "style 228",
                        WheelPicture = "https://i.imgur.com/YRyv81st.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E60",
                        WheelStyleName = "style 242",
                        WheelPicture = "https://i.imgur.com/aPTHgmKt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E60",
                        WheelStyleName = "style 243",
                        WheelPicture = "https://i.imgur.com/kAbPX4pt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E60",
                        WheelStyleName = "style 244",
                        WheelPicture = "https://i.imgur.com/Bt6F3zXt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E60",
                        WheelStyleName = "style 245",
                        WheelPicture = "https://i.imgur.com/BoxngDBt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E60",
                        WheelStyleName = "style 246",
                        WheelPicture = "https://i.imgur.com/uyafU6Ut.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E60",
                        WheelStyleName = "style 247",
                        WheelPicture = "https://i.imgur.com/yfgUaoUt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E60",
                        WheelStyleName = "style 269",
                        WheelPicture = "https://i.imgur.com/46SVKdLt.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E60",
                        WheelStyleName = "style 277",
                        WheelPicture = "https://i.imgur.com/g3mdMCit.jpg",
                        MostPopular = false,
                    },
                    new Wheel
                    {
                        BtnTabId = "E60",
                        WheelStyleName = "style 278",
                        WheelPicture = "https://i.imgur.com/lRr78g7t.jpg",
                        MostPopular = false,
                    },
                    //f10
                    new Wheel
                    {
                        BtnTabId = "F10",
                        WheelStyleName = "style 236",
                        WheelPicture = "https://i.imgur.com/R9EjaBft.jpg",
                        MostPopular = false,
                    },
                     new Wheel
                    {
                        BtnTabId = "F10",
                        WheelStyleName = "style 237",
                        WheelPicture = "https://i.imgur.com/Scqp186t.jpg",
                        MostPopular = false,
                    },
                     new Wheel
                    {
                        BtnTabId = "F10",
                        WheelStyleName = "style 281",
                        WheelPicture = "https://i.imgur.com/h8xtqbgt.jpg",
                        MostPopular = false,
                    },
                     new Wheel
                    {
                        BtnTabId = "F10",
                        WheelStyleName = "style 311",
                        WheelPicture = "https://i.imgur.com/Zr34Y6Wt.jpg",
                        MostPopular = false,
                    },
                     new Wheel
                    {
                        BtnTabId = "F10",
                        WheelStyleName = "style 312",
                        WheelPicture = "https://i.imgur.com/1fy1WVwt.jpg",
                        MostPopular = false,
                    },
                     new Wheel
                    {
                        BtnTabId = "F10",
                        WheelStyleName = "style 327",
                        WheelPicture = "https://i.imgur.com/6oiXEBXt.jpg",
                        MostPopular = false,
                    },
                     new Wheel
                    {
                        BtnTabId = "F10",
                        WheelStyleName = "style 328",
                        WheelPicture = "https://i.imgur.com/hNaYItEt.jpg",
                        MostPopular = false,
                    },
                     new Wheel
                    {
                        BtnTabId = "F10",
                        WheelStyleName = "style 329",
                        WheelPicture = "https://i.imgur.com/NiG9aogt.jpg",
                        MostPopular = false,
                    },
                     new Wheel
                    {
                        BtnTabId = "F10",
                        WheelStyleName = "style 330",
                        WheelPicture = "https://i.imgur.com/MoU2qUdt.jpg",
                        MostPopular = false,
                    },
                     new Wheel
                    {
                        BtnTabId = "F10",
                        WheelStyleName = "style 331",
                        WheelPicture = "https://i.imgur.com/RNRMc7Dt.jpg",
                        MostPopular = false,
                    },
                     new Wheel
                    {
                        BtnTabId = "F10",
                        WheelStyleName = "style 332",
                        WheelPicture = "https://i.imgur.com/iRHvhoft.jpg",
                        MostPopular = false,
                    },
                     new Wheel
                    {
                        BtnTabId = "F10",
                        WheelStyleName = "style 343",
                        WheelPicture = "https://i.imgur.com/WO7spq7t.jpg",
                        MostPopular = false,
                    },
                     new Wheel
                    {
                        BtnTabId = "F10",
                        WheelStyleName = "style 345",
                        WheelPicture = "https://i.imgur.com/iwXQ14Gt.jpg",
                        MostPopular = false,
                    },
                     new Wheel
                    {
                        BtnTabId = "F10",
                        WheelStyleName = "style 349",
                        WheelPicture = "https://i.imgur.com/K8uS4vgt.jpg",
                        MostPopular = false,
                    },
                     new Wheel
                    {
                        BtnTabId = "F10",
                        WheelStyleName = "style 350",
                        WheelPicture = "https://i.imgur.com/eVW1Ewlt.jpg",
                        MostPopular = false,
                    },
                     new Wheel
                    {
                        BtnTabId = "F10",
                        WheelStyleName = "style 351",
                        WheelPicture = "https://i.imgur.com/wRAYejIt.jpg",
                        MostPopular = false,
                    },
                     new Wheel
                    {
                        BtnTabId = "F10",
                        WheelStyleName = "style 356",
                        WheelPicture = "https://i.imgur.com/GZIdEGkt.jpg",
                        MostPopular = false,
                    },
                     new Wheel
                    {
                        BtnTabId = "F10",
                        WheelStyleName = "style 363",
                        WheelPicture = "https://i.imgur.com/djcGLFQt.jpg",
                        MostPopular = false,
                    },
                     new Wheel
                    {
                        BtnTabId = "F10",
                        WheelStyleName = "style 365",
                        WheelPicture = "https://i.imgur.com/DYU4F2ft.jpg",
                        MostPopular = false,
                    },
                     new Wheel
                    {
                        BtnTabId = "F10",
                        WheelStyleName = "style 366",
                        WheelPicture = "https://i.imgur.com/VYLMf5it.jpg",
                        MostPopular = false,
                    },
                     new Wheel
                    {
                        BtnTabId = "F10",
                        WheelStyleName = "style 367",
                        WheelPicture = "https://i.imgur.com/eYtehfvt.jpg",
                        MostPopular = false,
                    },
                     new Wheel
                    {
                        BtnTabId = "F10",
                        WheelStyleName = "style 408",
                        WheelPicture = "https://i.imgur.com/CtMfkMTt.jpg",
                        MostPopular = false,
                    },
                     new Wheel
                    {
                        BtnTabId = "F10",
                        WheelStyleName = "style 409",
                        WheelPicture = "https://i.imgur.com/UFWlahY.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "F10",
                        WheelStyleName = "style 410",
                        WheelPicture = "https://i.imgur.com/YanH4vtt.jpg",
                        MostPopular = false,
                    },
                      //gt-f07
                      new Wheel
                    {
                        BtnTabId = "GT-F07",
                        WheelStyleName = "style 228",
                        WheelPicture = "https://i.imgur.com/YRyv81st.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "GT-F07",
                        WheelStyleName = "style 234",
                        WheelPicture = "https://i.imgur.com/5d90L6st.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "GT-F07",
                        WheelStyleName = "style 238",
                        WheelPicture = "https://i.imgur.com/Bpbie24t.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "GT-F07",
                        WheelStyleName = "style 250",
                        WheelPicture = "https://i.imgur.com/W1vUFSJt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "GT-F07",
                        WheelStyleName = "style 251",
                        WheelPicture = "https://i.imgur.com/hVMjOm2t.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "GT-F07",
                        WheelStyleName = "style 252",
                        WheelPicture = "https://i.imgur.com/xQK3D5dt.jpg",
                        MostPopular = true,
                    },
                      new Wheel
                    {
                        BtnTabId = "GT-F07",
                        WheelStyleName = "style 253",
                        WheelPicture = "https://i.imgur.com/IQ0jmmtt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "GT-F07",
                        WheelStyleName = "style 254",
                        WheelPicture = "https://i.imgur.com/PhyWbBNt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "GT-F07",
                        WheelStyleName = "style 271",
                        WheelPicture = "https://i.imgur.com/CfOVVfRt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "GT-F07",
                        WheelStyleName = "style 272",
                        WheelPicture = "https://i.imgur.com/qtGyWw9t.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "GT-F07",
                        WheelStyleName = "style 301",
                        WheelPicture = "https://i.imgur.com/5fLWTLct.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "GT-F07",
                        WheelStyleName = "style 302",
                        WheelPicture = "https://i.imgur.com/rifgWZ4t.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "GT-F07",
                        WheelStyleName = "style 303",
                        WheelPicture = "https://i.imgur.com/S9tqkNEt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "GT-F07",
                        WheelStyleName = "style 311",
                        WheelPicture = "https://i.imgur.com/Zr34Y6Wt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "GT-F07",
                        WheelStyleName = "style 312",
                        WheelPicture = "https://i.imgur.com/1fy1WVwt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "GT-F07",
                        WheelStyleName = "style 315",
                        WheelPicture = "https://i.imgur.com/0nL3JfOt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "GT-F07",
                        WheelStyleName = "style 316",
                        WheelPicture = "https://i.imgur.com/6rRv6Nzt.jpg",
                        MostPopular = false,
                    },
                      //e24
                      new Wheel
                    {
                        BtnTabId = "E24",
                        WheelStyleName = "style 2",
                        WheelPicture = "https://i.imgur.com/K9SySrut.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E24",
                        WheelStyleName = "style 5",
                        WheelPicture = "https://i.imgur.com/q4c4fTMt.jpg",
                        MostPopular = false,
                    },
                      //e63
                      new Wheel
                    {
                        BtnTabId = "E63",
                        WheelStyleName = "style 92",
                        WheelPicture = "https://i.imgur.com/tMSnDIDt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E63",
                        WheelStyleName = "style 101",
                        WheelPicture = "https://i.imgur.com/C2Ud8M6t.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E63",
                        WheelStyleName = "style 117",
                        WheelPicture = "https://i.imgur.com/DjFkCVct.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E63",
                        WheelStyleName = "style 118",
                        WheelPicture = "https://i.imgur.com/GJOvfwmt.jpg",
                        MostPopular = true,
                    },
                      new Wheel
                    {
                        BtnTabId = "E63",
                        WheelStyleName = "style 120",
                        WheelPicture = "https://i.imgur.com/iZpbWfKt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E63",
                        WheelStyleName = "style 121",
                        WheelPicture = "https://i.imgur.com/q5H1t9Ot.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E63",
                        WheelStyleName = "style 152",
                        WheelPicture = "https://i.imgur.com/SnuPSqQt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E63",
                        WheelStyleName = "style 166",
                        WheelPicture = "https://i.imgur.com/T6eXZsVt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E63",
                        WheelStyleName = "style 167",
                        WheelPicture = "https://i.imgur.com/v2YPpP3t.jpg",
                        MostPopular = true,
                    },
                      new Wheel
                    {
                        BtnTabId = "E63",
                        WheelStyleName = "style 184",
                        WheelPicture = "https://i.imgur.com/njEnX81t.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "E63",
                        WheelStyleName = "style 218",
                        WheelPicture = "https://i.imgur.com/sIPOuNit.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "E63",
                        WheelStyleName = "style 248",
                        WheelPicture = "https://i.imgur.com/G0DAB2Jt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E63",
                        WheelStyleName = "style 249",
                        WheelPicture = "https://i.imgur.com/40ir2ZPt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E63",
                        WheelStyleName = "style 266",
                        WheelPicture = "https://i.imgur.com/0sExaGvt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E63",
                        WheelStyleName = "style 288",
                        WheelPicture = "https://i.imgur.com/g3CF9Sst.jpg",
                        MostPopular = false,
                    },
                      //f12
                      new Wheel
                    {
                        BtnTabId = "F12",
                        WheelStyleName = "style 234",
                        WheelPicture = "https://i.imgur.com/5d90L6st.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "F12",
                        WheelStyleName = "style 236",
                        WheelPicture = "https://i.imgur.com/R9EjaBft.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "F12",
                        WheelStyleName = "style 237",
                        WheelPicture = "https://i.imgur.com/Scqp186t.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "F12",
                        WheelStyleName = "style 281",
                        WheelPicture = "https://i.imgur.com/h8xtqbgt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "F12",
                        WheelStyleName = "style 311",
                        WheelPicture = "https://i.imgur.com/Zr34Y6Wt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "F12",
                        WheelStyleName = "style 312",
                        WheelPicture = "https://i.imgur.com/1fy1WVwt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "F12",
                        WheelStyleName = "style 327",
                        WheelPicture = "https://i.imgur.com/6oiXEBXt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "F12",
                        WheelStyleName = "style 328",
                        WheelPicture = "https://i.imgur.com/hNaYItEt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "F12",
                        WheelStyleName = "style 329",
                        WheelPicture = "https://i.imgur.com/NiG9aogt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "F12",
                        WheelStyleName = "style 330",
                        WheelPicture = "https://i.imgur.com/MoU2qUdt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "F12",
                        WheelStyleName = "style 331",
                        WheelPicture = "https://i.imgur.com/RNRMc7Dt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "F12",
                        WheelStyleName = "style 332",
                        WheelPicture = "https://i.imgur.com/iRHvhoft.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "F12",
                        WheelStyleName = "style 349",
                        WheelPicture = "https://i.imgur.com/K8uS4vgt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "F12",
                        WheelStyleName = "style 351",
                        WheelPicture = "https://i.imgur.com/wRAYejIt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "F12",
                        WheelStyleName = "style 356",
                        WheelPicture = "https://i.imgur.com/GZIdEGkt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "F12",
                        WheelStyleName = "style 365",
                        WheelPicture = "https://i.imgur.com/DYU4F2ft.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "F12",
                        WheelStyleName = "style 366",
                        WheelPicture = "https://i.imgur.com/VYLMf5it.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "F12",
                        WheelStyleName = "style 367",
                        WheelPicture = "https://i.imgur.com/eYtehfvt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "F12",
                        WheelStyleName = "style 373",
                        WheelPicture = "https://i.imgur.com/EtVYG2Yt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "F12",
                        WheelStyleName = "style 374",
                        WheelPicture = "https://i.imgur.com/IuDTUVct.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "F12",
                        WheelStyleName = "style 410",
                        WheelPicture = "https://i.imgur.com/YanH4vtt.jpg",
                        MostPopular = false,
                    },
                      //e23
                      new Wheel
                    {
                        BtnTabId = "E23",
                        WheelStyleName = "style 5",
                        WheelPicture = "https://i.imgur.com/q4c4fTMt.jpg",
                        MostPopular = false,
                    },
                      //32
                      new Wheel
                    {
                        BtnTabId = "E32",
                        WheelStyleName = "style 2",
                        WheelPicture = "https://i.imgur.com/K9SySrut.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E32",
                        WheelStyleName = "style 3",
                        WheelPicture = "https://i.imgur.com/pkKXp5wt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E32",
                        WheelStyleName = "style 4",
                        WheelPicture = "https://i.imgur.com/lbT5SLNt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E32",
                        WheelStyleName = "style 5",
                        WheelPicture = "https://i.imgur.com/q4c4fTMt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E32",
                        WheelStyleName = "style 7",
                        WheelPicture = "https://i.imgur.com/fSOd4blt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E32",
                        WheelStyleName = "style 10",
                        WheelPicture = "https://i.imgur.com/NvB8c4et.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E32",
                        WheelStyleName = "style 14",
                        WheelPicture = "https://i.imgur.com/SQV9n3ft.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E32",
                        WheelStyleName = "style 20",
                        WheelPicture = "https://i.imgur.com/8PYFsYAt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E32",
                        WheelStyleName = "style 21",
                        WheelPicture = "https://i.imgur.com/F9EgqL2t.jpg",
                        MostPopular = false,
                    },
                      //e38
                      new Wheel
                    {
                        BtnTabId = "E38",
                        WheelStyleName = "style 4",
                        WheelPicture = "https://i.imgur.com/lbT5SLNt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E38",
                        WheelStyleName = "style 15",
                        WheelPicture = "https://i.imgur.com/c9QNCx3t.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E38",
                        WheelStyleName = "style 18",
                        WheelPicture = "https://i.imgur.com/Ud6xE7Kt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E38",
                        WheelStyleName = "style 25",
                        WheelPicture = "https://i.imgur.com/t3RxvsXt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E38",
                        WheelStyleName = "style 32",
                        WheelPicture = "https://i.imgur.com/m8G7vQ3t.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E38",
                        WheelStyleName = "style 37",
                        WheelPicture = "https://i.imgur.com/34T4PJFt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E38",
                        WheelStyleName = "style 60",
                        WheelPicture = "https://i.imgur.com/DfyjOOOt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E38",
                        WheelStyleName = "style 61",
                        WheelPicture = "https://i.imgur.com/tPnUP0bt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E38",
                        WheelStyleName = "style 69",
                        WheelPicture = "https://i.imgur.com/R8Pe2fvt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E38",
                        WheelStyleName = "style 70",
                        WheelPicture = "https://i.imgur.com/X2niSQ6t.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E38",
                        WheelStyleName = "style 76",
                        WheelPicture = "https://i.imgur.com/8S2joA6t.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E38",
                        WheelStyleName = "style 80",
                        WheelPicture = "https://i.imgur.com/Km0l64xt.jpg",
                        MostPopular = false,
                    },
                      //65
                      new Wheel
                    {
                        BtnTabId = "E65",
                        WheelStyleName = "style 32",
                        WheelPicture = "https://i.imgur.com/m8G7vQ3t.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E65",
                        WheelStyleName = "style 89",
                        WheelPicture = "https://i.imgur.com/UOle4qRt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E65",
                        WheelStyleName = "style 90",
                        WheelPicture = "https://i.imgur.com/B5t1DrTt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E65",
                        WheelStyleName = "style 91",
                        WheelPicture = "https://i.imgur.com/FSueuJPt.jpg",
                        MostPopular = false,
                    },
                      new Wheel
                    {
                        BtnTabId = "E65",
                        WheelStyleName = "style 92",
                        WheelPicture = "https://i.imgur.com/tMSnDIDt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "E65",
                        WheelStyleName = "style 93",
                        WheelPicture = "https://i.imgur.com/XU5OFtft.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "E65",
                        WheelStyleName = "style 94",
                        WheelPicture = "https://i.imgur.com/h40B0iUt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "E65",
                        WheelStyleName = "style 95",
                        WheelPicture = "https://i.imgur.com/0wgpeOPt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "E65",
                        WheelStyleName = "style 101",
                        WheelPicture = "https://i.imgur.com/C2Ud8M6t.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "E65",
                        WheelStyleName = "style 126",
                        WheelPicture = "https://i.imgur.com/gZvrB2yt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "E65",
                        WheelStyleName = "style 128",
                        WheelPicture = "https://i.imgur.com/xFYKGH2t.jpg",
                        MostPopular = true,
                    },
                       new Wheel
                    {
                        BtnTabId = "E65",
                        WheelStyleName = "style 149",
                        WheelPicture = "https://i.imgur.com/gRmqx8Ht.jpg",
                        MostPopular = true,
                    },
                       new Wheel
                    {
                        BtnTabId = "E65",
                        WheelStyleName = "style 152",
                        WheelPicture = "https://i.imgur.com/SnuPSqQt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "E65",
                        WheelStyleName = "style 165",
                        WheelPicture = "https://i.imgur.com/iv96gXOt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "E65",
                        WheelStyleName = "style 174",
                        WheelPicture = "https://i.imgur.com/CPEiaUot.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "E65",
                        WheelStyleName = "style 175",
                        WheelPicture = "https://i.imgur.com/gKhxF3gt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "E65",
                        WheelStyleName = "style 176",
                        WheelPicture = "https://i.imgur.com/XKkuTnKt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "E65",
                        WheelStyleName = "style 231",
                        WheelPicture = "https://i.imgur.com/Sv02O0Pt.jpg",
                        MostPopular = false,
                    },
                       //f01
                       new Wheel
                    {
                        BtnTabId = "F01",
                        WheelStyleName = "style 228",
                        WheelPicture = "https://i.imgur.com/YRyv81st.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "F01",
                        WheelStyleName = "style 233",
                        WheelPicture = "https://i.imgur.com/bpxWkW4t.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "F01",
                        WheelStyleName = "style 234",
                        WheelPicture = "https://i.imgur.com/5d90L6st.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "F01",
                        WheelStyleName = "style 238",
                        WheelPicture = "https://i.imgur.com/Bpbie24t.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "F01",
                        WheelStyleName = "style 250",
                        WheelPicture = "https://i.imgur.com/W1vUFSJt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "F01",
                        WheelStyleName = "style 251",
                        WheelPicture = "https://i.imgur.com/hVMjOm2t.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "F01",
                        WheelStyleName = "style 252",
                        WheelPicture = "https://i.imgur.com/xQK3D5dt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "F01",
                        WheelStyleName = "style 253",
                        WheelPicture = "https://i.imgur.com/IQ0jmmtt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "F01",
                        WheelStyleName = "style 254",
                        WheelPicture = "https://i.imgur.com/PhyWbBNt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "F01",
                        WheelStyleName = "style 301",
                        WheelPicture = "https://i.imgur.com/5fLWTLct.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "F01",
                        WheelStyleName = "style 311",
                        WheelPicture = "https://i.imgur.com/Zr34Y6Wt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "F01",
                        WheelStyleName = "style 312",
                        WheelPicture = "https://i.imgur.com/1fy1WVwt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "F01",
                        WheelStyleName = "style 357",
                        WheelPicture = "https://i.imgur.com/oSM6Eznt.jpg",
                        MostPopular = false,
                    },
                       //x1
                       new Wheel
                    {
                        BtnTabId = "X1",
                        WheelStyleName = "style 311",
                        WheelPicture = "https://i.imgur.com/Zr34Y6Wt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X1",
                        WheelStyleName = "style 317",
                        WheelPicture = "https://i.imgur.com/t7WkDcBt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X1",
                        WheelStyleName = "style 318",
                        WheelPicture = "https://i.imgur.com/OeJSlhHt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X1",
                        WheelStyleName = "style 319",
                        WheelPicture = "https://i.imgur.com/05OrLd1t.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X1",
                        WheelStyleName = "style 320",
                        WheelPicture = "https://i.imgur.com/wOQyIHBt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X1",
                        WheelStyleName = "style 321",
                        WheelPicture = "https://i.imgur.com/ypEJK3nt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X1",
                        WheelStyleName = "style 322",
                        WheelPicture = "https://i.imgur.com/uwj5TtJt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X1",
                        WheelStyleName = "style 323",
                        WheelPicture = "https://i.imgur.com/0gtJM1Ht.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X1",
                        WheelStyleName = "style 324",
                        WheelPicture = "https://i.imgur.com/KyAfTh8t.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X1",
                        WheelStyleName = "style 354",
                        WheelPicture = "https://i.imgur.com/wnytgnKt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X1",
                        WheelStyleName = "style 355",
                        WheelPicture = "https://i.imgur.com/VBnjPktt.jpg",
                        MostPopular = false,
                    },
                       //x3
                       new Wheel
                    {
                        BtnTabId = "X3-E83",
                        WheelStyleName = "style 109",
                        WheelPicture = "https://i.imgur.com/dVqHjjst.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X3-E83",
                        WheelStyleName = "style 110",
                        WheelPicture = "https://i.imgur.com/z5QoU6ut.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X3-E83",
                        WheelStyleName = "style 111",
                        WheelPicture = "https://i.imgur.com/7gTLN6ct.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X3-E83",
                        WheelStyleName = "style 112",
                        WheelPicture = "https://i.imgur.com/Rk4ptUdt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X3-E83",
                        WheelStyleName = "style 113",
                        WheelPicture = "https://i.imgur.com/fMQd3fut.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X3-E83",
                        WheelStyleName = "style 114",
                        WheelPicture = "https://i.imgur.com/AQ78Waat.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X3-E83",
                        WheelStyleName = "style 128",
                        WheelPicture = "https://i.imgur.com/xFYKGH2t.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X3-E83",
                        WheelStyleName = "style 143",
                        WheelPicture = "https://i.imgur.com/s5EWWE2t.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X3-E83",
                        WheelStyleName = "style 145",
                        WheelPicture = "https://i.imgur.com/0MDQRort.jpg",
                        MostPopular = true,
                    },
                       new Wheel
                    {
                        BtnTabId = "X3-E83",
                        WheelStyleName = "style 146",
                        WheelPicture = "https://i.imgur.com/CBRuNeZt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X3-E83",
                        WheelStyleName = "style 147",
                        WheelPicture = "https://i.imgur.com/Gs2tOzgt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X3-E83",
                        WheelStyleName = "style 148",
                        WheelPicture = "https://i.imgur.com/sFiK6GTt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X3-E83",
                        WheelStyleName = "style 150",
                        WheelPicture = "https://i.imgur.com/ND01G5Ht.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X3-E83",
                        WheelStyleName = "style 191",
                        WheelPicture = "https://i.imgur.com/IMrYI6Pt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X3-E83",
                        WheelStyleName = "style 192",
                        WheelPicture = "https://i.imgur.com/GgcWkS7t.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X3-E83",
                        WheelStyleName = "style 204",
                        WheelPicture = "https://i.imgur.com/9rOuJdat.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X3-E83",
                        WheelStyleName = "style 205",
                        WheelPicture = "https://i.imgur.com/uQVeJrWt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X3-E83",
                        WheelStyleName = "style 206",
                        WheelPicture = "https://i.imgur.com/2hWg2oft.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X3-E83",
                        WheelStyleName = "style 279",
                        WheelPicture = "https://i.imgur.com/1fNPBEDt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X3-E83",
                        WheelStyleName = "style 280",
                        WheelPicture = "https://i.imgur.com/FX9XxW8t.jpg",
                        MostPopular = false,
                    },
                       //x3-f25
                       new Wheel
                    {
                        BtnTabId = "X3-F25",
                        WheelStyleName = "style 304",
                        WheelPicture = "https://i.imgur.com/6w7Dg1Ut.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X3-F25",
                        WheelStyleName = "style 305",
                        WheelPicture = "https://i.imgur.com/967VfyTt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X3-F25",
                        WheelStyleName = "style 306",
                        WheelPicture = "https://i.imgur.com/jOWcNlyt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X3-F25",
                        WheelStyleName = "style 307",
                        WheelPicture = "https://i.imgur.com/b4hFmSst.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X3-F25",
                        WheelStyleName = "style 308",
                        WheelPicture = "https://i.imgur.com/deAYQykt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X3-F25",
                        WheelStyleName = "style 309",
                        WheelPicture = "https://i.imgur.com/Am1lUwSt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X3-F25",
                        WheelStyleName = "style 310",
                        WheelPicture = "https://i.imgur.com/heAElbXt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X3-F25",
                        WheelStyleName = "style 311",
                        WheelPicture = "https://i.imgur.com/Zr34Y6Wt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X3-F25",
                        WheelStyleName = "style 368",
                        WheelPicture = "https://i.imgur.com/SgpEtwZt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X3-F25",
                        WheelStyleName = "style 369",
                        WheelPicture = "https://i.imgur.com/OaYsxput.jpg",
                        MostPopular = false,
                    },
                       //x5-e53
                       new Wheel
                    {
                        BtnTabId = "X5-E53",
                        WheelStyleName = "style 56",
                        WheelPicture = "https://i.imgur.com/VcOo9HBt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X5-E53",
                        WheelStyleName = "style 57",
                        WheelPicture = "https://i.imgur.com/6SfiaJvt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X5-E53",
                        WheelStyleName = "style 58",
                        WheelPicture = "https://i.imgur.com/4gRPoqSt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X5-E53",
                        WheelStyleName = "style 63",
                        WheelPicture = "https://i.imgur.com/bbWuBxxt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X5-E53",
                        WheelStyleName = "style 69",
                        WheelPicture = "https://i.imgur.com/R8Pe2fvt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X5-E53",
                        WheelStyleName = "style 74",
                        WheelPicture = "https://i.imgur.com/qtUCnPZt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X5-E53",
                        WheelStyleName = "style 75",
                        WheelPicture = "https://i.imgur.com/mEpHXcst.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X5-E53",
                        WheelStyleName = "style 87",
                        WheelPicture = "https://i.imgur.com/0b75unft.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X5-E53",
                        WheelStyleName = "style 99",
                        WheelPicture = "https://i.imgur.com/FICdXqkt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X5-E53",
                        WheelStyleName = "style 130",
                        WheelPicture = "https://i.imgur.com/eWALOISt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X5-E53",
                        WheelStyleName = "style 131",
                        WheelPicture = "https://i.imgur.com/koglXyjt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X5-E53",
                        WheelStyleName = "style 132",
                        WheelPicture = "https://i.imgur.com/FwZHv04t.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X5-E53",
                        WheelStyleName = "style 152",
                        WheelPicture = "https://i.imgur.com/SnuPSqQt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X5-E53",
                        WheelStyleName = "style 153",
                        WheelPicture = "https://i.imgur.com/gcpXcCIt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X5-E53",
                        WheelStyleName = "style 168",
                        WheelPicture = "https://i.imgur.com/yHv1LAZt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X5-E53",
                        WheelStyleName = "style 177",
                        WheelPicture = "https://i.imgur.com/2uo6rpzt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X5-E53",
                        WheelStyleName = "style 183",
                        WheelPicture = "https://i.imgur.com/XZiydH7t.jpg",
                        MostPopular = false,
                    },
                       //x5-e70
                       new Wheel
                    {
                        BtnTabId = "X5-E70",
                        WheelStyleName = "style 128",
                        WheelPicture = "https://i.imgur.com/xFYKGH2t.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X5-E70",
                        WheelStyleName = "style 177",
                        WheelPicture = "https://i.imgur.com/2uo6rpzt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X5-E70",
                        WheelStyleName = "style 209",
                        WheelPicture = "https://i.imgur.com/1ksYj7jt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X5-E70",
                        WheelStyleName = "style 210",
                        WheelPicture = "https://i.imgur.com/Uim3y0Nt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X5-E70",
                        WheelStyleName = "style 211",
                        WheelPicture = "https://i.imgur.com/fJ40bUQt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X5-E70",
                        WheelStyleName = "style 212",
                        WheelPicture = "https://i.imgur.com/Klw5DGFt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X5-E70",
                        WheelStyleName = "style 213",
                        WheelPicture = "https://i.imgur.com/1XaipUTt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X5-E70",
                        WheelStyleName = "style 214",
                        WheelPicture = "https://i.imgur.com/LciJqoyt.jpg",
                        MostPopular = true,
                    },
                       new Wheel
                    {
                        BtnTabId = "X5-E70",
                        WheelStyleName = "style 215",
                        WheelPicture = "https://i.imgur.com/nmr2STHt.jpg",
                        MostPopular = true,
                    },
                       new Wheel
                    {
                        BtnTabId = "X5-E70",
                        WheelStyleName = "style 223",
                        WheelPicture = "https://i.imgur.com/9vyzFiIt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X5-E70",
                        WheelStyleName = "style 227",
                        WheelPicture = "https://i.imgur.com/esTBYyUt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X5-E70",
                        WheelStyleName = "style 232",
                        WheelPicture = "https://i.imgur.com/GHNLsbOt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X5-E70",
                        WheelStyleName = "style 239",
                        WheelPicture = "https://i.imgur.com/fmKFuUSt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X5-E70",
                        WheelStyleName = "style 265",
                        WheelPicture = "https://i.imgur.com/BIHXcBht.jpg",
                        MostPopular = true,
                    },
                       new Wheel
                    {
                        BtnTabId = "X5-E70",
                        WheelStyleName = "style 275",
                        WheelPicture = "https://i.imgur.com/TuJE3E3t.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X5-E70",
                        WheelStyleName = "style 297",
                        WheelPicture = "https://i.imgur.com/yxJN5m2t.jpg",
                        MostPopular = true,
                    },
                       new Wheel
                    {
                        BtnTabId = "X5-E70",
                        WheelStyleName = "style 298",
                        WheelPicture = "https://i.imgur.com/n7JHMbxt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X5-E70",
                        WheelStyleName = "style 298",
                        WheelPicture = "https://i.imgur.com/AtAHWGGt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X5-E70",
                        WheelStyleName = "style 300",
                        WheelPicture = "https://i.imgur.com/ZYARlY2t.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X5-E70",
                        WheelStyleName = "style 333",
                        WheelPicture = "https://i.imgur.com/5ljVCvit.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X5-E70",
                        WheelStyleName = "style 334",
                        WheelPicture = "https://i.imgur.com/ci6ubGht.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X5-E70",
                        WheelStyleName = "style 335",
                        WheelPicture = "https://i.imgur.com/rdjiM5St.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X5-E70",
                        WheelStyleName = "style 336",
                        WheelPicture = "https://i.imgur.com/hu52Mxpt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X5-E70",
                        WheelStyleName = "style 337",
                        WheelPicture = "https://i.imgur.com/oM1MIUYt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X5-E70",
                        WheelStyleName = "style 375",
                        WheelPicture = "https://i.imgur.com/ImuJY5Nt.jpg",
                        MostPopular = false,
                    },
                       //x6
                       new Wheel
                    {
                        BtnTabId = "X6",
                        WheelStyleName = "style 128",
                        WheelPicture = "https://i.imgur.com/xFYKGH2t.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X6",
                        WheelStyleName = "style 212",
                        WheelPicture = "https://i.imgur.com/Klw5DGFt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X6",
                        WheelStyleName = "style 214",
                        WheelPicture = "https://i.imgur.com/LciJqoyt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X6",
                        WheelStyleName = "style 215",
                        WheelPicture = "https://i.imgur.com/nmr2STHt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X6",
                        WheelStyleName = "style 232",
                        WheelPicture = "https://i.imgur.com/GHNLsbOt.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X6",
                        WheelStyleName = "style 257",
                        WheelPicture = "https://i.imgur.com/N5ZfN1Et.jpg",
                        MostPopular = false,
                    },
                       new Wheel
                    {
                        BtnTabId = "X6",
                        WheelStyleName = "style 258",
                        WheelPicture = "https://i.imgur.com/u79leplt.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "X6",
                        WheelStyleName = "style 259",
                        WheelPicture = "https://i.imgur.com/TcSpdAUt.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "X6",
                        WheelStyleName = "style 265",
                        WheelPicture = "https://i.imgur.com/BIHXcBht.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "X6",
                        WheelStyleName = "style 275",
                        WheelPicture = "https://i.imgur.com/TuJE3E3t.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "X6",
                        WheelStyleName = "style 297",
                        WheelPicture = "https://i.imgur.com/yxJN5m2t.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "X6",
                        WheelStyleName = "style 298",
                        WheelPicture = "https://i.imgur.com/n7JHMbxt.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "X6",
                        WheelStyleName = "style 299",
                        WheelPicture = "https://i.imgur.com/AtAHWGGt.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "X6",
                        WheelStyleName = "style 300",
                        WheelPicture = "https://i.imgur.com/ZYARlY2t.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "X6",
                        WheelStyleName = "style 336",
                        WheelPicture = "https://i.imgur.com/hu52Mxpt.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "X6",
                        WheelStyleName = "style 375",
                        WheelPicture = "https://i.imgur.com/ImuJY5Nt.jpg",
                        MostPopular = false,
                    },
                        //z1
                        new Wheel
                    {
                        BtnTabId = "Z1",
                        WheelStyleName = "style 5",
                        WheelPicture = "https://i.imgur.com/q4c4fTMt.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z1",
                        WheelStyleName = "style 11",
                        WheelPicture = "https://i.imgur.com/ZyOoHeR.jpg",
                        MostPopular = false,
                    },
                        //Z3-E36
                        new Wheel
                    {
                        BtnTabId = "Z3",
                        WheelStyleName = "style 6",
                        WheelPicture = "https://i.imgur.com/ojIk8nAt.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z3",
                        WheelStyleName = "style 16",
                        WheelPicture = "https://i.imgur.com/pY7TWXSt.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z3",
                        WheelStyleName = "style 18",
                        WheelPicture = "https://i.imgur.com/Ud6xE7Kt.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z3",
                        WheelStyleName = "style 19",
                        WheelPicture = "https://i.imgur.com/13rgKo8t.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z3",
                        WheelStyleName = "style 22",
                        WheelPicture = "https://i.imgur.com/fJyeBEwt.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z3",
                        WheelStyleName = "style 23",
                        WheelPicture = "https://i.imgur.com/Upv5gw0t.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z3",
                        WheelStyleName = "style 24",
                        WheelPicture = "https://i.imgur.com/uUORV0Nt.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z3",
                        WheelStyleName = "style 25",
                        WheelPicture = "https://i.imgur.com/t3RxvsXt.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z3",
                        WheelStyleName = "style 26",
                        WheelPicture = "https://i.imgur.com/PtqlLwMt.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z3",
                        WheelStyleName = "style 27",
                        WheelPicture = "https://i.imgur.com/cefMsTTt.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z3",
                        WheelStyleName = "style 28",
                        WheelPicture = "https://i.imgur.com/HETZI5Jt.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z3",
                        WheelStyleName = "style 29",
                        WheelPicture = "https://i.imgur.com/YSi6q3Nt.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z3",
                        WheelStyleName = "style 30",
                        WheelPicture = "https://i.imgur.com/UPIeKtKt.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z3",
                        WheelStyleName = "style 32",
                        WheelPicture = "https://i.imgur.com/m8G7vQ3t.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z3",
                        WheelStyleName = "style 34",
                        WheelPicture = "https://i.imgur.com/UOBIcYJt.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z3",
                        WheelStyleName = "style 35",
                        WheelPicture = "https://i.imgur.com/TqpRh0Ut.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z3",
                        WheelStyleName = "style 36",
                        WheelPicture = "https://i.imgur.com/zUoqHFnt.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z3",
                        WheelStyleName = "style 38",
                        WheelPicture = "https://i.imgur.com/PNB8Vkct.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z3",
                        WheelStyleName = "style 39",
                        WheelPicture = "https://i.imgur.com/lgWRkfat.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z3",
                        WheelStyleName = "style 40",
                        WheelPicture = "https://i.imgur.com/DRitMQut.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z3",
                        WheelStyleName = "style 41",
                        WheelPicture = "https://i.imgur.com/kPfmmWKt.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z3",
                        WheelStyleName = "style 42",
                        WheelPicture = "https://i.imgur.com/T9WHjDft.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z3",
                        WheelStyleName = "style 43",
                        WheelPicture = "https://i.imgur.com/Sq0waJ3t.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z3",
                        WheelStyleName = "style 45",
                        WheelPicture = "https://i.imgur.com/CXkmRtwt.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z3",
                        WheelStyleName = "style 47",
                        WheelPicture = "https://i.imgur.com/smndUyit.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z3",
                        WheelStyleName = "style 55",
                        WheelPicture = "https://i.imgur.com/xfvHmu4t.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z3",
                        WheelStyleName = "style 64",
                        WheelPicture = "https://i.imgur.com/R9UoxK8t.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z3",
                        WheelStyleName = "style 71",
                        WheelPicture = "https://i.imgur.com/JSW1vZct.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z3",
                        WheelStyleName = "style 78",
                        WheelPicture = "https://i.imgur.com/wGXRyNHt.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z3",
                        WheelStyleName = "style 85",
                        WheelPicture = "https://i.imgur.com/dPbeh5Xt.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z3",
                        WheelStyleName = "style 86",
                        WheelPicture = "https://i.imgur.com/LQzuXzmt.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z3",
                        WheelStyleName = "style 88",
                        WheelPicture = "https://i.imgur.com/EihyrSat.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z3",
                        WheelStyleName = "style 136",
                        WheelPicture = "https://i.imgur.com/iaklo30t.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z3",
                        WheelStyleName = "style 137",
                        WheelPicture = "https://i.imgur.com/XVcMMQDt.jpg",
                        MostPopular = false,
                    },
                        //Z4-E85
                        new Wheel
                    {
                        BtnTabId = "Z4-E85",
                        WheelStyleName = "style 71",
                        WheelPicture = "https://i.imgur.com/JSW1vZct.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z4-E85",
                        WheelStyleName = "style 101",
                        WheelPicture = "https://i.imgur.com/C2Ud8M6t.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z4-E85",
                        WheelStyleName = "style 102",
                        WheelPicture = "https://i.imgur.com/c2ly3rvt.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z4-E85",
                        WheelStyleName = "style 103",
                        WheelPicture = "https://i.imgur.com/OZeAkokt.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z4-E85",
                        WheelStyleName = "style 104",
                        WheelPicture = "https://i.imgur.com/wqEKy0Qt.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z4-E85",
                        WheelStyleName = "style 105",
                        WheelPicture = "https://i.imgur.com/ZFParOot.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z4-E85",
                        WheelStyleName = "style 106",
                        WheelPicture = "https://i.imgur.com/qh4FLgBt.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z4-E85",
                        WheelStyleName = "style 107",
                        WheelPicture = "https://i.imgur.com/RceuZSRt.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z4-E85",
                        WheelStyleName = "style 108",
                        WheelPicture = "https://i.imgur.com/plXDHSCt.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z4-E85",
                        WheelStyleName = "style 125",
                        WheelPicture = "https://i.imgur.com/T5GUr1yt.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z4-E85",
                        WheelStyleName = "style 133",
                        WheelPicture = "https://i.imgur.com/yIbS0xRt.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z4-E85",
                        WheelStyleName = "style 135",
                        WheelPicture = "https://i.imgur.com/5kWYM9Ft.jpg",
                        MostPopular = true,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z4-E85",
                        WheelStyleName = "style 152",
                        WheelPicture = "https://i.imgur.com/SnuPSqQt.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z4-E85",
                        WheelStyleName = "style 164",
                        WheelPicture = "https://i.imgur.com/JEMN1sVt.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z4-E85",
                        WheelStyleName = "style 200",
                        WheelPicture = "https://i.imgur.com/5LnVObWt.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z4-E85",
                        WheelStyleName = "style 201",
                        WheelPicture = "https://i.imgur.com/Sw5kOmct.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z4-E85",
                        WheelStyleName = "style 202",
                        WheelPicture = "https://i.imgur.com/uJFvJnXt.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z4-E85",
                        WheelStyleName = "style 203",
                        WheelPicture = "https://i.imgur.com/PEqUtGAt.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z4-E85",
                        WheelStyleName = "style 224",
                        WheelPicture = "https://i.imgur.com/URYVhcpt.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z4-E85",
                        WheelStyleName = "style 241",
                        WheelPicture = "https://i.imgur.com/X5AzX3At.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z4-E85",
                        WheelStyleName = "style 269",
                        WheelPicture = "https://i.imgur.com/46SVKdLt.jpg",
                        MostPopular = true,
                    },
                        //Z4-E89
                        new Wheel
                    {
                        BtnTabId = "Z4-E89",
                        WheelStyleName = "style 276",
                        WheelPicture = "https://i.imgur.com/9s2TM7Pt.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z4-E89",
                        WheelStyleName = "style 290",
                        WheelPicture = "https://i.imgur.com/oYSuTAwt.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z4-E89",
                        WheelStyleName = "style 292",
                        WheelPicture = "https://i.imgur.com/FD9WcWJt.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z4-E89",
                        WheelStyleName = "style 293",
                        WheelPicture = "https://i.imgur.com/yMgzcSEt.jpg",
                        MostPopular = true,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z4-E89",
                        WheelStyleName = "style 294",
                        WheelPicture = "https://i.imgur.com/Z5Bv9wVt.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z4-E89",
                        WheelStyleName = "style 295",
                        WheelPicture = "https://i.imgur.com/8b5yGu5t.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z4-E89",
                        WheelStyleName = "style 296",
                        WheelPicture = "https://i.imgur.com/CmRwVjKt.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z4-E89",
                        WheelStyleName = "style 313",
                        WheelPicture = "https://i.imgur.com/NZceG4vt.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z4-E89",
                        WheelStyleName = "style 325",
                        WheelPicture = "https://i.imgur.com/OnJjYqgt.jpg",
                        MostPopular = false,
                    },
                        new Wheel
                    {
                        BtnTabId = "Z4-E89",
                        WheelStyleName = "style 326",
                        WheelPicture = "https://i.imgur.com/53F5v0Lt.jpg",
                        MostPopular = false,
                    },
                        //Z8-E52
                        new Wheel
                    {
                        BtnTabId = "Z8",
                        WheelStyleName = "style 59",
                        WheelPicture = "https://i.imgur.com/Haf8L91t.jpg",
                        MostPopular = false,
                    },
            };

            return Task.FromResult(wheelInfos);
        }
    }
}
