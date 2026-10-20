using System;
using System.Collections.Generic;
using System.Text;

namespace GymSystem
{
    internal class Equipment
    {
        // Private Feilds //
        private string equipmentID;
        private string name;
        private bool isAvailable;

        // Public Properties // 
        public string EquipmentID
        {
            get { return equipmentID; }
            set { equipmentID = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public bool IsAvailable
        {
            get { return isAvailable; }
            set { isAvailable = value; }
        }

        // Default Constructor //
        public Equipment()
        {
            equipmentID = "";
            name = "";
            isAvailable = false;
        }
        // Paramaterised Constructor //
        public Equipment(string equipmentEqipmentId, string equipmentName, bool equipmentIsAvailable)
        {
            equipmentID = equipmentEqipmentId;
            name = equipmentName;
            isAvailable= equipmentIsAvailable;
        }

    }
}
