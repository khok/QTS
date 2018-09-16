﻿using System.Collections.Generic;

namespace QTS.Core
{
    /// <summary>
    /// Интерфейс для объекта, который можно рассматривать как график.
    /// </summary>
    public interface IGraph
    {
        /// <summary>
        /// Название графика
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// Начинает создание новой линии
        /// </summary>
        void BeginLine();

        /// <summary>
        /// Заканчивает создание линии
        /// </summary>
        void CompleteLine(bool randomColor = true);

        /// <summary>
        /// Добавляет точку в текущую линию
        /// </summary>
        void AddPoint(double y, double x);

        void AddPoints(IEnumerable<double> yValues, double minX);

        /// <summary>
        /// Конвертирует график в PNG-изображение
        /// </summary>
        /// <returns></returns>
        void ExportToBitmap(bool betterHieghts, string path);
    }
}
