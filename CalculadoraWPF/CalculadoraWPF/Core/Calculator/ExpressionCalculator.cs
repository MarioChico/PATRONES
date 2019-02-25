using System;
using System.Data;


namespace WpfCalculadoraBueno.Core.Calculator
{
    public class ExpressionCalculator : ICalculator
    {

        public double Calculate(string CalculateText)
        {
            var dataTable = new DataTable();
            var value = dataTable.Compute(CalculateText, "");
            return Convert.ToDouble(value);
        }

    }
}
