using System;

namespace CreditCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditCalc mycalc = new CreditCalc();
            mycalc.calcPayments();
        }
    }

    class CreditCalc
    {
        static decimal getSum()
        {
            Console.WriteLine("Введите сумму кредита");
            var strSumm = Console.ReadLine();
            try
            {
                var summToDecimal = decimal.Parse(strSumm);
                return summToDecimal;
            }
            catch
            {
                Console.WriteLine("Сумма кредита должна содержать только цифры");
                return 0.0m;
            }
        }

        static decimal getProcents()
        {
            Console.WriteLine("Введите проценты кредита");
            try
            {
                var toDecimalProcents = decimal.Parse(Console.ReadLine());
                return toDecimalProcents;
            }
            catch
            {
                Console.WriteLine("Проценты должны содержать только цифры");
                return 0.00m;
            }
        }
        public void calcPayments()
        {

            decimal summ = getSum(); //получаем введенную сумму
            decimal procents = getProcents(); //получаем введенные проценты
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

    }
}


