using HelperTool;
using OfficeOpenXml;
using System;
using System.Collections.Generic;

namespace AutoDeployExcelDataForDesigner.Scripts.AutoModes
{

    /// <summary>
    /// 解决策划配置问题
    /// TODO = BP配置 
    /// TODO = CharacterInfo配置
    /// </summary>
    public class BattlePassClass
    {
        //BattlePass 所需数据

        //需要加载表
        //activity
        //battlepass
        //hero_data
        //item
        //pay
        //portrait
        //skin
        //tip_language
        //gift
        //shop


        public static void DeployBattlePass()
        {
            if (ExcelPathConst.e_BattlePass.WorkSheets is null) return;
            ExcelWorksheet s_battlepass = ExcelPathConst.e_BattlePass.WorkSheets.GetWorksheet("battlepass");
            ExcelWorksheet s_battlepassid = ExcelPathConst.e_BattlePass.WorkSheets.GetWorksheet("battlepassid");
            BattlePassFrame battlePassFrame = BattlePassFrame.Instance;
            if (s_battlepassid is null) return;
            var headerRow = s_battlepassid.GetHeaderDic();
            List<RowData> idWorkSheetData = s_battlepassid.GetRowDatas(6);

            if (idWorkSheetData is null) return;
            RowData LastData = idWorkSheetData[idWorkSheetData.Count - 1];
            RowData beforeData = idWorkSheetData[idWorkSheetData.Count - 2];

            ///自定义Time
            LastData[headerRow["id"]] = Convert.ToUInt32(LastData[0]) + 1;
            if (battlePassFrame?.HeroID.Text == "") battlePassFrame.HeroID.Text = "1001";
            RowData heroData = HeroDataClass.GetHeroDataByID(Convert.ToInt32(battlePassFrame?.HeroID.Text));

            LastData[headerRow["describe2"]] = $"达到对应等级可解锁{heroData[1]}的<Color=#bbd41e>「唤醒系列」心智投影、高级检索指令、石英砂</color>等丰厚奖励";

            LastData[headerRow["banner"]] = Convert.ToInt32(BattlePassFrame.Instance?.BPHeroSkinID.Text);

            for (int i = headerRow["price"]; i <= headerRow["ultimate_price"]; i++)
            {

                LastData[i] = beforeData[i];
                beforeData[i] = "";
            }
            string ultimate_reward = $"11=1000|{battlePassFrame?.HeadIconIDBox.Text}=1|5009=4|{battlePassFrame?.InfoPageIDBox.Text}=1|{battlePassFrame?.FunitureID.Text}=1";
            LastData[headerRow["ultimate_reward"]] = ultimate_reward;
            LastData[headerRow["supply_reward"]] = ultimate_reward;

            if (beforeData.ColTexts.ToString() == null) return;
            LastData[headerRow["supply_price"]] = beforeData[headerRow["supply_price"]];
            beforeData[headerRow["supply_price"]] = "";

            LastData[headerRow["tips_desc"]] = 333;

            ExcelHelper.AddExcelRow(beforeData, 4 + idWorkSheetData.Count, false, s_battlepassid, ExcelPathConst.e_BattlePass.PathInfo, ExcelPathConst.e_BattlePass.Package);
            ExcelHelper.AddExcelRow(LastData, 6 + idWorkSheetData.Count, true, s_battlepassid, ExcelPathConst.e_BattlePass.PathInfo, ExcelPathConst.e_BattlePass.Package);

            var rewardHeader = s_battlepass.GetHeaderDic();
            List<RowData> rewardWorkSheetData = s_battlepass.GetRowDatas(6);
            if (rewardWorkSheetData == null) return;
            //需要复制的数据
            List<RowData> needCopyDatas = s_battlepass.GetRowDatas(rewardWorkSheetData.Count - 44);

            int battlePassId = Convert.ToInt32(rewardWorkSheetData?[rewardWorkSheetData.Count - 1][0]) + 1;

            for (int i = 0; i < needCopyDatas?.Count; i++)
            {

                needCopyDatas[i].ColTexts[0] = battlePassId;
                if (i == 9)
                {
                    needCopyDatas[i].ColTexts[rewardHeader["senior_item"]] = $"{battlePassFrame?.BPHeroSkinID.Text}=1|3001=1";
                }
            }

            if (s_battlepass == null) return;
            int addRows = s_battlepass.Dimension.Rows + 1;

            ExcelHelper.AddExcelRows(needCopyDatas, addRows, true, s_battlepass, ExcelPathConst.e_BattlePass.PathInfo, ExcelPathConst.e_BattlePass.Package);

        }

