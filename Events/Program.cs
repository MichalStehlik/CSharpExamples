using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            EventPublisher pub = new EventPublisher(); // vytvoření poskytovatele události
            EventSubscriber sub = new EventSubscriber(); // vytvoření předplatitele události
            pub.ValueHasChanged += ReportChange; // program si předplácí událost
            pub.ValueHasChanged += sub.OnValueChanged; // EventSubScriber si předplácí událost
            for (int i = 0; i < 10; i++)
            {
                pub.Value = i; // Postupné nastavování hodnoty = vyvolání události
            }
            pub.ValueHasChanged -= ReportChange; // program se odhlašuje z předplácení události
            for (int i = 11; i < 20; i++)
            {
                pub.Value = i; // Postupné nastavování hodnoty = vyvolání události
            }
        }

        /// <summary>
        /// Obsluha události na straně třídy Program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void ReportChange(object sender, ExampleEventArgs e)
        {
            Console.WriteLine("Value was changed to " + e.Value);
        }
    }
}
