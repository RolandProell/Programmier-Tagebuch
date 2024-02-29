namespace Maze
{
    public class WebController : HttpController
    {
        private static readonly string DefaultFile = "/startmenu.html";

        public string WebRoot { get; init; }

        public WebController(string webRoot)
        {
            WebRoot = webRoot;
        }

        public override bool onRequest()
        {
            string file = getFile();
            if (File.Exists(file))
            {
                byte[] fileContent = File.ReadAllBytes(file);
                Response.OutputStream.Write(fileContent);
            }
            else
            {
                Response.StatusCode = 404;
            }
            return true;
        }

        private string getFile()
        {
            if ((UrlPath == null) || (UrlPath == "") || (UrlPath == "/"))
            {
                return WebRoot + DefaultFile;
            }
            return WebRoot + UrlPath;
        }
    }
}
