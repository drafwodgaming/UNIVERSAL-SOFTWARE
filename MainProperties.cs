using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNIVERSALSOFTWARE
{
    public static class MainProperties // Класс свойства главное формы
    {
        static bool DraggingBool { get; set; } // Перемещение выключено
        static Point DragCursorPoint { get; set; } // Позиция курсора мышки
        static Point DragFormPoint { get; set; }// Позиция формы

        public static async void OpenProgramEffect()
        {
            for (MainWindow.Main.OpacTY = 0; MainWindow.Main.OpacTY < .96; MainWindow.Main.OpacTY += .09) { await Task.Delay(5); }
        }
        public static async void CloseProgramEffect()
        {
            for (; MainWindow.Main.OpacTY > 0; MainWindow.Main.OpacTY -= .06) await Task.Delay(5);
            if (MainWindow.Main.OpacTY == 0) Application.Exit();
        }

        public static void DragWindow()
        {
            MainWindow.Main.MouseDown += (s, a) => { DraggingBool = true; DragCursorPoint = Cursor.Position; DragFormPoint = MainWindow.Main.Location; };
            MainWindow.Main.MouseMove += (s, a) => {if (DraggingBool) { Point dif = Point.Subtract(Cursor.Position, new Size(DragCursorPoint));
            MainWindow.Main.Location = Point.Add(DragFormPoint, new Size(dif)); } };
            MainWindow.Main.MouseUp += (s, a) => { DraggingBool = false; };
        }
    }
}
