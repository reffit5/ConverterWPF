using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfUnitConverter.ViewsModel
{
    public class UnitConverterViewModel : ObservableObject

    {
        public ICommand ButtonConvertCommand { get; set; }

        private double _result;

        public double Operand { get; set; }

        public string OperandUnit { get; set; }

        public string ResultUnit { get; set; }

        public double Result {
            get { return _result; }
            set {
                _result = value;
                OnPropertyChanged("Result");
            }
        }

        public List<string> Units { get; set; }

        private List<string> BuildOutUnitComboBoxSource()
        {
            return new List<string>() { "Inches", "Feet", "Miles", "Millimeters", "Centimeters", "Meters", "Kilometers" };

        }

        private void PerformCalculation(object obj)
        {
            switch (OperandUnit)    
            {
                case "Inches":
                    switch (ResultUnit)
                    {
                        case "Inches":
                            Result = Operand;
                            break;
                        case "Feet":
                            Result = Operand / 12;
                            break;
                        case "Miles":
                            Result = Operand / 63360;
                            break;
                        case "Millimeters":
                            Result = Operand * 25.4;
                            break;
                        case "Centimeters":
                            Result = Operand * 2.54;
                            break;
                        case "Meters":
                            Result = Operand / 39.37;
                            break;
                        case "Kilometers":
                            Result = Operand / 39370.079;
                            break;
                        default:
                            Result = Operand;
                            break;
                    }
                    break;
                case "Feet":
                    switch (ResultUnit)
                    {
                        case "Inches":
                            Result = Operand * 12;
                            break;
                        case "Feet":
                            Result = Operand;
                            break;
                        case "Miles":
                            Result = Operand / 5280;
                            break;
                        case "Millimeters":
                            Result = Operand * 304.8;
                            break;
                        case "Centimeters":
                            Result = Operand * 30.48;
                            break;
                        case "Meters":
                            Result = Operand / 3.281;
                            break;
                        case "Kilometers":
                            Result = Operand / 3280.84;
                            break;
                        default:
                            Result = Operand;
                            break;
                    }
                    break;
                case "Miles":
                    switch (ResultUnit)
                    {
                        case "Inches":
                            Result = Operand * 63360;
                            break;
                        case "Feet":
                            Result = Operand * 5280;
                            break;
                        case "Miles":
                            Result = Operand;
                            break;
                        case "Millimeters":
                            Result = Operand * 1609000;
                            break;
                        case "Centimeters":
                            Result = Operand * 160934.4;
                            break;
                        case "Meters":
                            Result = Operand * 1609.344;
                            break;
                        case "Kilometers":
                            Result = Operand * 1.609;
                            break;
                        default:
                            Result = Operand;
                            break;
                    }
                    break;
                case "Millimeters":
                    switch (ResultUnit)
                    {
                        case "Inches":
                            Result = Operand / 25.4;
                            break;
                        case "Feet":
                            Result = Operand / 304.8;
                            break;
                        case "Miles":
                            Result = Operand / 1609000;
                            break;
                        case "Millimeters":
                            Result = Operand;
                            break;
                        case "Centimeters":
                            Result = Operand / 10;
                            break;
                        case "Meters":
                            Result = Operand / 1000;
                            break;
                        case "Kilometers":
                            Result = Operand / 1000000;
                            break;
                        default:
                            Result = Operand;
                            break;
                    }
                    break;
                case "Centimeters":
                    switch (ResultUnit)
                    {
                        case "Inches":
                            Result = Operand / 2.54;
                            break;
                        case "Feet":
                            Result = Operand / 30.48;
                            break;
                        case "Miles":
                            Result = Operand / 160934.4;
                            break;
                        case "Millimeters":
                            Result = Operand * 10;
                            break;
                        case "Centimeters":
                            Result = Operand;
                            break;
                        case "Meters":
                            Result = Operand / 100;
                            break;
                        case "Kilometers":
                            Result = Operand / 100000;
                            break;
                        default:
                            Result = Operand;
                            break;
                    }
                    break;
                case "Meters":
                    switch (ResultUnit)
                    {
                        case "Inches":
                            Result = Operand * 39.37;
                            break;
                        case "Feet":
                            Result = Operand * 3.281;
                            break;
                        case "Miles":
                            Result = Operand / 1609.344;
                            break;
                        case "Millimeters":
                            Result = Operand * 1000;
                            break;
                        case "Centimeters":
                            Result = Operand * 100;
                            break;
                        case "Meters":
                            Result = Operand;
                            break;
                        case "Kilometers":
                            Result = Operand / 1000;
                            break;
                        default:
                            Result = Operand;
                            break;
                    }
                    break;
                case "Kilometers":
                    switch (ResultUnit)
                    {
                        case "Inches":
                            Result = Operand * 39370.079;
                            break;
                        case "Feet":
                            Result = Operand * 3280.84;
                            break;
                        case "Miles":
                            Result = Operand / 1.609;
                            break;
                        case "Millimeters":
                            Result = Operand * 1000000;
                            break;
                        case "Centimeters":
                            Result = Operand * 100000;
                            break;
                        case "Meters":
                            Result = Operand * 1000;
                            break;
                        case "Kilometers":
                            Result = Operand;
                            break;
                        default:
                            Result = Operand;
                            break;
                    }
                    break;
                default:
                    Result = Operand;
                    break;
            }

        }

        public UnitConverterViewModel()
        {
            Operand = 1; //confirm bind
            Units = BuildOutUnitComboBoxSource();
            ButtonConvertCommand = new RelayCommand(new Action<object>(PerformCalculation));
        }

        
        
       
}
}
