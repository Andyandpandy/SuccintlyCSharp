using System;
namespace Chapter06
{
    public interface IReport
    {
        DateTime Date { get; set; }
    }
    public class CustomerReport : IReport
    {
        public DateTime Date { get; set; }
    }
    public class OrdersReport : IReport
    {
        public DateTime Date { get; set; }
    }
    public class ReportFactory
    {
        public static TReport Create<TReport>()
            where TReport : IReport, new()
        {
            return new TReport() { Date = DateTime.Now };
        }
    }
}
