using Microsoft.Extensions.Caching.Memory;
using Water_Jug_Challenge.Application.Contracts.Services;
using Water_Jug_Challenge.Domain;

namespace Water_Jug_Challenge.Application.Features.VolumenZ
{
    public class VolumenZHandler : IgenericServices<JugsZ>
    {
        private IMemoryCache _cache;

        public VolumenZHandler(IMemoryCache cache)
        {
            _cache = cache;
        }

        public async Task<JugsZ> Llenar(JugsZ value)
        {
            Stack<int> pila = new Stack<int>();
            int capacidad = value.z;
            try
            {
                if (pila.Count <= value.z)
                {
                    for (int i = 1; i <= capacidad; i++)
                    {
                        var item = capacidad / capacidad;
                        pila.Push(item);

                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Excepción: Pila llena. " + ex.Message);
            }

            var capacidadz = new JugsZ { z = pila.Count };

            _cache.Set(3, capacidadz, DateTimeOffset.Now.AddMinutes(10));

            return await Task.FromResult(capacidadz);
        }

        public Task<JugsZ> Transferir(JugsZ value)
        {
            throw new NotImplementedException();
        }

        public async Task<JugsZ> Vaciar(JugsZ value)
        {
            Stack<int> pila = new Stack<int>();
            int capacidad = value.z;
            try
            {
                if (pila.Count <= value.z)
                {
                    for (int i = 1; i <= capacidad; i++)
                    {
                        var item = capacidad / capacidad;
                        pila.Pop();

                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Excepción: Pila llena. " + ex.Message);
            }

            var capacidadz = new JugsZ { z = pila.Count };

            return await Task.FromResult(capacidadz);
        }
    }
}
