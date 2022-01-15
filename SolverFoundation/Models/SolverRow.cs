using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SolverFoundation.Models
{
    public class SolverRow
    {
        /// <summary>
        /// Номер печи
        /// </summary>
        public int xId { get; set; }
        /// <summary>
        /// Расход природного газа в базовом периоде, м3/ч
        /// </summary>
        public double NaturalGasConsumptionBasePeriod { get; set; }
        /// <summary>
        /// Расход природного газа в расчетном периоде, м3/ч
        /// </summary>
        public double NaturalGasConsumptionBillingPeriod { get; set; }
        /// <summary>
        /// Минимально допустимый расход природного газа, м3/ч
        /// </summary>
        public double MinimumAllowableConsumptionOfNaturalGas { get; set; }
        /// <summary>
        /// Максимально допустимый расход природного газа, м3/ч
        /// </summary>
        public double MaximumAllowableConsumptionOfNaturalGas { get; set; }
        /// <summary>
        /// Расход кокса в базовом периоде, т/час
        /// </summary>
        public double CokeConsumptionBasePeriod { get; set; }
        /// <summary>
        /// Расход кокса в проектном периоде, т/час
        /// </summary>
        public double CokeConsumptiontProjectPeriod { get; set; }
        /// <summary>
        /// Эквивалент замены кокса в базовом периоде, кг кокса /(м3 ПГ)
        /// </summary>
        public double EquivalentCokeReplacementBasePeriod { get; set; }
        /// <summary>
        /// Производительность по чугуну в базовом периоде, т /ч
        /// </summary>
        public double ChugunProductivityBasePeriod { get; set; }
        /// <summary>
        /// Производительность по чугуну в проектном периоде, т /ч
        /// </summary>
        public double ChugunProductivityProjectPeriod { get; set; }
        /// <summary>
        /// Содержание S в чугуне в базовом периоде, %
        /// </summary>
        public double SeraContentInChugunBasePeriod { get; set; }
        /// <summary>
        /// Содержание S в чугуне в проектном периоде, %
        /// </summary>
        public double SeraContentInChugunProjectPeriod { get; set; }
        /// <summary>
        /// Минимально допустимое [S], %
        /// </summary>
        public double MinimumAllowedSeraContent { get; set; }
        /// <summary>
        /// Максимально допустимое [S], %
        /// </summary>
        public double MaximumAllowedSeraContent { get; set; }

        // КОЭФФИЦИЕНТЫ --------------------------------------------
        /// <summary>
        /// Изменение производства чугуна при изменении ПГ, т чуг/(м3 ПГ)
        /// </summary>
        public double KoefChangeChugunProductionChangeNaturalGas { get; set; }
        /// <summary>
        /// Изменение производства чугуна при увеличении расхода кокса, т чуг/(кг кокса)
        /// </summary>
        public double KoefChangeChugunProductionIncreaseCokeConsumption { get; set; }
        /// <summary>
        /// Изменение[S] при увеличении расхода ПГ на 1 м3/ч
        /// </summary>
        public double KoefChangeSeraIncreaseNaturalGas { get; set; }
        /// <summary>
        /// Изменение[S] при увеличении расхода кокса на 1 кг/ч
        /// </summary>
        public double KoefChangeSeraIncreaceCokeConsumption { get; set; }
        /// <summary>
        /// Изменение[S] при увеличении производительности печи на 1 т чуг/ч
        /// </summary>
        public double KoefChangeSeraIncreaceFurnanceCapacity { get; set; }
    }
}
//// Расход природного газа в базовом периоде, м3/ч
//Parameter NaturalGasConsumptionBasePeriod = new Parameter(Domain.Real, "NaturalGasConsumptionBasePeriod", users);
//NaturalGasConsumptionBasePeriod.SetBinding(solverList, "NaturalGasConsumptionBasePeriod", "xId");
//// Расход природного газа в расчетном периоде, м3/ ч
////Parameter NaturalGasConsumptionBillingPeriod = new Parameter(Domain.Real, "NaturalGasConsumptionBillingPeriod", users);
////NaturalGasConsumptionBillingPeriod.SetBinding(solverList, "NaturalGasConsumptionBillingPeriod", "xId");
//// Минимально допустимый расход природного газа, м3/ч
//Parameter MinimumAllowableConsumptionOfNaturalGas = new Parameter(Domain.Real, "MinimumAllowableConsumptionOfNaturalGas", users);
//MinimumAllowableConsumptionOfNaturalGas.SetBinding(solverList, "MinimumAllowableConsumptionOfNaturalGas", "xId");
//// Максимально допустимый расход природного газа, м3/ч
//Parameter MaximumAllowableConsumptionOfNaturalGas = new Parameter(Domain.Real, "MaximumAllowableConsumptionOfNaturalGas", users);
//MaximumAllowableConsumptionOfNaturalGas.SetBinding(solverList, "MaximumAllowableConsumptionOfNaturalGas", "xId");
//// Расход кокса в базовом периоде, т/час
//Parameter CokeConsumptionBasePeriod = new Parameter(Domain.Real, "CokeConsumptionBasePeriod", users);
//CokeConsumptionBasePeriod.SetBinding(solverList, "CokeConsumptionBasePeriod", "xId");
//// Расход кокса в проектном периоде, т/час
//Parameter CokeConsumptiontProjectPeriod = new Parameter(Domain.Real, "CokeConsumptiontProjectPeriod", users);
//CokeConsumptiontProjectPeriod.SetBinding(solverList, "CokeConsumptiontProjectPeriod", "xId");
// Эквивалент замены кокса в базовом периоде, кг кокса /(м3 ПГ)
//Parameter EquivalentCokeReplacementBasePeriod = new Parameter(Domain.Real, "EquivalentCokeReplacementBasePeriod", users);
//EquivalentCokeReplacementBasePeriod.SetBinding(solverList, "EquivalentCokeReplacementBasePeriod", "xId");
//// Производительность по чугуну в базовом периоде, т /ч
//Parameter ChugunProductivityBasePeriod = new Parameter(Domain.Real, "ChugunProductivityBasePeriod", users);
//ChugunProductivityBasePeriod.SetBinding(solverList, "ChugunProductivityBasePeriod", "xId");
//// Производительность по чугуну в проектном периоде, т /ч
//Parameter ChugunProductivityProjectPeriod = new Parameter(Domain.Real, "ChugunProductivityProjectPeriod", users);
//ChugunProductivityProjectPeriod.SetBinding(solverList, "ChugunProductivityProjectPeriod", "xId");
//// Содержание S в чугуне в базовом периоде, %
//Parameter SeraContentInChugunBasePeriod = new Parameter(Domain.Real, "SeraContentInChugunBasePeriod", users);
//SeraContentInChugunBasePeriod.SetBinding(solverList, "SeraContentInChugunBasePeriod", "xId");
//// Содержание S в чугуне в проектном периоде, %
//Parameter SeraContentInChugunProjectPeriod = new Parameter(Domain.Real, "SeraContentInChugunProjectPeriod", users);
//SeraContentInChugunProjectPeriod.SetBinding(solverList, "SeraContentInChugunProjectPeriod", "xId");
//// Минимально допустимое [S], %
//Parameter MinimumAllowedSeraContent = new Parameter(Domain.Real, "MinimumAllowedSeraContent", users);
//MinimumAllowedSeraContent.SetBinding(solverList, "MinimumAllowedSeraContent", "xId");
//// Максимально допустимое [S], %
//Parameter MaximumAllowedSeraContent = new Parameter(Domain.Real, "MaximumAllowedSeraContent", users);
//MaximumAllowedSeraContent.SetBinding(solverList, "MaximumAllowedSeraContent", "xId");

