using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class CarClass
    {//step 1 : Create some in Class Variables
     // in class Variables are almost always private
        private int CVIN;
        private string CMake;
        private string CModel;
        private string CColor;
        private int CYearbuilt;
        private EngineClass CCarEngine;
        //Step 2: Implementing default constructor
        public CarClass()  // Implementing "Default" constructor 
        { //default constructor is the one that has no arguments

        }
        //Step 2: Implementing overloaded constructors
        //OPTIONAL
        public CarClass(int VVIN, String VMake, string VModel, string VColor, int VYearbuilt, EngineClass VCarEngine)
        {
            CVIN = VVIN;
            CMake = VMake;
            CModel = VModel;
            CColor = VColor;
            CYearbuilt = VYearbuilt;
            CCarEngine = VCarEngine;
        }
        //Step 2: Copy Constructor
        public CarClass(CarClass right)
        {
            this.CVIN = right.GetVIN();
            this.CMake = right.GetMake();
            this.CModel = right.GetModel();
            this.CColor = right.GetColor();
            this.CYearbuilt = right.GetYearbuilt();
            this.CCarEngine = right.GetCarEngine();
        }
        //Step 3: Creating access functions
        public int GetVIN()
        {
            return CVIN;
        }
        public void SetVIN(int VVIN)
        {
            CVIN = VVIN;
        }
        public String GetMake()
        {
            return CMake;
        }
        public void SetMake(String VMake)
        {
            CMake = VMake;
        }
        public String GetModel()
        {
            return CModel;
        }
        public void SetModel(String VModel)
        {
            CModel = VModel;
        }
        public string GetColor()
        {
            return CColor;
        }
        public void SetColor(string VColor)
        {
            CColor = VColor;
        }
        public int GetYearbuilt()
        {
            return CYearbuilt;
        }
        public void SetYearbuilt(int VYearbuilt)
        {
            CYearbuilt = VYearbuilt;
        }
        public EngineClass GetCarEngine()
        {
            return CCarEngine;
        }
        public void SetCarEngine(EngineClass VCarEngine)
        {
            CCarEngine = VCarEngine;
        }

        public string MakeString()
        {

            string temp;
            temp = "";
            temp = temp + "VIN=" + CVIN;
            temp = temp + "\nMake =" + CMake;
            temp = temp + "\nModel =" + CModel;
            temp = temp + "\nColor =" + CColor;
            temp = temp + "\nYearbuilt" + CYearbuilt;
            //temp = temp + "\nCarEngine\n" + CCarEngine.MakeString();
            return temp;
        }
    }
}
