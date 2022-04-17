using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11
{
    public class Clients
    {
        #region Конструкторы

        public Clients()
        {

        }

        /// <summary>
        /// Добавление нового клиента
        /// </summary>
        /// <param name="FirstName">Имя</param>
        /// <param name="LastName">Фамилия</param>
        /// <param name="Patronymic">Отчество</param>
        /// <param name="Phone">Отдел</param>
        /// <param name="PassportId">Оплата труда</param>
        public Clients(string FirstName, string LastName, string Patronymic, string Phone, string PassportId)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
            this.patronymic = Patronymic;
            if (this.Phone!=null)
            {
                this.Phone = Phone;
            }
            this.passportId = PassportId;
        }

        #endregion

        #region Методы


        #endregion

        #region Свойства

        /// <summary>
        /// Имя
        /// </summary>
        public virtual string FirstName { get { return this.firstName; } set { this.firstName = value; } }

        /// <summary>
        /// Фамилия
        /// </summary>
        public virtual string LastName { get { return this.lastName; } set { this.lastName = value; } }

        /// <summary>
        /// Отчество
        /// </summary>
        public virtual  string Patronymic { get { return this.patronymic; } set { this.patronymic = value; } }

        /// <summary>
        /// Номер телефона
        /// </summary>
        public virtual string Phone { get { return this.phone; } set { this.phone = value; } }

        /// <summary>
        /// Номер паспорта
        /// </summary>
        /// 
        public virtual string PassportId { get { return this.passportId; } set { this.passportId = value; } }

        /// <summary>
        /// Почасовая оплата
        /// </summary>
     

        #endregion

        #region Поля

        /// <summary>
        /// Поле "Имя"
        /// </summary>
        private string firstName;

        /// <summary>
        /// Поле "Фамилия"
        /// </summary>
        private string lastName;

        /// <summary>
        /// Поле "Отчество"
        /// </summary>
        private string patronymic;

        /// <summary>
        /// Поле "Номер телефона"
        /// </summary>
        /// 
        private string phone;

        /// <summary>
        /// Поле "Серия и номер паспорта"
        /// </summary>
        private string passportId;

        #endregion
    }
}
