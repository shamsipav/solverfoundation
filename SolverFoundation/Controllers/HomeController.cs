using Microsoft.SolverFoundation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SolverFoundation.Models;

namespace SolverFoundation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            InputDataModel inputData = InputDataModel.GetDefaultData();
            
            return View(inputData);
        }

        public ActionResult Result()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Result(InputDataModel inputData)
        {
            List<SolverRow> solverList = new List<SolverRow>();

            solverList.Add(inputData.solverRows[0]);
            solverList.Add(inputData.solverRows[1]);
            solverList.Add(inputData.solverRows[2]);
            solverList.Add(inputData.solverRows[3]);
            solverList.Add(inputData.solverRows[4]);
            solverList.Add(inputData.solverRows[5]);
            solverList.Add(inputData.solverRows[6]);
            solverList.Add(inputData.solverRows[7]);

            SolverContext context = SolverContext.GetContext();
            Model model = context.CreateModel();

            Set users = new Set(Domain.Any, "users");

            // Расход природного газа в базовом периоде, м3/ч
            Parameter NaturalGasConsumptionBasePeriod = new Parameter(Domain.Real, "NaturalGasConsumptionBasePeriod", users);
            NaturalGasConsumptionBasePeriod.SetBinding(solverList, "NaturalGasConsumptionBasePeriod", "xId");
            // Минимально допустимый расход природного газа, м3/ч
            Parameter MinimumAllowableConsumptionOfNaturalGas = new Parameter(Domain.Real, "MinimumAllowableConsumptionOfNaturalGas", users);
            MinimumAllowableConsumptionOfNaturalGas.SetBinding(solverList, "MinimumAllowableConsumptionOfNaturalGas", "xId");
            // Максимально допустимый расход природного газа, м3/ч
            Parameter MaximumAllowableConsumptionOfNaturalGas = new Parameter(Domain.Real, "MaximumAllowableConsumptionOfNaturalGas", users);
            MaximumAllowableConsumptionOfNaturalGas.SetBinding(solverList, "MaximumAllowableConsumptionOfNaturalGas", "xId");
            // Расход кокса в базовом периоде, т/час
            Parameter CokeConsumptionBasePeriod = new Parameter(Domain.Real, "CokeConsumptionBasePeriod", users);
            CokeConsumptionBasePeriod.SetBinding(solverList, "CokeConsumptionBasePeriod", "xId");
            // Расход кокса в проектном периоде, т/час
            Parameter CokeConsumptiontProjectPeriod = new Parameter(Domain.Real, "CokeConsumptiontProjectPeriod", users);
            CokeConsumptiontProjectPeriod.SetBinding(solverList, "CokeConsumptiontProjectPeriod", "xId");
            // Эквивалент замены кокса в базовом периоде, кг кокса / (м3 ПГ)
            Parameter EquivalentCokeReplacementBasePeriod = new Parameter(Domain.Real, "EquivalentCokeReplacementBasePeriod", users);
            EquivalentCokeReplacementBasePeriod.SetBinding(solverList, "EquivalentCokeReplacementBasePeriod", "xId");
            // Производительность по чугуну в базовом периоде, т /ч
            Parameter ChugunProductivityBasePeriod = new Parameter(Domain.Real, "ChugunProductivityBasePeriod", users);
            ChugunProductivityBasePeriod.SetBinding(solverList, "ChugunProductivityBasePeriod", "xId");
            // Производительность по чугуну в проектном периоде, т /ч
            Parameter ChugunProductivityProjectPeriod = new Parameter(Domain.Real, "ChugunProductivityProjectPeriod", users);
            ChugunProductivityProjectPeriod.SetBinding(solverList, "ChugunProductivityProjectPeriod", "xId");
            // Содержание S в чугуне в базовом периоде, %
            Parameter SeraContentInChugunBasePeriod = new Parameter(Domain.Real, "SeraContentInChugunBasePeriod", users);
            SeraContentInChugunBasePeriod.SetBinding(solverList, "SeraContentInChugunBasePeriod", "xId");
            // Содержание S в чугуне в проектном периоде, %
            Parameter SeraContentInChugunProjectPeriod = new Parameter(Domain.Real, "SeraContentInChugunProjectPeriod", users);
            SeraContentInChugunProjectPeriod.SetBinding(solverList, "SeraContentInChugunProjectPeriod", "xId");
            // Минимально допустимое [S], %
            Parameter MinimumAllowedSeraContent = new Parameter(Domain.Real, "MinimumAllowedSeraContent", users);
            MinimumAllowedSeraContent.SetBinding(solverList, "MinimumAllowedSeraContent", "xId");
            // Максимально допустимое [S], %
            Parameter MaximumAllowedSeraContent = new Parameter(Domain.Real, "MaximumAllowedSeraContent", users);
            MaximumAllowedSeraContent.SetBinding(solverList, "MaximumAllowedSeraContent", "xId");

            // КОЭФФИЦИЕНТЫ
            // Изменение производства чугуна при изменении ПГ, т чуг/(м3 ПГ)
            Parameter KoefChangeChugunProductionChangeNaturalGas = new Parameter(Domain.Real, "KoefChangeChugunProductionChangeNaturalGas", users);
            KoefChangeChugunProductionChangeNaturalGas.SetBinding(solverList, "KoefChangeChugunProductionChangeNaturalGas", "xId");
            // Изменение производства чугуна при увеличении расхода кокса, т чуг/ (кг кокса)
            Parameter KoefChangeChugunProductionIncreaseCokeConsumption = new Parameter(Domain.Real, "KoefChangeChugunProductionIncreaseCokeConsumption", users);
            KoefChangeChugunProductionIncreaseCokeConsumption.SetBinding(solverList, "KoefChangeChugunProductionIncreaseCokeConsumption", "xId");
            // Изменение[S] при увеличении расхода ПГ на 1 м3/ч
            Parameter KoefChangeSeraIncreaseNaturalGas = new Parameter(Domain.Real, "KoefChangeSeraIncreaseNaturalGas", users);
            KoefChangeSeraIncreaseNaturalGas.SetBinding(solverList, "KoefChangeSeraIncreaseNaturalGas", "xId");
            // Изменение[S] при увеличении расхода кокса на 1 кг/ч
            Parameter KoefChangeSeraIncreaceCokeConsumption = new Parameter(Domain.Real, "KoefChangeSeraIncreaceCokeConsumption", users);
            KoefChangeSeraIncreaceCokeConsumption.SetBinding(solverList, "KoefChangeSeraIncreaceCokeConsumption", "xId");
            // Изменение[S] при увеличении производительности печи на 1 т чуг/ч
            Parameter KoefChangeSeraIncreaceFurnanceCapacity = new Parameter(Domain.Real, "KoefChangeSeraIncreaceFurnanceCapacity", users);
            KoefChangeSeraIncreaceFurnanceCapacity.SetBinding(solverList, "KoefChangeSeraIncreaceFurnanceCapacity", "xId");

            model.AddParameters(
                NaturalGasConsumptionBasePeriod,
                MinimumAllowableConsumptionOfNaturalGas,
                MaximumAllowableConsumptionOfNaturalGas,
                CokeConsumptionBasePeriod,
                CokeConsumptiontProjectPeriod,
                EquivalentCokeReplacementBasePeriod,
                ChugunProductivityBasePeriod,
                ChugunProductivityProjectPeriod,
                SeraContentInChugunBasePeriod,
                SeraContentInChugunProjectPeriod,
                MinimumAllowedSeraContent,
                MaximumAllowedSeraContent,
                KoefChangeChugunProductionChangeNaturalGas,
                KoefChangeChugunProductionIncreaseCokeConsumption,
                KoefChangeSeraIncreaseNaturalGas,
                KoefChangeSeraIncreaceCokeConsumption,
                KoefChangeSeraIncreaceFurnanceCapacity
            );

            // РЕШЕНИЕ
            Decision naturalGasConsumptionBillingPeriod = new Decision(Domain.RealNonnegative, "naturalGasConsumptionBillingPeriod", users);
            model.AddDecision(naturalGasConsumptionBillingPeriod);

            // ЦЕЛЕВАЯ ФУНКЦИЯ
            model.AddGoal("goal", GoalKind.Maximize, Model.Sum(Model.ForEach(users, xId => (0.5 * (EquivalentCokeReplacementBasePeriod[xId] * inputData.CostOfCoke - inputData.CostOfNaturalGas) + 0.5 * inputData.KoefCounditionallyConstant * (KoefChangeChugunProductionChangeNaturalGas[xId] - EquivalentCokeReplacementBasePeriod[xId] * KoefChangeChugunProductionIncreaseCokeConsumption[xId])) * naturalGasConsumptionBillingPeriod[xId])));

            // ОГРАНИЧЕНИЯ
            // По расходу природного газа в целом по цеху
            model.AddConstraint("Constraint1", Model.Sum(Model.ForEach(users, xId => naturalGasConsumptionBillingPeriod[xId])) <= inputData.ReserveNaturalGasConsumptions);
            // По расходу кокса в целом по цеху
            model.AddConstraint("Constraint2", Model.Sum(Model.ForEach(users, xId => (CokeConsumptionBasePeriod[xId] + 0.001 * (NaturalGasConsumptionBasePeriod[xId] - naturalGasConsumptionBillingPeriod[xId]) * EquivalentCokeReplacementBasePeriod[xId]))) <= inputData.CokeReserves);
            // По объему производства чугуна в целом по цеху
            model.AddConstraint("Constraint3", Model.Sum(Model.ForEach(users, xId => ((naturalGasConsumptionBillingPeriod[xId] - NaturalGasConsumptionBasePeriod[xId]) * KoefChangeChugunProductionChangeNaturalGas[xId] - EquivalentCokeReplacementBasePeriod[xId] * (naturalGasConsumptionBillingPeriod[xId] - NaturalGasConsumptionBasePeriod[xId]) * KoefChangeChugunProductionIncreaseCokeConsumption[xId] + ChugunProductivityBasePeriod[xId]))) >= inputData.RequiredChugunProduction);
            // По расходу природного газа на каждую из печей
            model.AddConstraint("Constraint4", Model.ForEach(users, xId => (MinimumAllowableConsumptionOfNaturalGas[xId] <= naturalGasConsumptionBillingPeriod[xId] <= MaximumAllowableConsumptionOfNaturalGas[xId])));
            // По содержанию серы в чугуне на каждую из печей
            model.AddConstraint("Constraint5", Model.ForEach(users, xId => (MinimumAllowedSeraContent[xId] <= ((naturalGasConsumptionBillingPeriod[xId] - NaturalGasConsumptionBasePeriod[xId]) * KoefChangeSeraIncreaceCokeConsumption[xId] - EquivalentCokeReplacementBasePeriod[xId] * (naturalGasConsumptionBillingPeriod[xId] - NaturalGasConsumptionBasePeriod[xId]) * KoefChangeSeraIncreaceCokeConsumption[xId] + (KoefChangeChugunProductionChangeNaturalGas[xId] * (naturalGasConsumptionBillingPeriod[xId] - NaturalGasConsumptionBasePeriod[xId]) - EquivalentCokeReplacementBasePeriod[xId] * (naturalGasConsumptionBillingPeriod[xId] - NaturalGasConsumptionBasePeriod[xId]) * KoefChangeChugunProductionIncreaseCokeConsumption[xId]) * KoefChangeSeraIncreaceFurnanceCapacity[xId] + SeraContentInChugunBasePeriod[xId]) <= MaximumAllowedSeraContent[xId])));

            Solution solution = context.Solve();
            Report report = solution.GetReport();

            // РЕЗУЛЬТАТ ПОИСКА РЕШЕНИЯ
            for (int i = 0; i < solverList.Count; i++)
            {
                var item = inputData.solverRows[i];
                item.NaturalGasConsumptionBillingPeriod = naturalGasConsumptionBillingPeriod.GetDouble(solverList[i].xId);
            }

            // РАСЧЕТНЫЕ ЗНАЧЕНИЯ
            for (int i = 0; i < inputData.solverRows.Length; i++)
            {
                var item = inputData.solverRows[i];
                // Расход кокса в проектном периоде, т/час
                item.CokeConsumptiontProjectPeriod = (item.CokeConsumptionBasePeriod + 0.001 * (item.NaturalGasConsumptionBasePeriod - item.NaturalGasConsumptionBillingPeriod) * item.EquivalentCokeReplacementBasePeriod);
                // Производительность по чугуну в проектном периоде, т /ч
                item.ChugunProductivityProjectPeriod = ((item.NaturalGasConsumptionBillingPeriod - item.NaturalGasConsumptionBasePeriod) * item.KoefChangeChugunProductionChangeNaturalGas - item.EquivalentCokeReplacementBasePeriod * (item.NaturalGasConsumptionBillingPeriod - item.NaturalGasConsumptionBasePeriod) * item.KoefChangeChugunProductionIncreaseCokeConsumption + item.ChugunProductivityBasePeriod);
                // Содержание S в чугуне в проектном периоде, %
                item.SeraContentInChugunProjectPeriod = ((item.NaturalGasConsumptionBillingPeriod - item.NaturalGasConsumptionBasePeriod) * item.KoefChangeSeraIncreaceCokeConsumption - item.EquivalentCokeReplacementBasePeriod * (item.NaturalGasConsumptionBillingPeriod - item.NaturalGasConsumptionBasePeriod) * item.KoefChangeSeraIncreaceCokeConsumption + (item.KoefChangeChugunProductionChangeNaturalGas * (item.NaturalGasConsumptionBillingPeriod - item.NaturalGasConsumptionBasePeriod) - item.EquivalentCokeReplacementBasePeriod * (item.NaturalGasConsumptionBillingPeriod - item.NaturalGasConsumptionBasePeriod) * item.KoefChangeChugunProductionIncreaseCokeConsumption) * item.KoefChangeSeraIncreaceFurnanceCapacity + item.SeraContentInChugunBasePeriod);
            }

            return View(inputData);
        }
    }
}