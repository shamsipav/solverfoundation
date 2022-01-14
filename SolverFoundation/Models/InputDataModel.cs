using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SolverFoundation.Models
{
    public class InputDataModel
    {
        // ОГРАНИЧЕНИЯ
        /// <summary>
        /// Стоимость кокса, руб/(кг кокса)
        /// </summary>
        public double CostOfCoke { get; set; }
        /// <summary>
        /// Стоимость природного газа, руб/(м3 ПГ)
        /// </summary>
        public double CostOfNaturalGas { get; set; }
        /// <summary>
        /// Резерв по расходу природного газа в целом по цеху, м3/ч
        /// </summary>
        public double ReserveNaturalGasConsumptions { get; set; }
        /// <summary>
        /// Запасы кокса по цеху, т/ч
        /// </summary>
        public double CokeReserves { get; set; }
        /// <summary>
        /// Требуемое производство чугуна в цехе, т/ ч
        /// </summary>
        public double RequiredChugunProduction { get; set; }
        /// <summary>
        /// Условно постоянный коэффициент
        /// </summary>
        public double KoefCounditionallyConstant { get; set; }

        public SolverRow[] solverRows { get; set; }

        // ПОЛУЧЕНИЕ ИСХОДНЫХ ЗНАЧЕНИЙ
        public static InputDataModel GetDefaultData()
        {
            return new InputDataModel
            {
                CostOfCoke = 1.8,
                CostOfNaturalGas = 0.6,
                ReserveNaturalGasConsumptions = 120000,
                CokeReserves = 520,
                RequiredChugunProduction = 1100,
                KoefCounditionallyConstant = 1,

                solverRows = new SolverRow[] {
                    new SolverRow {
                        xId = 1,
                        NaturalGasConsumptionBasePeriod = 15000,
                        NaturalGasConsumptionBillingPeriod = 15000,
                        MinimumAllowableConsumptionOfNaturalGas = 10000,
                        MaximumAllowableConsumptionOfNaturalGas = 20000,
                        CokeConsumptionBasePeriod = 64.25,
                        EquivalentCokeReplacementBasePeriod = 0.59,
                        ChugunProductivityBasePeriod = 146.4,
                        SeraContentInChugunBasePeriod = 0.015,
                        MinimumAllowedSeraContent = 0,
                        MaximumAllowedSeraContent = 0.025,
                        KoefChangeChugunProductionChangeNaturalGas = -0.0007295,
                        KoefChangeChugunProductionIncreaseCokeConsumption = -0.00297,
                        KoefChangeSeraIncreaseNaturalGas = -0.0000034,
                        KoefChangeSeraIncreaceCokeConsumption = -0.000003,
                        KoefChangeSeraIncreaceFurnanceCapacity = 0
                    },
                    new SolverRow {
                        xId = 2,
                        NaturalGasConsumptionBasePeriod = 17000,
                        NaturalGasConsumptionBillingPeriod = 17000,
                        MinimumAllowableConsumptionOfNaturalGas = 10000,
                        MaximumAllowableConsumptionOfNaturalGas = 20000,
                        CokeConsumptionBasePeriod = 66.76,
                        EquivalentCokeReplacementBasePeriod = 0.53,
                        ChugunProductivityBasePeriod = 136.4,
                        SeraContentInChugunBasePeriod = 0.014,
                        MinimumAllowedSeraContent = 0,
                        MaximumAllowedSeraContent = 0.025,
                        KoefChangeChugunProductionChangeNaturalGas = -0.0006695,
                        KoefChangeChugunProductionIncreaseCokeConsumption = -0.00297,
                        KoefChangeSeraIncreaseNaturalGas = -0.0000034,
                        KoefChangeSeraIncreaceCokeConsumption = -0.0000029,
                        KoefChangeSeraIncreaceFurnanceCapacity = 0
                    },
                    new SolverRow {
                        xId = 3,
                        NaturalGasConsumptionBasePeriod = 11000,
                        NaturalGasConsumptionBillingPeriod = 11000,
                        MinimumAllowableConsumptionOfNaturalGas = 10000,
                        MaximumAllowableConsumptionOfNaturalGas = 20000,
                        CokeConsumptionBasePeriod = 56.08,
                        EquivalentCokeReplacementBasePeriod = 0.85,
                        ChugunProductivityBasePeriod = 134.3,
                        SeraContentInChugunBasePeriod = 0.013,
                        MinimumAllowedSeraContent = 0,
                        MaximumAllowedSeraContent = 0.025,
                        KoefChangeChugunProductionChangeNaturalGas = 0,
                        KoefChangeChugunProductionIncreaseCokeConsumption = -0.002928,
                        KoefChangeSeraIncreaseNaturalGas = -0.0000035,
                        KoefChangeSeraIncreaceCokeConsumption = -0.0000032,
                        KoefChangeSeraIncreaceFurnanceCapacity = 0
                    },
                    new SolverRow {
                        xId = 4,
                        NaturalGasConsumptionBasePeriod = 13000,
                        NaturalGasConsumptionBillingPeriod = 13000,
                        MinimumAllowableConsumptionOfNaturalGas = 10000,
                        MaximumAllowableConsumptionOfNaturalGas = 20000,
                        CokeConsumptionBasePeriod = 49.78,
                        EquivalentCokeReplacementBasePeriod = 0.59,
                        ChugunProductivityBasePeriod = 122.3,
                        SeraContentInChugunBasePeriod = 0.014,
                        MinimumAllowedSeraContent = 0,
                        MaximumAllowedSeraContent = 0.025,
                        KoefChangeChugunProductionChangeNaturalGas = -0.00072373,
                        KoefChangeChugunProductionIncreaseCokeConsumption = -0.002897,
                        KoefChangeSeraIncreaseNaturalGas = -0.0000033,
                        KoefChangeSeraIncreaceCokeConsumption = -0.0000029,
                        KoefChangeSeraIncreaceFurnanceCapacity = 0
                    },
                    new SolverRow {
                        xId = 5,
                        NaturalGasConsumptionBasePeriod = 12000,
                        NaturalGasConsumptionBillingPeriod = 12000,
                        MinimumAllowableConsumptionOfNaturalGas = 10000,
                        MaximumAllowableConsumptionOfNaturalGas = 20000,
                        CokeConsumptionBasePeriod = 62.92,
                        EquivalentCokeReplacementBasePeriod = 0.75,
                        ChugunProductivityBasePeriod = 138.2,
                        SeraContentInChugunBasePeriod = 0.017,
                        MinimumAllowedSeraContent = 0,
                        MaximumAllowedSeraContent = 0.025,
                        KoefChangeChugunProductionChangeNaturalGas = -0.0007724,
                        KoefChangeChugunProductionIncreaseCokeConsumption = -0.00297,
                        KoefChangeSeraIncreaseNaturalGas = -0.0000034,
                        KoefChangeSeraIncreaceCokeConsumption = -0.0000031,
                        KoefChangeSeraIncreaceFurnanceCapacity = 0
                    },
                    new SolverRow {
                        xId = 6,
                        NaturalGasConsumptionBasePeriod = 15000,
                        NaturalGasConsumptionBillingPeriod = 15000,
                        MinimumAllowableConsumptionOfNaturalGas = 10000,
                        MaximumAllowableConsumptionOfNaturalGas = 20000,
                        CokeConsumptionBasePeriod = 60.02,
                        EquivalentCokeReplacementBasePeriod = 0.79,
                        ChugunProductivityBasePeriod = 138.8,
                        SeraContentInChugunBasePeriod = 0.016,
                        MinimumAllowedSeraContent = 0,
                        MaximumAllowedSeraContent = 0.025,
                        KoefChangeChugunProductionChangeNaturalGas = -0.0006872,
                        KoefChangeChugunProductionIncreaseCokeConsumption = -0.00297,
                        KoefChangeSeraIncreaseNaturalGas = -0.0000034,
                        KoefChangeSeraIncreaceCokeConsumption = -0.0000028,
                        KoefChangeSeraIncreaceFurnanceCapacity = 0
                    },
                    new SolverRow {
                        xId = 7,
                        NaturalGasConsumptionBasePeriod = 17000,
                        NaturalGasConsumptionBillingPeriod = 17000,
                        MinimumAllowableConsumptionOfNaturalGas = 10000,
                        MaximumAllowableConsumptionOfNaturalGas = 20000,
                        CokeConsumptionBasePeriod = 81.68,
                        EquivalentCokeReplacementBasePeriod = 0.87,
                        ChugunProductivityBasePeriod = 191.4,
                        SeraContentInChugunBasePeriod = 0.013,
                        MinimumAllowedSeraContent = 0,
                        MaximumAllowedSeraContent = 0.025,
                        KoefChangeChugunProductionChangeNaturalGas = -0.0007284,
                        KoefChangeChugunProductionIncreaseCokeConsumption = -0.003316,
                        KoefChangeSeraIncreaseNaturalGas = -0.0000034,
                        KoefChangeSeraIncreaceCokeConsumption = -0.000003,
                        KoefChangeSeraIncreaceFurnanceCapacity = 0
                    },
                    new SolverRow {
                        xId = 8,
                        NaturalGasConsumptionBasePeriod = 14000,
                        NaturalGasConsumptionBillingPeriod = 14000,
                        MinimumAllowableConsumptionOfNaturalGas = 10000,
                        MaximumAllowableConsumptionOfNaturalGas = 20000,
                        CokeConsumptionBasePeriod = 69.7,
                        EquivalentCokeReplacementBasePeriod = 0.77,
                        ChugunProductivityBasePeriod = 151.6,
                        SeraContentInChugunBasePeriod = 0.014,
                        MinimumAllowedSeraContent = 0,
                        MaximumAllowedSeraContent = 0.025,
                        KoefChangeChugunProductionChangeNaturalGas = -0.0007305,
                        KoefChangeChugunProductionIncreaseCokeConsumption = -0.00356,
                        KoefChangeSeraIncreaseNaturalGas = -0.0000034,
                        KoefChangeSeraIncreaceCokeConsumption = -0.0000031,
                        KoefChangeSeraIncreaceFurnanceCapacity = 0
                    }
                }
            };
        }
    }
}