namespace EmployeeOOP.Classes
{
    public class SalaryEmployee : Employee
    {
        #region Properties

        public decimal Salary { get; set; }

        #endregion

        #region Methods

        public SalaryEmployee() // Good practice
        {

        }

        public override decimal GetValueToPay()
        {
            return Salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Salario Devengado: {Salary:C2}\n\t"; // C2 "Currency", two decimals
        }

        #endregion
    }
}
