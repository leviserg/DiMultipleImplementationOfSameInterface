using DiMultipleImplementationOfSameInterface.Services.Interfaces;

namespace DiMultipleImplementationOfSameInterface.Services.Implementations
{
    public class RandomNumberService : INumberService
    {
        public int GetNumber()
        {
            return new Random().Next(0,100);
        }
    }
}
