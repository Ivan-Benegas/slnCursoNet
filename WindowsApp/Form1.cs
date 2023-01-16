using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApp.Entidades;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearProductoyClienteIndividuo_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();

            producto.Nombre = "Celular Samsung Z100.";
            producto.Descripcion = "Último modelo sacado por la empresa Samsung.";
            producto.PrecioCosto = 1000;
            producto.Margen = 0.3;
            producto.IVA = 0.21;
            producto.Proveedor = "Samsung";
            producto.Categoria = "Celulares";
            producto.SubCategoria = "Smartphones";


            ClienteIndividuo clienteIndividuo = new ClienteIndividuo();

            clienteIndividuo.Nombre = "Pedro";
            clienteIndividuo.Apellido = "González";
            clienteIndividuo.CUIT = "123456789";
            clienteIndividuo.Email = "pedrogonzalez@gmail.com";
            clienteIndividuo.Telefono = "987654321";
            clienteIndividuo.Direccion = "Avenida Hola 123";

            MessageBox.Show(
                "El nombre del producto es " + producto.Nombre + "\n" +
                "La descripción es " + producto.Descripcion + "\n" +
                "El precio de costo es " + producto.PrecioCosto + "\n" +
                "El margen de ganancia es " + producto.Margen + "\n" +
                "El valor de IVA es " + producto.IVA + "\n" +
                "El precio bruto es " + producto.PrecioBruto + "\n"+
                "El precio de venta es " + producto.PrecioVenta + "\n" +
                "El proveedor es " + producto.Proveedor + "\n" +
                "La categoría a la que pertence el producto es " + producto.Categoria + "\n" +
                "La subcategoría a la que pertenece es " + producto.SubCategoria + "\n" +
                "\n" +
                "El nombre del cliente es " + clienteIndividuo.Nombre + "\n" +
                "El apellido es " + clienteIndividuo.Apellido + "\n" +
                "El CUIT es " + clienteIndividuo.CUIT + "\n" +
                "El email es " + clienteIndividuo.Email + "\n" +
                "El teléfono es " + clienteIndividuo.Telefono + "\n" +
                "La dirección es " + clienteIndividuo.Direccion);

        }
    }
}
