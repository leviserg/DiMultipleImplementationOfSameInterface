using DiMultipleImplementationOfSameInterface.Services.Interfaces;

namespace DiMultipleImplementationOfSameInterface.Services.Implementations
{
    public class FiveNumberService : INumberService
    {
        public int GetNumber()
        {
            return 5;
        }
    }
}
