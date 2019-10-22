using System;
using System.Collections.Generic;
using System.Text;

namespace ZhoraBot.Repository
{
    /// <summary>
    /// интерфейс репозитория
    /// </summary>
    /// <typeparam name="TEntity"> класс, описывающий таблицу базы данных </typeparam>
    interface IRepository<TEntity> : IDisposable
        where TEntity : class
    {
        /// <summary>
        /// функция получения всех объектов таблицы
        /// </summary>
        /// <returns> перечисление объектов таблицы TEntity </returns>
        IEnumerable<TEntity> GetAll();
        /// <summary>
        /// функция получения объекта по его идентификатору
        /// </summary>
        /// <param name="id"> идентификатор искомого объекта </param>
        /// <returns></returns>
        TEntity Get(Guid id);
        /// <summary>
        /// функция создания объекта
        /// </summary>
        /// <param name="item"> объект для создания </param>
        void Create(TEntity item);
        /// <summary>
        /// функция обновления состояния объекта
        /// </summary>
        /// <param name="item"> объект для обновления </param>
        void Update(TEntity item);
        /// <summary>
        /// функция удаления объекта по его идентификатору
        /// </summary>
        /// <param name="id"> идентификатор объекта для удаления </param>
        void Delete(Guid id);
        /// <summary>
        /// функция сохранения изменений
        /// </summary>
        void Save();
    }
}
