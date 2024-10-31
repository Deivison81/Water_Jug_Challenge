using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Water_Jug_Challenge.Domain;
using Water_Jug_Challenge.Application.Contracts.Services;
using System.Runtime.CompilerServices;
using System.Data;
using System.ComponentModel.DataAnnotations;


namespace Water_Jug_Challenge.Application.Features.CapacityX
{
    public class CapacityXHandler : IgenericServices<JugsX>
    {
        public async Task<JugsX> Llenar(JugsX value)
        {
            Stack<int> pila = new Stack<int>();
            int capacidad = value.x;
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
            } catch (InvalidOperationException ex) 
            {
                Console.WriteLine("Excepción: Pila llena. " + ex.Message);
            }

            var capacidadx = new JugsX { x = pila.Count };

            return await Task.FromResult(capacidadx);
 
        }

        public Task<JugsX> Transferir(JugsX value)
        {
            throw new NotImplementedException();
        }

        public async Task<JugsX> Vaciar(JugsX value)
        {
            Stack<int> pila = new Stack<int>();
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
