using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    internal class MazeGameModel
    {
        public static readonly int PlaygroundWidth = 500;
        public static readonly int PlaygroundHeight = 500;

        private PlayerModel _player = new("the_man.png");
        private MazeModel _mazeModel = new();

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
            return "\n" + _mazeModel.toHtml() + "\n" + _player.toHtml() + "\n";
        }
    }
}
