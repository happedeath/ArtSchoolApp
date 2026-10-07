using System;

namespace ArtSchoolApp
{
    /// <summary>
    /// Основной класс программы. Вариант 23: Художественная школа.
    /// Объект: Ученик.
    /// </summary>
    public class Studentq
    {
        // 3 свойства, как требуется в задании
        public string FullName { get; set; }   // ФИО ученика
        public int Age { get; set; }           // Возраст
        public string CourseName { get; set; } // Название курса (например, "Масляная живопись")

        // Переопределяем ToString, чтобы объект красиво отображался в ListBox
        public override string ToString()
        {
            return $"{FullName} | Возраст: {Age} | Курс: {CourseName}";
        }
    }
}