        public static void DeployActivity()
        {
            BattlePassFrame battlePassFrame = BattlePassFrame.Instance;

            if (battlePassFrame == null)
            {
                return;
            }

            if (ExcelPathConst.e_Activity.WorkSheets == null)
            {
                return;
            }


            var actSheet = ExcelPathConst.e_Activity.WorkSheets.GetWorksheet("activity_1");
            var actHeader = actSheet.GetHeaderDic();
            RowData data = actSheet.GetRowData(actSheet.Dimension.Rows);

            if (data.ColTexts == null)
            {
                return;
            }
            var idCol = actHeader["id"];
            var actidCol = actHeader["activity_id"];
            var startTimeCol1 = actHeader["start_time"];
            var startTimeCol2 = actHeader["end_time"];
            var endTimeCol1 = actHeader["rewardStart_time"];
            var endTimeCol2 = actHeader["rewardEnd_time"];

            data[idCol] = Convert.ToInt32(data[idCol]) + 1;
            data[actidCol] = Convert.ToInt32(data[actidCol]) + 1;

            //StartTime
            var startTimeMark = TimeTipCaculateTool.DataTimeToTimestamp(battlePassFrame.ActivityTimeStart);
            var endTimeMark = TimeTipCaculateTool.DataTimeToTimestamp(battlePassFrame.ActivityTimeEnd);
            data[startTimeCol1] = startTimeMark;
            data[startTimeCol2] = endTimeMark;

            //EndTime
            data[endTimeCol1] = startTimeMark;
            data[endTimeCol2] = endTimeMark;

            var endTime = battlePassFrame.ActivityTimeEnd;
            var startTime = battlePassFrame.ActivityTimeStart;

            data[actSheet.Dimension.Columns - 1] = $"battle-pass，通关1-4解锁，第{Convert.ToInt32(data[2]) - 1}期，{startTime:yyyy-MM-dd hh:mm:ss}到{endTime:yyyy-MM-dd hh:mm:ss}";

            ExcelHelper.AddExcelRow(data, actSheet, ExcelPathConst.e_Activity.PathInfo, ExcelPathConst.e_Activity.Package);
        }


        public static void DeployHeroData()
        {
            RowData heroData = HeroDataClass.GetHeroDataByID(Convert.ToInt32(BattlePassFrame.Instance?.HeroID.Text));
            BattlePassFrame battlePassFrame = BattlePassFrame.Instance;

            var dataHeader = ExcelPathConst.e_Herodata.WorkSheets.GetWorksheet("hero_data").GetHeaderDic();

            string skinData = (string)heroData[dataHeader["skin"]];
            if (skinData == null) return;
            string[] split = skinData.Split('_');
            List<string> skinIDs = new List<string>(split);
            if (battlePassFrame?.BPHeroSkinID == null) return;
            string needSkinID = battlePassFrame.BPHeroSkinID.Text;
            if (needSkinID == null) return;
            skinIDs?.Add(needSkinID);

            if (skinIDs == null) return;
            needSkinID = skinIDs[dataHeader["id"]];
            for (int i = 1; i < skinIDs?.Count; i++)
            {
                needSkinID += $"_{skinIDs[i]}";
            }
            //string needSkinID = "_" + battlePassFrame?.HeroSkinID.Text;
            if (needSkinID != null)
                heroData[dataHeader["skin"]] = needSkinID;

            if (needSkinID == null) return;
            ExcelHelper.SetCell(needSkinID, heroData.index, 6, ExcelPathConst.e_Herodata.WorkSheets?.GetWorksheet("hero_data"), ExcelPathConst.e_Herodata.PathInfo, ExcelPathConst.e_Herodata.Package);

        }

