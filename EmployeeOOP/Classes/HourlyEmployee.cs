namespace EmployeeOOP.Classes
{
    internal class HourlyEmployee : Employee
    {
        #region Properties

        public int Hours { get; set; }
        public decimal HourValue { get; set; }

        #endregion

        #region Methods

        public HourlyEmployee() // Good practice
        {

        }

        public override decimal GetValueToPay()
        {
            /*Here the amount to be paid to the employee is calculated based on the number of 
              hours worked and the value per hour.*/
            return Hours * HourValue;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Cant. de horas: {Hours}\n\t" + 
                $"Base: {HourValue:C2}\n\t"; // C2 "Currency "
        }

        #endregion

    }
}
