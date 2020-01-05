using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    /// <summary>
    /// Třída, která provádí nějakou činnost,
    /// která by mohla nějakou jinou třídu zajímat.
    /// Tato třída bude vyvolávat události.
    /// </summary>
    class EventPublisher
    {
        private int _value = 0;

        /// <summary>
        /// Pokaždé, když někdo nastaví hodnotu Value,
        /// bude provedena kontrola, zda je k této události někdo přihlášený.
        /// Pokud je, budou její obsluhy postupně zavolány.
        /// </summary>
        public int Value {
            get 
            { 
                return _value; 
            }
            set 
            {
                _value = value;
                // if (ValueHasChanged != null) ValueHasChanged(this, new ExampleEventArgs(value)); // starší forma zápisu
                ValueHasChanged?.Invoke(this, new ExampleEventArgs(value));
            }
        }
        /// <summary>
        /// Událost třídy. Sem se "vloží" metody, které se mají zavolat,
        /// když k události dojde.
        /// </summary>
        public event ExampleEventHandler ValueHasChanged;
    }
}
