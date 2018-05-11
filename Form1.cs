using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDoble2
{
    public partial class Form1 : Form
    {
        CrudProducto _crud = new CrudProducto();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            _crud.Agregar(new Producto
            {
                Codigo = Convert.ToInt32(txtCodigo2.Text),
                Cantidad = Convert.ToInt32(txtNombre2.Text),
                Costo = Convert.ToInt32(txtCosto2.Text),
                Nombre = txtNombre2.Text,
                Descripcion = txtDescripcion2.Text
            });
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = _crud.Buscar(Convert.ToInt32(txtCodigo2.Text));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            _crud.Eliminar(Convert.ToInt32(txtCodigo2.Text));
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = _crud.Listar();
        }

        private void btnEliminarInicio_Click(object sender, EventArgs e)
        {
            _crud.EliminarInicio();
        }

        private void btnEliminarUltimo_Click(object sender, EventArgs e)
        {
            _crud.EliminarUltimo();
        }

        private void btnListarInverso_Click(object sender, EventArgs e)
        {
            txtResultado.Text = _crud.ListarInverso();
        }
    }
}
