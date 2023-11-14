using ProductoAppMAUI.Models;

namespace ProductoAppMAUI
{
    public partial class NuevoProductoPage : ContentPage
    {
        public NuevoProductoPage()
        {
            InitializeComponent();
        }



        private async void OnClickGuardarProducto(object sender, EventArgs e)
        {
            int id = Utils.Utils.ListaProductos.Count + 1;

            Utils.Utils.ListaProductos.Add(new Producto
            {
                IdProducto = id,
                Nombre = NombreEntry.Text,
                Descripcion = DescripcionEntry.Text,
                Precio = Convert.ToDecimal(PrecioEntry.Text),
                Stock = 10,
                Imagen = "gazelle.png"
            });

            // Limpiar los campos de entrada despu�s de agregar el producto
            NombreEntry.Text = string.Empty;
            DescripcionEntry.Text = string.Empty;
            PrecioEntry.Text = string.Empty;

            // Mostrar una alerta indicando que el producto se agreg� correctamente
            await DisplayAlert("�xito", "El producto se agreg� correctamente.", "OK");
          
        }

    }
}
