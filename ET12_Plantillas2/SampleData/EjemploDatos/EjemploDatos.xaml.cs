//      *********    NO MODIFIQUE ESTE ARCHIVO     *********
//      Este archivo se regenera mediante una herramienta de diseño.
//       Si realiza cambios en este archivo, puede causar errores.
namespace Blend.SampleData.EjemploDatos
{
    using System; 
    using System.ComponentModel;

// Para reducir de forma significativa la superficie de los datos de ejemplo en la aplicación de producción, puede establecer
// la constante de compilación condicional DISABLE_SAMPLE_DATA y deshabilitar los datos de ejemplo en tiempo de ejecución.
#if DISABLE_SAMPLE_DATA
    internal class EjemploDatos { }
#else

    public class EjemploDatos : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public EjemploDatos()
        {
            try
            {
                Uri resourceUri = new Uri("ms-appx:/SampleData/EjemploDatos/EjemploDatos.xaml", UriKind.RelativeOrAbsolute);
                Windows.UI.Xaml.Application.LoadComponent(this, resourceUri);
            }
            catch
            {
            }
        }

        private GroupCollection _Groups = new GroupCollection();

        public GroupCollection Groups
        {
            get
            {
                return this._Groups;
            }
        }
    }

    public class Group : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private string _Nombre = string.Empty;

        public string Nombre
        {
            get
            {
                return this._Nombre;
            }

            set
            {
                if (this._Nombre != value)
                {
                    this._Nombre = value;
                    this.OnPropertyChanged("Nombre");
                }
            }
        }

        private string _Fecha = string.Empty;

        public string Fecha
        {
            get
            {
                return this._Fecha;
            }

            set
            {
                if (this._Fecha != value)
                {
                    this._Fecha = value;
                    this.OnPropertyChanged("Fecha");
                }
            }
        }

        private Windows.UI.Xaml.Media.ImageSource _Imagen = null;

        public Windows.UI.Xaml.Media.ImageSource Imagen
        {
            get
            {
                return this._Imagen;
            }

            set
            {
                if (this._Imagen != value)
                {
                    this._Imagen = value;
                    this.OnPropertyChanged("Imagen");
                }
            }
        }

        private ItemCollection _Items = new ItemCollection();

        public ItemCollection Items
        {
            get
            {
                return this._Items;
            }
        }

        private bool _Property4 = false;

        public bool Property4
        {
            get
            {
                return this._Property4;
            }

            set
            {
                if (this._Property4 != value)
                {
                    this._Property4 = value;
                    this.OnPropertyChanged("Property4");
                }
            }
        }
    }

    public class Item : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private string _Property1 = string.Empty;

        public string Property1
        {
            get
            {
                return this._Property1;
            }

            set
            {
                if (this._Property1 != value)
                {
                    this._Property1 = value;
                    this.OnPropertyChanged("Property1");
                }
            }
        }

        private string _Property2 = string.Empty;

        public string Property2
        {
            get
            {
                return this._Property2;
            }

            set
            {
                if (this._Property2 != value)
                {
                    this._Property2 = value;
                    this.OnPropertyChanged("Property2");
                }
            }
        }

        private Windows.UI.Xaml.Media.ImageSource _Property3 = null;

        public Windows.UI.Xaml.Media.ImageSource Property3
        {
            get
            {
                return this._Property3;
            }

            set
            {
                if (this._Property3 != value)
                {
                    this._Property3 = value;
                    this.OnPropertyChanged("Property3");
                }
            }
        }
    }

    public class ItemCollection : System.Collections.ObjectModel.ObservableCollection<Item>
    { 
    }

    public class GroupCollection : System.Collections.ObjectModel.ObservableCollection<Group>
    { 
    }
#endif
}
