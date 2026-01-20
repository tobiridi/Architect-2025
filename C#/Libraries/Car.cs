using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries
{
    public class Car
    {
        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private int seats;

        public int Seats
        {
            get { return seats; }
            set { seats = value; }
        }

    }
}