        public static void DeployProtrait()
        {
            var frameBook = ExcelPathConst.e_Portrait.WorkSheets?.GetWorksheet("portrait_frame");
            var frameBookHeader = frameBook.GetHeaderDic();
            var frameData = frameBook.GetRowDatas(6);
            if (frameData == null) return;
            var lastData = frameData[frameData.Count - 1];
            var activity = ExcelPathConst.e_Activity.WorkSheets?[0].GetRowDatas();
            if (activity == null) return;
            int newestID = Convert.ToInt32(activity[activity.Count - 1][2]) - 1;
            lastData[frameBookHeader["id"]] = Convert.ToInt32(lastData[frameBookHeader["id"]]) + 1;
            lastData[frameBookHeader["name"]] = $"BP{newestID}";
            lastData[frameBookHeader["icon"]] = $"UsertHeadFrame_{lastData.index - 6}";
            lastData[frameBookHeader["type"]] = 3;
            lastData[frameBookHeader["type_name"]] = "麦戈拉通行栈";
            lastData[frameBookHeader["achieve"]] = 3;
            lastData[frameBookHeader["achieve_name"]] = "激活多信道通行栈Plus获得";


            var cardBook = ExcelPathConst.e_Portrait.WorkSheets?.GetWorksheet("portrait_card");
            var cardHeader = cardBook.GetHeaderDic();
            var cardData = cardBook.GetRowDatas(6);
            if (cardData == null) return;
            var lastCardData = cardData[cardData.Count - 1];

            lastCardData[cardHeader["id"]] = Convert.ToInt32(cardData[cardData.Count - 1][0]) + 1;
            lastCardData[cardHeader["name"]] = $"BP{newestID}";
            lastCardData[cardHeader["icon"]] = $"UserInfo_{lastCardData.index - 5}";

            ExcelHelper.AddExcelRow(lastData, frameBook, ExcelPathConst.e_Portrait.PathInfo, ExcelPathConst.e_Portrait.Package);
            ExcelHelper.AddExcelRow(lastCardData, cardBook, ExcelPathConst.e_Portrait.PathInfo, ExcelPathConst.e_Portrait.Package);

        }

