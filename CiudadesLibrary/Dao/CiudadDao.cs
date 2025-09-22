using CiudadesLibrary.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiudadesLibrary.Dao
{
    public class CiudadDao
    {
        private Ciudad[] listado = new Ciudad[10];
        int pos = 0;

        public void AgregarCiudad(Ciudad ciudad)
        {
            try
            {
                listado[pos] = ciudad;
                pos++;
            }catch(IndexOutOfRangeException)
            {
                Console.WriteLine("no puedes agregar mas de 10 ciudades");
            }

        }
        public Ciudad[] MostrarCiudad()
        {
            return listado;
        }
        
    }
}
