using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_3.Exceptions {
    public class NomeVuotoException : Exception {

        public NomeVuotoException() : base() {

        }

        public NomeVuotoException(string message) : base(message) {

        }
    }
}
