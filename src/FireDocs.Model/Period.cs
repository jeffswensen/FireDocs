namespace FireDocs.Model {
    public class Period {
        public int PeriodId { get; set; }
        public PeriodType PeriodType { get; set; }
        public int FiscalYear { get; set; }
        public int FiscalQuarter { get; set; }
        public int FiscalMonth { get; set; }
        public int FiscalWeek { get; set; }
        public int FiscalDay { get; set; }
    }

    public enum PeriodType {
        Actual, Reforecast, Budget, Yearly, Static
    }
}
