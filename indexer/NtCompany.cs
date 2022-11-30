using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexer
{
    public class NtCompany
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private Employee[] _employees;
        public NtCompany(int size=10)
        {
            _employees=new Employee[size];
        }
        public Employee this[int index]
        {
            get {
                try
                {
                    return _employees[index];
                }
                catch (Exception)
                {

                    return _employees[0];
                }
            }
            set {
                try
                {
                    _employees[index] = value;
                }
                catch (Exception)
                {

                    Console.WriteLine("out of range");
                }
            }
        }
    }
}
