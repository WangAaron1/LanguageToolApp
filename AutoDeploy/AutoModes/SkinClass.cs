using HelperTool;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AutoDeployExcelDataForDesigner.Scripts.AutoModes
{
    public class SkinClass
    {
        static int LatestSkinID;
        static string skinName_ZH;
        public static void DeploySkinData(int _heroID, string skinName, string skinDes, string __, string ___, int live2Level, bool haveMovie)
        {
            if (SkinFrame.Instance == null) return;
            if (skinName == null) skinName = "";
            if (skinDes == null) skinDes = "";
            int _heroSkinID = LatestSkinID;
            string[] skinName_ZHEN = skinName.Split('_');
            skinName_ZH = String.Empty;
            string skinName_EN = String.Empty;
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

            if (ExcelPathConst.e_Skin.WorkSheets == null) return;
            List<RowData> skinDatas = ExcelPathConst.e_Skin.WorkSheets[0].GetRowDatas(6);


            if (skinDatas == null) return;
            var baseSkinID = _heroID + 2000;
            var startedHeroSkinId = Convert.ToInt32(baseSkinID.ToString() + "00");
            RowData itemsData = skinDatas.GetMaxNum(baseSkinID, startedHeroSkinId);

            ///获取英雄名称
            if (ExcelPathConst.e_Herodata.WorkSheets == null) return;
            RowData heroData = ExcelPathConst.e_Herodata.WorkSheets[0].GetRowByID(_heroID);

            int newestHeroSkinID = itemsData[0].ToInt32() + 1;
            if (itemsData.ColTexts == null) return;
            //最新ID
            itemsData[0] = newestHeroSkinID;
            //备注名称(中文
            itemsData[1] = $"{heroData[1]}_{SkinFrame.Instance.textBox1.Text}";

            ///事多,,,发现资源名称不是完全按照角色的英文命名来的
            var characterResourceEN = itemsData[2].ToString().Split('_')[0];
            //立绘资源名称
            itemsData[2] = $"{characterResourceEN}_{skinName_EN}";
            //模型资源名称
            itemsData[3] = $"{characterResourceEN}_{skinName_EN}";
            //皮肤头像
            itemsData[4] = $"ICON_Item_{newestHeroSkinID}";

            //live2d级别
            itemsData[7] = live2Level;
            //获得语音提示 不需要这玩意
            itemsData[8] = "";
            itemsData[9] = haveMovie ? "1" : "";
            itemsData[10] = skinName_ZH;
            itemsData[11] = skinDes;
            //条件参数
            itemsData[12] = 610;
            itemsData[13] = 701 + "_" + 702;

            //Theme工作簿 
            List<RowData> themeDatas = ExcelPathConst.e_Skin.WorkSheets[1].GetRowDatas(6);
            if (themeDatas == null) return;
            int newestThemeData = themeDatas[themeDatas.Count - 1][0].ToInt32() + 1;

            itemsData[14] = newestThemeData;
            ///对应速率
            itemsData[16] = Convert.ToSingle(itemsData[16]);

            ///在添加Skin列之前需要先加Theme
            ExcelHelper.AddExcelRow(itemsData, itemsData.index + 1, true, ExcelPathConst.e_Skin.WorkSheets[0], ExcelPathConst.e_Skin.PathInfo, ExcelPathConst.e_Skin.Package);
        }

        public static void DeployTheme()
        {
            if (SkinFrame.Instance == null) return;
            if (ExcelPathConst.e_Skin.WorkSheets == null) return;
            //Theme工作簿 
            List<RowData> themeDatas = ExcelPathConst.e_Skin.WorkSheets[1].GetRowDatas(6);
            if (themeDatas == null) return;
            RowData themedata = themeDatas[themeDatas.Count - 1];
            int newestThemeData = themeDatas[themeDatas.Count - 1][0].ToInt32() + 1;

            ///主题 跟着Theme表的ID走

            themedata[0] = newestThemeData;
            themedata[1] = SkinFrame.Instance.SkinBoxName.Text;
            themedata[2] = "SkinTheme" + themedata[0].ToInt32().ToString();
            themedata[4] = SkinFrame.Instance.SkinBoxDes.Text;
            themedata[6] = SkinFrame.Instance.SkinTip.Text;

            ExcelHelper.AddExcelRow(themedata, themedata.index + 1, true, ExcelPathConst.e_Skin.WorkSheets[1], ExcelPathConst.e_Skin.PathInfo, ExcelPathConst.e_Skin.Package);
        }

        public static void DeployItem(int _heroID, string skinName, string skinDes, string skinprice, string achieveDes, int _, bool _______________)
        {
            try
            {
                if (skinName == null) skinName = "";
                if (skinDes == null) skinDes = "";
                if (achieveDes == null) achieveDes = "";
                if (skinprice == null) skinprice = "58";

                int _baseHeroSkinID = _heroID + 2000;
                string _heroSkinID = _baseHeroSkinID.ToString() + "01";
                int _realId = Convert.ToInt32(_heroSkinID);

                if (ExcelPathConst.e_Item.WorkSheets == null) return;

                List<RowData> itemsData = ExcelPathConst.e_Item.WorkSheets[0].GetRowDatas(6);

                if (itemsData == null) return;

                RowData biggestData = itemsData.GetMaxNum(_baseHeroSkinID, _realId);

                if (biggestData.ColTexts == null) return;

                var biggestID = Convert.ToInt32(biggestData[0]);
                int newestHeroSkinID = biggestID + 1;

                ///设置全局皮肤ID
                LatestSkinID = biggestData[0].ToInt32() + 1;

                biggestData[0] = LatestSkinID;
                biggestData[1] = skinName.Split('_')[0];
                biggestData[4] = skinDes;
                biggestData[6] = $"ICON_Item_{biggestData[0]}";
                biggestData[17] = biggestData[0];

                switch (Convert.ToInt32(skinprice))
                {
                    case 58:
                        biggestData[19] = "5800_5800_5800_580_10_1_5800_580_58_1000";
                        break;
                    case 68:
                        biggestData[19] = "6800_6800_6800_680_10_1_6800_680_68_1000";
                        break;
                    case 78:
                        biggestData[19] = "7800_7800_7800_780_10_1_7800_780_78_1000";
                        break;
                    default:
                        break;
                }

                biggestData[22] = achieveDes;
                ExcelHelper.AddExcelRow(biggestData, biggestData.index + 1, true, ExcelPathConst.e_Item.WorkSheets[0], ExcelPathConst.e_Item.PathInfo, ExcelPathConst.e_Item.Package);


            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        public static void DeployHeroData(int _heroID, string _, string __, string ___, string _____, int ______, bool ____________)
        {
            RowData heroData = HeroDataClass.GetHeroDataByID(_heroID);
            string skinData = (string)heroData[5];
            if (skinData == null) return;
            string[] split = skinData.Split('_');
            List<string> skinIDs = new List<string>(split);
            string needSkinID = LatestSkinID.ToString();
            if (needSkinID == null) return;
            skinIDs.Add(needSkinID);

            if (skinIDs == null) return;
            needSkinID = skinIDs[0];
            for (int i = 1; i < skinIDs.Count; i++)
            {
                needSkinID += $"_{skinIDs[i]}";
            }
            //string needSkinID = "_" + battlePassFrame.HeroSkinID.Text;
            if (needSkinID != null)
                heroData[5] = needSkinID;

            if (needSkinID == null) return;

            ExcelHelper.SetCell(needSkinID, heroData.index, 6, ExcelPathConst.e_Herodata.WorkSheets.GetWorksheet("hero_data"), ExcelPathConst.e_Herodata.PathInfo, ExcelPathConst.e_Herodata.Package);
        }


        public static void DeployShopData(int _heroID, string skinName, string skinDes, string ___, string _____, int ______, bool ____________)
        {
            //ExcelData e_shop = ExcelPathConst.e_Shop;

            //if (SkinFrame.Instance == null) return;

            //List<RowData> shopDatas = e_shop.WorkSheets[3].GetRowDatas(6);

            //if (shopDatas == null) return;
            //if (skinDes == null) return;

            //RowData start701 = shopDatas.GetRowById(701);
            //RowData end701 = shopDatas.GetMaxID(1, start701.index - 6);

            //long startTime = TimeTipCaculateTool.DataTimeToTimestamp(SkinFrame.Instance.monthSelectMode1.ActivityTimeStart);
            //long endTime = TimeTipCaculateTool.DataTimeToTimestamp(SkinFrame.Instance.monthSelectMode1.ActivityTimeEnd);

            //if (startTime < 0) startTime = -1;

            //end701[1] = end701[1].ToInt32() + 1;
            //end701[3] = LatestSkinID + "=1";
            //end701[4] = skinName_ZH;
            //end701[10] = startTime;
            //end701[11] = endTime;
            //end701[13] = end701[13].ToInt32() + 1;

            //RowData start702 = shopDatas.GetRowById(702);
            //RowData end702 = shopDatas.GetMaxID(1, start702.index - 6);

            //end702[1] = end702[1].ToInt32() + 1;
            //end702[3] = LatestSkinID + "=1";
            //end702[4] = skinName_ZH;
            //end702[10] = startTime;
            //end702[11] = endTime;
            //end702[13] = end702[13].ToInt32() + 1;

            //ExcelHelper.AddExcelRow(end701, end701.index + 1, true, e_shop.WorkSheets[3], e_shop.PathInfo, e_shop.Package);
            //ExcelHelper.AddExcelRow(end702, end702.index + 2, true, e_shop.WorkSheets[3], e_shop.PathInfo, e_shop.Package);

        }
    }


}