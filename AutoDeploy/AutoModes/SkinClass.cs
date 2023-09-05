using HelperTool;
using System;
using System.Collections.Generic;

namespace AutoDeployExcelDataForDesigner.Scripts.AutoModes
{
    public class SkinClass
    {
        static int LatestSkinID;
        static string skinName_ZH;

        public static string CheckDuplicate(int id)
        {
            return string.Empty;
        }


        public static void DeploySkinData(int _heroID, string skinName, string skinDes, string __, string ___, int live2Level, bool haveMovie)
        {
            string[] skinName_ZHEN = skinName.Split('_');
            skinName_ZH = string.Empty;
            string skinName_EN = string.Empty;
            if (skinName_ZHEN.Length == 1)
            {
                skinName_ZH = skinName_ZHEN[0];
                skinName_EN = "";
            }
            else if (skinName_ZHEN[0] != "" && skinName_ZHEN[1] != "")
            {
                skinName_ZH = skinName_ZHEN[0];
                skinName_EN = skinName_ZHEN[1];
            }

            var skinSheet = ExcelPathConst.e_Skin.WorkSheets[0];
            List<RowData> skinDatas = skinSheet.GetRowDatas(6);
            var skinHeader = skinSheet.GetHeaderDic();

            var baseSkinID = _heroID + 2000;
            var startedHeroSkinId = Convert.ToInt32(baseSkinID.ToString() + "00");
            RowData itemsData = skinDatas.GetMaxNum(baseSkinID, startedHeroSkinId);

            ///获取英雄名称
            RowData heroData = ExcelPathConst.e_Herodata.WorkSheets[0].GetRowByID(_heroID);

            int newestHeroSkinID = itemsData[0].ToInt32() + 1;
            //最新ID
            itemsData[skinHeader["id"]] = newestHeroSkinID;
            //备注名称(中文
            itemsData[skinHeader["#"]] = $"{skinHeader["#"]}_{SkinFrame.Instance.textBox1.Text}";

            ///事多,,,发现资源名称不是完全按照角色的英文命名来的
            var characterResourceEN = itemsData[skinHeader["src_id_pic"]].ToString().Split('_')[0];
            //立绘资源名称
            itemsData[skinHeader["src_id_pic"]] = $"{characterResourceEN}_{skinName_EN}";
            //模型资源名称
            itemsData[skinHeader["src_id_model"]] = $"{characterResourceEN}_{skinName_EN}";
            //皮肤头像
            itemsData[skinHeader["src_id_icon"]] = $"ICON_Item_{newestHeroSkinID}";

            //live2d级别
            itemsData[skinHeader["live2d_level"]] = live2Level;
            //获得语音提示 不需要这玩意
            itemsData[skinHeader["skin_avg"]] = "";
            itemsData[skinHeader["has_skill_movie"]] = haveMovie ? "1" : "";
            itemsData[skinHeader["name"]] = skinName_ZH;
            itemsData[skinHeader["describe"]] = skinDes;
            //条件参数
            itemsData[skinHeader["condition"]] = 610;
            itemsData[skinHeader["condition_para"]] = 701 + "_" + 702;

            //Theme工作簿 
            var themeSheet = ExcelPathConst.e_Skin.WorkSheets["theme"];
            List<RowData> themeDatas = themeSheet.GetRowDatas(6);
            if (themeDatas == null) return;
            int newestThemeData = themeDatas[themeDatas.Count - 1][0].ToInt32() + 1;

            itemsData[skinHeader["theme"]] = newestThemeData;
            ///对应速率
            itemsData[skinHeader["speed"]] = Convert.ToSingle(skinHeader["speed"]);

            ///在添加Skin列之前需要先加Theme
            ExcelHelper.AddExcelRow(itemsData, itemsData.index + 1, true, ExcelPathConst.e_Skin.WorkSheets[0], ExcelPathConst.e_Skin.PathInfo, ExcelPathConst.e_Skin.Package);
        }

        public static void DeployTheme()
        {
            if (SkinFrame.Instance == null) return;
            if (ExcelPathConst.e_Skin.WorkSheets == null) return;
            //Theme工作簿 
            var themeSheet = ExcelPathConst.e_Skin.WorkSheets["theme"];
            List<RowData> themeDatas = themeSheet.GetRowDatas(6);
            var themeHeader = themeSheet.GetHeaderDic();
            if (themeDatas == null) return;
            RowData themedata = themeDatas[themeDatas.Count - 1];
            int newestThemeData = themeDatas[themeDatas.Count - 1][0].ToInt32() + 1;

            ///主题 跟着Theme表的ID走
            themedata[themeHeader["id"]] = newestThemeData;
            themedata[themeHeader["name"]] = SkinFrame.Instance.SkinBoxName.Text;
            themedata[themeHeader["pic"]] = "SkinTheme" + themedata[0].ToInt32().ToString();
            themedata[themeHeader["theme_info"]] = SkinFrame.Instance.SkinBoxDes.Text;
            themedata[themeHeader["#1"]] = SkinFrame.Instance.SkinTip.Text;

            ExcelHelper.AddExcelRow(themedata, themedata.index + 1, true, ExcelPathConst.e_Skin.WorkSheets[1], ExcelPathConst.e_Skin.PathInfo, ExcelPathConst.e_Skin.Package);
        }

