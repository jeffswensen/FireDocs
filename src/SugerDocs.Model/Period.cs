
namespace SugerDocs.Model {
    public class Period {
        public int PeriodId { get; set; }
        
    }

    public enum PeriodType {
        Actual, Reforecast, Budget, Yearly
    }
}
