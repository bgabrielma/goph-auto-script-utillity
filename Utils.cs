using System.Drawing;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;

namespace DOPScript
{
    public static class Utils
    {
        private static WebClient webClient;
        private static readonly string WEB_HABBO_LOGO_URL = "https://www.habbo.com.br/habbo-imaging/avatarimage?img_format=gif&user={0}&action=crr=6&direction=2&head_direction=2&gesture=std&size=l&headonly=1";
        private static readonly string WEB_HEADERS = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)";
        public static readonly float MIN_SPEED = 4f;
        public static readonly float MAX_SPEED = 10f;
        public static async Task<(Bitmap, bool)> getHabboLogoImage(string _nickname = null)
        {

            return await Task.Run(() =>
            {
                bool isValid = true;
                Bitmap _habboImage = null;

                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                webClient = new WebClient();
                webClient.Headers
                    .Add("user-agent", WEB_HEADERS);

                try
                {
                    var blobImage = string.Format(WEB_HABBO_LOGO_URL, _nickname);

                    _habboImage = new Bitmap(webClient.OpenRead(blobImage));
                }
                catch (WebException e)
                {
                    if (e.Status == WebExceptionStatus.ProtocolError && (((HttpWebResponse)e.Response).StatusCode == HttpStatusCode.NotFound))
                    {
                        isValid = false;
                    }
                }
                return (_habboImage, isValid);
            });
        }
        public static string formatSpecialLineCharacters(string line) =>
            line.Replace("+", "{+}")
                .Replace("^", "{^}")
                .Replace("%", "{%}")
                .Replace("~", "{~}")
                .Replace("(", "{(}")
                .Replace(")", "{)}")
                .Replace("[", "{[}")
                .Replace("]", "{]}");
        public static string getProgramAssembleVersion() => Assembly.GetExecutingAssembly().GetName().Version.ToString();
    }
}
