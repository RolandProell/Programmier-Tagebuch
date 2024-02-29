
namespace Maze
{
    internal class TemplateModel
    {
        public static readonly int PlaygroundWidth = 500;
        public static readonly int PlaygroundHeight = 500;
        public static readonly int WonSize = 128;

        private PlayerModel _player = new("the_man.png");

        public void moveMouseUp()
        {
            _player.moveUp();
        }
        public void moveMouseDown()
        {
            _player.moveDown();
        }
        public void moveMouseRight()
        {
            _player.moveRight();
        }
        public void moveMouseLeft()
        {
            _player.moveLeft();
        }
        

        public string toHtml()
        {
            
            return "\n" + _player.toHtml() + "\n";
        }
    }
}
