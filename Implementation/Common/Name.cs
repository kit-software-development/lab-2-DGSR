using System.Text;

namespace Practice.Common
{
    /// <summary>
    ///     Скрытая реализация представления об имени человека.
    /// </summary>
    internal struct Name : IName
    {
        /*
         * TODO #1: Реализуйте интерфейс IName для структуры Name
         */
        /// <summary>
        ///     Имя.
        /// </summary>
        public string FirstName { get; set; }
        
        /// <summary>
        ///     Фамилия.
        /// </summary>
        public string Surname { get; set; }
        
        /// <summary>
        ///     Отчество.
        /// </summary>
        public string Patronymic { get; set; }
        
        public string FullName
        {
            get
            {
                return string.Join(" ", Surname, FirstName,Patronymic);
            }
        }
        public string ShortName
        {
            get
            {
                return new StringBuilder()
                    .Append(Surname)
                    .Append(' ')
                    .Append(FirstName[0])
                    .Append('.')
                    .Append(Patronymic[0])
                    .Append('.')
                    .ToString();
            }
        }
    }
}
