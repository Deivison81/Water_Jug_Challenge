

using Water_Jug_Challenge.Application.Models;

namespace Water_Jug_Challenge.Application.Contracts.Services
{
    public interface ISteps
    {
        int ValueSteps { get; }

        List<Stepsby> Arist { get; }
    }
}
