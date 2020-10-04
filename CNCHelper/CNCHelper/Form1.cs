using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNCHelper
{
    public partial class Form1 : Form
    {
        //ParameterRadius ToolName;

        /* ParameterRadius NumberDivisions;
         ParameterRadius InitialCorner;
         ParameterRadius EventualCorner;
         ParameterRadius RadiusCircle;
         ParameterRadius StartPointX;
         ParameterRadius StartPointZ;
         ParameterRadius SpeedShpindle;*/

        static public string ToolName;
        static public string RadiusTools;
        static public string NumberDivisions;
        static public string InitialCorner;
        static public string EventualCorner;
        static public string RadiusCircle;
        static public string StartPointX;
        static public string StartPointZ;
        static public string SpeedShpindle;
        static public string ToolСorrection;
        static public bool TotalCheck = false;

        

        public Form1()
        {
            //Инициализация компонентов
            InitializeComponent();
            
            
            

        }


        public void CheckParameters()
        {

            if (txBoxToolName.Text.Length == 0
                || txBoxToolRadius.Text.Length == 0
                || txBoxNumberDivisions.Text.Length == 0
                || txBoxInitialCorner.Text.Length == 0
                || txBoxEventualCorner.Text.Length == 0
                || txBoxRadiusCircle.Text.Length == 0
                || txBoxStartPointX.Text.Length == 0
                || txBoxStartPointZ.Text.Length == 0
                || txBoxSpeedShpindle.Text.Length == 0
               || string.IsNullOrEmpty(comboBoxSetTool.Text))
                  {
                TotalCheck = false;
            }
            else
            {
                TotalCheck = true;
            }

            if (txBoxToolName.Text.Length == 0) MessageBox.Show("Введите - Имя Инструмента");         
            if (txBoxToolRadius.Text.Length == 0) MessageBox.Show("Введите-Радиус инструмента ");         
            if (txBoxNumberDivisions.Text.Length == 0) MessageBox.Show("Введите-Кол-во делений полной окружности ");          
            if (txBoxInitialCorner.Text.Length == 0) MessageBox.Show("Введите-Начальный угол ");    
            if (txBoxEventualCorner.Text.Length == 0) MessageBox.Show("Введите-Конечный угол ");
            if (txBoxRadiusCircle.Text.Length == 0) MessageBox.Show("Введите-Радиус окружности ");      
            if (txBoxStartPointX.Text.Length == 0) MessageBox.Show("Введите-Начальная точка по оси X");         
            if (txBoxStartPointZ.Text.Length == 0) MessageBox.Show("Введите-Начальная точка по оси Z");
            if (txBoxSpeedShpindle.Text.Length == 0) MessageBox.Show("Введите-Скорость вращения шпинделя ");         
            if (string.IsNullOrEmpty(comboBoxSetTool.Text)) MessageBox.Show("Выберите Коррекцию Инструмента");
                      
        }

          public void ReadParameters()
        {
            ToolName = txBoxToolName.Text.ToString();
            RadiusTools = txBoxToolRadius.Text.ToString();
            NumberDivisions = txBoxNumberDivisions.Text.ToString();
            InitialCorner = txBoxInitialCorner.Text.ToString();
            EventualCorner =  txBoxEventualCorner.Text.ToString();
            RadiusCircle = txBoxRadiusCircle.Text.ToString();
            StartPointX = txBoxStartPointX.Text.ToString();
            StartPointZ = txBoxStartPointZ.Text.ToString();
            SpeedShpindle = txBoxSpeedShpindle.Text.ToString();
            ToolСorrection = comboBoxSetTool.Text.ToString();

            if (comboBoxSetTool.SelectedIndex == 0) ToolСorrection = "G41";
            if (comboBoxSetTool.SelectedIndex == 1) ToolСorrection = "G42";
            if (comboBoxSetTool.SelectedIndex == 2) ToolСorrection = "G40";


            //double n;
            //MessageBox.Show("Введено " + (double.TryParse(txBoxToolRadius.Text, out  n) ? "число!" : "не число!"));
            //MessageBox.Show("Введено " + (double.TryParse(txBoxNumberDivisions.Text, out n) ? "число!" : "не число!"));
            //MessageBox.Show("Введено " + (double.TryParse(txBoxInitialCorner.Text, out n) ? "число!" : "не число!"));
            //MessageBox.Show("Введено " + (double.TryParse(txBoxEventualCorner.Text, out n) ? "число!" : "не число!"));
            //MessageBox.Show("Введено " + (double.TryParse(txBoxRadiusCircle.Text, out n) ? "число!" : "не число!"));
            //MessageBox.Show("Введено " + (double.TryParse(txBoxStartPointX.Text, out n) ? "число!" : "не число!"));
            //MessageBox.Show("Введено " + (double.TryParse(txBoxStartPointZ.Text, out n) ? "число!" : "не число!"));
            //MessageBox.Show("Введено " + (double.TryParse(txBoxSpeedShpindle.Text, out n) ? "число!" : "не число!"));


        }

        public void OutputProgramm()
        {
            listBoxTotal.Items.Clear();  // очищаем список
         
            if(TotalCheck==true)
            {
                listBoxTotal.Items.Add(string.Format("T= \"{0}\" " , ToolName)) ;
                listBoxTotal.Items.Add(string.Format("M6"));
                listBoxTotal.Items.Add(string.Format("R61= {0} ", NumberDivisions));
                listBoxTotal.Items.Add(string.Format("R31= {0} ", InitialCorner));
                listBoxTotal.Items.Add(string.Format("R51= {0} ", EventualCorner));
                listBoxTotal.Items.Add(string.Format("R71= {0} ", RadiusCircle));
                listBoxTotal.Items.Add(string.Format("R81= {0} ", StartPointX));
                listBoxTotal.Items.Add(string.Format("R91= {0} ", StartPointZ));
                listBoxTotal.Items.Add(string.Format("R41=R31-360/R61 "));
                listBoxTotal.Items.Add(string.Format("S{0} M3 D1 ", SpeedShpindle));
                listBoxTotal.Items.Add(string.Format("G17 G90 "));// можно добавить др.системы координат G17(x/y) + G90 Абс. система координат
                listBoxTotal.Items.Add(string.Format("G599 G0 Z100 ")); // add G599 привязка/ add безопасное перемещение Z
                listBoxTotal.Items.Add(string.Format("G0 X0000 Y0000 "));// Подвод по оси х и у
                listBoxTotal.Items.Add(string.Format("G0 Z0000 "));  // безопасный подвод Z
                listBoxTotal.Items.Add(string.Format("LB2"));
                listBoxTotal.Items.Add(string.Format("G0 Z0000 "));// безопасный подвод Z
                listBoxTotal.Items.Add(string.Format("{0} G1 X=R81 F200 ", ToolСorrection)); // выбор из комбобокса
                listBoxTotal.Items.Add(string.Format("G1 Z=R91 F200 ")); // так же редактировать рабочую подачу
                listBoxTotal.Items.Add(string.Format("G1 Y-22 F400")); //конечная точка обработки У
                listBoxTotal.Items.Add(string.Format("R31=R31-360/R61"));
                listBoxTotal.Items.Add(string.Format("R41=R41-360/R61"));
                listBoxTotal.Items.Add(string.Format("R11=cosR41*R71-cosR31*R71"));
                listBoxTotal.Items.Add(string.Format("R21=cosR31*R71-sinR41*R71"));
                listBoxTotal.Items.Add(string.Format("R81=R81+R11"));
                listBoxTotal.Items.Add(string.Format("R91=R91-R21"));
                listBoxTotal.Items.Add(string.Format("G0 Z200"));//безопасное перемещение Z
                listBoxTotal.Items.Add(string.Format("G0 {0} Y0000", ToolСorrection)); //Коректор инст. и начало по У
                listBoxTotal.Items.Add(string.Format("IF R31>R51 GOTOB LB2"));
                listBoxTotal.Items.Add(string.Format("G0 Z200"));
                listBoxTotal.Items.Add(string.Format("M5 M0"));
                listBoxTotal.Items.Add(string.Format("M17"));
                listBoxTotal.Items.Add(string.Format("Ниже код для второй четверти по часовой: "));/////
                listBoxTotal.Items.Add(string.Format("{0} G1 X=R81 F200 ", ToolСorrection));
                listBoxTotal.Items.Add(string.Format("G1 Z=R91 F200 "));
                listBoxTotal.Items.Add(string.Format("G1 Y00000 F400"));
                listBoxTotal.Items.Add(string.Format("R31=R31-360/R61"));
                listBoxTotal.Items.Add(string.Format("R41=R41-360/R61"));
                listBoxTotal.Items.Add(string.Format("R11=ABS(cos(R41)*R71-cos(R31)*R71)"));
                listBoxTotal.Items.Add(string.Format("R21=ABS(sin(R31)*R71-sin(R41)*R71)"));
                listBoxTotal.Items.Add(string.Format("R81=R81-R11"));
                listBoxTotal.Items.Add(string.Format("R91=R91-R21"));
                listBoxTotal.Items.Add(string.Format("G0 Z200"));
                listBoxTotal.Items.Add(string.Format("G0 {0} Y00000", ToolСorrection));
                listBoxTotal.Items.Add(string.Format("IF R31<R51 GOTOB LB2"));
                listBoxTotal.Items.Add(string.Format("G0 Z200"));
                listBoxTotal.Items.Add(string.Format("M5 M0"));
                listBoxTotal.Items.Add(string.Format("M17"));
                






            }
            else
            {
                MessageBox.Show("Не все данные");
            }
          
                
            






        }


        private void btonTotal_Click(object sender, EventArgs e)
        {
            CheckParameters();
            ReadParameters();
            OutputProgramm();

        }

        private void txBoxSpeedShpindle_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Цифры
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            //Точку заменим запятой
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (txBoxSpeedShpindle.Text.IndexOf(',') != -1)
                {
                    //Уже есть одна запятая в textBox
                    e.Handled = true;
                }
                return;
            }

            //Управляющие клавиши <Backspace>, <Enter> и т.д.
            if (Char.IsControl(e.KeyChar))
            {
                return;
            }

            //Остальное запрещено
            e.Handled = true;






        }

        private void txBoxStartPointZ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            //Точку заменим запятой
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (txBoxStartPointZ.Text.IndexOf(',') != -1)
                {
                    //Уже есть одна запятая в textBox
                    e.Handled = true;
                }
                return;
            }

            //Управляющие клавиши <Backspace>, <Enter> и т.д.
            if (Char.IsControl(e.KeyChar))
            {
                return;
            }

            //Остальное запрещено
            e.Handled = true;
        }

        private void txBoxStartPointX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            //Точку заменим запятой
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (txBoxStartPointX.Text.IndexOf(',') != -1)
                {
                    //Уже есть одна запятая в textBox
                    e.Handled = true;
                }
                return;
            }

            //Управляющие клавиши <Backspace>, <Enter> и т.д.
            if (Char.IsControl(e.KeyChar))
            {
                return;
            }

            //Остальное запрещено
            e.Handled = true;
        }

        private void txBoxRadiusCircle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            //Точку заменим запятой
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (txBoxRadiusCircle.Text.IndexOf(',') != -1)
                {
                    //Уже есть одна запятая в textBox
                    e.Handled = true;
                }
                return;
            }

            //Управляющие клавиши <Backspace>, <Enter> и т.д.
            if (Char.IsControl(e.KeyChar))
            {
                return;
            }

            //Остальное запрещено
            e.Handled = true;
        }

        private void txBoxEventualCorner_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            //Точку заменим запятой
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (txBoxEventualCorner.Text.IndexOf(',') != -1)
                {
                    //Уже есть одна запятая в textBox
                    e.Handled = true;
                }
                return;
            }

            //Управляющие клавиши <Backspace>, <Enter> и т.д.
            if (Char.IsControl(e.KeyChar))
            {
                return;
            }

            //Остальное запрещено
            e.Handled = true;
        }

        private void txBoxInitialCorner_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            //Точку заменим запятой
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (txBoxInitialCorner.Text.IndexOf(',') != -1)
                {
                    //Уже есть одна запятая в textBox
                    e.Handled = true;
                }
                return;
            }

            //Управляющие клавиши <Backspace>, <Enter> и т.д.
            if (Char.IsControl(e.KeyChar))
            {
                return;
            }

            //Остальное запрещено
            e.Handled = true;
        }

        private void txBoxNumberDivisions_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            //Точку заменим запятой
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (txBoxNumberDivisions.Text.IndexOf(',') != -1)
                {
                    //Уже есть одна запятая в textBox
                    e.Handled = true;
                }
                return;
            }

            //Управляющие клавиши <Backspace>, <Enter> и т.д.
            if (Char.IsControl(e.KeyChar))
            {
                return;
            }

            //Остальное запрещено
            e.Handled = true;
        }

        private void txBoxToolRadius_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            //Точку заменим запятой
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (txBoxToolRadius.Text.IndexOf(',') != -1)
                {
                    //Уже есть одна запятая в textBox
                    e.Handled = true;
                }
                return;
            }

            //Управляющие клавиши <Backspace>, <Enter> и т.д.
            if (Char.IsControl(e.KeyChar))
            {
                return;
            }

            //Остальное запрещено
            e.Handled = true;
        }
    }
}
