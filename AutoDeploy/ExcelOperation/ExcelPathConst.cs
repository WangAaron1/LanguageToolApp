using Sunny.UI;
using System.Collections.Generic;

namespace HelperTool
{
    public static class ExcelPathConst
    {
        public static List<ExcelData> ExcelList = new List<ExcelData>();
        public static ExcelData e_BattlePass;
        public static ExcelData e_Activity;
        public static ExcelData e_Herodata;
        public static ExcelData e_Item;
        public static ExcelData e_Pay;
        public static ExcelData e_Portrait;
        public static ExcelData e_Skin;
        public static ExcelData e_TipLanguage;
        public static ExcelData e_Gift;
        public static ExcelData e_Shop;
        public static ExcelData e_HeroFriendShip;
        public static ExcelData e_OasisBuildingDorm;
        public static string _error { get; set; }
        public static string Error
        {
            get
            {
                return _error;
            }
            set
            {
                if (_error.IsNullOrEmpty())
                {
                    _error = value;
                    return;
                }
                string.Concat(_error, value);
            }
        }

        public static string LoadAllExcelData()
        {
            ExcelList.Clear();
            _error = string.Empty;

            (e_Shop, Error) = ExcelHelper.LoadSPExcel(PathConst.shop_ExcelPath);
            (e_BattlePass, Error) = ExcelHelper.LoadSPExcel(PathConst.battlepass_ExcelPath);
            (e_Activity, Error) = ExcelHelper.LoadSPExcel(PathConst.activity_ExcelPath);
            (e_Herodata, Error) = ExcelHelper.LoadSPExcel(PathConst.hero_data_ExcelPath);
            (e_Item, Error) = ExcelHelper.LoadSPExcel(PathConst.item_ExcelPath);
            (e_Pay, Error) = ExcelHelper.LoadSPExcel(PathConst.pay_ExcelPath);
            (e_Portrait, Error) = ExcelHelper.LoadSPExcel(PathConst.portrait_ExcelPath);
            (e_Skin, Error) = ExcelHelper.LoadSPExcel(PathConst.skin_ExcelPath);
            (e_TipLanguage, Error) = ExcelHelper.LoadSPExcel(PathConst.tip_language_ExcelPath);
            (e_Gift, Error) = ExcelHelper.LoadSPExcel(PathConst.gift_ExcelPath);
            (e_HeroFriendShip, Error) = ExcelHelper.LoadSPExcel(PathConst.hero_friendship_ExcelPath);
            (e_OasisBuildingDorm, Error) = ExcelHelper.LoadSPExcel(PathConst.oasis_building_dorm_ExcelPath);

            return Error;
        }
        public static void DisposeAllExcel()
        {
            var nullable = new ExcelData();
            e_Shop = nullable;
            e_BattlePass = nullable;
            e_Activity = nullable;
            e_Herodata = nullable;
            e_Item = nullable;
            e_Pay = nullable;
            e_Portrait = nullable;
            e_Skin = nullable;
            e_TipLanguage = nullable;
            e_Gift = nullable;
            e_HeroFriendShip = nullable;
            e_OasisBuildingDorm = nullable;
        }
    }
}
