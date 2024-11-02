
using Water_Jug_Challenge.Domain;
using Water_Jug_Challenge.Application.Contracts.Services;
using Microsoft.Extensions.Caching.Memory;
using System.Threading.Tasks;
using Water_Jug_Challenge.Application.Exception;

namespace Water_Jug_Challenge.Application.Features.CapacityX
{
    public class CapacityXHandler : IgenericServices<JugsX>
    {
        private IMemoryCache _cache;

        public CapacityXHandler(IMemoryCache cache)
        {
            _cache = cache;
        }

        public async Task<JugsX> Llenar(JugsX value)
        {
            Stack<int> pila = new Stack<int>();
            int capacidad = value.x;
            
            var result = new CapacityXValidation(value);

            try
            {
                if (pila.Count <= value.x)
                {
                    for (int i = 1; i <= capacidad; i++)
                    {
                        var item = capacidad / capacidad;
                        pila.Push(item);

                    }
                }
            }
            catch (NotFoundException ex)
            {
                throw new Exception.NotFoundException("Ha ocurrido Error:" + ex.Message);
            }

            var capacidadx = new JugsX { x = pila.Count };
            _cache.Set(1, capacidadx, DateTimeOffset.Now.AddMinutes(10));

            return await Task.FromResult(capacidadx);
 
        }

        public Task<JugsX> Transferir(JugsX value)
        {
            throw new NotImplementedException();
        }

        public async Task<JugsX> Vaciar(JugsX value)
        {
            Stack<int> pila = new Stack<int>();
            var cacheexist = _cache.Get(1);
            int capacidad = value.x;
            try
            {
                if (pila.Count <= value.x)
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

            var capacidadx = new JugsX { x = pila.Count };

            return await Task.FromResult(capacidadx);
        }
    }
}
