using System.Reflection;

namespace ControlExpenses.Application
{
    public class AssemblyReference
    {
        public const string NAMESPACE = "ControlExpenses.Application";

        public static readonly Assembly Assembly = typeof(AssemblyReference).Assembly;
    }
}
