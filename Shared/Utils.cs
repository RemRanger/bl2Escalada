namespace bl2Escalada
{
    public enum ApiKind { read, write };

    public class Utils
    {
        const string rootUrl = "https://www.remranger.com/escalada-api";
        public static string GetApiUrl(string apiName, ApiKind kind)
        {
            return $"{rootUrl}/{apiName}-{kind}.php";
        }
        public static string GetResultPic(int? result)
        {
            return result switch
            {
                0 => "images/result-fail.png",
                1 => "images/result-faults.png",
                2 => "images/result-success.png",
                _ => null,
            };
        }
    }
}
