namespace AutoDeployExcelDataForDesigner.Scripts.FactoryCenter
{
    public class BaseFactory
    {
        public delegate void BeaginDeploy();
        public static BeaginDeploy FramBeginDeploy;

        public delegate void EndDeploy();
        public static EndDeploy FrameEndDepoly;
    }
}
