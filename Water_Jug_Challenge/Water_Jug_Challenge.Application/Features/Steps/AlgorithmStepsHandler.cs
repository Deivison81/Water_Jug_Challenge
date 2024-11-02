using Water_Jug_Challenge.Application.Contracts.Services;
using Water_Jug_Challenge.Application.Models;

namespace Water_Jug_Challenge.Application.Features.Steps
{
    public class AlgorithmStepsHandler
    {
        private readonly List<ISteps> _steps;

        public AlgorithmStepsHandler(params ISteps[] steps)
        {
            _steps = steps.ToList();
            InitializeSteps();
        }

        private void InitializeSteps()
        {
            for (int i = 0; i < _steps.Count - 1; i++)
            {
                _steps[i].Arist.Add((Stepsby)_steps[i + 1]);
            }
            
        }


        public static List<int> solutions(Stepsby countsteps)
        {
            List<int> result = new List<int>();
            if (countsteps != null)
            {
                var valuesteps = countsteps.ValueSteps;
                foreach (var item in countsteps.Arist)
                {
                   result.AddRange(solutions(item));
                }
            }
            return result;
        }

        
        
       
    }
}
