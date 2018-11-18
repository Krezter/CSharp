using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle.Models
{
    class Cell
    {
        public string Status { get; set; }
        /// <summary>
        /// Статус клетки на текущий момент
        /// </summary>
        /// <param name="status">Хранит информацию о состоянии клетки (корабль, попадание мимо, подбитый корабль, море)</param>
        public Cell(string status)
        {
            Status = status;
        }
        /// <summary>
        /// Просмотр статуса клетки
        /// </summary>
        public void View()
        {
            Console.Write($" {Status}");
        }
    }
}
