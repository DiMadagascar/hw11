using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11
{
    public class Consultant:Clients
    {

        public Consultant()
        {

        }

        public Consultant(string FirstName, string LastName, string Patronymic, string Phone, string PassportId)
            :base (FirstName,  LastName,  Patronymic,  Phone,  PassportId)
        {
           
        }

        /// <summary>
        /// Консультант видит звездочки вместо номера паспорта
        /// </summary>
        public override string PassportId { get { return "**********"; } }
        /// <summary>
        /// Имя
        /// </summary>
        public override string FirstName { get { return this.FirstName; } }

        /// <summary>
        /// Фамилия
        /// </summary>
        public override string LastName { get { return this.LastName; } }

        /// <summary>
        /// Отчество
        /// </summary>
        public override string Patronymic { get { return this.Patronymic; } }
    }
}

