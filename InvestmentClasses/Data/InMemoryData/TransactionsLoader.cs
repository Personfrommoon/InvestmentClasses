using System;
using System.Linq;
using InvestmentClasses.Domain;

namespace InvestmentClasses.Data.InMemoryData
{
    public static class TransactionsLoader
    {
        public static void LoadTransactions(DataContext context)
        {
            Pohikonto20230401(context); // Põhikonto rahade liikumine 01.04.2023
            LHVarvelduskonto345645633(context); // LHV arvelduskonto rahade liikumine 01.04.2023
            LHVkasvukonto236554211(context); // LHV kasvukonto rahade liikumine 01.04.2023
            LHVvaartpaberikonto973647626(context); // LHV väärtpaberikonto rahade liikumine 01.04.2023
        }

        private static void Pohikonto20230401(DataContext context)
        {
            var swed = context.Accounts.GetByName("Põhikonto");
            var eur = context.Securables.GetByTicker("EUR");

            context.Transactions.Add(new Transaction
            {
                TransactionId = "42535082",
                OwningAccount = swed,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-01 10:00:00"),
                Amount = 1000m,
                Securable = eur,
                Description = "Palk 2023-03"
            });

            context.Transactions.Add(new Transaction
            {
                TransactionId = "26463646",
                OwningAccount = swed,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-01 11:00:00"),
                Amount = -20m,
                Securable = eur,
                Description = "PRISMA POS/XSD/9393873/9392" // Kommid
            });

            context.Transactions.Add(new Transaction
            {
                TransactionId = "98645322",
                OwningAccount = swed,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-01 11:20:00"),
                Amount = -5m,
                Securable = eur,
                Description = "Ülekanne sõbrale" // Raha sõbrale
            });

            context.Transactions.Add(new Transaction
            {
                TransactionId = "74568235",
                OwningAccount = swed,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-01 11:22:00"),
                Amount = -15m,
                Securable = eur,
                Description = "Arve B837378992/353535" // Telefoniarve
            });

            context.Transactions.Add(new Transaction
            {
                TransactionId = "19584526",
                OwningAccount = swed,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-01 14:00:00"),
                Amount = -0.5m,
                Securable = eur,
                Description = "Konto hooldustasu"
            });

            swed.Transactions.AddRange(context.Transactions.Where(t => t.OwningAccount == swed));
        }

        private static void LHVarvelduskonto345645633(DataContext context)
        {
            var lhv = context.Accounts.GetByName("LHV arvelduskonto");
            var eur = context.Securables.GetByTicker("EUR");

            context.Transactions.Add(new Transaction
            {
                TransactionId = "78634525",
                OwningAccount = lhv,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-01 10:00:00"),
                Amount = 567m,
                Securable = eur,
                Description = "Palk 2023-03"
            });

            context.Transactions.Add(new Transaction
            {
                TransactionId = "02857414",
                OwningAccount = lhv,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-01 11:00:00"),
                Amount = -100m,
                Securable = eur,
                Description = "Kommunaalid" // Kommunaalid
            });

            context.Transactions.Add(new Transaction
            {
                TransactionId = "97345621",
                OwningAccount = lhv,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-01 11:20:00"),
                Amount = -56m,
                Securable = eur,
                Description = "Elektriarve" // Elektri arve
            });

            context.Transactions.Add(new Transaction
            {
                TransactionId = "64356154",
                OwningAccount = lhv,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-01 11:22:00"),
                Amount = -120m,
                Securable = eur,
                Description = "Arve B837378992/353535" // Telefoniarve
            });

            context.Transactions.Add(new Transaction
            {
                TransactionId = "90316284",
                OwningAccount = lhv,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-01 14:00:00"),
                Amount = -0.5m,
                Securable = eur,
                Description = "Konto hooldustasu"
            });

            lhv.Transactions.AddRange(context.Transactions.Where(t => t.OwningAccount == lhv));
        }

