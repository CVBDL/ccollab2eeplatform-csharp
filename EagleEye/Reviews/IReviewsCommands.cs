﻿namespace EagleEye.Reviews
{
    public interface IReviewsCommands
    {
        void GenerateReviewCountByMonth(string settingsKey);
        void GenerateReviewCountByProduct(string settingsKey);
        void GenerateCodeCommentDensityUploaded(string settingsKey);
        void GenerateCodeCommentDensityChanged(string settingsKey);
        void GenerateCodeDefectDensityUploaded(string settingsKey);
        void GenerateDefectDensityChangedByProduct(string settingsKey);
        void GenerateReviewCountByCreator();
        void GenerateInspectionRateByMonthFromProduct();
        void GenerateDefectDensityChangedByMonthFromProduct();
    }
}
