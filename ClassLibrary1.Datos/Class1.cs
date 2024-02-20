using ClassLibrary1.Entidades;
using System.Drawing;

namespace ClassLibrary1.Datos
{
    public class RepositorioDeTriangulos
    {
        private readonly string _archivo = Environment.CurrentDirectory + "//Triangulos.txt";
        private readonly string _archivoCopia = Environment.CurrentDirectory + "//Triangulos.bak";
        private List<Triangulo> listaTriangulos;
        public RepositorioDeTriangulos()
        {
            listaTriangulos = new List<Triangulo>();
            LeerDatos();
        }

        private void LeerDatos()
        {
            var lector = new StreamReader(_archivo);
            while (!lector.EndOfStream)
            {
                string lineaLeida = lector.ReadLine();
                Triangulo triangulo = ConstruirTriangulo(lineaLeida);
                listaTriangulos.Add(triangulo);
            }
            lector.Close();
        }

        private Triangulo ConstruirTriangulo(string lineaLeida)
        {
            var campos = lineaLeida.Split('|');
            int ladoA = int.Parse(campos[0]);
            int ladoB = int.Parse(campos[1]);
            int ladoC = int.Parse(campos[2]);
            TipoDeBorde borde = (TipoDeBorde)int.Parse(campos[3]);
            ColorRelleno color = (ColorRelleno)int.Parse(campos[4]);
            Triangulo r = new Triangulo(ladoA, ladoB, ladoC, borde, color);
            return r;
        }
        public void Agregar(Triangulo triangulo)
        {
            using (var escritor = new StreamWriter(_archivo, true))
            {
                string lineaEscribir = ConstruirLinea(triangulo);
                escritor.WriteLine(lineaEscribir);
            }
            listaTriangulos.Add(triangulo);
        }

        private string ConstruirLinea(Triangulo triangulo)
        {
            return $"{triangulo.GetLadoA()}|" +
                $"{triangulo.GetLadoB()}|" +
                $"{triangulo.GetLadoC()}|" +
                $"{triangulo.TipoDeBorde.GetHashCode()}|" +
                $"{triangulo.TipoDeBorde.GetHashCode()}";
        }
        public int GetCantidad(int? valorFiltro = 0)
        {
            if (valorFiltro > 0)
            {
                return listaTriangulos.Count(c => c.LadoA > valorFiltro);
            }
            return listaTriangulos.Count();
        }
        public void Borrar(Triangulo trianguloBorrar)
        {
            using (var lector = new StreamReader(_archivo))
            {
                using (var escritor = new StreamWriter(_archivoCopia))
                {
                    while (!lector.EndOfStream)
                    {
                        string lineaLeida = lector.ReadLine();
                        Triangulo trianguloLeido = ConstruirTriangulo(lineaLeida);
                        if (trianguloBorrar.GetLadoA() != trianguloLeido.GetLadoA())
                        {
                            escritor.WriteLine(lineaLeida);
                        }
                    }
                }
            }
            File.Delete(_archivo);
            File.Move(_archivoCopia, _archivo);
            listaTriangulos.Remove(trianguloBorrar);
        }
        public List<Triangulo> GetLista()
        {
            LeerDatos();
            return listaTriangulos;
        }
        public List<Triangulo> Filtrar(int valorFiltro)
        {
            return listaTriangulos.Where(l => l.GetLadoA() >= valorFiltro).ToList();
        }

        public bool Existe(Triangulo triangulo)
        {
            listaTriangulos.Clear();
            LeerDatos();
            bool existe = false;
            foreach (var itemTriangulo in listaTriangulos)
            {
                if (itemTriangulo.GetLadoA() == triangulo.GetLadoA() && itemTriangulo.GetLadoB() == triangulo.GetLadoB() && itemTriangulo.GetLadoC() == triangulo.GetLadoC())
                {
                    return true;
                }
            }
            return false;
        }

        public void Editar(Triangulo trianguloCopia, Triangulo trianguloEditar)
        {
            using (var lector = new StreamReader(_archivo))
            {
                using (var escritor = new StreamWriter(_archivoCopia))
                {
                    while (!lector.EndOfStream)
                    {
                        string lineaLeida = lector.ReadLine();
                        Triangulo triangulo = ConstruirTriangulo(lineaLeida);
                        if (triangulo.GetLadoA() == triangulo.GetLadoA() && triangulo.GetLadoB() == triangulo.GetLadoB() && triangulo.GetLadoC() == triangulo.GetLadoC())
                        {
                            lineaLeida = ConstruirLinea(trianguloEditar);
                            escritor.WriteLine(lineaLeida);

                        }
                        else
                        {
                            escritor.WriteLine(lineaLeida);

                        }
                    }
                }
            }
            File.Delete(_archivo);
            File.Move(_archivoCopia, _archivo);
        }

        public List<Triangulo> OrdenarAscL1()
        {
            return listaTriangulos.OrderBy(l => l.GetLadoA()).ToList();
        }

        public List<Triangulo> OrdenarDescL1()
        {
            return listaTriangulos.OrderByDescending(l => l.GetLadoA()).ToList();
        }

        public List<Triangulo> OrdenarAscL2()
        {
            return listaTriangulos.OrderBy(l => l.GetLadoB()).ToList();
        }

        public List<Triangulo> OrdenarDescL2()
        {
            return listaTriangulos.OrderByDescending(l => l.GetLadoB()).ToList();
        }

        public List<Triangulo> OrdenarAscL3()
        {
            return listaTriangulos.OrderBy(l => l.GetLadoC()).ToList();
        }

        public List<Triangulo> OrdenarDescL3()
        {
            return listaTriangulos.OrderByDescending(l => l.GetLadoC()).ToList();
        }
    }
}
