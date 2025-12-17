namespace _10Demo_Report
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter Your Choice \n1.PDF \n2.DOCX \n3.Excel \n4.XML \n5.JSON");
                int choice = Convert.ToInt32(Console.ReadLine());

                ReportFactory factory = new ReportFactory();
                Report report = factory.GetSomeReport(choice);
                report.GenerateReport();


                Console.WriteLine("Do you want to continue? 'y/n'");
                string ynChoice = Console.ReadLine();

                if (ynChoice == "n")
                {
                    break;
                }
            }
        }
    }

    public abstract class Report
    {
        protected abstract void Parse();
        protected abstract void validate();
        protected abstract void save();
        public virtual void GenerateReport()
        {
            Parse();
            validate();
            save();
            Console.WriteLine("Report Generated");
        }
    }

    public abstract class SpecialReport: Report
    {
        protected abstract void Revalidate();
        public override void GenerateReport()
        {
            Parse();
            validate();
            Revalidate();
            save();
            Console.WriteLine("Report Generated");
        }
    }

    public class ReportFactory
    {
        public Report GetSomeReport( int choice)
        {
            Report SomeReport = null;
            switch(choice)
            {
                case 1:
                    SomeReport = new PDF();
                    break;
                case 2:
                    SomeReport = new DOCX();    
                    break;
                case 3:
                    SomeReport = new Excel();
                    break;
                case 4:
                    SomeReport = new XML();
                    break;
                case 5:
                    SomeReport = new JSON();
                    break;
                default:
                    SomeReport = null;
                    break;
            }
            return SomeReport;
        }
    }

    public class XML : SpecialReport
    {
        protected override void Parse()
        {
            Console.WriteLine("XML parsed.");
        }
        protected override void validate()
        {
            Console.WriteLine("XML validated.");
        }
        protected override void save()
        {
            Console.WriteLine("XML Saved.");
        }
        protected override void Revalidate()
        {
            Console.WriteLine("XML Re-Validated.");
        }
    }

    public class JSON : SpecialReport
    {
        protected override void Parse()
        {
            Console.WriteLine("JSON parsed.");
        }
        protected override void validate()
        {
            Console.WriteLine("JSON validated.");
        }
        protected override void save()
        {
            Console.WriteLine("JSON Saved.");
        }
        protected override void Revalidate()
        {
            Console.WriteLine("JSON Re-Validated.");
        }

    }
    public class PDF: Report
    {
        protected override void Parse()
        {
            Console.WriteLine("PDF Parsed");
        }

        protected override void validate()
        {
            Console.WriteLine("PDF Validated");
        }

        protected override void save()
        {
            Console.WriteLine("PDF Saved");
        }

       
    }

    public class DOCX:Report
    {
        protected override void Parse()
        {
            Console.WriteLine("DOCX Parsed");
        }

        protected override void validate()
        {
            Console.WriteLine("DOCX Validated");
        }

        protected override void save()
        {
            Console.WriteLine("DOCX Saved");
        }
    }

    public class Excel:Report
    {
        protected override void Parse()
        {
            Console.WriteLine("Excel Parsed");
        }

        protected override void validate()
        {
            Console.WriteLine("Excel Validated");
        }

        protected override void save()
        {
            Console.WriteLine("Excel Saved");
        }
    }

}
