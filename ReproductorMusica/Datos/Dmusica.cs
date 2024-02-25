using ReproductorMusica.Modelo;
using System.Collections.Generic;
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
                new Mmusica()
                {
                    Nombre = "Levitating",
                    Autor = "Dua Lipa",
                    Icono = "https://i.ibb.co/v1k9ttJ/DuaLipa.jpg",
                    Url = "https://firebasestorage.googleapis.com/v0/b/musicaapp-3e31c.appspot.com/o/Dua%20Lipa%20-%20Levitating.mp3?alt=media&token=73334d8b-f1f8-4b30-b629-0138194d93a8"
                },
                new Mmusica()
                {
                    Nombre = "Candy Store",
                    Autor = "Heathers",
                    Icono = "https://i.ibb.co/M22YSdX/heathers.jpg",
                    Url = "https://firebasestorage.googleapis.com/v0/b/musicaapp-3e31c.appspot.com/o/Heathers%20-%20Candy%20Store.mp3?alt=media&token=4d1312f5-152b-4b3e-9e19-a83a7457d895"
                },
                new Mmusica()
                {
                    Nombre = "Believer",
                    Autor = "Imagine Dragons",
                    Icono = "https://i.ibb.co/SdHBPvX/imaginedragons.jpg",
                    Url = "https://firebasestorage.googleapis.com/v0/b/musicaapp-3e31c.appspot.com/o/Imagine%20Dragons%20-%20Believer.mp3?alt=media&token=9f67b49e-1e5b-4261-84ad-df74a102c2f2"
                },
                new Mmusica()
                {
                    Nombre = "100 Ways",
                    Autor = "Jackson Wang",
                    Icono = "https://i.ibb.co/k2W9L82/jacksonwang.jpg",
                    Url = "https://firebasestorage.googleapis.com/v0/b/musicaapp-3e31c.appspot.com/o/Jackson%20Wang%20-%20100%20Ways.mp3?alt=media&token=d83b0d33-dd99-4974-9771-7d0e2d5fdd58"
                },
                new Mmusica()
                {
                    Nombre = "Bloody Mary",
                    Autor = "Lady Gaga",
                    Icono = "https://i.ibb.co/TP12d4P/ladygaga.jpg",
                    Url = "https://firebasestorage.googleapis.com/v0/b/musicaapp-3e31c.appspot.com/o/Lady%20Gaga%20-%20Bloody%20Mary.mp3?alt=media&token=88f7588a-b8ea-44ac-9e54-d4fce7bb0657"
                },
                new Mmusica()
                {
                    Nombre = "Me To",
                    Autor = "Meghan Trainor",
                    Icono = "https://i.ibb.co/pbMLGtX/Meghan-Trainor.jpg",
                    Url = "https://firebasestorage.googleapis.com/v0/b/musicaapp-3e31c.appspot.com/o/Meghan%20Trainor%20-%20Me%20To.mp3?alt=media&token=7b4183f8-7050-48cc-84ae-d86b7e1ccabd"

                },
                new Mmusica()
                {
                    Nombre = "Pocketful of Sunshine",
                    Autor = "Natasha Bedingfield",
                    Icono = "https://i.ibb.co/qg3VbLh/Natasha-Bedingfield.jpg",
                    Url = "https://firebasestorage.googleapis.com/v0/b/musicaapp-3e31c.appspot.com/o/Natasha%20Bedingfield%20-%20Pocketful%20of%20Sunshine.mp3?alt=media&token=4300a485-cfff-4e91-b1b7-e7bbd4963f4c"
                },
                new Mmusica()
                {
                    Nombre = "Unholy",
                    Autor = "Sam Smith ft Kim Petra",
                    Icono = "https://i.ibb.co/zn1m4x5/SamSmith.webp",
                    Url = "https://firebasestorage.googleapis.com/v0/b/musicaapp-3e31c.appspot.com/o/Sam%20Smith%20ft%20Kim%20Petra%20-%20Unholy%20.mp3?alt=media&token=17607108-478f-4a08-8851-1b0c5e1bf4de"
                },
                new Mmusica()
                {
                    Nombre = "The Greatest Show",
                    Autor = "The Greatest Showman",
                    Icono = "https://i.ibb.co/KzHgw0x/The-Greatest-Showman.jpg",
                    Url = "https://firebasestorage.googleapis.com/v0/b/musicaapp-3e31c.appspot.com/o/The%20Greatest%20Showman%20-%20The%20Greatest%20Show.mp3?alt=media&token=0e4e1a91-4baa-4644-b4ae-e7e3a4db6deb"
                },
                };
            return lista;
        }
    }
}

