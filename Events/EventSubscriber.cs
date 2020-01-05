using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    /// <summary>
    /// Třída, která chce být informována o stavu hodnoty Value 
    /// třídy EventPublisher.
    /// Pokud událost nastane, je zavolána metoda OnValueChanged.
    /// </summary>
    class EventSubscriber
    {
        public void OnValueChanged(object sender, ExampleEventArgs e)
        {
            // obsluha vypisuje, kdo událost vyvolal a s jakou hodnotou
            Console.WriteLine(sender.ToString() + " value is now " + e.Value);
        }
    }
}
