using Maze;

Console.WriteLine("start");
Console.WriteLine("open WebBrowser: http://localhost:8080");

HttpServer server = new HttpServer();
server.run(new MazeGameController());

Console.WriteLine("stop");

