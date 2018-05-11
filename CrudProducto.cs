using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDoble2
{
    class CrudProducto
    {
        Producto inicio = null;
        Producto ultimo = null;
        public void Agregar(Producto nuevo)
        {
            if (inicio == null)
            {
                inicio = nuevo;
                ultimo = nuevo;
            } else if (nuevo.Codigo <= inicio.Codigo){
                inicio.Anterior = nuevo;
                nuevo.Siguiente = inicio;
                inicio = nuevo;
            }
            else if (nuevo.Codigo >= ultimo.Codigo)
            {
                ultimo.Siguiente = nuevo;
                nuevo.Anterior = ultimo;
                ultimo = nuevo;
            }
            else
            {
                Producto p = inicio;
                while (nuevo.Codigo > p.Codigo)
                {
                    p = p.Siguiente;
                }
                nuevo.Anterior = p.Anterior;
                nuevo.Siguiente = p;
                p.Anterior.Siguiente = nuevo;
                p.Anterior = nuevo;
            }
        }

        public string Buscar(int codigo)
        {
            Producto p = inicio;
            while(p.Codigo != codigo)
            {
                p = p.Siguiente;
            }
            return p.ToString();
        }

        public void Eliminar(int codigo)
        {
            if(inicio.Codigo == codigo)
            {
                EliminarInicio();
            }
            else if (ultimo.Codigo == codigo)
            {
                EliminarUltimo();
            }
            else
            {
                Producto p = inicio;
                while(p.Codigo != codigo)
                {
                    p = p.Siguiente;
                }
                p.Anterior.Siguiente = p.Siguiente;
                p.Siguiente.Anterior = p.Anterior;
            }
        }

        public string Listar()
        {
            string lista = "";
            Producto p = inicio;
            while (p != null)
            {
                lista += p.ToString();
                p = p.Siguiente;
            }
            return lista;
        }

        public void EliminarInicio()
        {
            if(inicio == null)
            {
                System.Windows.Forms.MessageBox.Show("Lista vacía");
            } else
            {
                inicio.Siguiente.Anterior = null;
                inicio = inicio.Siguiente;
            }
            
        }

        public void EliminarUltimo()
        {
            if (ultimo == null)
            {
                System.Windows.Forms.MessageBox.Show("Lista vacía");
            }
            else 
            {
                ultimo.Anterior.Siguiente = null;
                ultimo = ultimo.Anterior;
            }
        }

        public string ListarInverso()
        {
            string lista = "";
            Producto p = ultimo;
            while(p != null)
            {
                lista += p.ToString();
                p = p.Anterior;
            }
            return lista;
        }
    }
}
