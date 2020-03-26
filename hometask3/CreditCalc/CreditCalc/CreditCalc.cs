using System;

class CreditCalc
{
    static String getSum()
    {
        Console.WriteLine("Введите сумму кредита");
        var summ = Console.ReadLine();
        return summ;
    }
    static String getProcents()
    {
        Console.WriteLine("Введите проценты кредита");
        var procents = Console.ReadLine();
        return procents;
    }
    public void calcPayments()
    {
        try
        {
            decimal summ = decimal.Parse(getSum()); //получаем введенную сумму
            decimal procents = decimal.Parse(getProcents()); //получаем введенные проценты
            decimal paymentWithoutPerc; //ежемесячный платеж без процентов
            decimal monthPaymentWithPerc; //ежемесячный платеж с процентами
            decimal monthPerc; // Ежемесячный платеж по процентам
            decimal mainSum = 0; //Общая сумма платежей с процентами
            int monthsOfCredit = 12; // срок кредита в месяцах
            paymentWithoutPerc = summ / monthsOfCredit;
            Console.WriteLine("Выплаты по месяцам:");

            for (int j = 1; j <= 12; j++)
            {
                monthPerc = (procents / monthsOfCredit) * (summ - (paymentWithoutPerc * (j - 1))) / 100;
                monthPaymentWithPerc = paymentWithoutPerc + monthPerc;
                mainSum = mainSum + monthPaymentWithPerc;
                Console.WriteLine("{0} месяц {1:F2} руб", j, monthPaymentWithPerc);

            }

            Console.WriteLine("Общая сумма выплат составит: {0:F2}", mainSum);
        }
        catch
        {
            Console.WriteLine("Введены невалидные символы. Сумма кредита и проценты должны содержать только числа");
        }

    }
}
  
}
