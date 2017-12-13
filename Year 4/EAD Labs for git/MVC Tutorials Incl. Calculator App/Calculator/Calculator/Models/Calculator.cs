using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Calculator.Models
{
    // operator for select list in view
    public enum Operators
    {
        [Display(Name = " + ")]
        add,
        [Display(Name = " - ")]
        subtract,
        [Display(Name = " * ")]
        multiply,
        [Display(Name = " / ")]
        divide
    };

    public class Calculator
    {
        [Required]
        [Display(Name = "A")]
        public double NumA { get; set; }

        [Required]
        [Display(Name = "B")]
        public double NumB { get; set; }

        public double Result { get; set; }

        // <select> with <option>s for enum values on UI
        [System.ComponentModel.DefaultValue("add")]
        public Operators Operator { get; set;}

        // Perform calculations based on operator selected
        public double getAnswer()
        {
            double answer = 0;

            if(Operator.ToString() == "add")
            {
                answer = NumA + NumB;
            }
            else if (Operator.ToString() == "subtract")
            {
                answer = NumA - NumB;
            }
            else if (Operator.ToString() == "multiply")
            {
                answer = NumA * NumB;
            }
            else if (Operator.ToString() == "divide")
            {
                answer = NumA / NumB;
            }

            return answer;
        }
    }
}