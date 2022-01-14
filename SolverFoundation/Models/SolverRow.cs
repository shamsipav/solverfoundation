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