using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOneDll
{
    public class Driver
    {
        private int id;
        private string firstname;
        private string lastname;
        private DateTime dob;
        private string placeOfBirth;
        private Country country;

        public Driver(int id, string firstname, string lastname, DateTime dob, string placeOfBirth, Country country)
        {
            this.Id = id;
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Dob = dob;
            this.PlaceOfBirth = placeOfBirth;
            this.Country = country;
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Firstname
        {
            get
            {
                return firstname;
            }

            set
            {
                firstname = value;
            }
        }

        public string Lastname
        {
            get
            {
                return lastname;
            }

            set
            {
                lastname = value;
            }
        }

        public DateTime Dob
        {
            get
            {
                return dob;
            }

            set
            {
                dob = value;
            }
        }

        public string PlaceOfBirth
        {
            get
            {
                return placeOfBirth;
            }

            set
            {
                placeOfBirth = value;
            }
        }

        public Country Country
        {
            get
            {
                return country;
            }

            set
            {
                country = value;
            }
        }

        public override string ToString()
        {
            string stOut = this.Firstname + " " + this.Lastname;
            return stOut;
        }

    }
}
