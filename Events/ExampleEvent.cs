using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    /// <summary>
    /// Definice tvaru obslužné rutiny události
    /// </summary>
    /// <param name="sender">Objekt, který událost vyvolal</param>
    /// <param name="e">Parametry, které událost předává</param>
    public delegate void ExampleEventHandler(object sender, ExampleEventArgs e);

    /// <summary>
    /// Definice tvaru parametrů předávaných událostí
    /// </summary>
    public class ExampleEventArgs
    {
        /// <summary>
        /// Jediným parametrem předávaným ExampleEventArgs
        /// je nějaké číslo, v našem případě půjde o hodnotu Value objektu,
        /// který vyvolal událost
        /// </summary>
        /// <param name="value">Předávaný parametr</param>
        public ExampleEventArgs(int value)
        {
            Value = value;
        }

        public int Value { get; set; }
    }
}
