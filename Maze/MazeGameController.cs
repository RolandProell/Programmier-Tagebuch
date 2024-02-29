using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    internal class MazeGameController : WebController
    {
        private MazeGameModel _model = new();
        public MazeGameController() 
            : base("C:\\Users\\roland\\Documents\\schule\\2DHIF\\C#stuff\\Maze\\web")
        {
        }

        public override bool onRequest()
        {
            switch (UrlPath)
            {
                case "/reload":
                    setResponseContent(_model.toHtml());
                    return true;
                case "/restart":
                    _model = new MazeGameModel();
                    setResponseContent(_model.toHtml());
                    return true;
                case "/up":
                    _model.moveMouseUp();
                    setResponseContent(_model.toHtml());
                    return true;
                case "/down":
                    _model.moveMouseDown();
                    setResponseContent(_model.toHtml());
                    return true;
                case "/right":
                    _model.moveMouseRight();
                    setResponseContent(_model.toHtml());
                    return true;
                case "/left":
                    _model.moveMouseLeft();
                    setResponseContent(_model.toHtml());
                    return true;
                case "/stop":
                    setResponseContent("<div>end</div>");
                    return false;
                default:
                    return base.onRequest();
            }
        }
    }
}
