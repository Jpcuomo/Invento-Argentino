namespace Biblioteca
{
    /// <summary>
    /// Clase que representa un boligrafo que dibuja y repone/ gasta tinta
    /// </summary>
    public class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        private ConsoleColor _color;
        private short _tinta;

        /// <summary>
        /// Metodo constructor del Boligrafo
        /// </summary>
        /// <param name="tinta">Cantidad de tinta actual que tiene el bolígrafo</param>
        /// <param name="color">Color del bolígrafo</param>
        public Boligrafo(short tinta, ConsoleColor color)
        {
            _tinta = tinta;
            _color = color;
        }

        /// <summary>
        /// Propiedad que accede al atributo privado color y lo retorna
        /// </summary>
        public ConsoleColor Color
        {
            get
            {
                return _color; 
            }
        }

        /// <summary>
        /// Propiedad que accede al atributo privado CantidadTitna y lo retorna o modifica si pasa la validación
        /// </summary>
        public short CantidadTinta
        {
            get
            {
                return _tinta;
            }
            private set
            {
                if (_tinta + value >= 0 && _tinta + value <= cantidadTintaMaxima)
                {
                    _tinta += value;
                }
            } 
        }

        /// <summary>
        /// Metodo que recerga la cantidad de tinta al máximo
        /// </summary>
        public void Recargar()
        {// no puedo modificar la propiedad directamente ya que no pasa la validacion del setter
            _tinta = cantidadTintaMaxima; 
        }

        /// <summary>
        /// Imprime tantos símbolos según se le indique o la cantidad de tinta deisponible
        /// </summary>
        /// <param name="gasto">Cantidad de tinta que será usada en la impresión de contarse con ella</param>
        /// <param name="dibujo">Cadena de caracteres que representa el dibujo impreso</param>
        /// <returns>True si imprime o false si no tiene tinta</returns>
        public bool Pintar(short gasto, out string dibujo)
        {
            dibujo = "";
            if (_tinta <= 0)
            {
                return false;
            }
            else if (_tinta >= gasto)
            {
                for (int i = 1; i <= gasto; i++)
                {
                    dibujo += "*";
                }
                _tinta -= gasto;
            }
            else if (_tinta < gasto)
            {
                for (int i = 1; i <= _tinta; i++)
                {
                    dibujo += "*";
                }
                _tinta = 0;
            }
            return true;
        }
    }
}