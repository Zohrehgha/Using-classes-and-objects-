using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class EngineClass
    {//step 1 : Create some in Class Variables
     // in class Variables are almost always private
        private int CNoofcylanders;
        private int CVolumeCC;
        private bool CEnginetype;
        private int CTorque;
        private int CHorsepower;
        //Step 2: Implementing default constructor
        public EngineClass()  // Implementing "Default" constructor 
        { //default constructor is the one that has no arguments

        }
        //Step 2: Implementing overloaded constructors
        //OPTIONAL
        public EngineClass(int VNoofcylanders, int VVolumeCC, bool VEnginetype, int VTorque, int VHorsepower)
        {
            CNoofcylanders = VNoofcylanders;
            CVolumeCC = VVolumeCC;
            CEnginetype = VEnginetype;
            CTorque = VTorque;
            CHorsepower = VHorsepower;
        }
        //Step 2: Copy Constructor
        public EngineClass(EngineClass right)
        {
            this.CNoofcylanders = right.GetNoofcylanders();
            this.CVolumeCC = right.GetVolumeCC();
            this.CEnginetype = right.GetEnginetype();
            this.CTorque = right.GetTorque();
            this.CHorsepower = right.GetHorsepower();
        }

        //Step 3: Creating access functions
        public int GetNoofcylanders()
        {
            return CNoofcylanders;
        }
        public void SetNoofcylanders(int VNoofcylanders)
        {
            CNoofcylanders = VNoofcylanders;
        }
        public int GetVolumeCC()
        {
            return CVolumeCC;
        }
        public void SetVolumeCC(int VVolumeCC)
        {
            CVolumeCC = VVolumeCC;
        }
        public bool GetEnginetype()
        {
            return CEnginetype;
        }
        public void SetEnginetype(bool VEnginetype)
        {
            CEnginetype = VEnginetype;
        }
        public int GetTorque()
        {
            return CTorque;
        }
        public void SetTorque(int VTorque)
        {
            CTorque = VTorque;
        }
        public int GetHorsepower()
        {
            return CHorsepower;
        }
        public void SetHorsepower(int VHorsepower)
        {
            CHorsepower = VHorsepower;
        }

        public string MakeString()
        {

            string temp;
            temp = "";
            temp = temp + "Noofcylanders=" + CNoofcylanders;
            temp = temp + "\nVolumeCC =" + CVolumeCC;
            temp = temp + "\nEnginetype=" + CEnginetype;
            temp = temp + "\nTorque=" + CTorque;
            temp = temp + "\nHorsepower=" + CHorsepower;
            return temp;
        }
    }
}
