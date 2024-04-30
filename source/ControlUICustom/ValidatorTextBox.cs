using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlUICustom
{
    public interface IValidator
    {
        bool IsValid(string value);
    }
    public class NameValidator : IValidator
    {
        public bool IsValid(string value)
        {
            bool valid = !string.IsNullOrEmpty(value) && Regex.IsMatch(value, "^[a-zA-Z\\s]+$");
            if (!valid)
            {
                throw new Exception("Invalid Name! Please enter that includes only letters and spaces.");
            }
            return true;
        }
    }
    public class GmailValidator : IValidator
    {
        public bool IsValid(string value)
        {
            string emailRegex = @"^[a-zA-Z0-9_+&*-]+(?:\.[a-zA-Z0-9_+&*-]+)*@gmail\.com$";

            bool valid = Regex.IsMatch(value, emailRegex);
            if (!valid)
            {

                throw new Exception("Invalid Gmail! Please enter a valid one.");
            }
            return true;
        }
    }
    public class PhoneValidator : IValidator
    {
        public bool IsValid(string input)
        {
            string phoneRegex = @"^0\d{9}$";

            bool valid = Regex.IsMatch(input, phoneRegex);
            if (!valid)
            {
                throw new Exception("Invalid Phone Number! Please enter a 10-digit phone number starting with 0.");
            }
            return true;
        }
    }

    public partial class ValidatorTextBox : TextBox
    {
        private IValidator validator;
        public ValidatorTextBox() : base()
        {
            InitializeComponent();
        }

        public ValidatorTextBox(IValidator validator) : base()
        {
            InitializeComponent();
            this.validator = validator;
        }

        public void SetValidator(IValidator validator)
        {
            this.validator = validator;
        }

        public bool Check()
        {
            return validator.IsValid(Text);
        }
    }
}
