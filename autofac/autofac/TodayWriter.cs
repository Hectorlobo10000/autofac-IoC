using System;

namespace DemoApp
{
    public class TodayWriter : IDateWrite
    {
        private IOutput _output;

        public TodayWriter(IOutput output)
        {
            _output = output;
        }

        public void WriteDate()
        {
            _output.Write(DateTime.Today.ToShortDateString());
        }
    }
}