using System.Net;
using System.Text;

namespace Maze
{
    public abstract class HttpController
    {
        public HttpListenerContext Context { get; set; }
        public HttpListenerRequest Request { get { return Context.Request; } }
        public HttpListenerResponse Response { get { return Context.Response; } }
        public string UrlPath { get { return Request.Url.AbsolutePath; } }

        public abstract bool onRequest();

        protected string getRequestContent()
        {
            StreamReader contentReader = new StreamReader(Request.InputStream, Request.ContentEncoding);
            string content = contentReader.ReadToEnd();
            contentReader.Close();
            Request.InputStream.Close();
            return content;
        }
        protected void setResponseContent(string content)
        {
            byte[] contentBuffer = Encoding.UTF8.GetBytes(content);
            Response.OutputStream.Write(contentBuffer);
        }
    }
}
