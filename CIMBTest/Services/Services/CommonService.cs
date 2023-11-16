using CIMBTest.DataContext;
using CIMBTest.Models;
using CIMBTest.Services.Abstract;
using CIMBTest.ViewModels;

namespace CIMBTest.Services.Services
{
    public class CommonService : ICommonService
    {
        public BaseContext dbContext;

        public CommonService(BaseContext dbc)
        {
            dbContext = dbc;
        }

        public List<UseCase2ViewModel> GetAllUseCase2List()
        {
            DateTime tempDueDate = new DateTime(1900, 01, 01);


            var data = dbContext.Table_02.Select(x => new UseCase2ViewModel()
            {
                CIF = x.CIF.ToString(),
                MonthlyIncome = x.MonthlyIncome,
                FacilityType = x.FacilityType,
                Plafond = x.Plafond,
                Outstanding = x.Outstanding,
                DueDate = tempDueDate.AddDays(x.DueDate != null ? x.DueDate.Value : 0),
                FacilityStartDate = tempDueDate.AddDays(x.FacilityStartDate != null ? x.FacilityStartDate.Value : 0),
                PercentageOfAnnualInterestRate = x.PercentageOfAnnualInterestRate,
                UsageType = x.UsageType ?? "",
                Status = x.Status ?? "",
                Tenor = x.Tenor.HasValue ? x.Tenor.Value : 0,
                Installment = x.FacilityType == "Credit Card" ? (decimal)(x.Plafond * 0.10) : CalculateInstallment(x.Plafond, x.PercentageOfAnnualInterestRate, x.Tenor.Value),
                DBR = x.MonthlyIncome != 0 ? x.Installment / x.MonthlyIncome : 0
            }).ToList();


            return data;
        }

        private static decimal CalculateInstallment(decimal plafond, decimal annualInterestRate, int tenor)
        {
            decimal monthlyInterestRate = (annualInterestRate / 100) / 12;
            return (plafond * monthlyInterestRate) / (decimal)(1 - Math.Pow(1 + (double)monthlyInterestRate, -tenor));
        }

        public UseCase1ViewModel GetData(int dpd, int col)
        {
            var result = new UseCase1ViewModel();


            var data = dbContext.Table_01.AsEnumerable();

            var projectedData = data
            .SelectMany(x => Enumerable.Range(1, 24)
                .Select(i => new
                {
                    x.jeniskredit,
                    x.kreditno,
                    x.Active,
                    kolom = $"tahunbulan{i:D2}",
                    dpd = (int)x.GetType().GetProperty($"tahunbulan{i:D2}ht").GetValue(x),
                    tahunbulan = (string)x.GetType().GetProperty($"tahunBulan{i:D2}").GetValue(x),
                    col = (int)x.GetType().GetProperty($"tahunBulan{i:D2}Kol").GetValue(x)
                })
            )
            .ToList();

            result.listData = projectedData
            .Where(x => (x.dpd > dpd || x.col > col) && x.Active?.ToLower() == "Y".ToLower())
            .Select(x => new UseCase1DataViewModel()
            {
                jeniskredit = x.jeniskredit,
                kreditno = x.kreditno,
                Active = x.Active,
                kolom = x.kolom,
                DPD = x.dpd,
                TahunBulan = x.tahunbulan,
                Col = x.col
            })
            .ToList();

            result.total = result.listData.Count();

            return result ?? new UseCase1ViewModel();
        }

        public List<UseCase3ViewModel> GetAllUseCase3List()
        {
            var data = dbContext.Table_03.Select(x => new UseCase3ViewModel()
            {
                CIF = x.CIF.ToString(),
                MonthlyIncome = x.MonthlyIncome,
                Age = x.Age,
                Gender = x.Gender,
                Occupation = x.Occupation,
                TotalScore = (decimal)(33.53 +
                (x.Age <= 20 ? 1.24 * 13.45 :
                (x.Age > 20 && x.Age <= 30 ? 1.24 * 17.88 :
                (x.Age > 30 && x.Age <= 50 ? 1.24 * 18.98 :
                1.24 * 19.33))) +
                (x.Gender == "Male" ? 9.42 * 24.44 : 9.42 * 21.89) +
                (x.Occupation == "Employee" ? 7.34 * 12.45 :
                (x.Occupation == "Entrepreneur" ? 7.34 * 9.34 :
                7.34 * 6.78))),
                RiskSegment = CalculateRiskSegment(x),
                FacultyLimit = (decimal)CalculateFacultyLimit(x)
            }).ToList();

            return data;
        }

