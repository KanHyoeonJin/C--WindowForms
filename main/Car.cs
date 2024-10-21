using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace main1
{
    public class Car
    {
        public string Name { get; set; }
        public Button CarButton { get; set; } // 각 차에 연결된 버튼
        public Point Position { get; set; }   // 현재 위치
        public Size Size { get; set; }        // 차 크기 (예: 1x2, 1x3)
        public bool IsHorizontal { get; set; } // 수평 또는 수직 방향

        public Car(string name, Button carButton, Point position, Size size, bool isHorizontal)
        {
            Name = name;
            CarButton = carButton;
            Position = position;
            Size = size;
            IsHorizontal = isHorizontal;
        }
    }
}