        public static void DeployItem()
        {
            BattlePassFrame winInfo = BattlePassFrame.Instance;
            int _heroID = Convert.ToInt32(winInfo.HeroID.Text);
            int _baseHeroSkinID = _heroID + 2000;
            string _heroSkinID = _baseHeroSkinID.ToString() + "01";
            int _realId = Convert.ToInt32(_heroSkinID);

            var itemSheet = ExcelPathConst.e_Item.WorkSheets.GetWorksheet("item");
            var itemHeader = itemSheet.GetHeaderDic();
            List<RowData> itemsData = itemSheet.GetRowDatas(6);
            if (itemsData == null) return;
            RowData biggestData = itemsData.GetMaxNum(_baseHeroSkinID, _realId);
            if (biggestData.ColTexts == null) return;
            var biggestID = Convert.ToInt32(biggestData[0]);
            int newestHeroSkinID = biggestID + 1;

            biggestData[itemHeader["id"]] = newestHeroSkinID;
            biggestData[itemHeader["name"]] = winInfo.BPSkinNameBox.Text;
            biggestData[itemHeader["describe"]] = winInfo.BPSkinDesBox.Text;
            biggestData[itemHeader["icon"]] = $"ICON_Item_{biggestData[0]}";
            biggestData[itemHeader["arg"]] = biggestData[itemHeader["id"]];
            biggestData[itemHeader["achieve_des"]] = "";
            ExcelHelper.AddExcelRow(biggestData, biggestData.index + 1, true, ExcelPathConst.e_Item.WorkSheets?[0], ExcelPathConst.e_Item.PathInfo, ExcelPathConst.e_Item.Package);

            //——————————头像框————————————
            itemsData = itemSheet.GetRowDatas(6);
            RowData biggestHeadFrameData = itemsData.GetMaxNum(400, 400001);
            if (biggestHeadFrameData.ColTexts == null) return;
            var biggestHeadFrameID = Convert.ToInt32(biggestHeadFrameData[0]);
            int newestHeadFrameID = biggestHeadFrameID + 1;


            biggestHeadFrameData[itemHeader["id"]] = newestHeadFrameID;
            biggestHeadFrameData[itemHeader["name"]] = winInfo.HeadIconNameBox.Text;
            biggestHeadFrameData[itemHeader["describe"]] = winInfo.HeadIconDesBox.Text;
            biggestHeadFrameData[itemHeader["icon"]] = $"UsertHeadFrame_{Convert.ToInt32(biggestHeadFrameData[itemHeader["id"]]) - 400001}";
            biggestHeadFrameData[itemHeader["achieve_des"]] = "激活多信道通行栈Plus获得";
            ExcelHelper.AddExcelRow(biggestHeadFrameData, biggestHeadFrameData.index + 1, true, ExcelPathConst.e_Item.WorkSheets?[0], ExcelPathConst.e_Item.PathInfo, ExcelPathConst.e_Item.Package);

            //——————————资料页———————————— 
            List<RowData> InfoData = itemSheet.GetRowDatas(6);
            RowData biggestInfoData = InfoData.GetMaxNum(410, 410001);
            if (biggestInfoData.ColTexts == null) return;
            var biggestInfoID = Convert.ToInt32(biggestInfoData[0]);
            int newestInfoID = biggestInfoID + 1;

            biggestInfoData[itemHeader["id"]] = newestInfoID;
            biggestInfoData[itemHeader["name"]] = winInfo.InfoPageNameBox.Text;
            biggestInfoData[itemHeader["describe"]] = winInfo.InfoPageDesBox.Text;
            biggestInfoData[itemHeader["icon"]] = $"UserInfo_{Convert.ToInt32(biggestInfoData[0]) - 410001}";
            biggestInfoData[itemHeader["achieve_des"]] = "激活多信道通行栈Plus获得";
            ExcelHelper.AddExcelRow(biggestInfoData, biggestInfoData.index + 1, true, ExcelPathConst.e_Item.WorkSheets?[0], ExcelPathConst.e_Item.PathInfo, ExcelPathConst.e_Item.Package);

            //——————————家具———————————— 
            List<RowData> funitureData = itemSheet.GetRowDatas(6);
            RowData biggestfunitureData = funitureData.GetMaxNum(721, 721001);
            if (biggestfunitureData.ColTexts == null) return;
            var biggestfunitureID = Convert.ToInt32(biggestfunitureData[0]);
            int newestfunitureID = biggestfunitureID + 1;

            biggestfunitureData[itemHeader["id"]] = newestfunitureID;
            biggestfunitureData[itemHeader["name"]] = winInfo.FurnitureNameBox.Text;
            biggestfunitureData[itemHeader["describe"]] = winInfo.FurnitureDesBox.Text;
            biggestfunitureData[itemHeader["icon"]] = $"ICON_furniture_{Convert.ToInt32(biggestfunitureData[0]) - 720000}";
            biggestfunitureData[itemHeader["achieve_des"]] = "激活多信道通行栈Plus获得";
            ExcelHelper.AddExcelRow(biggestfunitureData, biggestfunitureData.index + 1, true, ExcelPathConst.e_Item.WorkSheets?[0], ExcelPathConst.e_Item.PathInfo, ExcelPathConst.e_Item.Package);

        }

