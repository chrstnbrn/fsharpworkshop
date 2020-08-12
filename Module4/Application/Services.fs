namespace Services

open System

type CustomerService() =
    member this.UpgradeCustomer =
        Functions.getCustomer >> Functions.upgradeCustomer

    member this.GetCustomerInfo customer =
        let isAdult = Functions.isAdult customer
        let alert = Functions.getAlert customer
        sprintf
            "Id: %i, IsVip: %b, Credit: %.2f, IsAdult: %b, Alert: %s"
            customer.Id
            customer.IsVip
            customer.Credit
            isAdult
            alert