//// КОЭФФИЦИЕНТЫ
//// Изменение производства чугуна при изменении ПГ, т чуг/(м3 ПГ)
//Parameter KoefChangeChugunProductionChangeNaturalGas = new Parameter(Domain.Real, "KoefChangeChugunProductionChangeNaturalGas", users);
//KoefChangeChugunProductionChangeNaturalGas.SetBinding(solverList, "KoefChangeChugunProductionChangeNaturalGas", "xId");
// Изменение производства чугуна при увеличении расхода кокса, т чуг/(кг кокса)
//Parameter KoefChangeChugunProductionIncreaseCokeConsumption = new Parameter(Domain.Real, "KoefChangeChugunProductionIncreaseCokeConsumption", users);
//KoefChangeChugunProductionIncreaseCokeConsumption.SetBinding(solverList, "KoefChangeChugunProductionIncreaseCokeConsumption", "xId");
//// Изменение[S] при увеличении расхода ПГ на 1 м3/ч
//Parameter KoefChangeSeraIncreaseNaturalGas = new Parameter(Domain.Real, "KoefChangeSeraIncreaseNaturalGas", users);
//KoefChangeSeraIncreaseNaturalGas.SetBinding(solverList, "KoefChangeSeraIncreaseNaturalGas", "xId");
//// Изменение[S] при увеличении расхода кокса на 1 кг/ч
//Parameter KoefChangeSeraIncreaceCokeConsumption = new Parameter(Domain.Real, "KoefChangeSeraIncreaceCokeConsumption", users);
//KoefChangeSeraIncreaceCokeConsumption.SetBinding(solverList, "KoefChangeSeraIncreaceCokeConsumption", "xId");
//// Изменение[S] при увеличении производительности печи на 1 т чуг/ч
//Parameter KoefChangeSeraIncreaceFurnanceCapacity = new Parameter(Domain.Real, "KoefChangeSeraIncreaceFurnanceCapacity", users);
//KoefChangeSeraIncreaceFurnanceCapacity.SetBinding(solverList, "KoefChangeSeraIncreaceFurnanceCapacity", "xId");

//model.AddParameters(
//NaturalGasConsumptionBasePeriod,
//NaturalGasConsumptionBillingPeriod,
//MinimumAllowableConsumptionOfNaturalGas,
//MaximumAllowableConsumptionOfNaturalGas,
//CokeConsumptionBasePeriod,
//CokeConsumptiontProjectPeriod,
//EquivalentCokeReplacementBasePeriod,
//ChugunProductivityBasePeriod,
//ChugunProductivityProjectPeriod,
//SeraContentInChugunBasePeriod,
//SeraContentInChugunProjectPeriod,
//MinimumAllowedSeraContent,
//MaximumAllowedSeraContent,
//KoefChangeChugunProductionChangeNaturalGas,
//KoefChangeChugunProductionIncreaseCokeConsumption
//KoefChangeSeraIncreaseNaturalGas,
//KoefChangeSeraIncreaceCokeConsumption,
//KoefChangeSeraIncreaceFurnanceCapacity
//);