        public static void DeploySkinData()
        {
            int _heroID = Convert.ToInt32(BattlePassFrame.Instance?.HeroID.Text);
            int _heroSkinID = Convert.ToInt32(BattlePassFrame.Instance?.BPHeroSkinID.Text);
            if (BattlePassFrame.Instance == null) return;
            int activityLatestId = BattlePassFrame.Instance.ActivityLatestID + 1;

            if (ExcelPathConst.e_Skin.WorkSheets == null) return;
            var skinSheet = ExcelPathConst.e_Skin.WorkSheets.GetWorksheet("skin");
            var skinHeader = skinSheet.GetHeaderDic();
            List<RowData> skinDatas = skinSheet.GetRowDatas(6);

            if (skinDatas == null) return;
            RowData itemsData = skinDatas.GetMaxNum(_heroID + 2000, Convert.ToInt32((_heroID + 2000).ToString() + "00"));

            ///获取英雄名称
            if (ExcelPathConst.e_Herodata.WorkSheets == null) return;
            RowData heroData = ExcelPathConst.e_Herodata.WorkSheets[0].GetRowByID(_heroID);

            if (itemsData.ColTexts == null) return;
            itemsData[skinHeader["id"]] = _heroSkinID;
            itemsData[skinHeader["#"]] = $"{heroData[1]}_BP";
            var srcName = $"{heroData[2].ToString()?.ToLower()}_open";
            itemsData[skinHeader["src_id_pic"]] = srcName;
            itemsData[skinHeader["src_id_model"]] = srcName;
            itemsData[skinHeader["src_id_icon"]] = $"ICON_Item_{_heroSkinID}";

            //获得语音提示 BP不需要这玩意
            itemsData[skinHeader["skin_avg"]] = "";
            itemsData[skinHeader["has_skill_movie"]] = "";
            itemsData[skinHeader["name"]] = BattlePassFrame.Instance.BPSkinNameBox.Text;
            itemsData[skinHeader["describe"]] = BattlePassFrame.Instance.BPSkinDesBox.Text;
            itemsData[skinHeader["condition"]] = 2301;
            itemsData[skinHeader["condition_para"]] = activityLatestId;
            itemsData[skinHeader["theme"]] = 5;
            itemsData[skinHeader["备注帧数"]] = Convert.ToDouble(skinHeader["备注帧数"]);

            ExcelHelper.AddExcelRow(itemsData, itemsData.index + 1, true, ExcelPathConst.e_Skin.WorkSheets?[0], ExcelPathConst.e_Skin.PathInfo, ExcelPathConst.e_Skin.Package);

            ///特殊处理
            (ExcelPathConst.e_Skin, _) = ExcelHelper.LoadSPExcel(PathConst.skin_ExcelPath);
            skinDatas = ExcelPathConst.e_Skin.WorkSheets?[0].GetRowDatas(6);

            RowData beforeData = new RowData();
            RowData nextData = new RowData();

            if (skinDatas == null) return;
            for (int i = 0; i < skinDatas.Count; i++)
            {
                var num = skinDatas[i][13].ToString();
                if (num == null) return;
                if (!num.StartsWith("10")) continue;
                var activitys = num?.Split('_');

                if (activitys?.Length == 1) continue;
                if (activitys?.Length == 2) beforeData = skinDatas[i];
            }
            for (int i = 0; i < skinDatas.Count; i++)
            {
                var num = skinDatas[i][13].ToString();
                if (num == null) return;
                if (!num.StartsWith("10")) continue;
                var activitys = num?.Split('_');
                var targets = beforeData[13].ToString()?.Split('_');
                if (activitys?[0].ToInt32() == targets?[0].ToInt32() + 1)
                {
                    nextData = skinDatas[i];
                }
            }
            nextData[13] = string.Concat(nextData[13], "_" + activityLatestId + "|703");

            ExcelHelper.SetCell("2301|610", nextData.index, 13, ExcelPathConst.e_Skin.WorkSheets?[0], ExcelPathConst.e_Skin.PathInfo, ExcelPathConst.e_Skin.Package);
            ExcelHelper.SetCell(nextData[13], nextData.index, 14, ExcelPathConst.e_Skin.WorkSheets?[0], ExcelPathConst.e_Skin.PathInfo, ExcelPathConst.e_Skin.Package);

            string beforeActivityID = beforeData[13].ToString()?.Split('|')[0];
            if (beforeActivityID == null) return;
            beforeActivityID = String.Concat(beforeActivityID, $"_{activityLatestId}|703");
            ExcelHelper.SetCell(beforeActivityID, beforeData.index, 14, ExcelPathConst.e_Skin.WorkSheets?[0], ExcelPathConst.e_Skin.PathInfo, ExcelPathConst.e_Skin.Package);

        }
        public static void DeployPayData()
        {
            ExcelWorksheet s_battlepassid = ExcelPathConst.e_BattlePass.WorkSheets?.GetWorksheet("battlepassid");
            ExcelWorksheet s_payProduct = ExcelPathConst.e_Pay.WorkSheets.GetWorksheet("pay_product");
            var payHeader = s_payProduct.GetHeaderDic();
            var battleHeader = s_battlepassid.GetHeaderDic();
            List<RowData> idWorkSheetData = s_battlepassid.GetRowDatas(6);
            RowData LastData = idWorkSheetData[idWorkSheetData.Count - 1];
            var paraIndex = payHeader["para"];
            int newestID = Convert.ToInt32(LastData[0]);
            if (LastData[19].ToInt32() == 100201)
            {
                ExcelHelper.SetCell(newestID, s_payProduct.GetRowByID(100201).index, paraIndex, ExcelPathConst.e_Pay.WorkSheets[0], ExcelPathConst.e_Pay.PathInfo, ExcelPathConst.e_Pay.Package);
                ExcelHelper.SetCell(newestID, s_payProduct.GetRowByID(100203).index, paraIndex, ExcelPathConst.e_Pay.WorkSheets[0], ExcelPathConst.e_Pay.PathInfo, ExcelPathConst.e_Pay.Package);
                ExcelHelper.SetCell(newestID, s_payProduct.GetRowByID(100204).index, paraIndex, ExcelPathConst.e_Pay.WorkSheets[0], ExcelPathConst.e_Pay.PathInfo, ExcelPathConst.e_Pay.Package);
            }
            else if (LastData[19].ToInt32() == 100205)
            {
                ExcelHelper.SetCell(newestID, s_payProduct.GetRowByID(100205).index, paraIndex, ExcelPathConst.e_Pay.WorkSheets[0], ExcelPathConst.e_Pay.PathInfo, ExcelPathConst.e_Pay.Package);
                ExcelHelper.SetCell(newestID, s_payProduct.GetRowByID(100206).index, paraIndex, ExcelPathConst.e_Pay.WorkSheets[0], ExcelPathConst.e_Pay.PathInfo, ExcelPathConst.e_Pay.Package);
                ExcelHelper.SetCell(newestID, s_payProduct.GetRowByID(100207).index, paraIndex, ExcelPathConst.e_Pay.WorkSheets[0], ExcelPathConst.e_Pay.PathInfo, ExcelPathConst.e_Pay.Package);
            }
        }

