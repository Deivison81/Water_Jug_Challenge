
using Water_Jug_Challenge.Application.Contracts.Services;

namespace Water_Jug_Challenge.Application.Models
{
    public class Stepsby:ISteps
    {
        public int ValueSteps {  get; set; }
        public List<Stepsby> Arist {  get; set; }

        public Stepsby(int ValueSteps)
        {
            this.ValueSteps = ValueSteps;
            Arist = new List<Stepsby>();

        }
    }
}
