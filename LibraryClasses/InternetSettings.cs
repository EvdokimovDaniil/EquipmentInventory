using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentInventory.LibraryClasses
{
    class InternetSettings
    {
        public int SettId;
        public int AddresId;
        public int SubnetMask;
        public int MainGate;
        public int FDNSServer; //Первый ДНС
        public int SDNSServer; //Второй ДНС если надо
        public int TDNSServer; //Третий ну по рофлу
    }
}
