using BmwScannerApi.Models;

namespace BmwScannerApi.Services
{
    public static class WheelSpecsImagesService
    {
        public static Task<List<WheelSpecsImages>> GetData()
        {
            List<WheelSpecsImages> wheelImages = new List<WheelSpecsImages>
            {
                //style 2
                new WheelSpecsImages
                {
                    WheelStyleName = "style 2",
                    Image = "https://i.imgur.com/OpPOFmK.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 2",
                    Image = "https://i.imgur.com/swAziLH.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 2",
                    Image = "https://i.imgur.com/iyr28xn.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 2",
                    Image = "https://i.imgur.com/iyr28xn.jpg"
                },
                //style 3
                new WheelSpecsImages
                {
                    WheelStyleName = "style 3",
                    Image = "https://i.imgur.com/XdNWCfc.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 3",
                    Image = "https://i.imgur.com/HC2nbkO.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 3",
                    Image = "https://i.imgur.com/f51XCkV.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 3",
                    Image = "https://i.imgur.com/VasQIkO.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 3",
                    Image = "https://i.imgur.com/tiUODgJ.jpg"
                },
                //style 4
                new WheelSpecsImages
                {
                    WheelStyleName = "style 4",
                    Image = "https://i.imgur.com/AwNfQSY.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 4",
                    Image = "https://i.imgur.com/W2gpuKU.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 4",
                    Image = "https://i.imgur.com/QtHx5b4.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 4",
                    Image = "https://i.imgur.com/rARouI4.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 4",
                    Image = "https://i.imgur.com/yhdqV7V.jpg"
                },
                //style 5
                new WheelSpecsImages
                {
                    WheelStyleName = "style 5",
                    Image = "https://i.imgur.com/pFP3j41.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 5",
                    Image = "https://i.imgur.com/CcVTtXn.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 5",
                    Image = "https://i.imgur.com/8uU7Bhr.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 5",
                    Image = "https://i.imgur.com/TwWmySQ.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 5",
                    Image = "https://i.imgur.com/8sv2dau.jpg"
                },

                //style 6
                new WheelSpecsImages
                {
                    WheelStyleName = "style 6",
                    Image = "https://i.imgur.com/TTMUI96.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 6",
                    Image = "https://i.imgur.com/FzHiQnW.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 6",
                    Image = "https://i.imgur.com/ekRYk3F.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 6",
                    Image = "https://i.imgur.com/QkVbYRm.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 6",
                    Image = "https://i.imgur.com/lJmRBYQ.jpg"
                },
                //style 7
                new WheelSpecsImages
                {
                    WheelStyleName = "style 7",
                    Image = "https://i.imgur.com/aFN5bZF.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 7",
                    Image = "https://i.imgur.com/pwzZS1R.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 7",
                    Image = "https://i.imgur.com/rc5rBfq.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 7",
                    Image = "https://i.imgur.com/eEEkdwL.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 7",
                    Image = "https://i.imgur.com/wDXYK7e.jpg"
                },
                //style 8
                new WheelSpecsImages
                {
                    WheelStyleName = "style 8",
                    Image = "https://i.imgur.com/9W8NYas.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 8",
                    Image = "https://i.imgur.com/gW6jMbQ.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 8",
                    Image = "https://i.imgur.com/1PAJ3TZ.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 8",
                    Image = "https://i.imgur.com/AbibLGN.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 8",
                    Image = "https://i.imgur.com/ztl85fG.jpg"
                },
                //style 9
                new WheelSpecsImages
                {
                    WheelStyleName = "style 9",
                    Image = "https://i.imgur.com/f1kzPlI.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 9",
                    Image = "https://i.imgur.com/dBlDdt5.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 9",
                    Image = "https://i.imgur.com/Yn2Eqk3.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 9",
                    Image = "https://i.imgur.com/eaNAxDR.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 9",
                    Image = "https://i.imgur.com/H6gjNne.jpg"
                },
                //style 10
                new WheelSpecsImages
                {
                    WheelStyleName = "style 10",
                    Image = "https://i.imgur.com/q9DG3EI.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 10",
                    Image = "https://i.imgur.com/sTQM2Ls.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 10",
                    Image = "https://i.imgur.com/k4PdG4r.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 10",
                    Image = "https://i.imgur.com/PfsLLwN.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 10",
                    Image = "https://i.imgur.com/rN6Xeqr.jpg"
                },
                //style 11
                new WheelSpecsImages
                {
                    WheelStyleName = "style 11",
                    Image = "https://i.imgur.com/j6yY0QQ.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 11",
                    Image = "https://i.imgur.com/aORSy33.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 11",
                    Image = "https://i.imgur.com/ZyOoHeR.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 11",
                    Image = "https://i.imgur.com/Gq0fxXz.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 11",
                    Image = "https://i.imgur.com/PVUlcXd.jpg"
                },
                //style 13
                new WheelSpecsImages
                {
                    WheelStyleName = "style 13",
                    Image = "https://i.imgur.com/DY1J8xC.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 13",
                    Image = "https://i.imgur.com/GXY8ZO2.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 13",
                    Image = "https://i.imgur.com/ybP6ihX.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 13",
                    Image = "https://i.imgur.com/hHTUeQC.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 13",
                    Image = "https://i.imgur.com/w7FBgJK.jpg"
                },
                //style 14
                new WheelSpecsImages
                {
                    WheelStyleName = "style 14",
                    Image = "https://i.imgur.com/tptl7aQ.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 14",
                    Image = "https://i.imgur.com/ot67jpA.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 14",
                    Image = "https://i.imgur.com/XrhujrN.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 14",
                    Image = "https://i.imgur.com/RCeB9Pu.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 14",
                    Image = "https://i.imgur.com/kJtZD7d.jpg"
                },
                //style 15
                new WheelSpecsImages
                {
                    WheelStyleName = "style 15",
                    Image = "https://i.imgur.com/y3MCfmP.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 15",
                    Image = "https://i.imgur.com/h3yFD7o.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 15",
                    Image = "https://i.imgur.com/ccD0PkR.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 15",
                    Image = "https://i.imgur.com/E3allAu.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 15",
                    Image = "https://i.imgur.com/yyjKd4m.jpg"
                },
                //style 16
                new WheelSpecsImages
                {
                    WheelStyleName = "style 16",
                    Image = "https://i.imgur.com/CAag0Xt.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 16",
                    Image = "https://i.imgur.com/A4jVrIs.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 16",
                    Image = "https://i.imgur.com/6GBpuKl.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 16",
                    Image = "https://i.imgur.com/uQXNDdD.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 16",
                    Image = "https://i.imgur.com/MNIv7jP.jpg"
                },
                //style 17
                new WheelSpecsImages
                {
                    WheelStyleName = "style 17",
                    Image = "https://i.imgur.com/DoLU7dn.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 17",
                    Image = "https://i.imgur.com/Ema2VKL.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 17",
                    Image = "https://i.imgur.com/CWpkapT.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 17",
                    Image = "https://i.imgur.com/D46CMBc.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 17",
                    Image = "https://i.imgur.com/o1LvX2Z.jpg"
                },
                //style 18
                new WheelSpecsImages
                {
                    WheelStyleName = "style 18",
                    Image = "https://i.imgur.com/VHejPhl.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 18",
                    Image = "https://i.imgur.com/l4ilOy9.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 18",
                    Image = "https://i.imgur.com/l4ilOy9.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 18",
                    Image = "https://i.imgur.com/VXieyOP.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 18",
                    Image = "https://i.imgur.com/qSwCGWE.jpg"
                },
                //style 19
                new WheelSpecsImages
                {
                    WheelStyleName = "style 19",
                    Image = "https://i.imgur.com/neyeael.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 19",
                    Image = "https://i.imgur.com/aYHQ4aw.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 19",
                    Image = "https://i.imgur.com/BfKZcN0.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 19",
                    Image = "https://i.imgur.com/KHYmWCS.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 19",
                    Image = "https://i.imgur.com/TGXOl7p.jpg"
                },
                //style 20
                new WheelSpecsImages
                {
                    WheelStyleName = "style 20",
                    Image = "https://i.imgur.com/uv8AU9d.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 20",
                    Image = "https://i.imgur.com/8kYAa3e.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 20",
                    Image = "https://i.imgur.com/qNQimFI.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 20",
                    Image = "https://i.imgur.com/tzoMm3w.jpg"
                },
                //style 21
                new WheelSpecsImages
                {
                    WheelStyleName = "style 21",
                    Image = "https://i.imgur.com/603PhJ3.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 21",
                    Image = "https://i.imgur.com/mHGA0dz.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 21",
                    Image = "https://i.imgur.com/duF2Tjq.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 21",
                    Image = "https://i.imgur.com/sPG9GfQ.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 21",
                    Image = "https://i.imgur.com/ezvs8JI.jpg"
                },
                //style 22
                new WheelSpecsImages
                {
                    WheelStyleName = "style 22",
                    Image = "https://i.imgur.com/h9HiQhu.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 22",
                    Image = "https://i.imgur.com/ipeyIGO.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 22",
                    Image = "https://i.imgur.com/OFGFFdw.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 22",
                    Image = "https://i.imgur.com/Z57TOcR.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 22",
                    Image = "https://i.imgur.com/BhOs33W.jpg"
                },
                //style 23
                new WheelSpecsImages
                {
                    WheelStyleName = "style 23",
                    Image = "https://i.imgur.com/F665N6h.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 23",
                    Image = "https://i.imgur.com/OTgboTX.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 23",
                    Image = "https://i.imgur.com/NX5WAgD.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 23",
                    Image = "https://i.imgur.com/LwQ66Dm.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 23",
                    Image = "https://i.imgur.com/TO7sO7T.jpg"
                },
                //style 24
                new WheelSpecsImages
                {
                    WheelStyleName = "style 24",
                    Image = "https://i.imgur.com/4K7efUS.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 24",
                    Image = "https://i.imgur.com/IpHnARV.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 24",
                    Image = "https://i.imgur.com/B93SOpB.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 24",
                    Image = "https://i.imgur.com/ZU4IVWv.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 24",
                    Image = "https://i.imgur.com/7XcoaQK.jpg"
                },
                //style 25
                new WheelSpecsImages
                {
                    WheelStyleName = "style 25",
                    Image = "https://i.imgur.com/pyxiM7I.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 25",
                    Image = "https://i.imgur.com/5zSY3Wx.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 25",
                    Image = "https://i.imgur.com/5zSY3Wx.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 25",
                    Image = "https://i.imgur.com/VLGpXAY.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 25",
                    Image = "https://i.imgur.com/JlnS3xo.jpg"
                },
                //style 26
                new WheelSpecsImages
                {
                    WheelStyleName = "style 26",
                    Image = "https://i.imgur.com/Zd0Trbx.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 26",
                    Image = "https://i.imgur.com/VjJiBtk.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 26",
                    Image = "https://i.imgur.com/vOq2RYy.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 26",
                    Image = "https://i.imgur.com/bq37lke.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 26",
                    Image = "https://i.imgur.com/ENG6JUo.jpg"
                },
                //style 27
                new WheelSpecsImages
                {
                    WheelStyleName = "style 27",
                    Image = "https://i.imgur.com/GxCmpo2.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 27",
                    Image = "https://i.imgur.com/vuZaz6V.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 27",
                    Image = "https://i.imgur.com/JKpFdqS.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 27",
                    Image = "https://i.imgur.com/dTdyszL.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 27",
                    Image = "https://i.imgur.com/dxoE3sq.jpg"
                },
                //style 28
                new WheelSpecsImages
                {
                    WheelStyleName = "style 28",
                    Image = "https://i.imgur.com/5Ojl3tG.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 28",
                    Image = "https://i.imgur.com/GOae3wS.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 28",
                    Image = "https://i.imgur.com/Gf9cCez.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 28",
                    Image = "https://i.imgur.com/PSe01Pt.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 28",
                    Image = "https://i.imgur.com/2Msw25m.jpg"
                },
                //style 29
                new WheelSpecsImages
                {
                    WheelStyleName = "style 29",
                    Image = "https://i.imgur.com/bUC7c5C.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 29",
                    Image = "https://i.imgur.com/WL3A2Rp.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 29",
                    Image = "https://i.imgur.com/xEjw9p5.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 29",
                    Image = "https://i.imgur.com/K7R0Dze.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 29",
                    Image = "https://i.imgur.com/Rx6cb6l.jpg"
                },
                //style 30
                new WheelSpecsImages
                {
                    WheelStyleName = "style 30",
                    Image = "https://i.imgur.com/0LHzlFJ.jpgg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 30",
                    Image = "https://i.imgur.com/8NQv3vL.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 30",
                    Image = "https://i.imgur.com/Iigs8zG.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 30",
                    Image = "https://i.imgur.com/3sMp9jR.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 30",
                    Image = "https://i.imgur.com/3C34iIt.jpg"
                },
                //style 31
                new WheelSpecsImages
                {
                    WheelStyleName = "style 31",
                    Image = "https://i.imgur.com/KUVP8PI.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 31",
                    Image = "https://i.imgur.com/IMr1sKX.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 31",
                    Image = "https://i.imgur.com/1lGjYt6.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 31",
                    Image = "https://i.imgur.com/2KN7phx.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 31",
                    Image = "https://i.imgur.com/cVEN0lO.jpg"
                },
                //style 32
                new WheelSpecsImages
                {
                    WheelStyleName = "style 32",
                    Image = "https://i.imgur.com/2OXSZ0c.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 32",
                    Image = "https://i.imgur.com/6Y8Fe8e.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 32",
                    Image = "https://i.imgur.com/id1F65i.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 32",
                    Image = "https://i.imgur.com/H3O2dTn.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 32",
                    Image = "https://i.imgur.com/EC4Px2C.jpg"
                },
                //style 32
                new WheelSpecsImages
                {
                    WheelStyleName = "style 32",
                    Image = "https://i.imgur.com/2OXSZ0c.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 32",
                    Image = "https://i.imgur.com/KsVXqJx.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 32",
                    Image = "https://i.imgur.com/Kq99HrB.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 32",
                    Image = "https://i.imgur.com/XKQeoaZ.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 32",
                    Image = "https://i.imgur.com/X6exow7.jpg"
                },
                //style 33
                new WheelSpecsImages
                {
                    WheelStyleName = "style 33",
                    Image = "https://i.imgur.com/VgTTJLo.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 33",
                    Image = "https://i.imgur.com/DCST830.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 33",
                    Image = "https://i.imgur.com/LTjp0aU.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 33",
                    Image = "https://i.imgur.com/KyPm2nK.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 33",
                    Image = "https://i.imgur.com/Fz1XMDi.jpg"
                },
                //style 34
                new WheelSpecsImages
                {
                    WheelStyleName = "style 34",
                    Image = "https://i.imgur.com/WW6Bgnv.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 34",
                    Image = "https://i.imgur.com/vvGtfZE.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 34",
                    Image = "https://i.imgur.com/1reboF8.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 34",
                    Image = "https://i.imgur.com/4SD4CiF.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 34",
                    Image = "https://i.imgur.com/EAIsshN.jpg"
                },
                //style 35
                new WheelSpecsImages
                {
                    WheelStyleName = "style 35",
                    Image = "https://i.imgur.com/tz4lNgI.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 35",
                    Image = "https://i.imgur.com/CM6EJ11.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 35",
                    Image = "https://i.imgur.com/xBTOJJ4.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 35",
                    Image = "https://i.imgur.com/ZoImiFH.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 35",
                    Image = "http://i.imgur.com/QyvpHij.jpg"
                },
                //style 36
                new WheelSpecsImages
                {
                    WheelStyleName = "style 36",
                    Image = "https://i.imgur.com/PgJTlWy.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 36",
                    Image = "https://i.imgur.com/vASZOtg.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 36",
                    Image = "https://i.imgur.com/zUoqHFn.jpg"
                },
                //style 37
                new WheelSpecsImages
                {
                    WheelStyleName = "style 37",
                    Image = "https://i.imgur.com/3ekLjOU.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 37",
                    Image = "https://i.imgur.com/2OsThBe.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 37",
                    Image = "https://i.imgur.com/BFaTRKw.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 37",
                    Image = "https://i.imgur.com/cSpTRqL.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 37",
                    Image = "https://i.imgur.com/ieKR3MZ.jpg"
                },
                //style 38
                new WheelSpecsImages
                {
                    WheelStyleName = "style 38",
                    Image = "https://i.imgur.com/ljkdmPR.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 38",
                    Image = "https://i.imgur.com/cJRhSCL.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 38",
                    Image = "https://i.imgur.com/2HsCND4.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 38",
                    Image = "https://i.imgur.com/6pv4thG.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 38",
                    Image = "https://i.imgur.com/VcgOCmD.jpg"
                },
                //style 39
                new WheelSpecsImages
                {
                    WheelStyleName = "style 39",
                    Image = "https://i.imgur.com/WCtZNFg.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 39",
                    Image = "https://i.imgur.com/AV5y3Hl.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 39",
                    Image = "https://i.imgur.com/4PqR9wG.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 39",
                    Image = "https://i.imgur.com/0NVKZ6i.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 39",
                    Image = "https://i.imgur.com/0L2bjhH.jpg"
                },
                //style 40
                new WheelSpecsImages
                {
                    WheelStyleName = "style 40",
                    Image = "https://i.imgur.com/8PMcTph.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 40",
                    Image = "https://i.imgur.com/DIL0eW0.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 40",
                    Image = "https://i.imgur.com/HrBcHDq.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 40",
                    Image = "https://i.imgur.com/4osANeN.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 40",
                    Image = "https://i.imgur.com/yoy4U7T.jpg"
                },
                //style 41
                new WheelSpecsImages
                {
                    WheelStyleName = "style 41",
                    Image = "https://i.imgur.com/hSU23Io.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 41",
                    Image = "https://i.imgur.com/wDuNp4n.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 41",
                    Image = "https://i.imgur.com/qIXLrjE.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 41",
                    Image = "https://i.imgur.com/4iRv6U7.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 41",
                    Image = "https://i.imgur.com/pM0qOxz.jpg"
                },
                //style 42
                new WheelSpecsImages
                {
                    WheelStyleName = "style 42",
                    Image = "https://i.imgur.com/wgiR2T9.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 42",
                    Image = "https://i.imgur.com/UOkKRLl.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 42",
                    Image = "https://i.imgur.com/9Fq3jb6.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 42",
                    Image = "https://i.imgur.com/5Qd8DoX.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 42",
                    Image = "https://i.imgur.com/V3cXkBL.jpg"
                },
                //style 43
                new WheelSpecsImages
                {
                    WheelStyleName = "style 43",
                    Image = "https://i.imgur.com/tOEN6Rr.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 43",
                    Image = "https://i.imgur.com/GJkTByb.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 43",
                    Image = "https://i.imgur.com/TdvtapQ.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 43",
                    Image = "https://i.imgur.com/Z1feadB.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 43",
                    Image = "https://i.imgur.com/QKe43D8.jpg"
                },
                //style 44
                new WheelSpecsImages
                {
                    WheelStyleName = "style 44",
                    Image = "https://i.imgur.com/UtAiba6.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 44",
                    Image = "https://i.imgur.com/8yzgVb3.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 44",
                    Image = "https://i.imgur.com/u4vMLij.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 44",
                    Image = "https://i.imgur.com/OwzPlW9.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 44",
                    Image = "https://i.imgur.com/Oul0dZ8.jpg"
                },
                //style 45
                new WheelSpecsImages
                {
                    WheelStyleName = "style 45",
                    Image = "https://i.imgur.com/yPPAvEF.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 45",
                    Image = "https://i.imgur.com/juAZs0l.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 45",
                    Image = "https://i.imgur.com/otg774L.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 45",
                    Image = "https://i.imgur.com/Spl9Rgx.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 45",
                    Image = "https://i.imgur.com/70qcaTA.jpg"
                },
                //style 46
                new WheelSpecsImages
                {
                    WheelStyleName = "style 46",
                    Image = "https://i.imgur.com/vMW9KUn.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 46",
                    Image = "https://i.imgur.com/WnCCqPD.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 46",
                    Image = "https://i.imgur.com/Wzn1P0e.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 46",
                    Image = "https://i.imgur.com/k3tzteQ.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 46",
                    Image = "https://i.imgur.com/8xNJKx4.jpg"
                },
                //style 47
                new WheelSpecsImages
                {
                    WheelStyleName = "style 47",
                    Image = "https://i.imgur.com/EMgTFLF.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 47",
                    Image = "https://i.imgur.com/R6Cxskb.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 47",
                    Image = "https://i.imgur.com/0tMb4OO.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 47",
                    Image = "https://i.imgur.com/MJjFvWp.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 47",
                    Image = "https://i.imgur.com/Y3k0wSn.jpg"
                },
                //style 48
                new WheelSpecsImages
                {
                    WheelStyleName = "style 48",
                    Image = "https://i.imgur.com/YaTWo7L.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 48",
                    Image = "https://i.imgur.com/9ovtnNQ.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 48",
                    Image = "https://i.imgur.com/9ovtnNQ.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 48",
                    Image = "https://i.imgur.com/6zwe6of.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 48",
                    Image = "https://i.imgur.com/cpkXRs2.jpg"
                },
                //style 49
                new WheelSpecsImages
                {
                    WheelStyleName = "style 49",
                    Image = "https://i.imgur.com/Mi9lIjF.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 49",
                    Image = "https://i.imgur.com/DJhFHsP.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 49",
                    Image = "https://i.imgur.com/RAGqbro.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 49",
                    Image = "https://i.imgur.com/lrVteKW.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 49",
                    Image = "https://i.imgur.com/3ZseYg9.jpg"
                },
                //style 50
                new WheelSpecsImages
                {
                    WheelStyleName = "style 50",
                    Image = "https://i.imgur.com/iMML0Bf.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 50",
                    Image = "https://i.imgur.com/A2zYxO3.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 50",
                    Image = "https://i.imgur.com/mbG3PcR.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 50",
                    Image = "https://i.imgur.com/qL62zrR.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 50",
                    Image = "https://i.imgur.com/CPTO6He.jpg"
                },
                //style 51
                new WheelSpecsImages
                {
                    WheelStyleName = "style 51",
                    Image = "https://i.imgur.com/2MZ7P9S.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 51",
                    Image = "https://i.imgur.com/yZp3GzU.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 51",
                    Image = "https://i.imgur.com/JHNTbRS.jpg"
                },
                //style 53
                new WheelSpecsImages
                {
                    WheelStyleName = "style 53",
                    Image = "https://i.imgur.com/VuDZUy4.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 53",
                    Image = "https://i.imgur.com/WIIcJxB.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 53",
                    Image = "https://i.imgur.com/VRrjAYW.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 53",
                    Image = "https://i.imgur.com/bnlz9Xf.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 53",
                    Image = "https://i.imgur.com/S5xw49O.jpg"
                },
                //style 54
                new WheelSpecsImages
                {
                    WheelStyleName = "style 54",
                    Image = "https://i.imgur.com/3SoSlEJ.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 54",
                    Image = "https://i.imgur.com/EmjLpkM.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 54",
                    Image = "https://i.imgur.com/VwjXIKb.jpg"
                },
                //Style 55
                new WheelSpecsImages
                {
                    WheelStyleName = "style 55",
                    Image = "https://i.imgur.com/dhI5ssQ.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 55",
                    Image = "https://i.imgur.com/rG4DujB.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 55",
                    Image = "https://i.imgur.com/WVtUr5X.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 55",
                    Image = "https://i.imgur.com/EzeDfs7.jpg"
                },
                //style 56
                new WheelSpecsImages
                {
                    WheelStyleName = "style 56",
                    Image = "https://i.imgur.com/7ISH2kp.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 56",
                    Image = "https://i.imgur.com/aO2unFw.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 56",
                    Image = "https://i.imgur.com/qdyuhuu.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 56",
                    Image = "https://i.imgur.com/9oHDlFx.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 56",
                    Image = "https://i.imgur.com/BGx37NE.jpg"
                },
                //style 57
                new WheelSpecsImages
                {
                    WheelStyleName = "style 57",
                    Image = "https://i.imgur.com/DBBRxDj.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 57",
                    Image = "https://i.imgur.com/Xr1ACFe.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 57",
                    Image = "https://i.imgur.com/4CeefOj.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 57",
                    Image = "https://i.imgur.com/jFi5lC2.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 57",
                    Image = "https://i.imgur.com/kw2ROVl.jpg"
                },
                //style 58
                new WheelSpecsImages
                {
                    WheelStyleName = "style 58",
                    Image = "https://i.imgur.com/2LhdleE.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 58",
                    Image = "https://i.imgur.com/RvyhEew.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 58",
                    Image = "https://i.imgur.com/7YpqUe2.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 58",
                    Image = "https://i.imgur.com/oHzuE2i.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 58",
                    Image = "https://i.imgur.com/Yh04noY.jpg"
                },
                //style 59
                new WheelSpecsImages
                {
                    WheelStyleName = "style 59",
                    Image = "https://i.imgur.com/Nm72Yss.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 59",
                    Image = "https://i.imgur.com/HdtYLzv.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 59",
                    Image = "https://i.imgur.com/8i921Cf.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 59",
                    Image = "https://i.imgur.com/yFOojb9.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 59",
                    Image = "https://i.imgur.com/4wjbYbM.jpg"
                },
                //style 60
                new WheelSpecsImages
                {
                    WheelStyleName = "style 60",
                    Image = "https://i.imgur.com/6u4fMiZ.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 60",
                    Image = "https://i.imgur.com/LpVyCRF.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 60",
                    Image = "https://i.imgur.com/En7HN2M.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 60",
                    Image = "https://i.imgur.com/X42dtlp.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 60",
                    Image = "https://i.imgur.com/jdrk7CB.jpg"
                },
                //style 61
                new WheelSpecsImages
                {
                    WheelStyleName = "style 61",
                    Image = "https://i.imgur.com/n3G9J6Q.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 61",
                    Image = "https://i.imgur.com/mC7dkhB.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 61",
                    Image = "https://i.imgur.com/fnywTnl.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 61",
                    Image = "https://i.imgur.com/9S2KSbg.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 61",
                    Image = "https://i.imgur.com/AJ3gQLp.jpg"
                },
                //style 63
                new WheelSpecsImages
                {
                    WheelStyleName = "style 63",
                    Image = "https://i.imgur.com/fWv6wd9.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 63",
                    Image = "https://i.imgur.com/656dEHO.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 63",
                    Image = "https://i.imgur.com/6qIFGh5.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 63",
                    Image = "https://i.imgur.com/ojIoqUZ.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 63",
                    Image = "https://i.imgur.com/Q0ROwno.jpg"
                },
                //style 64
                new WheelSpecsImages
                {
                    WheelStyleName = "style 64",
                    Image = "https://i.imgur.com/9La8SCP.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 64",
                    Image = "https://i.imgur.com/KgnfzWq.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 64",
                    Image = "http://i.imgur.com/UHRobnO.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 64",
                    Image = "https://i.imgur.com/IxBOFbc.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 64",
                    Image = "https://i.imgur.com/ef8efpn.jpg"
                },
                //style 65
                new WheelSpecsImages
                {
                    WheelStyleName = "style 65",
                    Image = "https://i.imgur.com/CyvAoQ4.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 65",
                    Image = "https://i.imgur.com/G1NMiPo.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 65",
                    Image = "https://i.imgur.com/D6OM6OA.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 65",
                    Image = "https://i.imgur.com/k6fHLkM.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 65",
                    Image = "https://i.imgur.com/BQJ1EKN.jpg"
                },
                //style 66
                new WheelSpecsImages
                {
                    WheelStyleName = "style 66",
                    Image = "https://i.imgur.com/XRynCEo.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 66",
                    Image = "https://i.imgur.com/NO6Z88S.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 66",
                    Image = "https://i.imgur.com/4xBfdpg.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 66",
                    Image = "https://i.imgur.com/vSrH6AT.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 66",
                    Image = "https://i.imgur.com/5pT1PmM.jpg"
                },
                //style 67
                new WheelSpecsImages
                {
                    WheelStyleName = "style 67",
                    Image = "https://i.imgur.com/4YCJ8Rx.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 67",
                    Image = "https://i.imgur.com/0wWAxAL.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 67",
                    Image = "https://i.imgur.com/eQFXFBJ.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 67",
                    Image = "https://i.imgur.com/lQJKd6n.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 67",
                    Image = "https://i.imgur.com/RQ61P7Y.jpg"
                },
                //style 68
                new WheelSpecsImages
                {
                    WheelStyleName = "style 68",
                    Image = "https://i.imgur.com/uFT2FjN.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 68",
                    Image = "https://i.imgur.com/8eENS06.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 68",
                    Image = "https://i.imgur.com/f2pCn67.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 68",
                    Image = "https://i.imgur.com/Ifa0c8z.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 68",
                    Image = "https://i.imgur.com/7irSiua.jpg"
                },
                //style 69
                new WheelSpecsImages
                {
                    WheelStyleName = "style 69",
                    Image = "https://i.imgur.com/BBiSTrs.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 69",
                    Image = "https://i.imgur.com/cFr1eLt.jpgg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 69",
                    Image = "https://i.imgur.com/xc7UWjV.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 69",
                    Image = "https://i.imgur.com/22dofIX.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 69",
                    Image = "https://i.imgur.com/nyjkuVk.jpg"
                },
                //style 70
                new WheelSpecsImages
                {
                    WheelStyleName = "style 70",
                    Image = "https://i.imgur.com/pdQCRRu.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 70",
                    Image = "https://i.imgur.com/inrXQ9h.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 70",
                    Image = "https://i.imgur.com/WomK2ik.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 70",
                    Image = "https://i.imgur.com/3Drgpcp.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 70",
                    Image = "https://i.imgur.com/2JdmtGl.jpg"
                },
                //style 71
                new WheelSpecsImages
                {
                    WheelStyleName = "style 71",
                    Image = "https://i.imgur.com/FoWxlTc.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 71",
                    Image = "https://i.imgur.com/ZNRH2v2.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 71",
                    Image = "https://i.imgur.com/pCOUR4h.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 71",
                    Image = "https://i.imgur.com/Tvcowp0.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 71",
                    Image = "https://i.imgur.com/rA1hQAp.jpg"
                },
                //style 72
                new WheelSpecsImages
                {
                    WheelStyleName = "style 72",
                    Image = "https://i.imgur.com/PcGM7Ne.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 72",
                    Image = "https://i.imgur.com/amsJ6Az.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 72",
                    Image = "https://i.imgur.com/u0QBS6j.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 72",
                    Image = "https://i.imgur.com/cTuB64t.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 72",
                    Image = "https://i.imgur.com/bGrOEz6.jpg"
                },
                //style 73
                new WheelSpecsImages
                {
                    WheelStyleName = "style 73",
                    Image = "https://i.imgur.com/9IJvxu5.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 73",
                    Image = "https://i.imgur.com/vOnrt8t.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 73",
                    Image = "https://i.imgur.com/eXiXtO3.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 73",
                    Image = "https://i.imgur.com/ET3tJpW.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 73",
                    Image = "https://i.imgur.com/MEy1yEa.jpg"
                },
                //style 74
                new WheelSpecsImages
                {
                    WheelStyleName = "style 74",
                    Image = "https://i.imgur.com/OaCRjRQ.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 74",
                    Image = "https://i.imgur.com/jAuGxkS.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 74",
                    Image = "https://i.imgur.com/9Q8B21T.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 74",
                    Image = "https://i.imgur.com/DNMQUP5.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 74",
                    Image = "https://i.imgur.com/Vnf0WdC.jpg"
                },
                //style 75
                new WheelSpecsImages
                {
                    WheelStyleName = "style 75",
                    Image = "https://i.imgur.com/UEeDPZk.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 75",
                    Image = "https://i.imgur.com/jz2v7pC.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 75",
                    Image = "https://i.imgur.com/iClmjW6.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 75",
                    Image = "https://i.imgur.com/YTvLW4t.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 75",
                    Image = "https://i.imgur.com/5mJUS3I.jpg"
                },
                //style 76
                new WheelSpecsImages
                {
                    WheelStyleName = "style 76",
                    Image = "https://i.imgur.com/msfHGdg.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 76",
                    Image = "https://i.imgur.com/Q4KyfLf.jpg"
                },
                //style 77
                new WheelSpecsImages
                {
                    WheelStyleName = "style 77",
                    Image = "https://i.imgur.com/M3RzSg5.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 77",
                    Image = "https://i.imgur.com/rGJXb5I.jpg"
                },
                //style 78
                new WheelSpecsImages
                {
                    WheelStyleName = "style 78",
                    Image = "https://i.imgur.com/B2GTf65.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 78",
                    Image = "https://i.imgur.com/kXTcQJH.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 78",
                    Image = "https://i.imgur.com/gTYKWB9.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 78",
                    Image = "https://i.imgur.com/vIRCNJb.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 78",
                    Image = "https://i.imgur.com/UVIbn7W.jpg"
                },

                //style 79
                new WheelSpecsImages
                {
                    WheelStyleName = "style 79",
                    Image = "https://i.imgur.com/QJlauLj.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 79",
                    Image = "https://i.imgur.com/Nmyc1lB.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 79",
                    Image = "https://i.imgur.com/2LdRcDp.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 79",
                    Image = "https://i.imgur.com/mj197Ii.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 79",
                    Image = "https://i.imgur.com/nAAotTK.jpg"
                },
                //style 80
                new WheelSpecsImages
                {
                    WheelStyleName = "style 80",
                    Image = "https://i.imgur.com/uB63e3Y.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 80",
                    Image = "https://i.imgur.com/YPeHDJk.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 80",
                    Image = "https://i.imgur.com/0aeYtCj.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 80",
                    Image = "https://i.imgur.com/e6fDrk8.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 80",
                    Image = "https://i.imgur.com/DwSV6F2.jpg"
                },
                //style 81
                new WheelSpecsImages
                {
                    WheelStyleName = "style 81",
                    Image = "https://i.imgur.com/PB2GNpO.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 81",
                    Image = "https://i.imgur.com/7J5PIfe.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 81",
                    Image = "https://i.imgur.com/ajhhzvn.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 81",
                    Image = "https://i.imgur.com/vvfGpYP.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 81",
                    Image = "https://i.imgur.com/DA6Z3ow.jpg"
                },
                //style 82
                new WheelSpecsImages
                {
                    WheelStyleName = "style 82",
                    Image = "https://i.imgur.com/gDywEN9.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 82",
                    Image = "https://i.imgur.com/ANNGAGp.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 82",
                    Image = "https://i.imgur.com/RJGeJlW.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 82",
                    Image = "https://i.imgur.com/12FhwJ2.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 82",
                    Image = "https://i.imgur.com/PeXFH70.jpg"
                },
                //style 83
                new WheelSpecsImages
                {
                    WheelStyleName = "style 83",
                    Image = "https://i.imgur.com/PkEAFLM.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 83",
                    Image = "https://i.imgur.com/BjTS3gP.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 83",
                    Image = "https://i.imgur.com/Xz5jCGi.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 83",
                    Image = "https://i.imgur.com/cWahEpa.jpg"
                },
                
                //style 85
                new WheelSpecsImages
                {
                    WheelStyleName = "style 85",
                    Image = "https://i.imgur.com/UtQ2jq8.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 85",
                    Image = "https://i.imgur.com/sTHEk3F.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 85",
                    Image = "https://i.imgur.com/fN7wgKX.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 85",
                    Image = "https://i.imgur.com/SOnbJV1.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 85",
                    Image = "https://i.imgur.com/yLpGTyZ.jpg"
                },
                //style 86
                new WheelSpecsImages
                {
                    WheelStyleName = "style 86",
                    Image = "https://i.imgur.com/ozVIjX8.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 86",
                    Image = "https://i.imgur.com/OfYYsxg.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 86",
                    Image = "https://i.imgur.com/s6JQk3h.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 86",
                    Image = "https://i.imgur.com/TDLJdAC.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 86",
                    Image = "https://i.imgur.com/qFN1XVB.jpg"
                },
                //style 87
                new WheelSpecsImages
                {
                    WheelStyleName = "style 87",
                    Image = "https://i.imgur.com/9ZjQRLs.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 87",
                    Image = "https://i.imgur.com/TnxOf6M.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 87",
                    Image = "https://i.imgur.com/rE91geU.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 87",
                    Image = "https://i.imgur.com/ZGiApfL.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 87",
                    Image = "https://i.imgur.com/yClaySn.jpg"
                },
                //style  88
                new WheelSpecsImages
                {
                    WheelStyleName = "style 88",
                    Image = "https://i.imgur.com/mqMlRmz.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 88",
                    Image = "https://i.imgur.com/hmAn5sx.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 88",
                    Image = "https://i.imgur.com/xvR94xc.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 88",
                    Image = "https://i.imgur.com/UFVJfkN.jpg"
                },
                //style 89
                new WheelSpecsImages
                {
                    WheelStyleName = "style 89",
                    Image = "https://i.imgur.com/nnOW6bz.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 89",
                    Image = "https://i.imgur.com/lE9kROb.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 89",
                    Image = "https://i.imgur.com/RACzkxG.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 89",
                    Image = "https://i.imgur.com/bhY3ir6.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 89",
                    Image = "https://i.imgur.com/s9sKfnH.jpg"
                },
                //style 90
                new WheelSpecsImages
                {
                    WheelStyleName = "style 90",
                    Image = "https://i.imgur.com/IAYkjHJ.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 90",
                    Image = "https://i.imgur.com/lU9sRbV.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 90",
                    Image = "https://i.imgur.com/nB27AR2.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 90",
                    Image = "https://i.imgur.com/AFS0YJ8.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 90",
                    Image = "https://i.imgur.com/ya1r27l.jpg"
                },
                //style 91
                new WheelSpecsImages
                {
                    WheelStyleName = "style 91",
                    Image = "https://i.imgur.com/bYKTxi3.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 91",
                    Image = "https://i.imgur.com/MwsjcXe.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 91",
                    Image = "https://i.imgur.com/TB32Ynw.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 91",
                    Image = "https://i.imgur.com/TOhVdsC.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 91",
                    Image = "https://i.imgur.com/UbMQgum.jpg"
                },
                //style 92
                new WheelSpecsImages
                {
                    WheelStyleName = "style 92",
                    Image = "https://i.imgur.com/nV1bmqn.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 92",
                    Image = "https://i.imgur.com/qVSHhvG.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 92",
                    Image = "https://i.imgur.com/5hDLlKb.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 92",
                    Image = "https://i.imgur.com/km80hrl.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 92",
                    Image = "https://i.imgur.com/Qnxq1fE.jpg"
                },
                //style 93
                new WheelSpecsImages
                {
                    WheelStyleName = "style 93",
                    Image = "https://i.imgur.com/76ZbDIo.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 93",
                    Image = "https://i.imgur.com/rlQVGhy.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 93",
                    Image = "https://i.imgur.com/Xafz4Io.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 93",
                    Image = "https://i.imgur.com/fkUezrI.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 93",
                    Image = "https://i.imgur.com/whic132.jpg"
                },
                //style 94
                new WheelSpecsImages
                {
                    WheelStyleName = "style 94",
                    Image = "https://i.imgur.com/oIJVXwE.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 94",
                    Image = "https://i.imgur.com/uRcNCK7.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 94",
                    Image = "https://i.imgur.com/LJ2bqE2.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 94",
                    Image = "https://i.imgur.com/bOcwb3W.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 94",
                    Image = "https://i.imgur.com/XKJx1lA.jpg"
                },
                //style 95
                new WheelSpecsImages
                {
                    WheelStyleName = "style 95",
                    Image = "https://i.imgur.com/83DCeiE.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 95",
                    Image = "https://i.imgur.com/FpNMQqN.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 95",
                    Image = "https://i.imgur.com/GXvy2Wd.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 95",
                    Image = "https://i.imgur.com/mwwNgKB.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 95",
                    Image = "https://i.imgur.com/p4L1jth.jpg"
                },
                //style 96
                new WheelSpecsImages
                {
                    WheelStyleName = "style 96",
                    Image = "https://i.imgur.com/r3FsoxV.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 96",
                    Image = "https://i.imgur.com/wbMrMI8.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 96",
                    Image = "https://i.imgur.com/JlzBcMx.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 96",
                    Image = "https://i.imgur.com/JsgJWu8.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 96",
                    Image = "https://i.imgur.com/VwCJJDP.jpg"
                },

                //style 97
                new WheelSpecsImages
                {
                    WheelStyleName = "style 97",
                    Image = "https://i.imgur.com/QKPcJ4f.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 97",
                    Image = "https://i.imgur.com/5ifUrCd.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 97",
                    Image = "https://i.imgur.com/Cjtsznq.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 97",
                    Image = "https://i.imgur.com/O2AuVGx.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 97",
                    Image = "https://i.imgur.com/gavkWP0.jpg"
                },
                //style 98
                new WheelSpecsImages
                {
                    WheelStyleName = "style 98",
                    Image = "https://i.imgur.com/MlPIS7Q.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 98",
                    Image = "https://i.imgur.com/UryfFom.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 98",
                    Image = "https://i.imgur.com/098qHBl.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 98",
                    Image = "https://i.imgur.com/wszAlLO.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 98",
                    Image = "https://i.imgur.com/PW4Lxw3.jpg"
                },
                //style 99
                new WheelSpecsImages
                {
                    WheelStyleName = "style 99",
                    Image = "https://i.imgur.com/BILnBgq.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 99",
                    Image = "https://i.imgur.com/fRTLBWD.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 99",
                    Image = "https://i.imgur.com/tqOCZSf.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 99",
                    Image = "https://i.imgur.com/6Gv7Wrw.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 99",
                    Image = "https://i.imgur.com/pYdLdmL.jpg"
                },
                //style 101
                new WheelSpecsImages
                {
                    WheelStyleName = "style 101",
                    Image = "https://i.imgur.com/fkNcTTy.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 101",
                    Image = "https://i.imgur.com/IiSSbU6.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 101",
                    Image = "https://i.imgur.com/uh9bDpF.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 101",
                    Image = "https://i.imgur.com/puAZcMM.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 101",
                    Image = "https://i.imgur.com/X96FRew.jpg"
                },
                //style 102
                new WheelSpecsImages
                {
                    WheelStyleName = "style 102",
                    Image = "https://i.imgur.com/0j5ariH.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 102",
                    Image = "https://i.imgur.com/6uPpHna.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 102",
                    Image = "https://i.imgur.com/QgP2yuq.jpg"
                },
                //style 103
                new WheelSpecsImages
                {
                    WheelStyleName = "style 103",
                    Image = "https://i.imgur.com/gFizqre.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 103",
                    Image = "https://i.imgur.com/jmetxfy.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 103",
                    Image = "https://i.imgur.com/cLNYD7q.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 103",
                    Image = "https://i.imgur.com/KJyqln5.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 103",
                    Image = "https://i.imgur.com/6zfZkvn.jpg"
                },
                //style 104
                new WheelSpecsImages
                {
                    WheelStyleName = "style 104",
                    Image = "https://i.imgur.com/OjqRgGC.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 104",
                    Image = "https://i.imgur.com/akUutd6.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 104",
                    Image = "https://i.imgur.com/8pUmbP5.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 104",
                    Image = "https://i.imgur.com/5XzS44m.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 104",
                    Image = "https://i.imgur.com/7j2cewj.jpg"
                },
                //style 105
                new WheelSpecsImages
                {
                    WheelStyleName = "style 105",
                    Image = "https://i.imgur.com/IBM51Hy.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 105",
                    Image = "https://i.imgur.com/hgF3Bay.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 105",
                    Image = "https://i.imgur.com/ArNtamz.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 105",
                    Image = "https://i.imgur.com/JHLdBeV.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 105",
                    Image = "https://i.imgur.com/L7sMnRG.jpg"
                },
                //style 106
                new WheelSpecsImages
                {
                    WheelStyleName = "style 106",
                    Image = "https://i.imgur.com/Z6w635X.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 106",
                    Image = "https://i.imgur.com/CrHMYtq.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 106",
                    Image = "https://i.imgur.com/DQsrIP6.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 106",
                    Image = "https://i.imgur.com/bwLHtdz.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 106",
                    Image = "https://i.imgur.com/TB2e8H3.jpg"
                },
                //style 107
                new WheelSpecsImages
                {
                    WheelStyleName = "style 107",
                    Image = "https://i.imgur.com/ulDkmVH.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 107",
                    Image = "https://i.imgur.com/mIPHSYk.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 107",
                    Image = "https://i.imgur.com/XTkzVC0.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 107",
                    Image = "https://i.imgur.com/ZZjKpSs.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 107",
                    Image = "https://i.imgur.com/9uyyl5q.jpg"
                },
                //style 108
                new WheelSpecsImages
                {
                    WheelStyleName = "style 108",
                    Image = "https://i.imgur.com/6WdaXy7.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 108",
                    Image = "https://i.imgur.com/ByalqZb.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 108",
                    Image = "https://i.imgur.com/0UyZa6D.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 108",
                    Image = "https://i.imgur.com/kb6GKHS.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 108",
                    Image = "https://i.imgur.com/oO2P7bI.jpg"
                },
                //style 109
                new WheelSpecsImages
                {
                    WheelStyleName = "style 109",
                    Image = "https://i.imgur.com/BDlUYkE.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 109",
                    Image = "https://i.imgur.com/vayaLTO.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 109",
                    Image = "https://i.imgur.com/99PwMbJ.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 109",
                    Image = "https://i.imgur.com/IKC55SG.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 109",
                    Image = "https://i.imgur.com/LPvpHL8.jpg"
                },
                //style 110
                new WheelSpecsImages
                {
                    WheelStyleName = "style 110",
                    Image = "https://i.imgur.com/EkEx5ix.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 110",
                    Image = "https://i.imgur.com/r3c4Kyd.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 110",
                    Image = "https://i.imgur.com/ZwXg36z.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 110",
                    Image = "https://i.imgur.com/yVvimLP.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 110",
                    Image = "https://i.imgur.com/etgINjD.jpg"
                },
                //style 111
                new WheelSpecsImages
                {
                    WheelStyleName = "style 111",
                    Image = "https://i.imgur.com/N1I0Pob.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 111",
                    Image = "https://i.imgur.com/CcqPc4r.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 111",
                    Image = "https://i.imgur.com/JBq0WWu.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 111",
                    Image = "https://i.imgur.com/O3K6eN8.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 111",
                    Image = "https://i.imgur.com/GGyybC9.jpg"
                },
                //style 112
                new WheelSpecsImages
                {
                    WheelStyleName = "style 112",
                    Image = "https://i.imgur.com/wGcuhss.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 112",
                    Image = "https://i.imgur.com/zJ0vUou.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 112",
                    Image = "https://i.imgur.com/M8EvGhO.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 112",
                    Image = "https://i.imgur.com/VxwiHPa.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 112",
                    Image = "https://i.imgur.com/mdU11eu.jpg"
                },
                //style 113
                new WheelSpecsImages
                {
                    WheelStyleName = "style 113",
                    Image = "https://i.imgur.com/gLaPB9a.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 113",
                    Image = "https://i.imgur.com/ppHFUXf.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 113",
                    Image = "https://i.imgur.com/lMofid6.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 113",
                    Image = "https://i.imgur.com/epoRAtj.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 113",
                    Image = "https://i.imgur.com/hslZWRD.jpg"
                },
                //style 114
                new WheelSpecsImages
                {
                    WheelStyleName = "style 114",
                    Image = "https://i.imgur.com/Mm6qefe.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 114",
                    Image = "https://i.imgur.com/fpIFq3q.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 114",
                    Image = "https://i.imgur.com/1JcCIBj.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 114",
                    Image = "https://i.imgur.com/Yden0oX.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 114",
                    Image = "https://i.imgur.com/LzYIUV4.jpg"
                },
                //style 115
                new WheelSpecsImages
                {
                    WheelStyleName = "style 115",
                    Image = "https://i.imgur.com/l6nwA78.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 115",
                    Image = "https://i.imgur.com/VVQ3KS9.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 115",
                    Image = "https://i.imgur.com/uua7oT3.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 115",
                    Image = "https://i.imgur.com/8W9YeNf.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 115",
                    Image = "https://i.imgur.com/iUi6nZ9.jpg"
                },
                //style 116
                new WheelSpecsImages
                {
                    WheelStyleName = "style 116",
                    Image = "https://i.imgur.com/6HH5XPT.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 116",
                    Image = "https://i.imgur.com/lGAp0hg.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 116",
                    Image = "https://i.imgur.com/nQP4qVt.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 116",
                    Image = "https://i.imgur.com/ehwQTzH.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 116",
                    Image = "https://i.imgur.com/m6ramB3.jpg"
                },
                //style 117
                new WheelSpecsImages
                {
                    WheelStyleName = "style 117",
                    Image = "https://i.imgur.com/HfUX9Jc.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 117",
                    Image = "https://i.imgur.com/DpFHh3M.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 117",
                    Image = "https://i.imgur.com/cpcLbVR.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 117",
                    Image = "https://i.imgur.com/wXGVYbp.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 117",
                    Image = "https://i.imgur.com/VxJ2dcK.jpg"
                },
                //style 118
                new WheelSpecsImages
                {
                    WheelStyleName = "style 118",
                    Image = "https://i.imgur.com/7jP7yWe.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 118",
                    Image = "https://i.imgur.com/Esmn4aY.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 118",
                    Image = "https://i.imgur.com/eRpw4Ct.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 118",
                    Image = "https://i.imgur.com/HAX3K8i.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 118",
                    Image = "https://i.imgur.com/o7QMFCn.jpg"
                },
                //style 119
                new WheelSpecsImages
                {
                    WheelStyleName = "style 119",
                    Image = "https://i.imgur.com/KLwRFdu.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 119",
                    Image = "https://i.imgur.com/zhk2HAV.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 119",
                    Image = "https://i.imgur.com/nxkDEO4.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 119",
                    Image = "https://i.imgur.com/Wx6PICB.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 119",
                    Image = "https://i.imgur.com/gylCfrv.jpg"
                },
                //style 120
                new WheelSpecsImages
                {
                    WheelStyleName = "style 120",
                    Image = "https://i.imgur.com/mbwuRLS.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 120",
                    Image = "https://i.imgur.com/vVXkElO.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 120",
                    Image = "https://i.imgur.com/f91VdQa.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 120",
                    Image = "https://i.imgur.com/blp4wRO.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 120",
                    Image = "https://i.imgur.com/GVRs1A0.jpg"
                },
                //style 121
                new WheelSpecsImages
                {
                    WheelStyleName = "style 121",
                    Image = "https://i.imgur.com/01K42Dd.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 121",
                    Image = "https://i.imgur.com/TnY4ixy.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 121",
                    Image = "https://i.imgur.com/Knmyn4z.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 121",
                    Image = "https://i.imgur.com/lpXWEYr.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 121",
                    Image = "https://i.imgur.com/salr8Z9.jpg"
                },
                //style 122
                new WheelSpecsImages
                {
                    WheelStyleName = "style 122",
                    Image = "https://i.imgur.com/3inh69B.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 122",
                    Image = "https://i.imgur.com/ZuUpB0q.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 122",
                    Image = "https://i.imgur.com/kDzirhE.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 122",
                    Image = "https://i.imgur.com/MCOIWs8.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 122",
                    Image = "https://i.imgur.com/MUoogBr.jpg"
                },
                //style 123
                new WheelSpecsImages
                {
                    WheelStyleName = "style 123",
                    Image = "https://i.imgur.com/7hnKeu4.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 123",
                    Image = "https://i.imgur.com/zVQSYiy.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 123",
                    Image = "https://i.imgur.com/11xySqZ.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 123",
                    Image = "https://i.imgur.com/eEK9uG3.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 123",
                    Image = "https://i.imgur.com/7X0HQBK.jpg"
                },
                //style 124
                new WheelSpecsImages
                {
                    WheelStyleName = "style 124",
                    Image = "https://i.imgur.com/tMeHkDn.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 124",
                    Image = "https://i.imgur.com/ds0HMBZ.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 124",
                    Image = "https://i.imgur.com/TV7Y4aE.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 124",
                    Image = "https://i.imgur.com/ulvgFOb.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 124",
                    Image = "https://i.imgur.com/P2UPST3.jpg"
                },
                //style 125
                new WheelSpecsImages
                {
                    WheelStyleName = "style 125",
                    Image = "https://i.imgur.com/jwDV107.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 125",
                    Image = "https://i.imgur.com/1lvFljB.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 125",
                    Image = "https://i.imgur.com/Uv1OwW7.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 125",
                    Image = "https://i.imgur.com/b84f4MT.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 125",
                    Image = "https://i.imgur.com/zT39EMG.jpg"
                },
                //style 126
                new WheelSpecsImages
                {
                    WheelStyleName = "style 126",
                    Image = "https://i.imgur.com/FbfIxYd.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 126",
                    Image = "https://i.imgur.com/ORhHjfT.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 126",
                    Image = "https://i.imgur.com/JW3PCgV.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 126",
                    Image = "https://i.imgur.com/oUxUmFi.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 126",
                    Image = "https://i.imgur.com/qo32Hvj.jpg"
                },
                //style 127
                new WheelSpecsImages
                {
                    WheelStyleName = "style 127",
                    Image = "https://i.imgur.com/VChnVVA.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 127",
                    Image = "https://i.imgur.com/c7gYPxc.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 127",
                    Image = "https://i.imgur.com/KNZAWnt.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 127",
                    Image = "https://i.imgur.com/uA5H2Nx.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 127",
                    Image = "https://i.imgur.com/91xgBxG.jpg"
                },
                //style 128
                new WheelSpecsImages
                {
                    WheelStyleName = "style 128",
                    Image = "https://i.imgur.com/LAobEXx.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 128",
                    Image = "https://i.imgur.com/G9asxxp.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 128",
                    Image = "https://i.imgur.com/ClzKkMe.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 128",
                    Image = "https://i.imgur.com/v2JYl87.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 128",
                    Image = "https://i.imgur.com/tZD75KB.jpg"
                },
                //style 129
                new WheelSpecsImages
                {
                    WheelStyleName = "style 129",
                    Image = "https://i.imgur.com/HQhpInE.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 129",
                    Image = "https://i.imgur.com/npK7IPi.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 129",
                    Image = "https://i.imgur.com/qzg3Q0e.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 129",
                    Image = "https://i.imgur.com/h3K4tlF.jpg"
                },
                //style 130
                new WheelSpecsImages
                {
                    WheelStyleName = "style 130",
                    Image = "https://i.imgur.com/tWihtuY.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 130",
                    Image = "https://i.imgur.com/8Djtbgi.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 130",
                    Image = "https://i.imgur.com/BshIXAN.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 130",
                    Image = "https://i.imgur.com/PNeJH0Z.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 130",
                    Image = "https://i.imgur.com/crEmOkT.jpg"
                },
                //style 131
                new WheelSpecsImages
                {
                    WheelStyleName = "style 131",
                    Image = "https://i.imgur.com/0JfoMJW.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 131",
                    Image = "https://i.imgur.com/GVA0RYT.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 131",
                    Image = "https://i.imgur.com/7pSI3em.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 131",
                    Image = "https://i.imgur.com/qDfhw3g.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 131",
                    Image = "https://i.imgur.com/pyjP2KP.jpg"
                },
                //style 132
                new WheelSpecsImages
                {
                    WheelStyleName = "style 132",
                    Image = "https://i.imgur.com/QDVaTnh.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 132",
                    Image = "https://i.imgur.com/63gko4J.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 132",
                    Image = "https://i.imgur.com/4MI1Bzg.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 132",
                    Image = "https://i.imgur.com/lWyiQOc.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 132",
                    Image = "https://i.imgur.com/Q2lSohO.jpg"
                },
                //style 133
                new WheelSpecsImages
                {
                    WheelStyleName = "style 133",
                    Image = "https://i.imgur.com/H8saD1q.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 133",
                    Image = "https://i.imgur.com/W8NKsxo.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 133",
                    Image = "https://i.imgur.com/gIJ2nEb.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 133",
                    Image = "https://i.imgur.com/Mho19TV.jpg"
                },
                //style 134
                new WheelSpecsImages
                {
                    WheelStyleName = "style 134",
                    Image = "https://i.imgur.com/JG9nX1j.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 134",
                    Image = "https://i.imgur.com/SeC3Uoo.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 134",
                    Image = "https://i.imgur.com/vKAKvW6.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 134",
                    Image = "https://i.imgur.com/bzRUL6J.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 134",
                    Image = "https://i.imgur.com/JK5TBeA.jpg"
                },
               //style 135
               new WheelSpecsImages
                {
                    WheelStyleName = "style 135",
                    Image = "https://i.imgur.com/dOA7UxC.jpg"
                },
               new WheelSpecsImages
                {
                    WheelStyleName = "style 135",
                    Image = "https://i.imgur.com/Tz5DLnl.jpg"
                },
               new WheelSpecsImages
                {
                    WheelStyleName = "style 135",
                    Image = "https://i.imgur.com/A5LtgKt.jpg"
                },
               new WheelSpecsImages
                {
                    WheelStyleName = "style 135",
                    Image = "https://i.imgur.com/BDCeNTT.jpg"
                },
               new WheelSpecsImages
                {
                    WheelStyleName = "style 135",
                    Image = "https://i.imgur.com/vf7wvDb.jpg"
                },
               //style 136
               new WheelSpecsImages
                {
                    WheelStyleName = "style 136",
                    Image = "https://i.imgur.com/6MHeAf0.jpg"
                },
               new WheelSpecsImages
                {
                    WheelStyleName = "style 136",
                    Image = "https://i.imgur.com/lF2v6Rh.jpg"
                },
               new WheelSpecsImages
                {
                    WheelStyleName = "style 136",
                    Image = "https://i.imgur.com/eujxySK.jpg"
                },
               new WheelSpecsImages
                {
                    WheelStyleName = "style 136",
                    Image = "https://i.imgur.com/V4JRTT4.jpg"
                },
               new WheelSpecsImages
                {
                    WheelStyleName = "style 136",
                    Image = "https://i.imgur.com/KYRJ04Z.jpg"
                },
               //style 137
               new WheelSpecsImages
                {
                    WheelStyleName = "style 137",
                    Image = "https://i.imgur.com/6HaBhcS.jpg"
                },
               new WheelSpecsImages
                {
                    WheelStyleName = "style 137",
                    Image = "https://i.imgur.com/mCJFhJl.jpg"
                },
               new WheelSpecsImages
                {
                    WheelStyleName = "style 137",
                    Image = "https://i.imgur.com/8UETfse.jpg"
                },
               new WheelSpecsImages
                {
                    WheelStyleName = "style 137",
                    Image = "https://i.imgur.com/gUQOSpX.jpg"
                },
               new WheelSpecsImages
                {
                    WheelStyleName = "style 137",
                    Image = "https://i.imgur.com/FH4FTxr.jpg"
                },
               //style 138
               new WheelSpecsImages
                {
                    WheelStyleName = "style 138",
                    Image = "https://i.imgur.com/OYQcATW.jpg"
                },
               new WheelSpecsImages
                {
                    WheelStyleName = "style 138",
                    Image = "https://i.imgur.com/DIVvHUR.jpg"
                },
               new WheelSpecsImages
                {
                    WheelStyleName = "style 138",
                    Image = "https://i.imgur.com/mqcc21o.jpg"
                },
               new WheelSpecsImages
                {
                    WheelStyleName = "style 138",
                    Image = "https://i.imgur.com/YfRTbtr.jpg"
                },
               new WheelSpecsImages
                {
                    WheelStyleName = "style 138",
                    Image = "https://i.imgur.com/HONXaTD.jpg"
                },

                //style 139
                new WheelSpecsImages
                {
                    WheelStyleName = "style 139",
                    Image = "https://i.imgur.com/aBVwzWG.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 139",
                    Image = "https://i.imgur.com/3E2tgXA.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 139",
                    Image = "https://i.imgur.com/jxm6dxS.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 139",
                    Image = "https://i.imgur.com/OlLEifu.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 139",
                    Image = "https://i.imgur.com/LMF1kjH.jpg"
                },
                //style 140
                new WheelSpecsImages
                {
                    WheelStyleName = "style 140",
                    Image = "https://i.imgur.com/KYAnmYe.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 140",
                    Image = "https://i.imgur.com/Tn2U5xd.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 140",
                    Image = "https://i.imgur.com/87vWpw8.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 140",
                    Image = "https://i.imgur.com/jKIePsh.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 140",
                    Image = "https://i.imgur.com/Oc48kEJ.jpg"
                },
                //style 141
                new WheelSpecsImages
                {
                    WheelStyleName = "style 141",
                    Image = "https://i.imgur.com/nydgc7z.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 141",
                    Image = "https://i.imgur.com/s9cmIzL.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 141",
                    Image = "https://i.imgur.com/NjmVqhb.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 141",
                    Image = "https://i.imgur.com/P1iD6DS.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 141",
                    Image = "https://i.imgur.com/fYxJMff.jpg"
                },
                //style 142
                new WheelSpecsImages
                {
                    WheelStyleName = "style 142",
                    Image = "https://i.imgur.com/lTA2LNR.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 142",
                    Image = "https://i.imgur.com/0ZdK8Vw.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 142",
                    Image = "https://i.imgur.com/q9XH0bu.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 142",
                    Image = "https://i.imgur.com/4kgWKzv.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 142",
                    Image = "https://i.imgur.com/UAmYUQ4.jpg"
                },
                //style 143
                new WheelSpecsImages
                {
                    WheelStyleName = "style 143",
                    Image = "https://i.imgur.com/KAVeuXO.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 143",
                    Image = "https://i.imgur.com/xV6PFOw.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 143",
                    Image = "https://i.imgur.com/OOGPhWA.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 143",
                    Image = "https://i.imgur.com/8uJa8H4.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 143",
                    Image = "https://i.imgur.com/KO8ZbP1.jpg"
                },
               //style 144
               new WheelSpecsImages
                {
                    WheelStyleName = "style 144",
                    Image = "https://i.imgur.com/NoiWwZX.jpg"
                },
               new WheelSpecsImages
                {
                    WheelStyleName = "style 144",
                    Image = "https://i.imgur.com/D3CwsVw.jpg"
                },
               new WheelSpecsImages
                {
                    WheelStyleName = "style 144",
                    Image = "https://i.imgur.com/qU0gLJa.jpg"
                },
               new WheelSpecsImages
                {
                    WheelStyleName = "style 144",
                    Image = "https://i.imgur.com/1LVhlxI.jpg"
                },
               new WheelSpecsImages
                {
                    WheelStyleName = "style 144",
                    Image = "https://i.imgur.com/kgUpIz5.jpg"
                },
               //style 145
               new WheelSpecsImages
                {
                    WheelStyleName = "style 145",
                    Image = "https://i.imgur.com/Dhv9HHM.jpg"
                },
               new WheelSpecsImages
                {
                    WheelStyleName = "style 145",
                    Image = "https://i.imgur.com/nHspMPU.jpg"
                },
               new WheelSpecsImages
                {
                    WheelStyleName = "style 145",
                    Image = "https://i.imgur.com/bluPz1T.jpg"
                },
               new WheelSpecsImages
                {
                    WheelStyleName = "style 145",
                    Image = "https://i.imgur.com/Xp69cd0.jpg"
                },
               new WheelSpecsImages
                {
                    WheelStyleName = "style 145",
                    Image = "https://i.imgur.com/u9g3oMV.jpg"
                },
               //style 146
               new WheelSpecsImages
                {
                    WheelStyleName = "style 146",
                    Image = "https://i.imgur.com/0a1fyfL.jpg"
                },
               new WheelSpecsImages
                {
                    WheelStyleName = "style 146",
                    Image = "https://i.imgur.com/w3OyZFY.jpg"
                },
               new WheelSpecsImages
                {
                    WheelStyleName = "style 146",
                    Image = "https://i.imgur.com/G0B2EBU.jpg"
                },
               //style 147
               new WheelSpecsImages
                {
                    WheelStyleName = "style 147",
                    Image = "https://i.imgur.com/KKZb2k2.jpg"
                },
               new WheelSpecsImages
                {
                    WheelStyleName = "style 147",
                    Image = "https://i.imgur.com/rhimPr0.jpg"
                },
               new WheelSpecsImages
                {
                    WheelStyleName = "style 147",
                    Image = "https://i.imgur.com/7KewkCV.jpg"
                },
               new WheelSpecsImages
                {
                    WheelStyleName = "style 147",
                    Image = "https://i.imgur.com/GsDfa3P.jpg"
                },
               new WheelSpecsImages
                {
                    WheelStyleName = "style 147",
                    Image = "https://i.imgur.com/rSEEp8p.jpg"
                },
               //style 148
               new WheelSpecsImages
                {
                    WheelStyleName = "style 148",
                    Image = "https://i.imgur.com/4j9r2OT.jpg"
                },
               new WheelSpecsImages
                {
                    WheelStyleName = "style 148",
                    Image = "https://i.imgur.com/UJDBgwf.jpg"
                },
               new WheelSpecsImages
                {
                    WheelStyleName = "style 148",
                    Image = "https://i.imgur.com/nRXST9i.jpg"
                },
               new WheelSpecsImages
                {
                    WheelStyleName = "style 148",
                    Image = "https://i.imgur.com/Q9ijRUc.jpg"
                },
               new WheelSpecsImages
                {
                    WheelStyleName = "style 148",
                    Image = "https://i.imgur.com/xNfB0G3.jpg"
                },
               //style 149
               new WheelSpecsImages
                {
                    WheelStyleName = "style 149",
                    Image = "https://i.imgur.com/fQkoMs5.jpg"
                },
               new WheelSpecsImages
                {
                    WheelStyleName = "style 149",
                    Image = "https://i.imgur.com/ezoNYr6.jpg"
                },
               new WheelSpecsImages
                {
                    WheelStyleName = "style 149",
                    Image = "https://i.imgur.com/pJOpFiP.jpg"
                },
               new WheelSpecsImages
                {
                    WheelStyleName = "style 149",
                    Image = "https://i.imgur.com/3P7DOCH.jpg"
                },
               new WheelSpecsImages
                {
                    WheelStyleName = "style 149",
                    Image = "https://i.imgur.com/HRVJT99.jpg"
                },
               //style 150
               new WheelSpecsImages
                {
                    WheelStyleName = "style 150",
                    Image = "https://i.imgur.com/y942DC6.jpg"
                },
                //style 151
                new WheelSpecsImages
                {
                    WheelStyleName = "style 151",
                    Image = "https://i.imgur.com/1D72Nz2.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 151",
                    Image = "https://i.imgur.com/S0gc3L8.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 151",
                    Image = "https://i.imgur.com/uQAnfMC.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 151",
                    Image = "https://i.imgur.com/T4lxT4z.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 151",
                    Image = "https://i.imgur.com/zYZlb8U.jpg"
                },
                //style 152
                new WheelSpecsImages
                {
                    WheelStyleName = "style 152",
                    Image = "https://i.imgur.com/qFbsjfY.jpg"
                },
                 new WheelSpecsImages
                {
                    WheelStyleName = "style 152",
                    Image = "https://i.imgur.com/yKoKxgR.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 152",
                    Image = "https://i.imgur.com/UiWsaIa.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 152",
                    Image = "https://i.imgur.com/Xv20LfO.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 152",
                    Image = "https://i.imgur.com/ZHAqSjI.jpg"
                },
                //style 153
                new WheelSpecsImages
                {
                    WheelStyleName = "style 153",
                    Image = "https://i.imgur.com/jdhrPm2.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 153",
                    Image = "https://i.imgur.com/0zPsrmM.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 153",
                    Image = "https://i.imgur.com/Ll8kiWz.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 153",
                    Image = "https://i.imgur.com/jmdMNai.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 153",
                    Image = "https://i.imgur.com/L61bWD3.jpg"
                },
                //style 154
                new WheelSpecsImages
                {
                    WheelStyleName = "style 154",
                    Image = "https://i.imgur.com/9EDLHdi.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 154",
                    Image = "https://i.imgur.com/AwHzuX6.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 154",
                    Image = "https://i.imgur.com/5bDiJpJ.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 154",
                    Image = "https://i.imgur.com/6zSEbNT.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 154",
                    Image = "https://i.imgur.com/7xvGP2T.jpg"
                },
                //style 155
                new WheelSpecsImages
                {
                    WheelStyleName = "style 155",
                    Image = "https://i.imgur.com/QFLDTjk.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 155",
                    Image = "https://i.imgur.com/PMvR2sI.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 155",
                    Image = "https://i.imgur.com/3nbTULo.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 155",
                    Image = "https://i.imgur.com/7Iz2ryW.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 155",
                    Image = "https://i.imgur.com/gRXEzM6.jpg"
                },
                //style 156
                new WheelSpecsImages
                {
                    WheelStyleName = "style 156",
                    Image = "https://i.imgur.com/g2I2sSf.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 156",
                    Image = "https://i.imgur.com/6fSLiMI.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 156",
                    Image = "https://i.imgur.com/tXFZH0X.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 156",
                    Image = "https://i.imgur.com/EqLUhG2.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 156",
                    Image = "https://i.imgur.com/zMiDA7F.jpg"
                },
                //style 157
                new WheelSpecsImages
                {
                    WheelStyleName = "style 157",
                    Image = "https://i.imgur.com/TO9tWlu.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 157",
                    Image = "https://i.imgur.com/g3authn.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 157",
                    Image = "https://i.imgur.com/0gaRn8y.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 157",
                    Image = "https://i.imgur.com/1OKG9GV.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 157",
                    Image = "https://i.imgur.com/qotQAVv.jpg"
                },
                //style 158
                new WheelSpecsImages
                {
                    WheelStyleName = "style 158",
                    Image = "https://i.imgur.com/dzmzXW2.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 158",
                    Image = "https://i.imgur.com/EbuLsxl.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 158",
                    Image = "https://i.imgur.com/FmLdQQ6.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 158",
                    Image = "https://i.imgur.com/brwjxgt.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 158",
                    Image = "https://i.imgur.com/dckkdSh.jpg"
                },
                //style 159
                new WheelSpecsImages
                {
                    WheelStyleName = "style 159",
                    Image = "https://i.imgur.com/ztpdRhm.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 159",
                    Image = "https://i.imgur.com/fenp2IF.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 159",
                    Image = "https://i.imgur.com/VXugKju.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 159",
                    Image = "https://i.imgur.com/JsZAOY7.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 159",
                    Image = "https://i.imgur.com/39UAxgs.jpg"
                },
                //style 160
                new WheelSpecsImages
                {
                    WheelStyleName = "style 160",
                    Image = "https://i.imgur.com/niT30TV.jpg"
                },
                 new WheelSpecsImages
                {
                    WheelStyleName = "style 160",
                    Image = "https://i.imgur.com/MSjlHUT.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 160",
                    Image = "https://i.imgur.com/1QPqa60.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 160",
                    Image = "https://i.imgur.com/heAoiyK.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 160",
                    Image = "https://i.imgur.com/olLjoaK.jpgg"
                },
                //style 161
                new WheelSpecsImages
                {
                    WheelStyleName = "style 161",
                    Image = "https://i.imgur.com/ZiTmUAL.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 161",
                    Image = "https://i.imgur.com/GhS4in6.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 161",
                    Image = "https://i.imgur.com/0xDNIJm.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 161",
                    Image = "https://i.imgur.com/xlM3OIC.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 161",
                    Image = "https://i.imgur.com/gf5Jhnw.jpg"
                },
                //style 162
                new WheelSpecsImages
                {
                    WheelStyleName = "style 162",
                    Image = "https://i.imgur.com/r60TqQC.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 162",
                    Image = "https://i.imgur.com/nzcGl52.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 162",
                    Image = "https://i.imgur.com/hqAyuJK.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 162",
                    Image = "https://i.imgur.com/yoidvSB.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 162",
                    Image = "https://i.imgur.com/GVH78h8.jpg"
                },
                //style 163
                new WheelSpecsImages
                {
                    WheelStyleName = "style 163",
                    Image = "https://i.imgur.com/wpsS87p.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 163",
                    Image = "https://i.imgur.com/ok9vBgg.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 163",
                    Image = "https://i.imgur.com/SFUYr2v.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 163",
                    Image = "https://i.imgur.com/wDjXECf.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 163",
                    Image = "https://i.imgur.com/UxrjPYR.jpg"
                },
                //style 164
                new WheelSpecsImages
                {
                    WheelStyleName = "style 164",
                    Image = "https://i.imgur.com/KoDAcqH.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 164",
                    Image = "https://i.imgur.com/YeaNqi3.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 164",
                    Image = "https://i.imgur.com/79yP4ML.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 164",
                    Image = "https://i.imgur.com/wanS4fN.jpg"
                },
                //style 165
                new WheelSpecsImages
                {
                    WheelStyleName = "style 165",
                    Image = "https://i.imgur.com/iDTPtyo.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 165",
                    Image = "https://i.imgur.com/BuVySHu.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 165",
                    Image = "https://i.imgur.com/8vNa6UU.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 165",
                    Image = "https://i.imgur.com/ATQDbuY.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 165",
                    Image = "https://i.imgur.com/oml2VuN.jpg"
                },
                //style 166
                new WheelSpecsImages
                {
                    WheelStyleName = "style 166",
                    Image = "https://i.imgur.com/unGbXiv.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 166",
                    Image = "https://i.imgur.com/2ojLZIj.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 166",
                    Image = "https://i.imgur.com/gaBaz5X.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 166",
                    Image = "https://i.imgur.com/m59ZW9I.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 166",
                    Image = "https://i.imgur.com/m59ZW9I.jpg"
                },
                //style 167
                new WheelSpecsImages
                {
                    WheelStyleName = "style 167",
                    Image = "https://i.imgur.com/16BctPw.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 167",
                    Image = "https://i.imgur.com/aYigNYn.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 167",
                    Image = "https://i.imgur.com/o6hCcTc.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 167",
                    Image = "https://i.imgur.com/ERUWYPj.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 167",
                    Image = "https://i.imgur.com/6fT4Txy.jpg"
                },
                //style 168
                new WheelSpecsImages
                {
                    WheelStyleName = "style 168",
                    Image = "https://i.imgur.com/jEmFe9X.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 168",
                    Image = "https://i.imgur.com/uqMHVH9.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 168",
                    Image = "https://i.imgur.com/qeqphYb.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 168",
                    Image = "https://i.imgur.com/qgQzHNP.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 168",
                    Image = "https://i.imgur.com/KCr5loG.jpg"
                },
                //style 169
                new WheelSpecsImages
                {
                    WheelStyleName = "style 169",
                    Image = "https://i.imgur.com/YGNod5T.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 169",
                    Image = "https://i.imgur.com/1BTFN6X.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 169",
                    Image = "https://i.imgur.com/mJO6cOa.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 169",
                    Image = "https://i.imgur.com/Hgaptjh.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 169",
                    Image = "https://i.imgur.com/4jCPI1U.jpg"
                },
                //style 170
                new WheelSpecsImages
                {
                    WheelStyleName = "style 170",
                    Image = "https://i.imgur.com/i3seE9E.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 170",
                    Image = "https://i.imgur.com/zVwQcTC.jpg"
                },
               //style 171
               new WheelSpecsImages
                {
                    WheelStyleName = "style 171",
                    Image = "https://i.imgur.com/XWbkNO9.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 171",
                    Image = "https://i.imgur.com/BMKf92P.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 171",
                    Image = "https://i.imgur.com/seUI6H4.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 171",
                    Image = "https://i.imgur.com/x2YoS9u.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 171",
                    Image = "https://i.imgur.com/sJ17EBb.jpg"
                },
                //style 172
                new WheelSpecsImages
                {
                    WheelStyleName = "style 172",
                    Image = "https://i.imgur.com/OXkaoxG.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 172",
                    Image = "https://i.imgur.com/5OwKXSP.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 172",
                    Image = "https://i.imgur.com/VyRjbZI.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 172",
                    Image = "https://i.imgur.com/49sKhaR.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 172",
                    Image = "https://i.imgur.com/aeczVJi.jpg"
                },
                //style 174
                new WheelSpecsImages
                {
                    WheelStyleName = "style 174",
                    Image = "https://i.imgur.com/SnufAxu.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 174",
                    Image = "https://i.imgur.com/4LfNZRg.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 174",
                    Image = "https://i.imgur.com/Q8Fl0Br.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 174",
                    Image = "https://i.imgur.com/ZkaBfGS.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 174",
                    Image = "https://i.imgur.com/B1XVS4A.jpg"
                },
                //style 175
                new WheelSpecsImages
                {
                    WheelStyleName = "style 175",
                    Image = "https://i.imgur.com/nFLxvqZ.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 175",
                    Image = "https://i.imgur.com/8VYXxOj.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 175",
                    Image = "https://i.imgur.com/UgSAhoq.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 175",
                    Image = "https://i.imgur.com/dePQv1m.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 175",
                    Image = "https://i.imgur.com/c1xhNdi.jpg"
                },
                //style 176
                new WheelSpecsImages
                {
                    WheelStyleName = "style 176",
                    Image = "https://i.imgur.com/Ju3UKhX.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 176",
                    Image = "https://i.imgur.com/sAZ5DPK.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 176",
                    Image = "https://i.imgur.com/ZOiFsjf.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 176",
                    Image = "https://i.imgur.com/OsAMj18.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 176",
                    Image = "https://i.imgur.com/9Kig9Hd.jpg"
                },
                //style 177
                new WheelSpecsImages
                {
                    WheelStyleName = "style 177",
                    Image = "https://i.imgur.com/jwQWOMl.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 177",
                    Image = "https://i.imgur.com/gU3yJQo.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 177",
                    Image = "https://i.imgur.com/qbnKwYW.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 177",
                    Image = "https://i.imgur.com/WcGgR2Q.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 177",
                    Image = "https://i.imgur.com/yuAgseX.jpg"
                },
                //style 178
                new WheelSpecsImages
                {
                    WheelStyleName = "style 178",
                    Image = "https://i.imgur.com/Y9ACCBo.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 178",
                    Image = "https://i.imgur.com/m6mnjmG.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 178",
                    Image = "https://i.imgur.com/fUq4WqC.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 178",
                    Image = "https://i.imgur.com/IIItqwK.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 178",
                    Image = "https://i.imgur.com/m6mnjmG.jpg"
                },

                //style 179
                new WheelSpecsImages
                {
                    WheelStyleName = "style 179",
                    Image = "https://i.imgur.com/gpZG1ZI.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 179",
                    Image = "https://i.imgur.com/KdR4zUj.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 179",
                    Image = "https://i.imgur.com/qzjM2TU.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 179",
                    Image = "https://i.imgur.com/pN7hvBN.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 179",
                    Image = "https://i.imgur.com/AW1feW3.jpg"
                },

                // style 180
                new WheelSpecsImages
                {
                    WheelStyleName = "style 180",
                    Image = "https://i.imgur.com/jWsoi85.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 180",
                    Image = "https://i.imgur.com/Enpttjp.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 180",
                    Image = "https://i.imgur.com/Tb6BF1D.jpg"
                },
                //style 181
                new WheelSpecsImages
                {
                    WheelStyleName = "style 181",
                    Image = "https://i.imgur.com/WC58JRU.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 181",
                    Image = "https://i.imgur.com/JlyxeaI.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 181",
                    Image = "https://i.imgur.com/DG00Xhz.jpg"
                },
                //style 182
                new WheelSpecsImages
                {
                    WheelStyleName = "style 181",
                    Image = "https://i.imgur.com/mqEtK75.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 181",
                    Image = "https://i.imgur.com/dwVRmhD.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 181",
                    Image = "https://i.imgur.com/SB1X9UR.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 181",
                    Image = "https://i.imgur.com/ujhSso8.jpg"
                },
                //style 182
                new WheelSpecsImages
                {
                    WheelStyleName = "style 182",
                    Image = "https://i.imgur.com/mqEtK75.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 182",
                    Image = "https://i.imgur.com/dwVRmhD.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 182",
                    Image = "https://i.imgur.com/SB1X9UR.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 182",
                    Image = "https://i.imgur.com/cODIZSr.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 182",
                    Image = "https://i.imgur.com/GWMhSDd.jpg"
                },
                //style 183
                new WheelSpecsImages
                {
                    WheelStyleName = "style 183",
                    Image = "https://i.imgur.com/12zvjqk.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 183",
                    Image = "https://i.imgur.com/415SITQ.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 183",
                    Image = "https://i.imgur.com/DW05GXm.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 183",
                    Image = "https://i.imgur.com/V7CnbF5.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 183",
                    Image = "https://i.imgur.com/BT5sFBF.jpg"
                },
                //style 184
                new WheelSpecsImages
                {
                    WheelStyleName = "style 184",
                    Image = "https://i.imgur.com/CpG571f.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 184",
                    Image = "https://i.imgur.com/Ya6jm4m.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 184",
                    Image = "https://i.imgur.com/gmJPVsV.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 184",
                    Image = "https://i.imgur.com/rtgbDRg.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 184",
                    Image = "https://i.imgur.com/WMaMjYu.jpg"
                },
                //style 185
                new WheelSpecsImages
                {
                    WheelStyleName = "style 185",
                    Image = "https://i.imgur.com/1MP1IFh.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 185",
                    Image = "https://i.imgur.com/EZYfahz.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 185",
                    Image = "https://i.imgur.com/2qYyXdJ.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 185",
                    Image = "https://i.imgur.com/i4ns3u6.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 185",
                    Image = "https://i.imgur.com/vy84WHr.jpg"
                },
                //style 187
                new WheelSpecsImages
                {
                    WheelStyleName = "style 187",
                    Image = "https://i.imgur.com/EJ1XlHM.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 187",
                    Image = "https://i.imgur.com/OMgJwLN.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 187",
                    Image = "https://i.imgur.com/WNE0YPU.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 187",
                    Image = "https://i.imgur.com/OkOfR2m.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 187",
                    Image = "https://i.imgur.com/zxNRM4U.jpg"
                },
                //style 188
                new WheelSpecsImages
                {
                    WheelStyleName = "style 188",
                    Image = "https://i.imgur.com/2wbQrdf.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 188",
                    Image = "https://i.imgur.com/IuM7n02.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 188",
                    Image = "https://i.imgur.com/GbeZglX.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 188",
                    Image = "https://i.imgur.com/wYTvdkU.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 188",
                    Image = "https://i.imgur.com/IC8NTi1.jpg"
                },
                //style 189
                new WheelSpecsImages
                {
                    WheelStyleName = "style 189",
                    Image = "https://i.imgur.com/Kh4mmi8.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 189",
                    Image = "https://i.imgur.com/vThPf5F.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 189",
                    Image = "https://i.imgur.com/y22e1lH.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 189",
                    Image = "https://i.imgur.com/WFYWZyW.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 189",
                    Image = "https://i.imgur.com/PRnTpt6.jpg"
                },
                //style 190
                new WheelSpecsImages
                {
                    WheelStyleName = "style 190",
                    Image = "https://i.imgur.com/tGL977E.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 190",
                    Image = "https://i.imgur.com/Xdk5Ef6.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 190",
                    Image = "https://i.imgur.com/cSH6HmQ.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 190",
                    Image = "https://i.imgur.com/nePYYLj.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 190",
                    Image = "https://i.imgur.com/Cr3Lues.jpg"
                },
                //style 191
                new WheelSpecsImages
                {
                    WheelStyleName = "style 191",
                    Image = "https://i.imgur.com/nkDfhPr.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 191",
                    Image = "https://i.imgur.com/HSR2Mjf.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 191",
                    Image = "https://i.imgur.com/c7EcPyt.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 191",
                    Image = "https://i.imgur.com/c2MdM3R.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 191",
                    Image = "https://i.imgur.com/GWIwE1w.jpg"
                },
                //style 192
                new WheelSpecsImages
                {
                    WheelStyleName = "style 192",
                    Image = "https://i.imgur.com/GlBEtbU.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 192",
                    Image = "https://i.imgur.com/QhQzIBh.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 192",
                    Image = "https://i.imgur.com/WEJ0YQs.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 192",
                    Image = "https://i.imgur.com/Bv6kFma.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 192",
                    Image = "https://i.imgur.com/a2dWtYW.jpg"
                },
                //style 193
                new WheelSpecsImages
                {
                    WheelStyleName = "style 193",
                    Image = "https://i.imgur.com/bZ4a6WW.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 193",
                    Image = "https://i.imgur.com/nYWVhnY.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 193",
                    Image = "https://i.imgur.com/17TRc0h.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 193",
                    Image = "https://i.imgur.com/ywB0xY9.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 193",
                    Image = "https://i.imgur.com/qi8Ax4u.jpg"
                },
                //style 194
                new WheelSpecsImages
                {
                    WheelStyleName = "style 194",
                    Image = "https://i.imgur.com/99LuExs.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 194",
                    Image = "https://i.imgur.com/D7sZqGJ.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 194",
                    Image = "https://i.imgur.com/GGDTY43.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 194",
                    Image = "https://i.imgur.com/0sD7d8a.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 194",
                    Image = "https://i.imgur.com/H1HoYod.jpg"
                },
                //style 195
                new WheelSpecsImages
                {
                    WheelStyleName = "style 195",
                    Image = "https://i.imgur.com/KJg60uQ.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 195",
                    Image = "https://i.imgur.com/v6GTToi.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 195",
                    Image = "https://i.imgur.com/o3h0jkW.jpgg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 195",
                    Image = "https://i.imgur.com/zfW9FzH.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 195",
                    Image = "https://i.imgur.com/0Ahk6jA.jpg"
                },
                //style 196
                new WheelSpecsImages
                {
                    WheelStyleName = "style 196",
                    Image = "https://i.imgur.com/p9lCN5b.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 196",
                    Image = "https://i.imgur.com/Hc0qb5D.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 196",
                    Image = "https://i.imgur.com/j1xI5RO.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 196",
                    Image = "https://i.imgur.com/72dxrKU.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 196",
                    Image = "https://i.imgur.com/CtC5L1P.jpg"
                },
                //style 197
                new WheelSpecsImages
                {
                    WheelStyleName = "style 197",
                    Image = "https://i.imgur.com/YKjG2tQ.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 197",
                    Image = "https://i.imgur.com/6UmKbGx.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 197",
                    Image = "https://i.imgur.com/KB0QWet.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 197",
                    Image = "https://i.imgur.com/Vy6hZXl.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 197",
                    Image = "https://i.imgur.com/RUMnf2m.jpg"
                },
                //style 198
                new WheelSpecsImages
                {
                    WheelStyleName = "style 198",
                    Image = "https://i.imgur.com/Ue8NGXQ.jpgg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 198",
                    Image = "https://i.imgur.com/pdw2QaO.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 198",
                    Image = "https://i.imgur.com/yIVuTah.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 198",
                    Image = "https://i.imgur.com/2Gs2Vov.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 198",
                    Image = "https://i.imgur.com/70gyzqj.jpg"
                },
                //style 199
                new WheelSpecsImages
                {
                    WheelStyleName = "style 199",
                    Image = "https://i.imgur.com/B227t2z.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 199",
                    Image = "https://i.imgur.com/hlaTQuq.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 199",
                    Image = "https://i.imgur.com/OOkID6M.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 199",
                    Image = "https://i.imgur.com/K13kqtF.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 199",
                    Image = "https://i.imgur.com/40tIqX9.jpg"
                },
                //style 200
                new WheelSpecsImages
                {
                    WheelStyleName = "style 200",
                    Image = "https://i.imgur.com/x2bED1P.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 200",
                    Image = "https://i.imgur.com/Bfbqcye.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 200",
                    Image = "https://i.imgur.com/OEF03Rz.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 200",
                    Image = "https://i.imgur.com/plzuNqP.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 200",
                    Image = "https://i.imgur.com/j5Igv9i.jpg"
                },
                //style 201
                new WheelSpecsImages
                {
                    WheelStyleName = "style 201",
                    Image = "https://i.imgur.com/a0uiZg7.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 201",
                    Image = "https://i.imgur.com/6pgkqmI.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 201",
                    Image = "https://i.imgur.com/wAabjw4.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 201",
                    Image = "https://i.imgur.com/rjJ8TL9.jpg"
                },
                //style 202
                new WheelSpecsImages
                {
                    WheelStyleName = "style 202",
                    Image = "https://i.imgur.com/kk3CZa2.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 202",
                    Image = "https://i.imgur.com/K21el6q.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 202",
                    Image = "https://i.imgur.com/4KHrfTK.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 202",
                    Image = "https://i.imgur.com/YJG59jk.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 202",
                    Image = "https://i.imgur.com/LgKf7oy.jpg"
                },
                //style 203
                new WheelSpecsImages
                {
                    WheelStyleName = "style 203",
                    Image = "https://i.imgur.com/E3hVM8A.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 203",
                    Image = "https://i.imgur.com/J3hu7et.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 203",
                    Image = "https://i.imgur.com/Z5CaWnM.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 203",
                    Image = "https://i.imgur.com/6RBoZiM.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 203",
                    Image = "https://i.imgur.com/1YEUSMU.jpg"
                },
                //style 204
                new WheelSpecsImages
                {
                    WheelStyleName = "style 204",
                    Image = "https://i.imgur.com/37lE3qt.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 204",
                    Image = "https://i.imgur.com/stRYCOM.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 204",
                    Image = "https://i.imgur.com/fhs9KZF.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 204",
                    Image = "https://i.imgur.com/0fQNT2s.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 204",
                    Image = "https://i.imgur.com/NiGQG8J.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 204",
                    Image = "https://i.imgur.com/wLDNTiG.jpg"
                },
                //style 205
                new WheelSpecsImages
                {
                    WheelStyleName = "style 205",
                    Image = "https://i.imgur.com/tAAszwZ.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 205",
                    Image = "https://i.imgur.com/XIesrvz.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 205",
                    Image = "https://i.imgur.com/c8ZuI6R.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 205",
                    Image = "https://i.imgur.com/qxFvFQY.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 205",
                    Image = "https://i.imgur.com/96CzzYi.jpg"
                },
                //style 206
                new WheelSpecsImages
                {
                    WheelStyleName = "style 206",
                    Image = "https://i.imgur.com/2hWg2of.jpg"
                },
                //style 207
                new WheelSpecsImages
                {
                    WheelStyleName = "style 207",
                    Image = "https://i.imgur.com/XVCWyOZ.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 207",
                    Image = "https://i.imgur.com/Hg2fOP8.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 207",
                    Image = "https://i.imgur.com/5khsqeJ.jpg"
                },
                 new WheelSpecsImages
                {
                    WheelStyleName = "style 207",
                    Image = "https://i.imgur.com/ooeawVf.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 207",
                    Image = "https://i.imgur.com/wE8RsHW.jpg"
                },
                  //style 208
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 208",
                    Image = "https://i.imgur.com/AZIQLzP.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 208",
                    Image = "https://i.imgur.com/jou1gYK.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 208",
                    Image = "https://i.imgur.com/oAzx1bS.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 208",
                    Image = "https://i.imgur.com/oxp5xWE.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 208",
                    Image = "https://i.imgur.com/USCYI8v.jpg"
                },
                  //style 209
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 209",
                    Image = "https://i.imgur.com/fLsKF6I.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 209",
                    Image = "https://i.imgur.com/43lhMdn.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 209",
                    Image = "https://i.imgur.com/fjZG36o.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 209",
                    Image = "https://i.imgur.com/nE1bWGf.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 209",
                    Image = "https://i.imgur.com/fr7swpi.jpg"
                },
                  //style 210
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 210",
                    Image = "https://i.imgur.com/c1Pw5Wb.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 210",
                    Image = "https://i.imgur.com/R0ZBqz7.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 210",
                    Image = "https://i.imgur.com/AAHfznH.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 210",
                    Image = "https://i.imgur.com/glQDu4r.jpg"
                },
                  //style 211
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 211",
                    Image = "https://i.imgur.com/R0ryUdb.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 211",
                    Image = "https://i.imgur.com/WUL67Bz.jpgg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 211",
                    Image = "https://i.imgur.com/P0Uz7MX.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 211",
                    Image = "https://i.imgur.com/NuTXLkN.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 211",
                    Image = "https://i.imgur.com/qcC0wFP.jpg"
                },
                  //style 212
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 212",
                    Image = "https://i.imgur.com/Jv3VnQk.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 212",
                    Image = "https://i.imgur.com/X7WMXFK.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 212",
                    Image = "https://i.imgur.com/1vBHnHc.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 212",
                    Image = "https://i.imgur.com/ENffvn9.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 212",
                    Image = "https://i.imgur.com/OWJvBAh.jpg"
                },
                  //style 213
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 213",
                    Image = "https://i.imgur.com/DWH6Hjt.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 213",
                    Image = "https://i.imgur.com/5BFMenQ.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 213",
                    Image = "https://i.imgur.com/ggrCjUh.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 213",
                    Image = "https://i.imgur.com/ppG3Y5k.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 213",
                    Image = "https://i.imgur.com/v7BVcMO.jpg"
                },
                  //style 214
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 214",
                    Image = "https://i.imgur.com/3MHK5bU.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 214",
                    Image = "https://i.imgur.com/Noa7XCl.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 214",
                    Image = "https://i.imgur.com/Vmm67DA.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 214",
                    Image = "https://i.imgur.com/lmdiKjf.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 214",
                    Image = "https://i.imgur.com/JRzrp8w.jpg"
                },
                  //style 215
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 215",
                    Image = "https://i.imgur.com/pzQkFrN.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 215",
                    Image = "https://i.imgur.com/LKHZaz2.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 215",
                    Image = "https://i.imgur.com/ImyIgr7.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 215",
                    Image = "https://i.imgur.com/aaPdN3M.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 215",
                    Image = "https://i.imgur.com/KiVJ1m5.jpg"
                },
                  //Style 216
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 216",
                    Image = "https://i.imgur.com/DsBM1kC.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 216",
                    Image = "https://i.imgur.com/mKhiLaA.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 216",
                    Image = "https://i.imgur.com/Mi3IVLh.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 216",
                    Image = "https://i.imgur.com/u9cwcbh.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 216",
                    Image = "https://i.imgur.com/E4US1G9.jpg"
                },

                  //style 217
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 217",
                    Image = "https://i.imgur.com/7etL4Ph.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 217",
                    Image = "https://i.imgur.com/302GLfG.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 217",
                    Image = "https://i.imgur.com/BqRi21S.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 217",
                    Image = "https://i.imgur.com/HYlBAun.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 217",
                    Image = "https://i.imgur.com/o8I2f5M.jpg"
                },
                  //style 218
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 218",
                    Image = "https://i.imgur.com/cgsheAy.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 218",
                    Image = "https://i.imgur.com/MIJnrwi.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 218",
                    Image = "https://i.imgur.com/Vq5yikK.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 218",
                    Image = "https://i.imgur.com/MOMDrpJ.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 218",
                    Image = "https://i.imgur.com/lal7BUB.jpg"
                },
                  //style 219\
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 219",
                    Image = "https://i.imgur.com/lbxNztU.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 219",
                    Image = "https://i.imgur.com/j8ANSln.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 219",
                    Image = "https://i.imgur.com/pp4pLiF.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 219",
                    Image = "https://i.imgur.com/YD442L7.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 219",
                    Image = "https://i.imgur.com/r8SCPVn.jpg"
                },
                  //style 220
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 220",
                    Image = "https://i.imgur.com/F9qlnjT.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 220",
                    Image = "https://i.imgur.com/L4bFKQr.jpgg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 220",
                    Image = "https://i.imgur.com/b7ZC3wJ.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 220",
                    Image = "https://i.imgur.com/Hmoxs8Z.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 220",
                    Image = "https://i.imgur.com/LCGTmHm.jpg"
                },
                  //Style 222
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 222",
                    Image = "https://i.imgur.com/KrBJ59S.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 222",
                    Image = "https://i.imgur.com/Tunkujl.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 222",
                    Image = "https://i.imgur.com/CON77k0.jpg"
                },
                  //style 223
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 223",
                    Image = "https://i.imgur.com/cvQwHJd.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 223",
                    Image = "https://i.imgur.com/FT22VT0.jpgg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 223",
                    Image = "https://i.imgur.com/tWSiLQs.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 223",
                    Image = "https://i.imgur.com/NgOYpmM.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 223",
                    Image = "https://i.imgur.com/uPIdBwH.jpg"
                },
                  //style 224
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 224",
                    Image = "https://i.imgur.com/gPn8L79.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 224",
                    Image = "https://i.imgur.com/IjojSbn.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 224",
                    Image = "https://i.imgur.com/SnUSjDq.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 224",
                    Image = "https://i.imgur.com/3DFyPbS.jpg"
                },
                  //style 225
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 225",
                    Image = "https://i.imgur.com/eVejzbA.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 225",
                    Image = "https://i.imgur.com/KdyrDOH.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 225",
                    Image = "https://i.imgur.com/J8Dhy9L.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 225",
                    Image = "https://i.imgur.com/ZFXU7ku.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 225",
                    Image = "https://i.imgur.com/J2IJrxo.jpg"
                },
                  //style 227
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 227",
                    Image = "https://i.imgur.com/EuX3DHD.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 227",
                    Image = "https://i.imgur.com/FhX6I41.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 227",
                    Image = "https://i.imgur.com/EaQNeBe.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 227",
                    Image = "https://i.imgur.com/pkllu5U.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 227",
                    Image = "https://i.imgur.com/2vRaGb7.jpg"
                },
                  //style 228
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 228",
                    Image = "https://i.imgur.com/LQKvtBk.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 228",
                    Image = "https://i.imgur.com/0ytf748.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 228",
                    Image = "https://i.imgur.com/nVynjb7.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 228",
                    Image = "https://i.imgur.com/h41YGgX.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 228",
                    Image = "https://i.imgur.com/5dZ7usg.jpg"
                },
                  //Style 229
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 229",
                    Image = "https://i.imgur.com/wOZ03qh.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 229",
                    Image = "https://i.imgur.com/u0v27E1.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 229",
                    Image = "https://i.imgur.com/diBzzjc.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 229",
                    Image = "https://i.imgur.com/0HT0HET.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 229",
                    Image = "https://i.imgur.com/jWaY6QL.jpg"
                },
                  //style 230
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 230",
                    Image = "https://i.imgur.com/Fm7nBeP.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 230",
                    Image = "https://i.imgur.com/WIpGxDm.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 230",
                    Image = "https://i.imgur.com/IBUeGpl.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 230",
                    Image = "https://i.imgur.com/BJu8Ibg.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 230",
                    Image = "https://i.imgur.com/rKajmXI.jpg"
                },
                  //style 231
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 231",
                    Image = "https://i.imgur.com/2BYyoj0.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 231",
                    Image = "https://i.imgur.com/l4hJagn.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 231",
                    Image = "https://i.imgur.com/fdAp5Ch.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 231",
                    Image = "https://i.imgur.com/EkMC1KY.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 231",
                    Image = "https://i.imgur.com/1wbOyO8.jpg"
                },
                  //style 232
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 232",
                    Image = "https://i.imgur.com/zen1ZW3.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 232",
                    Image = "https://i.imgur.com/K0Q5nEC.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 232",
                    Image = "https://i.imgur.com/ofkf7Ei.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 232",
                    Image = "https://i.imgur.com/lBNo5bo.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 232",
                    Image = "https://i.imgur.com/QbXIYo4.jpg"
                },
                  //style 233
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 233",
                    Image = "https://i.imgur.com/l7kS4Ay.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 233",
                    Image = "https://i.imgur.com/Q2LCuWD.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 233",
                    Image = "https://i.imgur.com/pm5xsOF.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 233",
                    Image = "https://i.imgur.com/F2sP1R7.jpg"
                },
                  //style 234
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 234",
                    Image = "https://i.imgur.com/Cibdo7W.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 234",
                    Image = "https://i.imgur.com/WrXM64U.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 234",
                    Image = "https://i.imgur.com/M27AVci.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 234",
                    Image = "https://i.imgur.com/PPriggj.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 234",
                    Image = "https://i.imgur.com/I8viYsv.jpg"
                },
                  //style 236
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 236",
                    Image = "https://i.imgur.com/RdQY3iF.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 236",
                    Image = "https://i.imgur.com/BFMQTcy.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 236",
                    Image = "https://i.imgur.com/SeLhnTL.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 236",
                    Image = "https://i.imgur.com/P2FGual.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 236",
                    Image = "https://i.imgur.com/f1sAdBH.jpg"
                },
                  //style 237
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 237",
                    Image = "https://i.imgur.com/qyBunrc.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 237",
                    Image = "https://i.imgur.com/4BAAIGN.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 237",
                    Image = "https://i.imgur.com/EY8ehDR.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 237",
                    Image = "https://i.imgur.com/UBkRse9.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 237",
                    Image = "https://i.imgur.com/Ypcp3da.jpg"
                },
                  //style 238
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 238",
                    Image = "https://i.imgur.com/Hi8YZXx.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 238",
                    Image = "https://i.imgur.com/vM14Ir4.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 238",
                    Image = "https://i.imgur.com/q0Cnu7h.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 238",
                    Image = "https://i.imgur.com/6A1kkng.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 238",
                    Image = "https://i.imgur.com/taMbIm2.jpg"
                },
                  //style 239
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 239",
                    Image = "https://i.imgur.com/fLg1DDq.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 239",
                    Image = "https://i.imgur.com/ucuYXYE.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 239",
                    Image = "https://i.imgur.com/PbgwWw0.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 239",
                    Image = "https://i.imgur.com/DloNzJa.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 239",
                    Image = "https://i.imgur.com/7DJXoZk.jpg"
                },
                  //style 241
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 241",
                    Image = "https://i.imgur.com/G7oohwQ.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 241",
                    Image = "https://i.imgur.com/yO4vRlm.jpgg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 241",
                    Image = "https://i.imgur.com/nRDGrup.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 241",
                    Image = "https://i.imgur.com/oum3E1v.jpg"
                },
                  //style 242
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 242",
                    Image = "https://i.imgur.com/PI6s2CS.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 242",
                    Image = "https://i.imgur.com/bz501I3.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 242",
                    Image = "https://i.imgur.com/xVy5IIE.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 242",
                    Image = "https://i.imgur.com/xTK9213.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 242",
                    Image = "https://i.imgur.com/OEn5xcU.jpg"
                },
                  //style 243
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 243",
                    Image = "https://i.imgur.com/xo7NQXX.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 243",
                    Image = "https://i.imgur.com/3NtKJjT.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 243",
                    Image = "https://i.imgur.com/IW2ykbk.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 243",
                    Image = "https://i.imgur.com/NqipxoC.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 243",
                    Image = "https://i.imgur.com/geFT0IN.jpg"
                },
                  //style 244
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 244",
                    Image = "https://i.imgur.com/FQl3QXB.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 244",
                    Image = "https://i.imgur.com/IPmuqRg.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 244",
                    Image = "https://i.imgur.com/oyZnUU1.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 244",
                    Image = "https://i.imgur.com/ImaeQk1.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 244",
                    Image = "https://i.imgur.com/6nxMHRf.jpg"
                },
                  //style 245
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 245",
                    Image = "https://i.imgur.com/Q7xZcPb.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 245",
                    Image = "https://i.imgur.com/kgsh3Tf.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 245",
                    Image = "https://i.imgur.com/u7j0H2X.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 245",
                    Image = "https://i.imgur.com/E04A135.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 245",
                    Image = "https://i.imgur.com/gtCZ2nY.jpg"
                },
                  //style 246
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 246",
                    Image = "https://i.imgur.com/5ZrrbUR.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 246",
                    Image = "https://i.imgur.com/xCFBVuB.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 246",
                    Image = "https://i.imgur.com/tstLvL0.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 246",
                    Image = "https://i.imgur.com/rplIANz.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 246",
                    Image = "https://i.imgur.com/GEZ7RPo.jpg"
                },
                  //style 247
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 247",
                    Image = "https://i.imgur.com/ifrU1TR.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 247",
                    Image = "https://i.imgur.com/ScQeG9B.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 247",
                    Image = "https://i.imgur.com/kPwddK3.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 247",
                    Image = "https://i.imgur.com/oaoXLmk.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 247",
                    Image = "https://i.imgur.com/bROPnsD.jpg"
                },
                  //style 248
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 248",
                    Image = "https://i.imgur.com/Xu46kGy.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 248",
                    Image = "https://i.imgur.com/mkG2REJ.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 248",
                    Image = "https://i.imgur.com/BU5giL7.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 248",
                    Image = "https://i.imgur.com/tlxwBQu.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 248",
                    Image = "https://i.imgur.com/17aOgpb.jpg"
                },
                  //style 249
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 249",
                    Image = "https://i.imgur.com/5jw034i.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 249",
                    Image = "https://i.imgur.com/dUj42Bh.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 249",
                    Image = "https://i.imgur.com/QjtLEU0.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 249",
                    Image = "https://i.imgur.com/UrYo0cy.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 249",
                    Image = "https://i.imgur.com/i6EDFn1.jpg"
                },
                  //style 250
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 250",
                    Image = "https://i.imgur.com/b4QLrki.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 250",
                    Image = "https://i.imgur.com/bkLREOB.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 250",
                    Image = "https://i.imgur.com/uCppBw9.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 250",
                    Image = "https://i.imgur.com/Cx4aKAZ.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 250",
                    Image = "https://i.imgur.com/lxK4J8w.jpg"
                },
                  //style 251
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 251",
                    Image = "https://i.imgur.com/FIJaBSP.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 251",
                    Image = "https://i.imgur.com/shAfa03.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 251",
                    Image = "https://i.imgur.com/fJOL29H.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 251",
                    Image = "https://i.imgur.com/idVroym.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 251",
                    Image = "https://i.imgur.com/eaf0odx.jpg"
                },
                  //style 252
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 252",
                    Image = "https://i.imgur.com/szWKDqm.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 252",
                    Image = "https://i.imgur.com/Jhx2GgJ.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 252",
                    Image = "https://i.imgur.com/ciqh105.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 252",
                    Image = "https://i.imgur.com/dSP3W8s.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 252",
                    Image = "https://i.imgur.com/c3GoKeA.jpg"
                },
                  //style 253
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 253",
                    Image = "https://i.imgur.com/pVd7CJK.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 253",
                    Image = "https://i.imgur.com/f6Rgki9.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 253",
                    Image = "https://i.imgur.com/Q3KnUna.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 253",
                    Image = "https://i.imgur.com/Ymk1Yah.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 253",
                    Image = "https://i.imgur.com/Vmgn6kS.jpg"
                },
                  //style 254
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 254",
                    Image = "https://i.imgur.com/p3Uu8a7.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 254",
                    Image = "https://i.imgur.com/Fjmn068.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 254",
                    Image = "https://i.imgur.com/FvETSOD.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 254",
                    Image = "https://i.imgur.com/dJFYQPH.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 254",
                    Image = "https://i.imgur.com/xAmWeqD.jpg"
                },
                  //style 255
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 255",
                    Image = "https://i.imgur.com/n2sIOuw.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 255",
                    Image = "https://i.imgur.com/efJfzIU.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 255",
                    Image = "https://i.imgur.com/XUtqoQh.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 255",
                    Image = "https://i.imgur.com/qQ3Igrv.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 255",
                    Image = "https://i.imgur.com/nVgj6Lt.jpg"
                },

                  //style 256
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 256",
                    Image = "https://i.imgur.com/5RQt55W.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 256",
                    Image = "https://i.imgur.com/DUJdsbd.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 256",
                    Image = "https://i.imgur.com/N5BUEiT.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 256",
                    Image = "https://i.imgur.com/wDt9tez.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 256",
                    Image = "https://i.imgur.com/sYayz0n.jpg"
                },
                  //style 257
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 257",
                    Image = "https://i.imgur.com/iyuEGop.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 257",
                    Image = "https://i.imgur.com/IfAVLUm.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 257",
                    Image = "https://i.imgur.com/tS4NTei.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 257",
                    Image = "https://i.imgur.com/YIWGyQm.jpg"
                },
                  //style 258
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 258",
                    Image = "https://i.imgur.com/DiYD6ZF.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 258",
                    Image = "https://i.imgur.com/kUEppee.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 258",
                    Image = "https://i.imgur.com/dquJFuF.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 258",
                    Image = "https://i.imgur.com/hDKUtnT.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 258",
                    Image = "https://i.imgur.com/jz5ThVR.jpg"
                },
                  //style 259
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 259",
                    Image = "https://i.imgur.com/PKpFtGE.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 259",
                    Image = "https://i.imgur.com/f2dtxuH.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 259",
                    Image = "https://i.imgur.com/cecZREj.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 259",
                    Image = "https://i.imgur.com/vgok5iP.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 259",
                    Image = "https://i.imgur.com/9hAG3og.jpg"
                },
                  //style 260
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 260",
                    Image = "https://i.imgur.com/LDRo97M.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 260",
                    Image = "https://i.imgur.com/2nw4KLx.jpg"
                },
                     new WheelSpecsImages
                {
                    WheelStyleName = "style 260",
                    Image = "https://i.imgur.com/M6Fe3SE.jpg"
                },
                     new WheelSpecsImages
                {
                    WheelStyleName = "style 260",
                    Image = "https://i.imgur.com/BwvmX0I.jpg"
                },
                 new WheelSpecsImages
                {
                    WheelStyleName = "style 260",
                    Image = "https://i.imgur.com/W5QTZZv.jpg"
                },
                  //style 261
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 261",
                    Image = "https://i.imgur.com/IhQQDgJ.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 261",
                    Image = "https://i.imgur.com/9XP1iQS.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 261",
                    Image = "https://i.imgur.com/WeIQVe4.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 261",
                    Image = "https://i.imgur.com/Tbf9h5r.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 261",
                    Image = "https://i.imgur.com/XVCPuPM.jpg"
                },

                  //style 262
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 262",
                    Image = "https://i.imgur.com/K7ZZnhb.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 262",
                    Image = "https://i.imgur.com/PGxu60c.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 262",
                    Image = "https://i.imgur.com/auT2HWv.jpg"
                },

                  //style 263
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 263",
                    Image = "https://i.imgur.com/VmiqWCo.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 263",
                    Image = "https://i.imgur.com/9h8g5t3.jpgg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 263",
                    Image = "https://i.imgur.com/QR059HZ.jpg"
                },

                  //Style 264
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 264",
                    Image = "https://i.imgur.com/sNzE8rK.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 264",
                    Image = "https://i.imgur.com/ZnnYC3p.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 264",
                    Image = "https://i.imgur.com/7d2Osfh.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 264",
                    Image = "https://i.imgur.com/4ncmryR.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 264",
                    Image = "https://i.imgur.com/W6X3loR.jpg"
                },
                   //style 265
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 265",
                    Image = "https://i.imgur.com/BIHXcBh.jpg"
                },
                   //style 266
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 266",
                    Image = "https://i.imgur.com/4YzA2DP.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 266",
                    Image = "https://i.imgur.com/ZdaZClT.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 266",
                    Image = "https://i.imgur.com/EZ6ycIX.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 266",
                    Image = "https://i.imgur.com/Sfo0DCu.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 266",
                    Image = "https://i.imgur.com/Mrdvd7r.jpg"
                },
                   //style 268
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 268",
                    Image = "https://i.imgur.com/a2sETBF.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 268",
                    Image = "https://i.imgur.com/MAUTjts.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 268",
                    Image = "https://i.imgur.com/43n0FzI.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 268",
                    Image = "https://i.imgur.com/2aMMxOc.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 268",
                    Image = "https://i.imgur.com/GQSI7QV.jpg"
                },
                   //style 269

                   new WheelSpecsImages
                {
                    WheelStyleName = "style 269",
                    Image = "https://i.imgur.com/5Qf60id.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 269",
                    Image = "https://i.imgur.com/h1CMxv7.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 269",
                    Image = "https://i.imgur.com/AVYw3k4.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 269",
                    Image = "https://i.imgur.com/6F7ERL0.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 269",
                    Image = "https://i.imgur.com/ipDDgLl.jpg"
                },

                   //style 270

                   new WheelSpecsImages
                {
                    WheelStyleName = "style 270",
                    Image = "https://i.imgur.com/fwOxROa.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 270",
                    Image = "https://i.imgur.com/MEgW8Wc.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 270",
                    Image = "https://i.imgur.com/R9EEHMU.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 270",
                    Image = "https://i.imgur.com/zvglaHZ.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 270",
                    Image = "https://i.imgur.com/OsvWo0r.jpg"
                },
                   //style 271
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 271",
                    Image = "https://i.imgur.com/iP1thQC.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 271",
                    Image = "https://i.imgur.com/dOYkaYy.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 271",
                    Image = "https://i.imgur.com/n8c7wBu.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 271",
                    Image = "https://i.imgur.com/CfOVVfR.jpg"
                },
                   //style 272
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 272",
                    Image = "https://i.imgur.com/4AuMdkS.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 272",
                    Image = "https://i.imgur.com/YtkRl6R.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 272",
                    Image = "https://i.imgur.com/fs6vAYY.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 272",
                    Image = "https://i.imgur.com/wBj7zkj.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 272",
                    Image = "https://i.imgur.com/GvjfEPX.jpg"
                },
                   //style 275
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 275",
                    Image = "https://i.imgur.com/TuJE3E3.jpg"
                },
                   //style 276
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 276",
                    Image = "https://i.imgur.com/5L081tU.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 276",
                    Image = "https://i.imgur.com/OVRvHq4.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 276",
                    Image = "https://i.imgur.com/uyhy6N6.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 276",
                    Image = "https://i.imgur.com/ZqP36Ip.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 276",
                    Image = "https://i.imgur.com/M8AaBVn.jpg"
                },
                   //style 277
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 277",
                    Image = "https://i.imgur.com/mO8LtEz.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 277",
                    Image = "https://i.imgur.com/U1KjuTz.jpg"
                },
                     new WheelSpecsImages
                {
                    WheelStyleName = "style 277",
                    Image = "https://i.imgur.com/y8zIRCH.jpg"
                },
                      new WheelSpecsImages
                {
                    WheelStyleName = "style 277",
                    Image = "https://i.imgur.com/qOPTE8Y.jpg"
                },
                       new WheelSpecsImages
                {
                    WheelStyleName = "style 277",
                    Image = "https://i.imgur.com/jsgIvaX.jpg"
                },
                   //style 278
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 278",
                    Image = "https://i.imgur.com/GA7tPMY.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 278",
                    Image = "https://i.imgur.com/ZPE7Fy2.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 278",
                    Image = "https://i.imgur.com/wMHyjxs.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 278",
                    Image = "https://i.imgur.com/dfNZ6zR.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 278",
                    Image = "https://i.imgur.com/4wZ77n9.jpg"
                },
                   //style 279
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 279",
                    Image = "https://i.imgur.com/A1uoTpC.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 279",
                    Image = "https://i.imgur.com/TJf2Xsk.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 279",
                    Image = "https://i.imgur.com/QTLXT7C.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 279",
                    Image = "https://i.imgur.com/jSxHOW8.jpg"
                },
                   //style 280
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 280",
                    Image = "https://i.imgur.com/BzTIvh6.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 280",
                    Image = "https://i.imgur.com/37ynPt7.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 280",
                    Image = "https://i.imgur.com/WFymNnL.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 280",
                    Image = "https://i.imgur.com/8k8eoXT.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 280",
                    Image = "https://i.imgur.com/B0ZCYN5.jpg"
                },
                   //style 281
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 281",
                    Image = "https://i.imgur.com/ukiHxh5.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 281",
                    Image = "https://i.imgur.com/w8ipyK1.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 281",
                    Image = "https://i.imgur.com/jGXy9Hx.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 281",
                    Image = "https://i.imgur.com/29c2gnb.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 281",
                    Image = "https://i.imgur.com/guVPYzA.jpg"
                },
                   //style 282
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 282",
                    Image = "https://i.imgur.com/Q6eQLIs.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 282",
                    Image = "https://i.imgur.com/E5I3hlM.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 282",
                    Image = "https://i.imgur.com/TWHX54K.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 282",
                    Image = "https://i.imgur.com/rm1ELRy.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 282",
                    Image = "https://i.imgur.com/v4zfT33.jpg"
                },
                   //style 283
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 283",
                    Image = "https://i.imgur.com/9lRMUTe.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 283",
                    Image = "https://i.imgur.com/kamBsHp.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 283",
                    Image = "https://i.imgur.com/BQLgEV8.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 283",
                    Image = "https://i.imgur.com/GFvQQd9.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 283",
                    Image = "https://i.imgur.com/iwiFTfb.jpg"
                },
                   //style 284
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 284",
                    Image = "https://i.imgur.com/AsNpLot.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 284",
                    Image = "https://i.imgur.com/SdMoLbk.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 284",
                    Image = "https://i.imgur.com/S4M1oTt.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 284",
                    Image = "https://i.imgur.com/sRERwf0.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 284",
                    Image = "https://i.imgur.com/eJG8qM3.jpg"
                },
                   //style 285
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 285",
                    Image = "https://i.imgur.com/sOfwSQL.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 285",
                    Image = "https://i.imgur.com/gN8eRdq.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 285",
                    Image = "https://i.imgur.com/oeuhhRv.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 285",
                    Image = "https://i.imgur.com/dyRblKy.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 285",
                    Image = "https://i.imgur.com/mS0uJPt.jpg"
                },
                   //style 286
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 286",
                    Image = "https://i.imgur.com/8oovXih.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 286",
                    Image = "https://i.imgur.com/ysRCeWB.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 286",
                    Image = "https://i.imgur.com/TyXv1nF.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 286",
                    Image = "https://i.imgur.com/HPEn3ff.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 286",
                    Image = "https://i.imgur.com/WMSdgL2.jpg"
                },
                   //style 287
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 287",
                    Image = "https://i.imgur.com/jdMjs2j.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 287",
                    Image = "https://i.imgur.com/itZ25lM.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 287",
                    Image = "https://i.imgur.com/fkaw3n1.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 287",
                    Image = "https://i.imgur.com/9DfGMMI.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 287",
                    Image = "https://i.imgur.com/O8kjqLw.jpg"
                },
                   //style 288
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 288",
                    Image = "https://i.imgur.com/QkmhoMC.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 288",
                    Image = "https://i.imgur.com/pnllWE4.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 288",
                    Image = "https://i.imgur.com/2bcJTrR.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 288",
                    Image = "https://i.imgur.com/ZAwnOe4.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 288",
                    Image = "https://i.imgur.com/3ZwhrNd.jpg"
                },
                   //style 290
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 290",
                    Image = "https://i.imgur.com/6h7ljH3.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 290",
                    Image = "https://i.imgur.com/WdALOzl.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 290",
                    Image = "https://i.imgur.com/N9AKRLM.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 290",
                    Image = "https://i.imgur.com/0l2MQww.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 290",
                    Image = "https://i.imgur.com/68naQ4Y.jpg"
                },
                   //style 292
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 292",
                    Image = "https://i.imgur.com/raN3evo.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 292",
                    Image = "https://i.imgur.com/aVoRmNW.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 292",
                    Image = "https://i.imgur.com/f0vYex0.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 292",
                    Image = "https://i.imgur.com/r6XPxeI.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 292",
                    Image = "https://i.imgur.com/aiq98FV.jpg"
                },
                   //style 293
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 293",
                    Image = "https://i.imgur.com/6JpLFT9.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 293",
                    Image = "https://i.imgur.com/2ek7IC7.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 293",
                    Image = "https://i.imgur.com/xeaPHBV.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 293",
                    Image = "https://i.imgur.com/Kd04Azp.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 293",
                    Image = "http://i.imgur.com/6FNhJph.jpg"
                },
                   //style 294
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 294",
                    Image = "https://i.imgur.com/Fx5pn9A.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 294",
                    Image = "https://i.imgur.com/El0vxST.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 294",
                    Image = "https://i.imgur.com/uCBeDA3.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 294",
                    Image = "https://i.imgur.com/JtSn07V.jpg"
                },
                   //style 295
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 295",
                    Image = "https://i.imgur.com/gpVNwwb.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 295",
                    Image = "https://i.imgur.com/eMfbOyg.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 295",
                    Image = "https://i.imgur.com/8b5yGu5.jpg"
                },

                   //style 296
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 296",
                    Image = "https://i.imgur.com/D3zZsxx.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 296",
                    Image = "https://i.imgur.com/R6ePOFk.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 296",
                    Image = "https://i.imgur.com/IeBdnF1.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 296",
                    Image = "https://i.imgur.com/vo3kAel.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 296",
                    Image = "https://i.imgur.com/YMjP78P.jpg"
                },
                    //style 297
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 297",
                    Image = "https://i.imgur.com/CCmyrwq.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 297",
                    Image = "https://i.imgur.com/ahQ6hNW.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 297",
                    Image = "https://i.imgur.com/AACF2k1.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 297",
                    Image = "https://i.imgur.com/xHnzDtM.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 297",
                    Image = "https://i.imgur.com/CQNvETL.jpg"
                },
                    //style 298
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 298",
                    Image = "https://i.imgur.com/nBJbe30.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 298",
                    Image = "https://i.imgur.com/OoREUFs.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 298",
                    Image = "https://i.imgur.com/fWZkF6l.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 298",
                    Image = "https://i.imgur.com/T8ATFP7.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 298",
                    Image = "https://i.imgur.com/CQNvETL.jpg"
                },
                    //style 299
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 299",
                    Image = "https://i.imgur.com/E7am1Sd.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 299",
                    Image = "https://i.imgur.com/6tTFd9Q.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 299",
                    Image = "https://i.imgur.com/gUyBCRz.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 299",
                    Image = "https://i.imgur.com/BrgBAeZ.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 299",
                    Image = "https://i.imgur.com/GSFjcG6.jpg"
                },
                    //style 300
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 300",
                    Image = "https://i.imgur.com/rECEtaL.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 300",
                    Image = "https://i.imgur.com/DvHmE63.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 300",
                    Image = "https://i.imgur.com/Zsm7yDL.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 300",
                    Image = "https://i.imgur.com/N59K1Mn.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 300",
                    Image = "https://i.imgur.com/tSU4Jie.jpg"
                },
                    //style 301
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 301",
                    Image = "https://i.imgur.com/EYAySWe.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 301",
                    Image = "https://i.imgur.com/oYexjkw.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 301",
                    Image = "https://i.imgur.com/L2RJt9F.jpg"
                },
                //style 302
                 new WheelSpecsImages
                {
                    WheelStyleName = "style 302",
                    Image = "https://i.imgur.com/hw3DAcF.jpg"
                },
                 new WheelSpecsImages
                {
                    WheelStyleName = "style 302",
                    Image = "https://i.imgur.com/sVBSWw8.jpg"
                },
                 new WheelSpecsImages
                {
                    WheelStyleName = "style 302",
                    Image = "https://i.imgur.com/z9EWE1p.jpg"
                },
                 new WheelSpecsImages
                {
                    WheelStyleName = "style 302",
                    Image = "https://i.imgur.com/woeQ3Oy.jpg"
                },
                 new WheelSpecsImages
                {
                    WheelStyleName = "style 302",
                    Image = "https://i.imgur.com/2oab98Y.jpg"
                },
                 //style 303
                 new WheelSpecsImages
                {
                    WheelStyleName = "style 303",
                    Image = "https://i.imgur.com/voM29nF.jpg"
                },
                 new WheelSpecsImages
                {
                    WheelStyleName = "style 303",
                    Image = "https://i.imgur.com/tkGgMUY.jpg"
                },
                 new WheelSpecsImages
                {
                    WheelStyleName = "style 303",
                    Image = "https://i.imgur.com/Ag71V0c.jpg"
                },
                 new WheelSpecsImages
                {
                    WheelStyleName = "style 303",
                    Image = "https://i.imgur.com/TNlGnLF.jpg"
                },
                 new WheelSpecsImages
                {
                    WheelStyleName = "style 303",
                    Image = "https://i.imgur.com/mIX5qdw.jpg"
                },
                 //style 304
                 new WheelSpecsImages
                {
                    WheelStyleName = "style 304",
                    Image = "https://i.imgur.com/jmH6Vui.jpg"
                },
                 new WheelSpecsImages
                {
                    WheelStyleName = "style 304",
                    Image = "https://i.imgur.com/zlzmxPq.jpg"
                },
                 new WheelSpecsImages
                {
                    WheelStyleName = "style 304",
                    Image = "https://i.imgur.com/R3NP5LW.jpg"
                },
                 new WheelSpecsImages
                {
                    WheelStyleName = "style 304",
                    Image = "https://i.imgur.com/gU7lZFj.jpg"
                },
                 new WheelSpecsImages
                {
                    WheelStyleName = "style 304",
                    Image = "https://i.imgur.com/E7ME47r.jpg"
                },
                 //style 305
                 new WheelSpecsImages
                {
                    WheelStyleName = "style 305",
                    Image = "https://i.imgur.com/JGxIAGn.jpg"
                },
                 new WheelSpecsImages
                {
                    WheelStyleName = "style 305",
                    Image = "https://i.imgur.com/R0SpXBl.jpg"
                },
                 new WheelSpecsImages
                {
                    WheelStyleName = "style 305",
                    Image = "https://i.imgur.com/uyU5GNs.jpg"
                },
                 new WheelSpecsImages
                {
                    WheelStyleName = "style 305",
                    Image = "https://i.imgur.com/V3VVABn.jpg"
                },
                 new WheelSpecsImages
                {
                    WheelStyleName = "style 305",
                    Image = "https://i.imgur.com/PwYdJ39.jpg"
                },
                   //style 306
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 306",
                    Image = "https://i.imgur.com/3aDUKOT.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 306",
                    Image = "https://i.imgur.com/AScQFS7.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 306",
                    Image = "https://i.imgur.com/bjhoBmV.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 306",
                    Image = "https://i.imgur.com/FzGKKZd.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 306",
                    Image = "https://i.imgur.com/jKf8lUl.jpg"
                },
                   //style 307
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 307",
                    Image = "https://i.imgur.com/BrL9CN2.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 307",
                    Image = "https://i.imgur.com/zPRm7Vu.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 307",
                    Image = "https://i.imgur.com/qICPvW5.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 307",
                    Image = "https://i.imgur.com/7NCbKue.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 307",
                    Image = "https://i.imgur.com/uEusbZ8.jpg"
                },
                   //style 308
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 308",
                    Image = "https://i.imgur.com/yfCKXW3.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 308",
                    Image = "https://i.imgur.com/5b8mHtb.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 308",
                    Image = "https://i.imgur.com/qhlCbw2.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 308",
                    Image = "https://i.imgur.com/deAYQyk.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 308",
                    Image = "https://i.imgur.com/eAe3yGG.jpg"
                },
                   //style 309
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 309",
                    Image = "https://i.imgur.com/OoRQjKN.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 309",
                    Image = "https://i.imgur.com/W94ZEPb.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 309",
                    Image = "https://i.imgur.com/7XlokUr.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 309",
                    Image = "https://i.imgur.com/UtQ9ulR.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 309",
                    Image = "https://i.imgur.com/VFHfpZ3.jpg"
                },
                   //style 310
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 310",
                    Image = "https://i.imgur.com/vxb8ojF.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 310",
                    Image = "https://i.imgur.com/sQ9ibGL.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 310",
                    Image = "https://i.imgur.com/Coe6mlI.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 310",
                    Image = "https://i.imgur.com/paw0Jpa.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 310",
                    Image = "https://i.imgur.com/RXLeQ87.jpg"
                },
                   // style 311
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 311",
                    Image = "https://i.imgur.com/Sk155qJ.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 311",
                    Image = "https://i.imgur.com/zxw0Rl4.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 311",
                    Image = "https://i.imgur.com/ANfJYmB.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 311",
                    Image = "https://i.imgur.com/FRI8bkf.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 311",
                    Image = "https://i.imgur.com/xZ5jlEp.jpg"
                },
                   //style 312
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 312",
                    Image = "https://i.imgur.com/kXQUQil.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 312",
                    Image = "https://i.imgur.com/4BeTP3M.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 312",
                    Image = "https://i.imgur.com/qh9iG8y.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 312",
                    Image = "https://i.imgur.com/1SZe416.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 312",
                    Image = "https://i.imgur.com/K3A4NPk.jpg"
                },
                   //style 313
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 313",
                    Image = "https://i.imgur.com/0WJJ4hr.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 313",
                    Image = "https://i.imgur.com/SVs137r.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 313",
                    Image = "https://i.imgur.com/B9AZj64.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 313",
                    Image = "https://i.imgur.com/AApAcpP.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 313",
                    Image = "https://i.imgur.com/Ocbf0cL.jpg"
                },
                   //style 315
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 315",
                    Image = "https://i.imgur.com/25uPnZD.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 315",
                    Image = "https://i.imgur.com/i20BOSp.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 315",
                    Image = "https://i.imgur.com/4Cv4cgE.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 315",
                    Image = "https://i.imgur.com/tz7CsZX.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 315",
                    Image = "https://i.imgur.com/oQs4q5p.jpg"
                },
                   //style 316
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 316",
                    Image = "https://i.imgur.com/APR4Gne.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 316",
                    Image = "https://i.imgur.com/xP9Yrqk.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 316",
                    Image = "https://i.imgur.com/BmAwBUs.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 316",
                    Image = "https://i.imgur.com/P5O92Pt.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 316",
                    Image = "https://i.imgur.com/L8wSVqr.jpg"
                },
                   //style 317
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 317",
                    Image = "https://i.imgur.com/vodTRlj.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 317",
                    Image = "https://i.imgur.com/fFIH7rd.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 317",
                    Image = "https://i.imgur.com/Lyge4GQ.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 317",
                    Image = "https://i.imgur.com/axhwWT3.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 317",
                    Image = "https://i.imgur.com/t74m0Cx.jpg"
                },
                   //style 318
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 318",
                    Image = "https://i.imgur.com/eORUlVC.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 318",
                    Image = "https://i.imgur.com/LTrav7Q.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 318",
                    Image = "https://i.imgur.com/KTbpe73.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 318",
                    Image = "https://i.imgur.com/1LDKpXY.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 318",
                    Image = "https://i.imgur.com/2VpuhMw.jpg"
                },
                   //style 319
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 319",
                    Image = "https://i.imgur.com/PR7Lhcm.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 319",
                    Image = "https://i.imgur.com/KclFnf6.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 319",
                    Image = "https://i.imgur.com/pMLQMSC.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 319",
                    Image = "https://i.imgur.com/hmPEleK.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 319",
                    Image = "https://i.imgur.com/Puif6Jl.jpg"
                },
                   //style 320
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 320",
                    Image = "https://i.imgur.com/lOUjkZP.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 320",
                    Image = "https://i.imgur.com/XnF17vV.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 320",
                    Image = "https://i.imgur.com/lEtIpFs.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 320",
                    Image = "https://i.imgur.com/lFXO4bN.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 320",
                    Image = "https://i.imgur.com/lDMx4B8.jpg"
                },
                    //style 321
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 321",
                    Image = "https://i.imgur.com/vTSIgc4.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 321",
                    Image = "https://i.imgur.com/cXihhj5.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 321",
                    Image = "https://i.imgur.com/Nw976Jq.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 321",
                    Image = "https://i.imgur.com/FPIKryK.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 321",
                    Image = "https://i.imgur.com/a2k6le8.jpg"
                },
                    //style 322
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 322",
                    Image = "https://i.imgur.com/WKM0RnG.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 322",
                    Image = "https://i.imgur.com/Hx2Q7VB.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 322",
                    Image = "https://i.imgur.com/hA1qDwT.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 322",
                    Image = "https://i.imgur.com/VY50gwV.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 322",
                    Image = "https://i.imgur.com/3BNKqLD.jpg"
                },
                    //style 323
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 323",
                    Image = "https://i.imgur.com/bMFdTku.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 323",
                    Image = "https://i.imgur.com/CNMQ8JH.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 323",
                    Image = "https://i.imgur.com/lhxDFCT.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 323",
                    Image = "https://i.imgur.com/cHHNgBq.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 323",
                    Image = "https://i.imgur.com/ujrGlqZ.jpg"
                },
                    //style 324
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 324",
                    Image = "https://i.imgur.com/0tnfMWM.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 324",
                    Image = "https://i.imgur.com/YYQGAir.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 324",
                    Image = "https://i.imgur.com/wbSMdaW.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 324",
                    Image = "https://i.imgur.com/13pZ6HO.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 324",
                    Image = "https://i.imgur.com/LGIZcO6.jpg"
                },
                    //style 325
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 325",
                    Image = "https://i.imgur.com/gYHmdzy.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 325",
                    Image = "https://i.imgur.com/BuaRyUQ.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 325",
                    Image = "https://i.imgur.com/9oDWhh4.jpg"
                },
                    //style 326
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 326",
                    Image = "https://i.imgur.com/B54I7wZ.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 326",
                    Image = "https://i.imgur.com/s1XtsBP.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 326",
                    Image = "https://i.imgur.com/rC2JHlm.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 326",
                    Image = "https://i.imgur.com/MLtGEmh.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 326",
                    Image = "https://i.imgur.com/tNuZ3Bx.jpg"
                },
                    //style 327
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 327",
                    Image = "https://i.imgur.com/EDO9qcU.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 327",
                    Image = "https://i.imgur.com/C2dyWWp.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 327",
                    Image = "https://i.imgur.com/9n2a64q.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 327",
                    Image = "https://i.imgur.com/THkB35E.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 327",
                    Image = "https://i.imgur.com/7KxdDGm.jpg"
                },
                    //style 328
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 328",
                    Image = "https://i.imgur.com/x6rMKzC.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 328",
                    Image = "https://i.imgur.com/KXf48p1.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 328",
                    Image = "https://i.imgur.com/kt5DPb3.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 328",
                    Image = "https://i.imgur.com/Y32ljqg.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 328",
                    Image = "https://i.imgur.com/TgPqtB6.jpg"
                },
                    //style 329
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 329",
                    Image = "https://i.imgur.com/N5DTbKs.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 329",
                    Image = "https://i.imgur.com/6R3wfmy.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 329",
                    Image = "https://i.imgur.com/it3dSgW.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 329",
                    Image = "https://i.imgur.com/Nh2Zkrm.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 329",
                    Image = "https://i.imgur.com/2iepYBp.jpg"
                },
                    //style 330
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 330",
                    Image = "https://i.imgur.com/aFEI2sN.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 330",
                    Image = "https://i.imgur.com/UuQtSzO.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 330",
                    Image = "https://i.imgur.com/S7kqGjP.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 330",
                    Image = "https://i.imgur.com/u3XNXYF.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 330",
                    Image = "https://i.imgur.com/tn3LpK1.jpg"
                },
                    //style 331
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 331",
                    Image = "https://i.imgur.com/XyRsske.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 331",
                    Image = "https://i.imgur.com/ducEOqC.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 331",
                    Image = "https://i.imgur.com/fXhT2Mt.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 331",
                    Image = "https://i.imgur.com/4OM1VOT.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 331",
                    Image = "https://i.imgur.com/MxRH6vq.jpg"
                },
                    //style 332
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 332",
                    Image = "https://i.imgur.com/LzFCiPO.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 332",
                    Image = "https://i.imgur.com/v1FNjfF.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 332",
                    Image = "https://i.imgur.com/XTd01bc.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 332",
                    Image = "https://i.imgur.com/MH5REaE.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 332",
                    Image = "https://i.imgur.com/PXJWswx.jpg"
                },
                    //style 333
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 333",
                    Image = "https://i.imgur.com/dRK1r7e.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 333",
                    Image = "https://i.imgur.com/0qOuHj2.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 333",
                    Image = "https://i.imgur.com/nOvUTPC.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 333",
                    Image = "https://i.imgur.com/YMrRKqz.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 333",
                    Image = "https://i.imgur.com/J2eJhza.jpg"
                },
                    //style 334
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 334",
                    Image = "https://i.imgur.com/7E5rnsM.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 334",
                    Image = "https://i.imgur.com/qlTINWO.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 334",
                    Image = "https://i.imgur.com/xjlQDzl.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 334",
                    Image = "https://i.imgur.com/jeHlCcc.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 334",
                    Image = "https://i.imgur.com/hDP37TT.jpg"
                },
                    //style 335
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 335",
                    Image = "https://i.imgur.com/RCRVgMU.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 335",
                    Image = "https://i.imgur.com/X2Xjwx9.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 335",
                    Image = "https://i.imgur.com/UQ65EDv.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 335",
                    Image = "https://i.imgur.com/xcpyWx2.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 335",
                    Image = "https://i.imgur.com/KbVvnop.jpg"
                },
                    //style 336
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 336",
                    Image = "https://i.imgur.com/yja1Tkp.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 336",
                    Image = "https://i.imgur.com/AGpC0as.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 336",
                    Image = "https://i.imgur.com/QNJXaLL.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 336",
                    Image = "https://i.imgur.com/bclXHo0.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 336",
                    Image = "https://i.imgur.com/O4jQHNW.jpg"
                },
                    //style 337
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 337",
                    Image = "https://i.imgur.com/ZWbtHBM.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 337",
                    Image = "https://i.imgur.com/xZGXhwd.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 337",
                    Image = "https://i.imgur.com/W9E7oFH.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 337",
                    Image = "https://i.imgur.com/yNlF9au.jpg"
                },
                    new WheelSpecsImages
                {
                    WheelStyleName = "style 337",
                    Image = "https://i.imgur.com/KNCFME6.jpg"
                },
                   //style 338
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 338",
                    Image = "https://i.imgur.com/KzLR9nq.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 338",
                    Image = "https://i.imgur.com/ttEQVRH.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 338",
                    Image = "https://i.imgur.com/pm6hwIa.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 338",
                    Image = "https://i.imgur.com/eSbRez4.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 338",
                    Image = "https://i.imgur.com/tinKWvK.jpg"
                },
                   //style 339
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 339",
                    Image = "https://i.imgur.com/jypLJfG.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 339",
                    Image = "https://i.imgur.com/2gnVGbY.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 339",
                    Image = "https://i.imgur.com/aH70N7W.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 339",
                    Image = "https://i.imgur.com/75sFCNH.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 339",
                    Image = "https://i.imgur.com/EjYq3gs.jpg"
                },
                   //style 340
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 340",
                    Image = "https://i.imgur.com/KKuJV2E.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 340",
                    Image = "https://i.imgur.com/SgBhf1L.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 340",
                    Image = "https://i.imgur.com/6H6djQU.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 340",
                    Image = "https://i.imgur.com/aDpm3mB.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 340",
                    Image = "https://i.imgur.com/ftnFRsb.jpg"
                },
                   //style 342
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 342",
                    Image = "https://i.imgur.com/X6KeCJC.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 342",
                    Image = "https://i.imgur.com/dU2zEex.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 342",
                    Image = "https://i.imgur.com/qkyeTEN.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 342",
                    Image = "https://i.imgur.com/2y1NrdR.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 342",
                    Image = "https://i.imgur.com/lkNUEis.jpg"
                },
                   //style 343
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 343",
                    Image = "https://i.imgur.com/DZpsmVd.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 343",
                    Image = "https://i.imgur.com/Eq9RGNb.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 343",
                    Image = "https://i.imgur.com/XYu7C1y.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 343",
                    Image = "https://i.imgur.com/x1o8o9v.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 343",
                    Image = "https://i.imgur.com/lS00nUd.jpg"
                },
                   //style 345
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 345",
                    Image = "https://i.imgur.com/6hCEA9X.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 345",
                    Image = "https://i.imgur.com/w5LX7Nj.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 345",
                    Image = "https://i.imgur.com/hyAbLRt.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 345",
                    Image = "https://i.imgur.com/XeF2dS5.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 345",
                    Image = "https://i.imgur.com/0JCdLL1.jpg"
                },
                   //style 349
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 349",
                    Image = "https://i.imgur.com/dm5UlTo.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 349",
                    Image = "https://i.imgur.com/Po5a3W8.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 349",
                    Image = "https://i.imgur.com/eOxEDlP.jpg"
                },
                 //style 350
                 new WheelSpecsImages
                {
                    WheelStyleName = "style 350",
                    Image = "https://i.imgur.com/KAT5EXy.jpg"
                },
                 new WheelSpecsImages
                {
                    WheelStyleName = "style 350",
                    Image = "https://i.imgur.com/tvWePN5.jpg"
                },
                 new WheelSpecsImages
                {
                    WheelStyleName = "style 350",
                    Image = "https://i.imgur.com/i5JrOTz.jpg"
                },
                 new WheelSpecsImages
                {
                    WheelStyleName = "style 350",
                    Image = "https://i.imgur.com/AmPog7r.jpg"
                },
                 new WheelSpecsImages
                {
                    WheelStyleName = "style 350",
                    Image = "https://i.imgur.com/qXkwKfW.jpg"
                },
                 //style 351
                 new WheelSpecsImages
                {
                    WheelStyleName = "style 351",
                    Image = "https://i.imgur.com/S01iVLj.jpg"
                },
                 new WheelSpecsImages
                {
                    WheelStyleName = "style 351",
                    Image = "https://i.imgur.com/mxGgnv7.jpg"
                },
                 new WheelSpecsImages
                {
                    WheelStyleName = "style 351",
                    Image = "https://i.imgur.com/9XlMQp9.jpg"
                },
                 new WheelSpecsImages
                {
                    WheelStyleName = "style 351",
                    Image = "https://i.imgur.com/6wAUFnS.jpg"
                },
                 new WheelSpecsImages
                {
                    WheelStyleName = "style 351",
                    Image = "https://i.imgur.com/1YAL8ir.jpg"
                },
                 //style 354
                 new WheelSpecsImages
                {
                    WheelStyleName = "style 354",
                    Image = "https://i.imgur.com/gSXwYcE.jpg"
                },
                //style 355
                new WheelSpecsImages
                {
                    WheelStyleName = "style 355",
                    Image = "https://i.imgur.com/8JZYYZH.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 355",
                    Image = "https://i.imgur.com/koznX1Q.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 355",
                    Image = "https://i.imgur.com/WFYolzW.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 355",
                    Image = "https://i.imgur.com/1gt6p2x.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 355",
                    Image = "https://i.imgur.com/kSsDOaw.jpg"
                },
                //style 356
                new WheelSpecsImages
                {
                    WheelStyleName = "style 356",
                    Image = "https://i.imgur.com/ZmCnJjU.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 356",
                    Image = "https://i.imgur.com/aGUQiFl.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 356",
                    Image = "https://i.imgur.com/PDeIujb.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 356",
                    Image = "https://i.imgur.com/WK8D3YB.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 356",
                    Image = "https://i.imgur.com/nliO0gl.jpg"
                },
                //style 357
                new WheelSpecsImages
                {
                    WheelStyleName = "style 357",
                    Image = "https://i.imgur.com/fKfWIXQ.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 357",
                    Image = "https://i.imgur.com/a1La6FQ.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 357",
                    Image = "https://i.imgur.com/FfqDnyA.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 357",
                    Image = "https://i.imgur.com/BLkKloK.jpg"
                },
                new WheelSpecsImages
                {
                    WheelStyleName = "style 357",
                    Image = "https://i.imgur.com/xAbHaQU.jpg"
                },
                   //style 359
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 359",
                    Image = "https://i.imgur.com/ErQLMSx.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 359",
                    Image = "https://i.imgur.com/zu8HUxU.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 359",
                    Image = "https://i.imgur.com/wSMnFCT.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 359",
                    Image = "https://i.imgur.com/6ocXJdV.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 359",
                    Image = "https://i.imgur.com/1Vw2ucf.jpg"
                },

                   //style 360
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 360",
                    Image = "https://i.imgur.com/JHBv0ug.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 360",
                    Image = "https://i.imgur.com/3wjUsoE.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 360",
                    Image = "https://i.imgur.com/oFf3RFr.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 360",
                    Image = "https://i.imgur.com/ccTOzsS.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 360",
                    Image = "https://i.imgur.com/LkdRFVy.jpg"
                },

                   //style 361
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 361",
                    Image = "https://i.imgur.com/wJxVcZb.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 361",
                    Image = "https://i.imgur.com/gGtGQ0X.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 361",
                    Image = "https://i.imgur.com/wOETvIB.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 361",
                    Image = "https://i.imgur.com/YOe9KwR.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 361",
                    Image = "https://i.imgur.com/o4FTkUH.jpg"
                },
                   //style 363
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 363",
                    Image = "https://i.imgur.com/5VO8Hyu.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 363",
                    Image = "https://i.imgur.com/5UyfqEE.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 363",
                    Image = "https://i.imgur.com/DZmbzEm.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 363",
                    Image = "https://i.imgur.com/O62KD1L.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 363",
                    Image = "https://i.imgur.com/Bk3dA3Z.jpg"
                },
                   //style 365
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 365",
                    Image = "https://i.imgur.com/RaHX7Y0.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 365",
                    Image = "https://i.imgur.com/ilSUscO.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 365",
                    Image = "https://i.imgur.com/gSaBNu7.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 365",
                    Image = "https://i.imgur.com/wDdvIsY.jpg"
                },
                  //style 366
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 366",
                    Image = "https://i.imgur.com/rLgOHLz.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 366",
                    Image = "https://i.imgur.com/TB0twaC.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 366",
                    Image = "https://i.imgur.com/wegEK0e.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 366",
                    Image = "https://i.imgur.com/27NdbLY.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 366",
                    Image = "https://i.imgur.com/WI535BW.jpg"
                },
                  //style 367
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 367",
                    Image = "https://i.imgur.com/oIGG0q6.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 367",
                    Image = "https://i.imgur.com/ojDtLmm.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 367",
                    Image = "https://i.imgur.com/WZWqURU.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 367",
                    Image = "https://i.imgur.com/eCLfoCn.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 367",
                    Image = "https://i.imgur.com/AbOQ3OA.jpg"
                },
                  //style 368
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 368",
                    Image = "https://i.imgur.com/7vaEPmu.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 368",
                    Image = "https://i.imgur.com/MiWDBeF.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 368",
                    Image = "https://i.imgur.com/cxB4YB5.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 368",
                    Image = "https://i.imgur.com/prwTlaY.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 368",
                    Image = "https://i.imgur.com/4octL78.jpg"
                },
                  //style 369
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 369",
                    Image = "https://i.imgur.com/rvVBxFI.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 369",
                    Image = "https://i.imgur.com/LKYaNqh.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 369",
                    Image = "https://i.imgur.com/O0r9tGE.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 369",
                    Image = "https://i.imgur.com/tsMirVV.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 369",
                    Image = "https://i.imgur.com/txq3uYJ.jpg"
                },
                  //style 373
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 373",
                    Image = "https://i.imgur.com/FxzMYm6.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 373",
                    Image = "https://i.imgur.com/McXTMWG.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 373",
                    Image = "https://i.imgur.com/lkoORwD.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 373",
                    Image = "https://i.imgur.com/ByAWfkU.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 373",
                    Image = "https://i.imgur.com/Y6h59sl.jpg"
                },
                  //style 374
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 374",
                    Image = "https://i.imgur.com/N6gupg6.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 374",
                    Image = "https://i.imgur.com/ru034l0.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 374",
                    Image = "https://i.imgur.com/9ln2TRh.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 374",
                    Image = "https://i.imgur.com/xYu9Czf.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 374",
                    Image = "https://i.imgur.com/fMHbHTB.jpg"
                },
                  //style 375
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 375",
                    Image = "https://i.imgur.com/os5lDUO.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 375",
                    Image = "https://i.imgur.com/oQlvrVy.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 375",
                    Image = "https://i.imgur.com/jINB1dU.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 375",
                    Image = "https://i.imgur.com/se9VNmj.jpg"
                },
                  new WheelSpecsImages
                {
                    WheelStyleName = "style 375",
                    Image = "https://i.imgur.com/uiPcbwE.jpg"
                },
                   //style 376
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 376",
                    Image = "https://i.imgur.com/9bfjbdP.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 376",
                    Image = "https://i.imgur.com/bAH9S9A.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 376",
                    Image = "https://i.imgur.com/yP01NHF.jpg"
                },

                   //style 377
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 377",
                    Image = "https://i.imgur.com/mwAcXsb.jpgg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 377",
                    Image = "https://i.imgur.com/nG14M3b.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 377",
                    Image = "https://i.imgur.com/JY7SFPg.jpg"
                },

                   //style 378
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 378",
                    Image = "https://i.imgur.com/RF1QSli.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 378",
                    Image = "https://i.imgur.com/PLb5OtX.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 378",
                    Image = "https://i.imgur.com/oQUbii3.jpg"
                },

                   //style 379
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 379",
                    Image = "https://i.imgur.com/KhRgCpm.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 379",
                    Image = "https://i.imgur.com/7Dg3PI8.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 379",
                    Image = "https://i.imgur.com/xU5XYEw.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 379",
                    Image = "https://i.imgur.com/Aw3rwN9.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 379",
                    Image = "https://i.imgur.com/XmPXhTm.jpg"
                },

                   //style 380
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 380",
                    Image = "https://i.imgur.com/jpDXu6G.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 380",
                    Image = "https://i.imgur.com/lHCopST.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 380",
                    Image = "https://i.imgur.com/zGninmp.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 380",
                    Image = "https://i.imgur.com/Tgly77e.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 380",
                    Image = "https://i.imgur.com/qTmOMw8.jpg"
                },

                   //style 381
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 381",
                    Image = "https://i.imgur.com/MMsXhVW.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 381",
                    Image = "https://i.imgur.com/WnBqqw3.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 381",
                    Image = "https://i.imgur.com/QlBsQmB.jpg"
                },

                   //style 382
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 382",
                    Image = "https://i.imgur.com/dEE6499.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 382",
                    Image = "https://i.imgur.com/wxgzDVE.jpg"
                },

                   //style 385
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 385",
                    Image = "https://i.imgur.com/P8gsbn9.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 385",
                    Image = "https://i.imgur.com/pvFfDZ6.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 385",
                    Image = "https://i.imgur.com/RDB2zUs.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 385",
                    Image = "https://i.imgur.com/BO7TlBN.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 385",
                    Image = "https://i.imgur.com/mbgjB55.jpg"
                },

                   //style 388

                   new WheelSpecsImages
                {
                    WheelStyleName = "style 388",
                    Image = "https://i.imgur.com/yalPNz9.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 388",
                    Image = "https://i.imgur.com/hBvpoxD.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 388",
                    Image = "https://i.imgur.com/yF9oLv9.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 388",
                    Image = "https://i.imgur.com/i3A5wZK.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 388",
                    Image = "https://i.imgur.com/ib2LVq0.jpg"
                },
                   //style 390
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 390",
                    Image = "https://i.imgur.com/AQdYexx.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 390",
                    Image = "https://i.imgur.com/sc8Gkpp.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 390",
                    Image = "https://i.imgur.com/p5gTIId.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 390",
                    Image = "https://i.imgur.com/NzAPuS0.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 390",
                    Image = "https://i.imgur.com/x157OHF.jpg"
                },
                   //style 391
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 391",
                    Image = "https://i.imgur.com/5vyt7WH.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 391",
                    Image = "https://i.imgur.com/ydMmvHc.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 391",
                    Image = "https://i.imgur.com/EG58ucN.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 391",
                    Image = "https://i.imgur.com/SUM7dAw.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 391",
                    Image = "https://i.imgur.com/iYkpHUB.jpg"
                },
                   //style 392
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 392",
                    Image = "https://i.imgur.com/UifWJve.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 392",
                    Image = "https://i.imgur.com/UKnJlkC.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 392",
                    Image = "https://i.imgur.com/JrGtlDi.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 392",
                    Image = "https://i.imgur.com/tvYIqyC.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 392",
                    Image = "https://i.imgur.com/oqW08iW.jpg"
                },
                   //style 393
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 393",
                    Image = "https://i.imgur.com/WB8DMQA.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 393",
                    Image = "https://i.imgur.com/W4OrQXr.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 393",
                    Image = "https://i.imgur.com/npndcVC.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 393",
                    Image = "https://i.imgur.com/TEN1KJc.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 393",
                    Image = "https://i.imgur.com/BYuZC8l.jpg"
                },
                   //style 394
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 394",
                    Image = "https://i.imgur.com/oD1s0CZ.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 394",
                    Image = "https://i.imgur.com/twvyOZH.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 394",
                    Image = "https://i.imgur.com/8Gr5x9l.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 394",
                    Image = "https://i.imgur.com/dPp5jzs.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 394",
                    Image = "https://i.imgur.com/58YRJZt.jpg"
                },
                   //style 395
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 395",
                    Image = "https://i.imgur.com/EXrp10w.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 395",
                    Image = "https://i.imgur.com/XBt5Jz9.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 395",
                    Image = "https://i.imgur.com/IeRG4SC.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 395",
                    Image = "https://i.imgur.com/Ncqq1LI.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 395",
                    Image = "https://i.imgur.com/fA8scYk.jpg"
                },
                   //style 396
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 396",
                    Image = "https://i.imgur.com/W6HSkMy.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 396",
                    Image = "https://i.imgur.com/wX8ecuC.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 396",
                    Image = "https://i.imgur.com/IM82xDG.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 396",
                    Image = "https://i.imgur.com/kbqxaXF.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 396",
                    Image = "https://i.imgur.com/n08e4f1.jpg"
                },
                   //style 397
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 397",
                    Image = "https://i.imgur.com/DFvEhPU.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 397",
                    Image = "https://i.imgur.com/iaMIHEz.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 397",
                    Image = "https://i.imgur.com/JvjrCpU.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 397",
                    Image = "https://i.imgur.com/sY0LeQF.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 397",
                    Image = "https://i.imgur.com/Y2z92Sk.jpg"
                },
                   //style 398
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 398",
                    Image = "https://i.imgur.com/DYC3CZD.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 398",
                    Image = "https://i.imgur.com/qZV3EFd.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 398",
                    Image = "https://i.imgur.com/84pUtPh.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 398",
                    Image = "https://i.imgur.com/GMh3qDZ.jpg"
                },
                   //style 401
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 401",
                    Image = "https://i.imgur.com/RlMF83G.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 401",
                    Image = "https://i.imgur.com/gMARKSK.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 401",
                    Image = "https://i.imgur.com/UJL5qSi.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 401",
                    Image = "https://i.imgur.com/b6wGNhi.jpg"
                },
                   //style 404
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 404",
                    Image = "https://i.imgur.com/FYmfxX6.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 404",
                    Image = "https://i.imgur.com/kDdTKUQ.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 404",
                    Image = "https://i.imgur.com/MB9tUtL.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 404",
                    Image = "https://i.imgur.com/ml3KyOD.jpg"
                },
                   //style 405
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 405",
                    Image = "https://i.imgur.com/WOvNk2r.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 405",
                    Image = "https://i.imgur.com/JR8TbRb.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 405",
                    Image = "https://i.imgur.com/xVW7JAP.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 405",
                    Image = "https://i.imgur.com/wpjcBM2.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 405",
                    Image = "https://i.imgur.com/U2zQXEB.jpg"
                },
                   //style 408
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 408",
                    Image = "https://i.imgur.com/eIDnlgq.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 408",
                    Image = "https://i.imgur.com/OxhclOT.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 408",
                    Image = "https://i.imgur.com/2EWvNHU.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 408",
                    Image = "https://i.imgur.com/ByPjXal.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 408",
                    Image = "https://i.imgur.com/pDC1ip5.jpg"
                },
                   //style 409
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 409",
                    Image = "https://i.imgur.com/klkiAdC.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 409",
                    Image = "https://i.imgur.com/mhTFpA3.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 409",
                    Image = "https://i.imgur.com/u2FmGII.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 409",
                    Image = "https://i.imgur.com/2DnHbPU.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 409",
                    Image = "https://i.imgur.com/zdbmXqN.jpg"
                },
                   //style 410
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 410",
                    Image = "https://i.imgur.com/YanH4vt.jpg"
                },
                   //style 411
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 411",
                    Image = "https://i.imgur.com/XQe2IED.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 411",
                    Image = "https://i.imgur.com/F1P0Xf1.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 411",
                    Image = "https://i.imgur.com/yEqwfnZ.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 411",
                    Image = "https://i.imgur.com/kKznqB0.jpg"
                },
                   //style 412
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 412",
                    Image = "https://i.imgur.com/2bKjpF2.jpg"
                },
                   //style 413
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 413",
                    Image = "https://i.imgur.com/cU7Vg4Z.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 413",
                    Image = "https://i.imgur.com/OOwJ4IA.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 413",
                    Image = "https://i.imgur.com/p3fvtlt.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 413",
                    Image = "https://i.imgur.com/iQWmgof.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 413",
                    Image = "https://i.imgur.com/8PojEii.jpg"
                },
                   //style 414
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 414",
                    Image = "https://i.imgur.com/pFjYNmD.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 414",
                    Image = "https://i.imgur.com/Q7kvkFI.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 414",
                    Image = "https://i.imgur.com/puhJrGP.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 414",
                    Image = "https://i.imgur.com/cIAuvDa.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 414",
                    Image = "https://i.imgur.com/LEuw9JC.jpg"
                },
                   //style 415
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 415",
                    Image = "https://i.imgur.com/rRfG82k.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 415",
                    Image = "https://i.imgur.com/cjI7bxb.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 415",
                    Image = "https://i.imgur.com/92M4EPk.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 415",
                    Image = "https://i.imgur.com/IrCGFBi.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 415",
                    Image = "https://i.imgur.com/4Bk99Od.jpg"
                },
                   //style 416
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 416",
                    Image = "https://i.imgur.com/TgNC5Z5.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 416",
                    Image = "https://i.imgur.com/khsOtqp.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 416",
                    Image = "https://i.imgur.com/kVXmfHb.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 416",
                    Image = "https://i.imgur.com/DLjWGiT.jpg"
                },
                   new WheelSpecsImages
                {
                    WheelStyleName = "style 416",
                    Image = "https://i.imgur.com/i3mQBbR.jpg"
                },
            };

            return Task.FromResult(wheelImages);
        }
    }
}