        private static void LHVkasvukonto236554211(DataContext context)
        {
            var lhv = context.Accounts.GetByName("LHV kasvukonto");
            var eur = context.Securables.GetByTicker("EUR");

            context.Transactions.Add(new Transaction
            {
                TransactionId = "31246597",
                OwningAccount = lhv,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-01 10:00:00"),
                Amount = 1000m,
                Securable = eur,
                Description = "Palk 2023-03"
            });

            context.Transactions.Add(new Transaction
            {
                TransactionId = "96451326",
                OwningAccount = lhv,
                OtherAccount = null,
                Time = DateTime.Parse("2023-05-01 11:00:00"),
                Amount = +20m,
                Securable = eur,
                Description = "Kasvukonto kasv" // Kasvukonto kasv
            });

            context.Transactions.Add(new Transaction
            {
                TransactionId = "94653021",
                OwningAccount = lhv,
                OtherAccount = null,
                Time = DateTime.Parse("2023-06-01 11:20:00"),
                Amount = +20m,
                Securable = eur,
                Description = "Kasvukonto kasv" // Kasvukonto kasv
            });

            context.Transactions.Add(new Transaction
            {
                TransactionId = "85236901",
                OwningAccount = lhv,
                OtherAccount = null,
                Time = DateTime.Parse("2023-07-01 11:22:00"),
                Amount = +20m,
                Securable = eur,
                Description = "Kasvukonto kasv" // Kasvukonto kasv
            });

            context.Transactions.Add(new Transaction
            {
                TransactionId = "73690148",
                OwningAccount = lhv,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-01 14:00:00"),
                Amount = -0.5m,
                Securable = eur,
                Description = "Konto hooldustasu"
            });

            context.Transactions.Add(new Transaction
            {
                TransactionId = "00230015",
                OwningAccount = lhv,
                OtherAccount = null,
                Time = DateTime.Parse("2023-05-01 14:00:00"),
                Amount = -0.5m,
                Securable = eur,
                Description = "Konto hooldustasu"
            });

            context.Transactions.Add(new Transaction
            {
                TransactionId = "42069000",
                OwningAccount = lhv,
                OtherAccount = null,
                Time = DateTime.Parse("2023-06-01 14:00:00"),
                Amount = -0.5m,
                Securable = eur,
                Description = "Konto hooldustasu"
            });

            context.Transactions.Add(new Transaction
            {
                TransactionId = "00042069",
                OwningAccount = lhv,
                OtherAccount = null,
                Time = DateTime.Parse("2023-07-01 14:00:00"),
                Amount = -0.5m,
                Securable = eur,
                Description = "Konto hooldustasu"
            });

            lhv.Transactions.AddRange(context.Transactions.Where(t => t.OwningAccount == lhv));
        }

        private static void LHVvaartpaberikonto973647626(DataContext context)
        {
            var lhv = context.Accounts.GetByName("LHV väärtpaberikonto");
            var eur = context.Securables.GetByTicker("EUR");

            context.Transactions.Add(new Transaction
            {
                TransactionId = "36980215",
                OwningAccount = lhv,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-01 10:00:00"),
                Amount = 500m,
                Securable = eur,
                Description = "ülekanne 2023-03"
            });

            context.Transactions.Add(new Transaction
            {
                TransactionId = "90241800",
                OwningAccount = lhv,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-01 11:00:00"),
                Amount = -200m,
                Securable = eur,
                Description = "Aktsia1" // Aktsia1
            });

            context.Transactions.Add(new Transaction
            {
                TransactionId = "35069843",
                OwningAccount = lhv,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-01 11:20:00"),
                Amount = -200m,
                Securable = eur,
                Description = "Aktsia2" // Aktsia2
            });

            context.Transactions.Add(new Transaction
            {
                TransactionId = "32325678",
                OwningAccount = lhv,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-01 11:22:00"),
                Amount = -36m,
                Securable = eur,
                Description = "Aktsia3" // Aktsia3
            });

            context.Transactions.Add(new Transaction
            {
                TransactionId = "12345678",
                OwningAccount = lhv,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-01 14:00:00"),
                Amount = -0.5m,
                Securable = eur,
                Description = "Konto hooldustasu"
            });

            lhv.Transactions.AddRange(context.Transactions.Where(t => t.OwningAccount == lhv));
        }
    }
}
