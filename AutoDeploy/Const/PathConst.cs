using AutoDeploy;
using System.Windows.Forms;

namespace HelperTool
{
    public static class PathConst
    {
        public static string RootApplicationPath = Application.StartupPath;

        public static string RootFolder => IntroLogin.Instance.Tex_ExcelPathSetting.Text;

        public static string activity_ExcelPath => $"{RootFolder}\\activity.xlsx";

        public static string battlepass_ExcelPath => $"{RootFolder}\\battlepass.xlsx";

        public static string hero_data_ExcelPath => $"{RootFolder}\\hero_data.xlsx";

        public static string item_ExcelPath => $"{RootFolder}\\item.xlsx";

        public static string pay_ExcelPath => $"{RootFolder}\\pay.xlsx";

        public static string portrait_ExcelPath => $"{RootFolder}\\portrait.xlsx";

        public static string skin_ExcelPath => $"{RootFolder}\\skin.xlsx";

        public static string tip_language_ExcelPath => $"{RootFolder}\\tip_language.xlsx";

        public static string gift_ExcelPath => $"{RootFolder}\\gift.xlsx";

        public static string shop_ExcelPath => $"{RootFolder}\\shop.xlsx";

        public static string sign_acitivity_ExcelPath => $"{RootFolder}\\sign_acitivity.xlsx";

        public static string hero_friendship_ExcelPath => $"{RootFolder}\\hero_friendship.xlsx";

        public static string oasis_building_dorm_ExcelPath => $"{RootFolder}\\oasis_building_dorm.xlsx";

        public static readonly string[] array_BattlePassModePaths = new string[]
        {
            activity_ExcelPath,
            battlepass_ExcelPath,
            hero_data_ExcelPath,
            item_ExcelPath,
            pay_ExcelPath,
            portrait_ExcelPath,
            skin_ExcelPath,
            tip_language_ExcelPath,
            gift_ExcelPath
        };

        public static readonly string[] array_SkinDataModePaths = new string[]
        {
            skin_ExcelPath,
            item_ExcelPath,
            hero_data_ExcelPath,
            shop_ExcelPath
        };

        public static readonly string[] array_HeroDataModePaths = new string[]
        {
            item_ExcelPath,
            hero_data_ExcelPath,
            hero_friendship_ExcelPath,
            skin_ExcelPath,
            portrait_ExcelPath,
            oasis_building_dorm_ExcelPath
        };
    }
}
