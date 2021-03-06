using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;

namespace PropOnChange
{
    public class Example : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int _AProperty;
        public int AProperty
        {
            get { return _AProperty; }
            set
            {
                if (this._AProperty != value)
                {
                    _AProperty = value;
                    if (PropertyChanged != null)
                    { 
                        // If something subscribed to the event
                        OnPropertyChanged("AProperty"); // Raise the event
                    }
                }
            }
        }

        // Create the OnPropertyChanged method to raise the event 
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }


    class Program
    {
        /// <summary>
        /// Causes await requirement with property update
        /// </summary>
        /// <param name="value">The updated value.</param>
        /// <returns></returns>
        static async Task PseudoDbUpdate(int value)
        {
            // Just have an await activity as would a database call
            Console.WriteLine($"Updating value to {value}");
            await Task.Run(() => Thread.Sleep(2000));
            Console.WriteLine($"Updated value.");
            System.Diagnostics.Debug.WriteLine($"Updated value.");
        }

        // Nb: Coded such that handler "knows" which property raised the event 
        // ... and so can can access the property explicitly
        private static async void Example_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            await PseudoDbUpdate(example.AProperty);
            Console.WriteLine("Property Changed");
        }
        static Example example = null;

        static void Main(string[] args)
        {
            Console.WriteLine("Starting app.");

            example = new Example();
            example.PropertyChanged += Example_PropertyChanged;

            example.AProperty = 137;

            //Next line is just to let the the above complete
            Thread.Sleep(4000);
            Console.WriteLine("Done app!");
        }

    }
}
