﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Water_Jug_Challenge.Application.Contracts.Services;
using Water_Jug_Challenge.Domain;

namespace Water_Jug_Challenge.Application.Features.CapacityY
{
    public class CapacityYHandler : IgenericServices<JugsY>
    {
        public async Task<JugsY> Llenar(JugsY value)
        {
            Stack<int> pila = new Stack<int>();
            int capacidad = value.Y;
            try
            {
                if (pila.Count <= value.Y)
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

            var capacidadY = new JugsY { Y = pila.Count };

            return await Task.FromResult(capacidadY);
        }

        public Task<JugsY> Transferir(JugsY value)
        {
            throw new NotImplementedException();
        }

        public async Task<JugsY> Vaciar(JugsY value)
        {
            Stack<int> pila = new Stack<int>();
            int capacidad = value.Y;
            try
            {
                if (pila.Count <= value.Y)
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

            var capacidadY = new JugsY { Y = pila.Count };

            return await Task.FromResult(capacidadY);
        }
    }
}