        public static void DeployItem(int _heroID, string skinName, string skinDes, string skinprice, string achieveDes, int _, bool _______________)
        {
            if (skinName == null) skinName = "";
            if (skinDes == null) skinDes = "";
            if (achieveDes == null) achieveDes = "";
            if (skinprice == null) skinprice = "58";

            int _baseHeroSkinID = _heroID + 2000;
            string _heroSkinID = _baseHeroSkinID.ToString() + "01";
            int _realId = Convert.ToInt32(_heroSkinID);

            var itemSheet = ExcelPathConst.e_Item.WorkSheets["item"];
            List<RowData> itemsData = itemSheet.GetRowDatas(6);
            var itemHeader = itemSheet.GetHeaderDic();

            RowData biggestData = itemsData.GetMaxNum(_baseHeroSkinID, _realId);

            if (biggestData.ColTexts == null) return;

            var biggestID = Convert.ToInt32(biggestData[0]);
            int newestHeroSkinID = biggestID + 1;

            ///设置全局皮肤ID
            LatestSkinID = biggestData[0].ToInt32() + 1;

            biggestData[itemHeader["id"]] = LatestSkinID;
            biggestData[itemHeader["name"]] = skinName.Split('_')[0];
            biggestData[itemHeader["describe"]] = skinDes;
            biggestData[itemHeader["icon"]] = $"ICON_Item_{biggestData[0]}";
            biggestData[itemHeader["arg"]] = biggestData[itemHeader["id"]];
            string price = string.Empty;
            switch (Convert.ToInt32(skinprice))
            {
                case 58:
                    price = "5800_5800_5800_580_10_1_5800_580_58_1000";
                    break;
                case 68:
                    price = "6800_6800_6800_680_10_1_6800_680_68_1000";
                    break;
                case 78:
                    price = "7800_7800_7800_780_10_1_7800_780_78_1000";
                    break;
                default:
                    break;
            }
            biggestData[itemHeader["currency_price"]] = price;
            biggestData[itemHeader["achieve_des"]] = achieveDes;
            ExcelHelper.AddExcelRow(biggestData, biggestData.index + 1, true, ExcelPathConst.e_Item.WorkSheets[0], ExcelPathConst.e_Item.PathInfo, ExcelPathConst.e_Item.Package);
        }

        public static void DeployHeroData(int _heroID, string _, string __, string ___, string _____, int ______, bool ____________)
        {
            var heroSheet = ExcelPathConst.e_Herodata.WorkSheets["hero_data"];
            var heroData = heroSheet.GetRowByID(_heroID);
            var heroHeader = heroSheet.GetHeaderDic();
            string skinData = (string)heroData[heroHeader["skin"]];
            if (skinData == null) return;
            string[] split = skinData.Split('_');
            List<string> skinIDs = new List<string>(split);
            string needSkinID = LatestSkinID.ToString();
            skinIDs.Add(needSkinID);

            needSkinID = skinIDs[0];
            for (int i = 1; i < skinIDs.Count; i++)
            {
                needSkinID += $"_{skinIDs[i]}";
            }
            ExcelHelper.SetCell(needSkinID, heroData.index, heroHeader["skin"] + 1, ExcelPathConst.e_Herodata.WorkSheets["hero_data"], ExcelPathConst.e_Herodata.PathInfo, ExcelPathConst.e_Herodata.Package);
        }

        public static void DeployShopData(int _heroID, string skinName, string skinDes, string ___, string _____, int ______, bool ____________)
        {
            var shopSheet = ExcelPathConst.e_Shop.WorkSheets["shop_normal"];
            var shopDatas = shopSheet.GetRowDatas(6);
            var shopHeader = shopSheet.GetHeaderDic();

            RowData start701 = shopDatas.GetRowById(701);
            RowData end701 = shopDatas.GetMaxID(1, start701.index - 6);

            long startTime = TimeTipCaculateTool.DataTimeToTimestamp(SkinFrame.Instance.monthSelectMode1.ActivityTimeStart);
            long endTime = TimeTipCaculateTool.DataTimeToTimestamp(SkinFrame.Instance.monthSelectMode1.ActivityTimeEnd);

            if (startTime < 0) startTime = -1;

            end701[shopHeader["goods_shelves"]] = end701[shopHeader["goods_shelves"]].ToInt32() + 1;
            end701[shopHeader["item"]] = LatestSkinID + "=1";
            end701[shopHeader["#"]] = skinName_ZH;
            end701[shopHeader["pre_para1"]] = startTime;
            end701[shopHeader["pre_para2"]] = endTime;
            end701[shopHeader["order"]] = end701[shopHeader["order"]].ToInt32() + 1;

            RowData start702 = shopDatas.GetRowById(702);
            RowData end702 = shopDatas.GetMaxID(1, start702.index - 6);

            end702[shopHeader["goods_shelves"]] = end702[shopHeader["goods_shelves"]].ToInt32() + 1;
            end702[shopHeader["item"]] = LatestSkinID + "=1";
            end702[shopHeader["#"]] = skinName_ZH;
            end702[shopHeader["pre_para1"]] = startTime;
            end702[shopHeader["pre_para2"]] = endTime;
            end702[shopHeader["order"]] = end702[shopHeader["order"]].ToInt32() + 1;

            ExcelHelper.AddExcelRow(end701, end701.index + 1, true, shopSheet, ExcelPathConst.e_Shop.PathInfo, ExcelPathConst.e_Shop.Package);
            ExcelHelper.AddExcelRow(end702, end702.index + 2, true, shopSheet, ExcelPathConst.e_Shop.PathInfo, ExcelPathConst.e_Shop.Package);

        }
    }


}