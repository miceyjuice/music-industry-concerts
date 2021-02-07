using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;

namespace MusicIndustryConcerts
{
    public class Validation
    {

        private bool ValidateTextBox(TextBox field)
        {
            if (String.IsNullOrWhiteSpace(field.Text))
            {
                field.BorderBrush = Brushes.Red;
                return false;
            }
            return true;
        }

        private static  bool ValidateComboBox(ComboBox field)
        {
            //TODO Validate for a custom style
            if (field.SelectedIndex == -1)
            {
                field.Background = new SolidColorBrush(Colors.Red);
                field.BorderBrush = new SolidColorBrush(Colors.Red);

                return false;
            }
            return true;
        }

        private bool ValidateDateInput(DatePicker field)
        {
            //TODO Validate for a custom style
            if (field.SelectedDate == null) return false;
            return true;
        }

        public bool ValidateFields(Control[] controls)
        {
            bool isAllValidated = true;
            foreach (var control in controls)
            {
                if (typeof(TextBox).IsInstanceOfType(control))
                {
                    isAllValidated = ValidateTextBox((TextBox)control) ? isAllValidated : false;
                }
                else if (typeof(ComboBox).IsInstanceOfType(control))
                {
                    isAllValidated = ValidateComboBox((ComboBox)control) ? isAllValidated : false;
                }
                else if (typeof(DatePicker).IsInstanceOfType(control))
                {
                    isAllValidated = ValidateDateInput((DatePicker)control) ? isAllValidated : false;
                }
                else throw new ArgumentException("Type of the argument is not supported");
            }
            return isAllValidated;
        }
    }
}
