﻿namespace FinanceCalculator.Models
{
    using System.ComponentModel.DataAnnotations;
    public class CreditCalcParams
    {
        /// <summary>
        /// Размер на кредита
        /// </summary>
        [Required]
        [Range(1, 1000000000)]
        public decimal Amount { get; set; }
        /// <summary>
        /// Срок (месеци)
        /// </summary>
        [Required]
        [Range(1, 960)]
        public int Period { get; set; }
        /// <summary>
        /// Лихва (%) 
        /// </summary>
        [Required]
        [Range(1, 100)]
        public decimal Rate { get; set; }
        /// <summary>
        /// Промоционален период (месеци) 
        /// </summary>
        public int? PromotionPeriod { get; set; }
        /// <summary>
        /// Промоционална лихва(%) 
        /// </summary>
        public decimal? PromotionRate { get; set; }
        /// <summary>
        /// Гратисен период (месеци) 
        /// </summary>
        public int? GratisPeriod { get; set; }
        /// <summary>
        /// Вид погасителен план
        /// </summary>
        public bool IsAnnuityInstallments { get; set; }
        /// <summary>
        /// Първоначални такси Такса кандидатстване 
        /// </summary>
        public decimal? ApplicationFee { get; set; }
        /// <summary>
        /// Указва дали такса кандидатстване е процент
        /// </summary>
        public bool TreatApplicationFeeAsPercent { get; set; }
        /// <summary>
        /// Първоначални такси Такса обработка 
        /// </summary>
        public decimal? ProcessingFee { get; set; }
        /// <summary>
        /// Указва дали такса обработка е процент
        /// </summary>
        public bool TreatProcessingFeeAsPercent { get; set; }
        /// <summary>
        /// Първоначални такси Други такси 
        /// </summary>
        public decimal? OtherInitialFees { get; set; }
        /// <summary>
        /// Указва дали Други такси е процент
        /// </summary>
        public bool TreatOtherInitialFeesAsPercent { get; set; }
        /// <summary>
        /// Годишни такси Годишна такса управление
        /// </summary>
        public decimal? AnnualManagementFee { get; set; }
        /// <summary>
        /// Указва дали Годишна такса управление е процент
        /// </summary>
        public bool TreatAnnualManagementFeeAsPercent { get; set; }
        /// <summary>
        /// Годишни такси Други годишни такси 
        /// </summary>
        public decimal? OtherAnnualFees { get; set; }
        /// <summary>
        /// Указва дали Други годишни такси е процент
        /// </summary>
        public bool TreatOtherAnnualFeesAsPercent { get; set; }
        /// <summary>
        /// Месечни такси Месечна такса управление 
        /// </summary>
        public decimal? MonthlyManagementFee { get; set; }
        /// <summary>
        /// Указва дали Месечна такса управление е процент
        /// </summary>
        public bool TreatMonthlyManagementFeeAsPercent { get; set; }
        /// <summary>
        /// Месечни такси Други месечни такси 
        /// </summary>
        public decimal? OtherMonthlyFees { get; set; }
        /// <summary>
        /// Указва дали Други месечни такси е процент
        /// </summary>
        public bool TreatOtherMonthlyFeesAsPercent { get; set; }
    }
}
