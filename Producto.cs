namespace ListaDoble2
{
    public class Producto
    {
        private int _codigo;
        private Producto _siguiente;
        private Producto _anterior;

        public Producto Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }

        public Producto Anterior
        {
            get { return _anterior; }
            set { _anterior = value; }
        }

        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _descripcion;

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        private int _cantidad;

        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        private double _costo;

        public double Costo
        {
            get { return _costo; }
            set { _costo = value; }
        }

        public override string ToString()
        {
            return "Codigo: " + _codigo + " Nombre: " + _nombre + " Descripcion: " + _descripcion + " Cantidad: " + _cantidad + " Costo: " + _costo + "\r\n";
        }
    }
}