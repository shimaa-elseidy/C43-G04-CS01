using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Demo
{
    internal struct PhoneBook
    {
        string[] names;
        long[] phonenumber;
        public PhoneBook(int size)
        {
            names       = new string[size];
            phonenumber = new long  [size];
        }


        public long this[string name]
        {


            get
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == name)
                    {
                        return phonenumber[i];
                    }
                }
                return -1;
            }

            set
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] ==name)
                    {
                        phonenumber[i] = value;
                    }
                }
            }
     
        }
        public string this[long number]
        {
            get
            {
                for (int i = 0; i < phonenumber.Length; i++)
                {
                    if (phonenumber[i] == number)
                    {
                        return names[i];
                    }
                }
                return null;
            }
            set
            {
                for (int i = 0; i < phonenumber.Length; i++)
                {
                    if (phonenumber[i] == number)
                    {
                        {
                            names[i] = value;
                        }
                    }
                }
            }
        }


        public void AddPerson(string name, long numbers , int index)
        { 
           names[index] = name;
           phonenumber[index] = numbers;
        }
        public long GetNumber(String name)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                {
                    return phonenumber[i];
                }
            }
            return -1;
        }
        public void UpdateNum(String name , long newNum)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                {
                    phonenumber[i]=newNum;
                }
            }
        }
    }
}
