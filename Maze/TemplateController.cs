namespace Maze
{
    internal class TemplateController : WebController
    {
        private TemplateModel _model = new TemplateModel();
        public TemplateController() : base("C:\\Users\\roland\\Documents\\schule\\2DHIF\\C#stuff\\Maze\\web")
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
                    _model = new TemplateModel();
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
