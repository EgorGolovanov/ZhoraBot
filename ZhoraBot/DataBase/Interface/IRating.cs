using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolApplication.DataBase.Interface
{
    /// <summary>
    /// интерфейс описывающий рейтинговую таблицу 
    /// </summary>
    /// <typeparam name="T"> наследуемый класс интерфейса IUser</typeparam>
    public interface IRating<T> where T : IUser
    {
        /// <summary>
        /// идентификатор
        /// </summary>
        Guid Id { get; set; }
        /// <summary>
        /// список пользователей, находящихся в рейтинговой таблице
        /// </summary>
        List<T> RatingList { get; set; }
        /// <summary>
        /// позиция в рейтинге
        /// </summary>
        int PositionOfRating { get; set; }
    }
}
