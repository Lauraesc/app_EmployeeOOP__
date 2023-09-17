namespace EmployeeOOP.Classes
{
    public class CommissionEmployee : Employee
    {

        #region Properties

        public decimal CommissionPercentage { get; set; }
        public decimal Sales { get; set; }

        #endregion

        #region Methods

        public CommissionEmployee() // Good practice
        {

        }

        public override decimal GetValueToPay()
        {
            /*Next, the operation is applied with the created properties. For this operation, 100 is taken as the percentage base.*/
            return (CommissionPercentage * Convert.ToDecimal(0.01)) * Sales;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Comisión en porcentaje: {CommissionPercentage:C1}\n\t" + // C2 "Currency "
                $"Vendido: {Sales:C2}\n\t";
        }

        #endregion


    }
}
