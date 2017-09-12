using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHPSRePS {
    public class Product {
        private int _id;
        private string _name;
        private string _category;
        private float _price;
        private int _stock;
        private bool _discontinued;

        public Product() {

        }
        
        public int Id {
            get => _id;
            set => _id = value;
        }

        public string Name {
            get => _name;
            set => _name = value;
        }

        public string Category {
            get => _category;
            set => _category = value;
        }

        public float Price {
            get => _price;
            set => _price = value;
        }

        public int Stock {
            get => _stock;
            set => _stock = value;
        }

        public bool Discontinued {
            get => _discontinued;
            set => _discontinued = value;
        }
    }
}
