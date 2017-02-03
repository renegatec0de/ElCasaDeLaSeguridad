using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    public interface IPerson
    {
        bool EnterHouse(EntranceWay throughThisEntrance);

        bool EnterHouse(House house);

        bool LeaveHouseNow();

        bool LeaveHouse(TimeSpan waitTimeBeforeLeave);

    }

    public interface ISuspectPerson : IPerson
    {
        bool TryBreakIntoHouse(House house, )

    }

    public interface ITrustablePerson : IPerson
    {
        void AcceptAlarmCodeFromOwner(string alarmSecurityCode);

        bool HasAcessToSecurityAlarm { get;  set; }
    }


    public interface IHouseOwner
    {
        void InviteGuests(List<IPerson> group);

   
        bool TurnAlarmSerurityOn(string securitypim, TimeSpan howLong);

        void ShareAlarmSecurityCode(string securityCode, IPerson aPerson)

    }

    public class Owner
    {
        protected readonly House house = null;

        protected readonly Dictionary<EntranceWay, Key> keySet = null;

        /// <summary>
        /// Overloaded constructor (means that whoever calls to create a new object                                                          
        /// </summary>
        /// <param name="house"></param>
        /// <param name="keySet"></param>
        public Owner(House house, Dictionary<EntranceWay, Key> keySet)
        {
            this.house = house;
            this.keySet = keySet;

        }

    }
}
;;