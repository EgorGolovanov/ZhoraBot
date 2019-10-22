using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolApplication.DataBase.Interface
{
    /// <summary>
    /// интерфейс, который описывает контент (файлы, картинки и тд.)
    /// </summary>
    public interface IContent
    {
        /// <summary>
        /// идентификатор
        /// </summary>
        Guid Id { get; set; }
        /// <summary>
        /// название файла контента
        /// </summary>
        string FileName { get; set; }
        /// <summary>
        /// путь к файлу контента
        /// </summary>
        string File { get; set; }
    }
}
