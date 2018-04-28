using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car
{
    public partial class Form1 : Form
    {        
        EngineClass TempObject;
        CarClass CarObject;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //int x; The compiler allocates memory for the variable in stack 
            EngineClass EnginObject;  // it is only a declaration 
            CarObject = new CarClass();
            EnginObject = new EngineClass(); // the compiler allocates memory for variable in heap 
                                             // and it is completely reclaimable 
                                             // as a side effect of creating this object, constructor will run
            EnginObject.SetNoofcylanders(2);
            EnginObject.SetVolumeCC(5);
            //EnginObject.SetEnginetype(false);
            EnginObject.SetTorque(5);
            EnginObject.SetHorsepower(2200);
            MessageBox.Show(EnginObject.MakeString());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TempObject = new EngineClass();


            TempObject.SetNoofcylanders(Convert.ToInt16(textBox1.Text));
            TempObject.SetVolumeCC(Convert.ToInt16(textBox2.Text));
            //TempObject.SetEnginetype(Convert.ToBoolean(radioButton1.Text));
            TempObject.SetTorque(Convert.ToInt16(textBox3.Text));
            TempObject.SetHorsepower(Convert.ToInt16(textBox4.Text));
            MessageBox.Show("Values are set in object");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TempObject.MakeString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CarObject = new CarClass();


            CarObject.SetVIN(Convert.ToInt16(textBox5.Text));
            CarObject.SetMake(Convert.ToString(textBox6.Text));
            CarObject.SetModel(Convert.ToString(textBox7.Text));
            //CarObject.SetYearbuilt(Convert.ToDateTime(dateTimePicker1.Text));
            CarObject.SetColor(Convert.ToString(textBox8.Text)); 
            //CarObject.SetCarEngine(Convert.ToString(textBox9.Text));
            MessageBox.Show("Values are set in object");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CarObject.MakeString());
        }
    }
}
