using EmployeeOOP.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BaseCommissionEmployee : CommissionEmployee
{

    #region Properties

    public decimal Base { get; set; }

    #endregion

    #region Methods

    public BaseCommissionEmployee() // Good practice
    {

    }

    public override decimal GetValueToPay()
    {
        /*Next, what is calculated in the parent class is then added to the employee's base.*/
        return Base + base.GetValueToPay();
    }

    public override string ToString()
    {
        return $"{base.ToString()}" +
            $"Base sumada a la comisión: {base.GetValueToPay():C2}\n\t"+ // C2 "Currency "
            $"Base: {Base:C2}\n\t";
    }

    #endregion


}