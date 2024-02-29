using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    internal class PlayerModel
    {
        private static readonly int MoveSpeed = 4;

        private string _image;
        public int PosX { get; private set; }
        public int PosY { get; private set; }
        public int EndPosX { get { return PosX; } }
        public int EndPosY { get { return PosY; } }

        public PlayerModel(string image)
        {
            _image = image;
            setNewRandomPosition();
        }

        public void setNewRandomPosition()
        {
            PosX = 2;
            PosY = 2;
        }
        public void moveUp()
        {
            PosY -= MoveSpeed;
        }
        public void moveDown()
        {
            PosY += MoveSpeed;
        }
        public void moveRight()
        {
            PosX += MoveSpeed;
        }
        public void moveLeft()
        {
            PosX -= MoveSpeed;
        }

        public string toHtml()
        {
            return $@"<div class=""person"" style=""left: {PosX}px; top: {PosY}px;"">
                      <img class=""person-image"" src=""the_man.png"">
                   </div>";

        }
    }
}