        /// <summary>
        /// 废弃逻辑 改用333之后不用修改了
        /// </summary>
        public static void DeployTipData()
        {
            //DateTime endDataTime = BattlePassFrame.Instance.ActivityTimeEnd;
            //var endTime = endDataTime.ToString("yyyy/MM/dd hh:mm:ss");
            //
            //var battlepassSheet = ExcelPathConst.e_BattlePass.WorkSheets?.GetWorksheet("battlepassid");
            //var battlepassHeader = battlepassSheet.GetHeaderDic();
            //List<RowData> rows = battlepassSheet.GetRowDatas(6);
            //var tipsID = rows[rows.Count - 1][battlepassHeader["tips_desc"]];
            //
            //var tipSheet1 = ExcelPathConst.e_TipLanguage.WorkSheets.GetWorksheet("Sheet1");
            //var tipsHeader = tipSheet1.GetHeaderDic();
            //var tips = tipSheet1.GetRowDatas(6);
            //RowData bpTip = tips.GetRowById(Convert.ToInt32(tipsID));
            //var colText = bpTip[tipsHeader["content"]];
            //var match = colText.ToString();
            //var realText = Regex.Replace(match, @"\d+/\d+/\d+ \d+:\d+:\d+", endTime.ToString());
            //ExcelHelper.AddExcelRow(realText, bpTip.index, 4, ExcelPathConst.e_TipLanguage.WorkSheets?[0], ExcelPathConst.e_TipLanguage.PathInfo, ExcelPathConst.e_TipLanguage.Package);
        }

