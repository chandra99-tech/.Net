namespace _13Demo_NotePad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SpellCheckerFactory factory = new SpellCheckerFactory();
            ISpellChecker SomeSpellChecker = factory.GetSomeSpellChecker("en");
            NotePad notePad = new NotePad(SomeSpellChecker);
            notePad.Cut();
            notePad.SpellChecker();

            HindiSpellChecker hindiChecker = new HindiSpellChecker();
            NotePad forHindi = new NotePad(hindiChecker);
            forHindi.Cut();
            forHindi.SpellChecker();

            KlingonSpellChecker klingonCheck = new KlingonSpellChecker();
            NotePad forKlingon = new NotePad(klingonCheck);
            forKlingon.Cut();
            forKlingon.SpellChecker();
        }
    }
}

public class NotePad
{
    private ISpellChecker _checker;

    public NotePad(ISpellChecker checker)
    {
        SpellCheckerFactory factory = new SpellCheckerFactory();

        if (checker == null)
        {
            _checker = factory.GetSomeSpellChecker("en");
        }
        else
        {
            _checker = checker;
        }
    }

    public void Cut()
    {
        Console.WriteLine("Text Cut Functionality Done");
    }

    public void Copy()
    {
        Console.WriteLine("Text Copy Functionality Done");
    }

    public void Paste()
    {
        Console.WriteLine("Text Paste Functionality Done");
    }

    public void SpellChecker()
    {
        _checker.DoSpellChecker();
    }
}
    

    public interface ISpellChecker
    {
        void DoSpellChecker();
    }

    public class SpellCheckerFactory
    {
        ISpellChecker _someSpellChecker = null;
        public ISpellChecker GetSomeSpellChecker(string lang)
        {
            switch(lang)
            {
                case "en":
                    _someSpellChecker = new EnglishSpellChecker();
                    break;

                case "gr":
                    _someSpellChecker = new GermanSpellChecker();
                    break;

                case "sp":
                    _someSpellChecker = new SpanishSpellChecker();
                break;

                default:
                    _someSpellChecker = new EnglishSpellChecker();
                    break ;
            }
        return _someSpellChecker;
        }

    }

    public class EnglishSpellChecker:ISpellChecker
    {
        public void DoSpellChecker()
        {
            Console.WriteLine("Spell Check done For English Text");
        }
    }

    public class GermanSpellChecker : ISpellChecker
    {
        public void DoSpellChecker()
        {
            Console.WriteLine("Spell Check done For German Text");
        }
    }

    public class SpanishSpellChecker : ISpellChecker
    {
        public void DoSpellChecker()
        {
            Console.WriteLine("Spell Check done For Spanish Text");
        }
    }

    public class HindiSpellChecker : ISpellChecker
    {
        public void DoSpellChecker()
        {
            Console.WriteLine("Spell Check done For Hindi Text");
        }
    }

    public class KlingonSpellChecker : ISpellChecker
    {
        public void DoSpellChecker()
        {
            Console.WriteLine("Spell Check done For Klingon Text");
        }
    }
