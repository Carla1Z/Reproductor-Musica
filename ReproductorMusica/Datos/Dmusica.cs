using ReproductorMusica.Modelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ReproductorMusica.Datos
{
    public class Dmusica
    {
        public async Task<List<Mmusica>> ListarMusica()
        {
            var lista = new List<Mmusica>()
            {
                new Mmusica()
                {
                    Nombre = "I Wanna Go",
                    Autor = "Britney Spears",
                    Icono = "https://i.ibb.co/qRSv0SN/Britney.jpg",
                    Url = "https://firebasestorage.googleapis.com/v0/b/musicaapp-3e31c.appspot.com/o/Britney%20Spears%20-%20I%20Wanna%20Go.mp3?alt=media&token=b5a119c7-7d99-4f56-8173-8a1c6fac9b8c"
                },
                };
            return lista;
        }
    }
}

