using System.Windows.Controls;
using System.Windows.Input;
using CalcCore;

namespace CalcWpf
{
    public partial class CalculatorControl : UserControl
    {
        public CalculatorControl()
        {
            InitializeComponent();
            this.PreviewKeyDown += CalculatorControl_PreviewKeyDown;
            this.Focusable = true;
        }

        private void CalculatorControl_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            var vm = this.DataContext as CalcModel;
            if (vm == null) return;

            switch (e.Key)
            {
                case Key.D0:
                case Key.NumPad0:
                    vm.ExecuteCommand.Execute(Command.Type0);
                    break;
                case Key.D1:
                case Key.NumPad1:
                    vm.ExecuteCommand.Execute(Command.Type1);
                    break;
                case Key.D2:
                case Key.NumPad2:
                    vm.ExecuteCommand.Execute(Command.Type2);
                    break;
                case Key.D3:
                case Key.NumPad3:
                    vm.ExecuteCommand.Execute(Command.Type3);
                    break;
                case Key.D4:
                case Key.NumPad4:
                    vm.ExecuteCommand.Execute(Command.Type4);
                    break;
                case Key.D5:
                case Key.NumPad5:
                    vm.ExecuteCommand.Execute(Command.Type5);
                    break;
                case Key.D6:
                case Key.NumPad6:
                    vm.ExecuteCommand.Execute(Command.Type6);
                    break;
                case Key.D7:
                case Key.NumPad7:
                    vm.ExecuteCommand.Execute(Command.Type7);
                    break;
                case Key.D8:
                case Key.NumPad8:
                    vm.ExecuteCommand.Execute(Command.Type8);
                    break;
                case Key.D9:
                case Key.NumPad9:
                    vm.ExecuteCommand.Execute(Command.Type9);
                    break;
                case Key.OemPeriod:
                case Key.Decimal:
                    vm.ExecuteCommand.Execute(Command.DecimalPoint);
                    break;
                case Key.Add:
                case Key.OemPlus:
                    if ((Keyboard.Modifiers & ModifierKeys.Shift) != 0 || e.Key == Key.Add)
                        vm.ExecuteCommand.Execute(Command.Plus);
                    else
                        vm.ExecuteCommand.Execute(Command.Equal);
                    break;
                case Key.Subtract:
                case Key.OemMinus:
                    vm.ExecuteCommand.Execute(Command.Minus);
                    break;
                case Key.Multiply:
                //case Key.D8 when (Keyboard.Modifiers & ModifierKeys.Shift) != 0:
                    vm.ExecuteCommand.Execute(Command.Multiply);
                    break;
                case Key.Divide:
                //case Key.Oem2:
                    vm.ExecuteCommand.Execute(Command.Divide);
                    break;
                case Key.Enter:
                //case Key.Return:
                    vm.ExecuteCommand.Execute(Command.Equal);
                    break;
                case Key.Back:
                    vm.ExecuteCommand.Execute(Command.Backspace);
                    break;
                case Key.Delete:
                    vm.ExecuteCommand.Execute(Command.ClearEntry);
                    break;
                default:
                    break;
            }
            e.Handled = true;
        }
    }
}