        public static void DeployShopData()
        {
            var instance = BattlePassFrame.Instance;
            if (instance == null) return;
            var shopSheet = ExcelPathConst.e_Shop.WorkSheets?.GetWorksheet("shop_resource");
            var shopHeader = shopSheet.GetHeaderDic();
            List<RowData> rows = shopSheet.GetRowDatas(6);
            if (rows == null) return;

            var start703 = rows.GetRowById(703);
            var max703 = rows.GetMaxID(1, start703.index - 6);
            max703[shopHeader["goods_shelves"]] = max703[1].ToInt32() + 1;
            max703[shopHeader["item"]] = instance.BPHeroSkinID.Text + "=1";
            max703[shopHeader["pre_para1"]] = TimeTipCaculateTool.DataTimeToTimestamp(instance.ActivityTimeStart);
            max703[shopHeader["pre_para2"]] = TimeTipCaculateTool.DataTimeToTimestamp(instance.ActivityTimeNextEnd);
            ExcelHelper.AddExcelRow(max703, max703.index + 1, true, ExcelPathConst.e_Shop.WorkSheets?.GetWorksheet("shop_resource"), ExcelPathConst.e_Shop.PathInfo, ExcelPathConst.e_Shop.Package);

        }
        public static void DeployGift()
        {
            List<RowData> rows = ExcelPathConst.e_Gift.WorkSheets?.GetWorksheet("gift_type").GetRowDatas(6);
            if (rows == null) return;
            RowData newestData = rows.GetRowById(119);
            RowData beforeData = rows.GetRowById(120);

            (ExcelPathConst.e_Activity, _) = ExcelHelper.LoadSPExcel(PathConst.activity_ExcelPath);
            List<RowData> activityRows = ExcelPathConst.e_Activity.WorkSheets?.GetWorksheet("activity_1").GetRowDatas(6);

            List<RowData> s_battlepassid = ExcelPathConst.e_BattlePass.WorkSheets?.GetWorksheet("battlepassid").GetRowDatas(6);

            if (activityRows == null) return;
            if (s_battlepassid == null) return;

            var newestTime = activityRows[activityRows.Count - 1][8];
            var newestTime2 = activityRows[activityRows.Count - 1][9];

            if (newestTime == null || newestTime2 == null) return;

            if (s_battlepassid[s_battlepassid.Count - 1][16].ToInt32() == 120)
            {
                //120
                ExcelHelper.SetCell(newestTime.ToInt64(), beforeData.index, 7, ExcelPathConst.e_Gift.WorkSheets?[1], ExcelPathConst.e_Gift.PathInfo, ExcelPathConst.e_Gift.Package);
                ExcelHelper.SetCell(newestTime2.ToInt64(), beforeData.index, 8, ExcelPathConst.e_Gift.WorkSheets?[1], ExcelPathConst.e_Gift.PathInfo, ExcelPathConst.e_Gift.Package);

            }
            else if (s_battlepassid[s_battlepassid.Count - 1][16].ToInt32() == 119)
            {
                //119
                ExcelHelper.SetCell(newestTime.ToInt64(), newestData.index, 7, ExcelPathConst.e_Gift.WorkSheets?[1], ExcelPathConst.e_Gift.PathInfo, ExcelPathConst.e_Gift.Package);
                ExcelHelper.SetCell(newestTime2.ToInt64(), newestData.index, 8, ExcelPathConst.e_Gift.WorkSheets?[1], ExcelPathConst.e_Gift.PathInfo, ExcelPathConst.e_Gift.Package);

            }

        }
    }
}
