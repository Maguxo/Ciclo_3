using System;
using HomePetCare.App.Dominio;
using HomePetCare.App.Persistencia;
using System.Collections.Generic;

namespace HomePetCare.App.Consola
{
    public class Program
    {
        private static IRepositorioDog _repoDog = new RepositorioDog(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Salve gente bellisima");
            //buscarDog(2);
            Addperro();
            //AddVeterinario();
            //AsignaVeterinary();
            //AddperroConSignos();
            //AddSignosvitales(3);
            //ListaVital();
            //ListarCorazon();

        }
      private static void Addperro()
        {
            var dog = new Dog
            {
                NameVDog = "Leo",
                Breed = "Gto",
                FechaNacimiento = new DateTime(2021, 04, 16),
                Color = "Negro",


            };
            _repoDog.AddDog(dog);
        }

         private static void buscarDog(int idDog)
        {
            var dog = _repoDog.GetDog(idDog);
            Console.WriteLine(dog.NameVDog + " " + dog.Color);

        }
        private static void AddVeterinario()
        {
            var veterinario = new Veterinary
            {
                NameVet = "Lorena",
                LastNameVet = "Queen",
                PhoneVet = "1234567865",
                ProfCard = "6",

            };
            _repoDog.AddVeterinary(veterinario);
        }

        private static void AsignaVeterinary()
        {
            var veterinary = _repoDog.AsignaVeterinario(1, 2);
            Console.WriteLine(veterinary.NameVet + " " + veterinary.LastNameVet);
        }
        private static void AddperroConSignos()
        {
            var dog = new Dog
            {
                NameVDog = "Pesro",
                Breed = "Chiwuawua",
                FechaNacimiento = new DateTime(2006, 06, 02),
                Color = "Rosa",
                Estado = new List<EstadoVital>{
                    new EstadoVital{ FechaHora= new DateTime(2016,09,12), Valor=90,Signo= TipoVital.TensionArterial},
                    new EstadoVital{ FechaHora= new DateTime(2018,10,02), Valor=90,Signo= TipoVital.FrecuenciaRespiratoria},
                    new EstadoVital{ FechaHora= new DateTime(2019,11,04), Valor=89,Signo= TipoVital.SaturacionOxigeno}

                }

            };
            _repoDog.AddDog(dog);
        }
        private static void AddSignosvitales(int idDog)
        {

            var dog = _repoDog.GetDog(idDog);
            if (dog != null)
            {
                if (dog.Estado != null)
                {
                    dog.Estado.Add(new EstadoVital { FechaHora = new DateTime(2019, 11, 04, 18, 50, 00), Valor = 89, Signo = TipoVital.SaturacionOxigeno });
                }
                else
                {
                    dog.Estado = new List<EstadoVital>{
                            new EstadoVital{ FechaHora= new DateTime(2019,11,04), Valor=89,Signo= TipoVital.SaturacionOxigeno}

                };

                }
                _repoDog.UpdateDog(dog);

            }

        }

        private static void ListaVital()
        {
            var dog = _repoDog.GetDogMasculinos();
            foreach (Dog d in dog)
            {
                Console.WriteLine(d.NameVDog + " " + d.Breed);
            }
        }

        private static void ListarCorazon()
        {
            var dog = _repoDog.GetDogCorazon();
            foreach (Dog d in dog)
            {
                Console.WriteLine(d.NameVDog + " " + d.Color);
            }
        }
    }
}

