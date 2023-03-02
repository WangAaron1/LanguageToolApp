using HelperTool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AutoDeployExcelDataForDesigner.Scripts.AutoModes
{
    public class HeroDataClass
    {

        private static int LatestSkinID;
        public static void Deploy_Item()
        {
            try
            {
                //——————————获取Item表数据————————————
                if (HeroDataFrame.Instance == null) return;
                HeroDataFrame instance = HeroDataFrame.Instance;

                if (ExcelPathConst.e_Item.WorkSheets == null) return;
                List<RowData> itemsData = ExcelPathConst.e_Item.WorkSheets[0].GetRowDatas(6);

                //——————————人形————————————
                int _heroID = instance.HeroIDBox.Text.ToInt32();
                int _heroItemId = _heroID + 1000;
                int _heroStars = instance.HeroStarsBox.Text.ToInt32();
                string _heroZHName = instance.HeroZHNameBox.Text;
                string _heroENName = instance.HeroENNameBox.Text;

                RowData biggestHeroIdData = itemsData.GetMaxNum(20, 2001);

                biggestHeroIdData[0] = _heroItemId;
                biggestHeroIdData[1] = _heroZHName;
                biggestHeroIdData[4] = instance.FragmentDesBox.Text;
                biggestHeroIdData[6] = $"ICON_Item_{biggestHeroIdData[0]}";
                biggestHeroIdData[17] = $"{_heroItemId}_{_heroStars * 2}";
                biggestHeroIdData[22] = instance.GetFunctionBox.Text;

                ExcelHelper.AddExcelRow(biggestHeroIdData, biggestHeroIdData.index + 1, true, ExcelPathConst.e_Item.WorkSheets?[0], ExcelPathConst.e_Item.PathInfo, ExcelPathConst.e_Item.Package);

                //——————————人形碎片————————————

                int _heroFragmentId = _heroID + 1500;

                RowData biggestFragmentIdData = itemsData.GetMaxNum(25, 2501);

                biggestFragmentIdData[0] = _heroFragmentId;
                biggestFragmentIdData[4] = $"{_heroZHName}的心智碎片，可用于心智扩容。碎片里保存着{_heroZHName}的心智数据，请妥善保管。";
                biggestFragmentIdData[6] = $"ICON_Item_{_heroFragmentId}";
                biggestFragmentIdData[17] = _heroID;
                biggestFragmentIdData[21] = $"102={_heroID}";
                biggestFragmentIdData[22] = "获得该角色后可通过补给商店购买或碎片搜索掉落";

                ExcelHelper.AddExcelRow(biggestFragmentIdData, biggestFragmentIdData.index + 2, true, ExcelPathConst.e_Item.WorkSheets?[0], ExcelPathConst.e_Item.PathInfo, ExcelPathConst.e_Item.Package);

                //——————————P2P3皮肤————————————

                int _heroBaseSkinID = _heroID + 2000;


                string _heroP2SkinID = _heroBaseSkinID.ToString() + "01";
                string _heroP3SkinID = _heroBaseSkinID.ToString() + "02";

                int _p2RealId = Convert.ToInt32(_heroP2SkinID);
                int _p3RealId = Convert.ToInt32(_heroP3SkinID);

                LatestSkinID = _p2RealId;

                int _newestHeroSkinID = _heroID + 1999;
                string _realLatestSkinID = _newestHeroSkinID.ToString() + "01";

                RowData biggestSkinData = itemsData.GetMaxNum(3, _realLatestSkinID.ToInt32());
                bool findBiggest = biggestSkinData.ColTexts != null;
                int findTime = 0;
                while (!findBiggest)
                {
                    _newestHeroSkinID = _heroID + 1999 - ++findTime;
                    _realLatestSkinID = _newestHeroSkinID.ToString() + "01";
                    biggestSkinData = itemsData.GetMaxNum(3, _realLatestSkinID.ToInt32());
                    findBiggest = biggestSkinData.ColTexts != null;
                }
                ///以下是P2
                biggestSkinData[0] = _p2RealId;
                biggestSkinData[1] = _heroZHName;
                biggestSkinData[4] = $"测试皮肤数据";
                biggestSkinData[6] = $"ICON_Item_{_p2RealId}";
                biggestSkinData[17] = _p2RealId;
                biggestSkinData[19] = "5800_5800_5800_580_10_1_5800_580_58_1000";
                biggestSkinData[22] = "";
                ExcelHelper.AddExcelRow(biggestSkinData, biggestSkinData.index + 3, true, ExcelPathConst.e_Item.WorkSheets?[0], ExcelPathConst.e_Item.PathInfo, ExcelPathConst.e_Item.Package);

                ///以下是P3
                biggestSkinData[0] = _p3RealId;
                biggestSkinData[1] = _heroZHName;
                biggestSkinData[4] = $"测试皮肤数据";
                biggestSkinData[6] = $"ICON_Item_{_p3RealId}";
                biggestSkinData[17] = _p3RealId;
                biggestSkinData[19] = "5800_5800_5800_580_10_1_5800_580_58_1000";
                biggestSkinData[22] = "";
                ExcelHelper.AddExcelRow(biggestSkinData, biggestSkinData.index + 4, true, ExcelPathConst.e_Item.WorkSheets?[0], ExcelPathConst.e_Item.PathInfo, ExcelPathConst.e_Item.Package);

                //——————————头像框————————————
                string checkID = $"42{_heroID - 1001}02";
                if (itemsData == null) return;
                RowData biggestHeadFrameData = itemsData.GetRowById(checkID.ToInt32());

                if (biggestHeadFrameData.ColTexts == null) return;

                var biggestHeadFrameID = biggestHeadFrameData[0].ToInt32();
                int newestHeadFrameID = biggestHeadFrameID + 1;

                biggestHeadFrameData[0] = $"42{_heroID - 1000}02";
                biggestHeadFrameData[1] = instance.HeadIconNameBox.Text;
                biggestHeadFrameData[4] = instance.HeadIconDesBox.Text;
                biggestHeadFrameData[6] = $"ICON_Item_42{_heroID - 1000}02";
                biggestHeadFrameData[22] = "人形心智扩容解锁头像";

                ExcelHelper.AddExcelRow(biggestHeadFrameData, biggestHeadFrameData.index + 5, true, ExcelPathConst.e_Item.WorkSheets?[0], ExcelPathConst.e_Item.PathInfo, ExcelPathConst.e_Item.Package);
            }
            catch (Exception e)
            {
                MessageBox.Show($"请先确保你的Excel都处于关闭状态\n报错信息:{e}");
                return;
            }
        }

        public static void Deploy_HeroData()
        {
            var instance = HeroDataFrame.Instance;
            if (instance == null) return;

            if (ExcelPathConst.e_Herodata.RowDatas == null) return;
            RowData LastHeroData = ExcelPathConst.e_Herodata.RowDatas.Last();

            var _heroID = instance.HeroIDBox.Text.ToInt32();

            LastHeroData[0] = _heroID;
            LastHeroData[1] = instance.HeroZHNameBox.Text;
            LastHeroData[2] = instance.HeroENNameBox.Text;
            LastHeroData[3] = instance.HeroZHNameBox.Text;
            LastHeroData[4] = LatestSkinID - 1;
            LastHeroData[5] = $"{LatestSkinID}_{LatestSkinID + 1}";
            LastHeroData[6] = "";
            LastHeroData[7] = 0;
            LastHeroData[9] = instance.HeroBirthdayBox.Text;
            LastHeroData[10] = instance.HeroModelIDBox.Text;
            LastHeroData[11] = instance.HeroCVNameBox.Text;
            LastHeroData[13] = instance.HeroCareerBox.Text;
            LastHeroData[14] = _heroID;
            switch (instance.HeroCareerSelectBox.Text)
            {
                case "守卫":
                    LastHeroData[16] = 1;
                    break;
                case "射手":
                    LastHeroData[16] = 2;
                    break;
                case "战士":
                    LastHeroData[16] = 3;
                    break;
                case "特种":
                    LastHeroData[16] = 4;
                    break;
                case "医师":
                    LastHeroData[16] = 5;
                    break;
                default:
                    break;
            }
            LastHeroData[17] = $"{_heroID}00_{_heroID}01_{_heroID}02_{_heroID}03";
            switch (instance.HeroCompanyBox.Text)
            {
                case "火神重工":
                    LastHeroData[20] = 1;
                    break;
                case "42Lab":
                    LastHeroData[20] = 2;
                    break;
                case "最终生命控股":
                    LastHeroData[20] = 3;
                    break;
                case "赛博传媒":
                    LastHeroData[20] = 4;
                    break;
                case "环球万事服务":
                    LastHeroData[20] = 5;
                    break;
                default:
                    break;
            }
            LastHeroData[23] = _heroID + 1500;
            LastHeroData[25] = _heroID + 1000;

            ExcelHelper.AddExcelRow(LastHeroData, LastHeroData.index + 1, true, ExcelPathConst.e_Herodata.WorkSheets?.GetWorksheet("hero_data"), ExcelPathConst.e_Herodata.PathInfo, ExcelPathConst.e_Herodata.Package);

        }

        public static void Deploy_HeroData_HeroStarSheet()
        {
            var instance = HeroDataFrame.Instance;

            if (instance == null) return;

            var starSheet = ExcelPathConst.e_Herodata.WorkSheets?.GetWorksheet("hero_star");

            if (starSheet == null) return;

            var starDatas = starSheet.GetRowDatas(starSheet.Dimension.Rows - 10);

            if (starDatas == null) return;

            for (int i = 0; i < starDatas.Count; i++)
            {
                var data = starDatas[i];
                data[0] = instance.HeroIDBox.Text.ToInt32();
                data[1] = instance.HeroZHNameBox.Text;
                if (i == 6)
                {

                    data[30] = $"{LatestSkinID}=1";
                }
                else if (i == 7)
                {
                    data[30] = $"{LatestSkinID + 1}=1";
                }
                else if (i == starDatas.Count)
                {
                    data[31] = LatestSkinID;
                }
            }


            ExcelHelper.AddExcelRows(starDatas, starDatas.Last().index + 1, true, starSheet, ExcelPathConst.e_Herodata.PathInfo, ExcelPathConst.e_Herodata.Package);

        }

        public static void Deploy_HeroData_HeroRelationship()
        {
            var instance = HeroDataFrame.Instance;

            if (instance == null) return;

            var shipSheet = ExcelPathConst.e_Herodata.WorkSheets?.GetWorksheet("hero_relationship");

            if (shipSheet == null) return;

            var shipDatas = shipSheet.GetRowDatas(6);
            if (shipDatas == null) return;
            var lastShipData = shipDatas.Last();
            var shipGridDatas = instance.ShipGridView.ConvertDataGrid2RowData();

            int active = 0;

            //先检查下老角色关系网数量是否超过6
            //如果没有则老角色新增关系网
            for (int i = 0; i < shipGridDatas.Count; i++)
            {
                var relationShipData = shipGridDatas[i];
                var oldID = relationShipData[0].ToInt32();
                RowData oldRelationShip = shipSheet.GetRowByID(oldID);
                RowData oldRelationShip_latest = shipDatas.GetMaxID(2, oldRelationShip.index - 6);
                if (oldRelationShip_latest[2].ToInt32() >= 6)
                {
                    continue;
                }
                else
                {
                    oldRelationShip_latest[2] = oldRelationShip_latest[2].ToInt32() + 1;
                    oldRelationShip_latest[3] = instance.HeroIDBox.Text.ToInt32();
                    oldRelationShip_latest[4] = instance.HeroZHNameBox.Text;
                    oldRelationShip_latest[5] = relationShipData[2];
                    ExcelHelper.AddExcelRow(oldRelationShip_latest, oldRelationShip_latest.index + active + 1, true, ExcelPathConst.e_Herodata.WorkSheets?.GetWorksheet("hero_relationship"), ExcelPathConst.e_Herodata.PathInfo, ExcelPathConst.e_Herodata.Package);
                    active++;
                }
            }
            (ExcelPathConst.e_Herodata, _) = ExcelHelper.LoadSPExcel(PathConst.hero_data_ExcelPath);

            shipSheet = ExcelPathConst.e_Herodata.WorkSheets?.GetWorksheet("hero_relationship");
            shipDatas = shipSheet.GetRowDatas(6);
            if (shipDatas == null) return;
            lastShipData = shipDatas.Last();

            for (int i = 0; i < shipGridDatas.Count; i++)
            {
                var shipData = shipGridDatas[i];
                lastShipData[0] = instance.HeroIDBox.Text.ToInt32();
                lastShipData[1] = instance.HeroZHNameBox.Text;
                lastShipData[2] = i + 1;
                lastShipData[3] = shipData[0];
                lastShipData[4] = shipData[1];
                lastShipData[5] = shipData[2];
                ExcelHelper.AddExcelRow(lastShipData, lastShipData.index + i + 1, true, ExcelPathConst.e_Herodata.WorkSheets?.GetWorksheet("hero_relationship"), ExcelPathConst.e_Herodata.PathInfo, ExcelPathConst.e_Herodata.Package);
            }

        }

        public static void Deploy_HeroData_HeroFriendShipGift()
        {
            var instance = HeroDataFrame.Instance;

            if (instance == null) return;

            var shipSheet = ExcelPathConst.e_HeroFriendShip.WorkSheets?.GetWorksheet("friendship_hero");

            if (shipSheet == null) return;

            List<RowData> ships = shipSheet.GetRowDatas(6);

            if (ships == null) return;


            var likeChecks = instance.LikeGiftList.CheckedIndices;
            var unlikeChecks = instance.HateGiftList.CheckedIndices;

            if (likeChecks.Count == 0 && unlikeChecks.Count == 0) return;

            int[] likes = new int[likeChecks.Count];
            int[] unlikes = new int[unlikeChecks.Count];


            for (int i = 0; i < likeChecks.Count; i++)
            {
                var index = likeChecks[i];
                likes[i] = index + 3100;
            }
            for (int i = 0; i < unlikeChecks.Count; i++)
            {
                var index = unlikeChecks[i];
                unlikes[i] = index + 3100;
            }

            string likeConfig = likes[0].ToString();
            string unlikeConfig = unlikes[0].ToString();

            for (int i = 1; i < likes.Length; i++)
            {
                likeConfig = string.Concat(likeConfig, $"_{likes[i]}");
            }
            for (int i = 1; i < unlikes.Length; i++)
            {
                unlikeConfig = string.Concat(unlikeConfig, $"_{unlikes[i]}");
            }

            var newestData = ships[ships.Count - 1];
            var heroID = instance.HeroIDBox.Text.ToInt32();

            newestData[0] = heroID;
            newestData[1] = instance.HeroZHNameBox.Text;
            newestData[2] = likeConfig;
            newestData[3] = unlikeConfig;
            newestData[5] = $"5{heroID - 1000}1_5{heroID - 1000}2_5{heroID - 1000}3_5{heroID - 1000}4_5{heroID - 1000}5_5{heroID - 1000}6";
            switch (instance.HeroCompanyBox.Text)
            {
                case "火神重工":
                    newestData[7] = 2;
                    break;
                case "42Lab":
                    newestData[7] = 3;
                    break;
                case "最终生命控股":
                    newestData[7] = 0;
                    break;
                case "赛博传媒":
                    newestData[7] = 4;
                    break;
                case "环球万事服务":
                    newestData[7] = 1;
                    break;
                default:
                    break;
            }
            newestData[9] = instance.FragmentSectorDesBox.Text;
            newestData[10] = instance.HeroZHNameBox.Text;

            ExcelHelper.AddExcelRow(newestData, newestData.index + 1, true, ExcelPathConst.e_HeroFriendShip.WorkSheets?.GetWorksheet("friendship_hero"), ExcelPathConst.e_HeroFriendShip.PathInfo, ExcelPathConst.e_HeroFriendShip.Package);

        }



        public static void Deploy_Skin()
        {
            var instance = HeroDataFrame.Instance;

            if (instance == null) return;

            int _heroSkinID = LatestSkinID - 1;
            string heroName_ZH = instance.HeroZHNameBox.Text;
            string heroName_EN = instance.HeroENNameBox.Text.ToLower();

            if (ExcelPathConst.e_Skin.WorkSheets == null) return;

            List<RowData> skinDatas = ExcelPathConst.e_Skin.WorkSheets[0].GetRowDatas(6);

            if (skinDatas == null) return;

            var baseSkinID = instance.HeroIDBox.Text.ToInt32() + 2000;
            var startedHeroSkinId = Convert.ToInt32(baseSkinID.ToString() + "00");
            RowData p1Data = skinDatas.Last();

            if (p1Data.ColTexts == null) return;
            //最新ID
            p1Data[0] = _heroSkinID;
            //备注名称(中文
            p1Data[1] = heroName_ZH + "P1";

            //立绘资源名称
            p1Data[2] = heroName_EN;
            //模型资源名称
            p1Data[3] = "";
            //皮肤头像
            p1Data[4] = $"ICON_Item_{instance.HeroIDBox.Text.ToInt32() + 1000}";

            //live2d级别
            p1Data[7] = 0;
            //获得语音提示 不需要这玩意
            p1Data[8] = "";
            p1Data[9] = "";
            p1Data[10] = instance.SkinP1_P2NameBox.Text;
            var skinDes = instance.SkinP1_P2DesBox.Text;
            //处理下转义
            skinDes = skinDes.Replace("\r\n", "\\n");
            p1Data[11] = skinDes;
            //条件参数
            p1Data[12] = "";
            p1Data[13] = "";

            p1Data[14] = 1;
            ///对应速率
            p1Data[16] = Convert.ToSingle(p1Data[16]);
            p1Data[20] = 0;

            ExcelHelper.AddExcelRow(p1Data, p1Data.index + 1, true, ExcelPathConst.e_Skin.WorkSheets?[0], ExcelPathConst.e_Skin.PathInfo, ExcelPathConst.e_Skin.Package);

            var p2Data = p1Data;
            //最新ID
            p2Data[0] = _heroSkinID + 1;
            //备注名称(中文
            p2Data[1] = heroName_ZH + "P2";

            //立绘资源名称
            p2Data[2] = heroName_EN + "_p2";
            //模型资源名称
            p2Data[3] = "";
            //皮肤头像
            p2Data[4] = $"ICON_Item_{_heroSkinID + 1}";

            //live2d级别
            p2Data[7] = 0;
            //获得语音提示 不需要这玩意
            p2Data[8] = "";
            p2Data[9] = "";
            p2Data[10] = instance.SkinP1_P2NameBox.Text;
            //处理下转义
            p2Data[11] = skinDes;
            //条件参数
            p2Data[12] = 502;
            p2Data[13] = 0;

            p2Data[14] = 2;
            ///对应速率
            p2Data[16] = Convert.ToSingle(p1Data[16]);
            p2Data[20] = 0;
            ExcelHelper.AddExcelRow(p2Data, p2Data.index + 2, true, ExcelPathConst.e_Skin.WorkSheets?[0], ExcelPathConst.e_Skin.PathInfo, ExcelPathConst.e_Skin.Package);
            var p3Data = p2Data;
            //最新ID
            p3Data[0] = _heroSkinID + 2;
            //备注名称(中文
            p3Data[1] = heroName_ZH + "P3";

            //立绘资源名称
            p3Data[2] = heroName_EN + "_p3";
            //模型资源名称
            p3Data[3] = "";
            //皮肤头像
            p3Data[4] = $"ICON_Item_{_heroSkinID + 2}";

            //live2d级别
            p3Data[7] = 0;
            //获得语音提示 不需要这玩意
            p3Data[8] = "";
            p3Data[9] = "";
            p3Data[10] = instance.SkinP3NameBox.Text;
            //处理下转义
            p3Data[11] = instance.SkinP3DesBox.Text.Replace("\r\n", "\\n");
            //条件参数
            p3Data[12] = 502;
            p3Data[13] = 0;
            p3Data[14] = 3;
            ///对应速率
            p3Data[16] = Convert.ToSingle(p3Data[16]);
            p3Data[20] = 0;
            ExcelHelper.AddExcelRow(p3Data, p3Data.index + 3, true, ExcelPathConst.e_Skin.WorkSheets?[0], ExcelPathConst.e_Skin.PathInfo, ExcelPathConst.e_Skin.Package);

        }

        public static void Deploy_Protrait()
        {
            var instance = HeroDataFrame.Instance;
            if (instance == null) return;

            var portrait = ExcelPathConst.e_Portrait.WorkSheets?[0].GetRowDatas(6);
            if (portrait == null) return;

            var heroID = instance.HeroIDBox.Text.ToInt32();
            int newestID = 420002 + (heroID - 1000) * 100;
            var lastRow = portrait.Last();
            lastRow[0] = newestID;
            lastRow[1] = instance.HeadIconNameBox.Text;
            lastRow[2] = $"ICON_Item_{newestID}";

            ExcelHelper.AddExcelRow(lastRow, lastRow.index + 1, true, ExcelPathConst.e_Portrait.WorkSheets?[0], ExcelPathConst.e_Portrait.PathInfo, ExcelPathConst.e_Portrait.Package);

        }
        public static void Deploy_OasisBuilding()
        {
            var instance = HeroDataFrame.Instance;
            if (instance == null) return;

            var greetSheet = ExcelPathConst.e_OasisBuildingDorm.WorkSheets?.GetWorksheet("hero_greet").GetRowDatas(6);
            if (greetSheet == null) return;

            var lastRow = greetSheet.Last();
            lastRow[0] = lastRow[0].ToInt32() + 1;
            ExcelHelper.AddExcelRow(lastRow, lastRow.index + 1, true, ExcelPathConst.e_OasisBuildingDorm.WorkSheets?.GetWorksheet("hero_greet"), ExcelPathConst.e_OasisBuildingDorm.PathInfo, ExcelPathConst.e_OasisBuildingDorm.Package);


            var talkSheet = ExcelPathConst.e_OasisBuildingDorm.WorkSheets?.GetWorksheet("hero_talk").GetRowDatas(6);
            if (talkSheet == null) return;

            var lastTalk = talkSheet.Last();
            lastTalk[0] = instance.HeroIDBox.Text.ToInt32();

            string heroENName = instance.HeroENNameBox.Text.ToLower();

            string[] dormList = new string[5] {
                $"dorm_{heroENName}_01",
                $"dorm_{heroENName}_02",
                $"dorm_{heroENName}_03",
                $"dorm_{heroENName}_04",
                $"dorm_{heroENName}_05"};

            string talkList = dormList[0];
            for (int i = 1; i < dormList.Length; i++)
            {
                talkList = string.Concat(talkList, "|" + dormList[i]);
            }
            lastTalk[3] = talkList;
            lastTalk[4] = dormList[0];
            lastTalk[5] = dormList[1];
            lastTalk[6] = dormList[2];
            lastTalk[7] = dormList[3];
            lastTalk[8] = dormList[4];

            ExcelHelper.AddExcelRow(lastTalk, lastTalk.index + 1, true, ExcelPathConst.e_OasisBuildingDorm.WorkSheets?.GetWorksheet("hero_talk"), ExcelPathConst.e_OasisBuildingDorm.PathInfo, ExcelPathConst.e_OasisBuildingDorm.Package);

        }


        public static RowData GetHeroDataByID(int id)
        {
            (ExcelData e_Herodata, _) = ExcelHelper.LoadSPExcel(PathConst.hero_data_ExcelPath);
            e_Herodata.RowDatas = e_Herodata.WorkSheets?.GetWorksheet("hero_data").GetRowDatas(6);
            if (e_Herodata.RowDatas == null) return new RowData();
            return e_Herodata.RowDatas.GetRowById(id);
        }
    }
}
