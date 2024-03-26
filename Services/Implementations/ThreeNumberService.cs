using DiMultipleImplementationOfSameInterface.Services.Interfaces;

namespace DiMultipleImplementationOfSameInterface.Services.Implementations
{
    public class ThreeNumberService : INumberService
    {
        public int GetNumber()
        {
            return 3;
        }
    }
}
