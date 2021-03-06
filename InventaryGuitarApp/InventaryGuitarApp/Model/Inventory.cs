using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventaryGuitarApp.Model.Enum;

namespace InventaryGuitarApp.Model
{
    class Inventory
    {
        List<Guitar> listGuitar;

        public Inventory()
        {
            listGuitar = new List<Guitar>();
        }
        public void AddGuitar(string serielNumber, double price, Builder builder, string model, GuitarType type, Wood backWood, Wood topWood)
        {
            Guitar guitar = new Guitar(serielNumber, price, builder, model, type, backWood, topWood);
            listGuitar.Add(guitar);
        }

        public Guitar GetGuitar(string serielNumber)
        {
            foreach (Guitar guitar in listGuitar)
            {
                if (guitar.SerialNumber == serielNumber)
                {
                    return guitar;
                }
            }
            return null;
        }

        public List<Guitar> Search(Guitar searchGuitar)
        {
            List<Guitar> mathGuitars = new List<Guitar>();
            foreach (Guitar items in listGuitar)
            {
                int flag = 0;
                Builder builder = searchGuitar.Builder;
                String model = searchGuitar.Model;
                GuitarType type = searchGuitar.Type;
                Wood topWood = searchGuitar.TopWood;
                Wood backWood = searchGuitar.BackWood;
                if ((builder.Equals(items.Builder)))
                {
                    flag = 1;
                }
                else if ((model.Equals(items.Model)))
                {
                    flag = 1;
                }
                else if ((type.Equals(items.Type)))
                {
                    flag = 1;
                }
                else if ((topWood.Equals(items.TopWood)))
                {
                    flag = 1;
                }
                else if ((backWood.Equals(items.BackWood)))
                {
                    flag = 1;
                }
                else
                {
                    continue;
                }

                /*else if( model.Equals(" ") && model != null && !(model.Equals(items.GetModel)) )
                {
                    flag = 0;
                    break;
                }
                
                else if (type.Equals(" ") && type != null && !(type.Equals(items.GetType)))
                {
                    break;
                }
                
                else if (topWood.Equals(" ") && (topWood != null) && !(topWood.Equals(items.GetTopWood)))
                {
                    break;
                }
                
                else if (backWood.Equals(" ") && backWood != null && !(backWood.Equals(items.GetBackWood)))
                {
                    break;
                }*/
                if (flag == 1)
                {
                    mathGuitars.Add(items);
                }
                else
                {
                    continue;
                }
            }
            return mathGuitars;
        }
    }
}
