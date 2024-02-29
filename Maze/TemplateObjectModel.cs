
namespace Maze
{
    internal class TemplateObjectModel
    {
        private static readonly int InitSize = 16;
        private static readonly int MoveSpeed = 4;

        private readonly Random _random = new Random();
        private string _image;
        public int PosX { get; private set; }
        public int PosY { get; private set; }
        public int Size { get; private set; }
        public int EndPosX { get { return PosX + Size; } }
        public int EndPosY { get { return PosY + Size; } }

        public TemplateObjectModel(string image)
        {
            _image = image;
            setNewRandomPosition();
        }

        public void setNewRandomPosition()
        {
            Size = InitSize;
            PosX = _random.Next(Size, TemplateModel.PlaygroundWidth - (Size * 2));
            PosY = _random.Next(Size, TemplateModel.PlaygroundHeight - (Size * 2));
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
        public bool hasColisionWith(TemplateObjectModel other)
        {
            return (this.PosX < other.EndPosX) && (other.PosX < this.EndPosX) && (this.PosY < other.EndPosY) && (other.PosY < this.EndPosY);
        }
        public void eat(TemplateObjectModel other)
        {
            this.Size += other.Size;
        }
        public string toHtml()
        {
            return $"<img src=\"{_image}\" style=\"width: {Size}px; height: {Size}px; top: {PosY}px; left: {PosX}px;\" />";
        }
        public string ToString()
        {
            return $"{_image}: PosX={PosX}, EndPosX={EndPosX}, PosY={PosY}, EndPosY={EndPosY}, Size={Size}";
        }
    }
}
