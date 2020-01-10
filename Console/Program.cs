using FinalDraftParser;

namespace Console
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            FinalDraft fd = XMLOp.Deserialize<FinalDraft>(@"E:\MiscCode\FinalDraftParser\FinalDraftParser\Too_V2.fdx");
            System.Console.WriteLine();
        }
    }
}