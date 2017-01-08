﻿namespace EagleEye.Defects
{
    public class DefectsManager
    {
        ICommand _cmdDefectCountByProduct;
        ICommand _cmdDefectCountOfSeverityByProduct;
        ICommand _cmdDefectCountByInjectionStage;
        ICommand _cmdDefectCountByType;
        ICommand _cmdDefectsDistributionByType;
        ICommand _cmdDefectCountByCreator;
        ICommand _cmdDefectCountOfSeverityByCreator;
        ICommand _cmdDefectCountOfTypeByCreator;

        public DefectsManager
        (
            ICommand cmdDefectCountByProduct,
            ICommand DefectCountOfSeverityByProduct,
            ICommand cmdDefectCountByInjectionStage,
            ICommand cmdDefectCountByType,
            ICommand cmdDefectsDistributionByType,
            ICommand cmdDefectCountByCreator,
            ICommand cmdDefectCountOfSeverityByCreator,
            ICommand cmdDefectCountOfTypeByCreator
        )
        {
            _cmdDefectCountByProduct = cmdDefectCountByProduct;
            _cmdDefectCountOfSeverityByProduct = DefectCountOfSeverityByProduct;
            _cmdDefectCountByInjectionStage = cmdDefectCountByInjectionStage;
            _cmdDefectCountByType = cmdDefectCountByType;
            _cmdDefectsDistributionByType = cmdDefectsDistributionByType;
            _cmdDefectCountByCreator = cmdDefectCountByCreator;
            _cmdDefectCountOfSeverityByCreator = cmdDefectCountOfSeverityByCreator;
            _cmdDefectCountOfTypeByCreator = cmdDefectCountOfTypeByCreator;
        }

        public void GenerateDefectCountByProduct()
        {
            _cmdDefectCountByProduct.Execute();
        }
        public void GenerateDefectSeverityByProduct()
        {
            _cmdDefectCountOfSeverityByProduct.Execute();
        }
        public void GenerateDefectCountByInjectionStage()
        {
            _cmdDefectCountByInjectionStage.Execute();
        }
        public void GenerateDefectCountByType()
        {
            _cmdDefectCountByType.Execute();
        }
        public void GenerateDefectsDistributionByType()
        {
            _cmdDefectsDistributionByType.Execute();
        }
        public void GenerateDefectCountByCreator()
        {
            _cmdDefectCountByCreator.Execute();
        }
        public void GenerateDefectSeverityCountByCreator()
        {
            _cmdDefectCountOfSeverityByCreator.Execute();
        }
        public void GenerateDefectCountOfTypeByCreator()
        {
            _cmdDefectCountOfTypeByCreator.Execute();
        }
    }
}
