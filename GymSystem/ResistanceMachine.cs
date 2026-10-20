using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace GymSystem
{
    internal class ResistanceMachine : Equipment
    {
        // Private Feilds //
        private int weightStackMax;

        // Public Properties //
        public int WeightStackMax;

        // Default Constuctor //
        public ResistanceMachine()
            : base()
        {
            WeightStackMax = 0;
        }

        // Paramaterised Constructor //
        public ResistanceMachine(string equipmentEqipmentId, string equipmentName, bool equipmentIsAvailable, int equipmentWeightStackMax)
            : base(equipmentEqipmentId, equipmentName, equipmentIsAvailable)
        {
            weightStackMax = equipmentWeightStackMax;
        }

    }
}