        public static string CalculateRiskSegment(UseCase_03 x)
        {
            double totalScore = 33.53 +
                (x.Age <= 20 ? 1.24 * 13.45 :
                (x.Age > 20 && x.Age <= 30 ? 1.24 * 17.88 :
                (x.Age > 30 && x.Age <= 50 ? 1.24 * 18.98 :
                1.24 * 19.33))) +
                (x.Gender == "Male" ? 9.42 * 24.44 : 9.42 * 21.89) +
                (x.Occupation == "Employee" ? 7.34 * 12.45 :
                (x.Occupation == "Entrepreneur" ? 7.34 * 9.34 :
                7.34 * 6.78));

            if (totalScore < 325)
            {
                return "Very High Risk (VHR)";
            }
            else if (totalScore >= 325 && totalScore < 350)
            {
                return "Very High Risk (VHR)";
            }
            else if (totalScore >= 350 && totalScore < 370)
            {
                return "High Risk (HR)";
            }
            else if (totalScore >= 370 && totalScore < 375)
            {
                return "Medium Risk (MR)";
            }
            else if (totalScore >= 375 && totalScore < 379)
            {
                return "Low Risk (LR)";
            }
            else if (totalScore >= 379 && totalScore < 390)
            {
                return "Very Low Risk (VLR)";
            }
            else
            {
                return "Ultra Low Risk (ULR)";
            }
        }

        public static double CalculateFacultyLimit(UseCase_03 x)
        {
            double totalScore = 33.53 +
                (x.Age <= 20 ? 1.24 * 13.45 :
                (x.Age > 20 && x.Age <= 30 ? 1.24 * 17.88 :
                (x.Age > 30 && x.Age <= 50 ? 1.24 * 18.98 :
                1.24 * 19.33))) +
                (x.Gender == "Male" ? 9.42 * 24.44 : 9.42 * 21.89) +
                (x.Occupation == "Employee" ? 7.34 * 12.45 :
                (x.Occupation == "Entrepreneur" ? 7.34 * 9.34 :
                7.34 * 6.78));

            if (x.Occupation == "Employee")
            {
                if (totalScore < 325)
                {
                    return x.MonthlyIncome * 1.5;
                }
                else if (totalScore >= 325 && totalScore < 350)
                {
                    return x.MonthlyIncome * 2;
                }
                else if (totalScore >= 350 && totalScore < 370)
                {
                    return x.MonthlyIncome * 3.5;
                }
                else if (totalScore >= 370 && totalScore < 375)
                {
                    return x.MonthlyIncome * 6;
                }
                else if (totalScore >= 375 && totalScore < 379)
                {
                    return x.MonthlyIncome * 8;
                }
                else
                {
                    return x.MonthlyIncome * 10;
                }
            }
            else if (x.Occupation == "Entrepreneur")
            {
                // Adjust the multiplier for Self Employed here
                if (totalScore < 325)
                {
                    return x.MonthlyIncome * 1;
                }
                else if (totalScore >= 325 && totalScore < 350)
                {
                    return x.MonthlyIncome * 1.3;
                }
                else if (totalScore >= 350 && totalScore < 370)
                {
                    return x.MonthlyIncome * 1.5;
                }
                else if (totalScore >= 370 && totalScore < 375)
                {
                    return x.MonthlyIncome * 3;
                }
                else if (totalScore >= 375 && totalScore < 379)
                {
                    return x.MonthlyIncome * 4;
                }
                else
                {
                    return x.MonthlyIncome * 5;
                }
            }
            else
            {
                // Use a default value for 'Others' occupation or adjust as needed
                return x.MonthlyIncome;
            }
        }

    }
}
