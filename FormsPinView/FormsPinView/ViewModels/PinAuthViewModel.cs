using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace FormsPinView.ViewModels
{
    public class PinAuthViewModel : ViewModelBase
    {
        public bool[] CellIsFilled { get; set; } = new bool[4] { false, false, false, false};

        private string _pin = "";
        public string Pin
        {
            get => _pin;
            set
            {
                _pin = value;
                if (value.Length == 4)
                {
                    ValidatePin(value);
                    _pin = "";
                }
                UpdateCellsVisability();
                RaisePropertyChanged(nameof(Pin));
            }
        }

        private bool _pinIsHidden;
        public bool PinIsHidden
        {
            get => _pinIsHidden;
            set
            {
                _pinIsHidden = value;
                UpdateCellsVisability();
            }
        }

        public PinAuthViewModel()
        {

        }
        private bool ValidatePin(string pin)
        {
            if(pin == "1234")
            {
                return true;
            }
            return false;
        }

        private void UpdateCellsVisability()
        {
            for (int i = 0; i < CellIsFilled.Length; ++i)
            {
                CellIsFilled[i] = PinIsHidden && (i < Pin.Length);
                RaisePropertyChanged(nameof(CellIsFilled));
            }
            RaisePropertyChanged(nameof(PinIsHidden));
        }
    }
}
