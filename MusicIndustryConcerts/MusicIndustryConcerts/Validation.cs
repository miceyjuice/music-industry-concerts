using System;
using System.Net.Mail;
using System.Windows.Controls;
using System.Windows.Media;

namespace MusicIndustryConcerts
{
    public class Validation
    {
        /// <summary>
        /// Metoda do sprawdzania czy użytkownik wpisał 
        /// mniejszą bądź równą wartość od maksymalnej
        /// </summary>
        /// <param name="desiredCapacity">Żądana ilość miejsc</param>
        /// <param name="maxCapacity">Maksymalna ilość miejsc w klubie</param>
        /// <returns></returns>
        public bool ValidateCapacity(int desiredCapacity, int maxCapacity) => desiredCapacity <= maxCapacity;
        /// <summary>
        /// Sprawdzanie czy użytkownik wpisał poprawną godzinę
        /// </summary>
        /// <param name="field">Pole tekstowe</param>
        /// <returns></returns>
        public bool ValidateHour(TextBox field)
        {
            if (!String.IsNullOrWhiteSpace(field.Text))
            {
                if (Convert.ToInt32(field.Text) <= 24 && Convert.ToInt32(field.Text) >= 0)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
        /// <summary>
        /// Sprawdzanie czy użytkownik wpisał email w poprawnym formacie
        /// </summary>
        /// <param name="mail">E-mail podany przez użytkownika</param>
        /// <returns></returns>
        public bool ValidateMail(string mail)
        {
            try
            {
                MailAddress m = new MailAddress(mail);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
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
            if (field.SelectedDate == null) return false;
            return true;
        }
        /// <summary>
        /// Metoda do walidacji pól w formularzu
        /// </summary>
        /// <param name="controls">Pole tekstowe, lista rozwijalna bądź pole daty</param>
        /// <returns></returns>
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
