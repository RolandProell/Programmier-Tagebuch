using System.Net;

namespace Maze
{
    public class HttpServer
    {
        private HttpListener _listener = new HttpListener();
        public void run(HttpController controller)
        {
            start();
            bool running = true;
            while (running)
            {
                running = handleRequest(controller);
            }
            stop();
        }
        private void start()
        {
            _listener.Prefixes.Add("http://localhost:8080/");
            _listener.Start();
        }
        private bool handleRequest(HttpController controller)
        {
            HttpListenerContext context = _listener.GetContext();
            controller.Context = context;
            bool keepRunning = controller.onRequest();
            context.Response.Close();
            return keepRunning;
        }
        private void stop()
        {
            _listener.Stop();
        }
    }
}
