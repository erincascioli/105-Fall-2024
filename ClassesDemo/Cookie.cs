using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo
{
    internal class Cookie
    {
        // --------------------------------------------------------------------
        // Fields
        // --------------------------------------------------------------------
        public string flavor;
        public double price;
        public double diameter;
        public bool glutenFree;
        public string[] toppings;


        // --------------------------------------------------------------------
        // Constructor(s)
        // --------------------------------------------------------------------

        /// <summary>
        /// Default constructor
        /// Sets up the fields of the Cookie class with identical data
        /// </summary>
        public Cookie()
        {
            flavor = "sugar";
            price = 2.99;
            diameter = 2;
            glutenFree = false;
            toppings = new string[2]{"frosting", "sprinkles"};
        }

        /// <summary>
        /// Paramaterized Constructor
        /// Sets up the class with values for all fields.
        /// </summary>
        /// <param name="flavor">Flavor of this cookie</param>
        /// <param name="price">Price of this cookie</param>
        /// <param name="diameter">Size of cookie, in inches</param>
        /// <param name="glutenFree">Is the cookie gluten free?</param>
        /// <param name="toppings">Array of toppings. Can be null.</param>
        public Cookie(string flavor, double price, double diameter, 
            bool glutenFree, string[] toppings)
        {
            // MEMBER OF THIS CLASS = PARAMETER;
            this.flavor = flavor;
            this.price = price;
            this.diameter = diameter;
            this.glutenFree = glutenFree;
            this.toppings = toppings;
        }

        /// <summary>
        /// Parameterized constructor where all cookies are $3.50 and gluten free.
        /// </summary>
        /// <param name="flavor">Flavor of the cookie</param>
        /// <param name="diameter">Size of cookie, in inches</param>
        /// <param name="toppings">Array of toppings. Can be null.</param>
        public Cookie(string flavor, double diameter, string[] toppings)
        {
            // MEMBER OF THIS CLASS = PARAMETER;
            this.flavor = flavor;
            this.price = 3.50;
            this.diameter = diameter;
            this.glutenFree = true;
            this.toppings = toppings;
        }

        // Students may also use differently named parameters! 
        // One strategy is to use p_ in front of all parameters.
        /*
        public Cookie(string p_flavor, double p_price, double p_diameter,
            bool p_glutenFree, string[] p_toppings)
        {
            // FIELD = PARAMETER;
            flavor = p_flavor;
            price = p_price;
            diameter = p_diameter;
            glutenFree = p_glutenFree;
            toppings = p_toppings;
        }
        */

        // Or use completely separately named identifiers!
        /*
        public Cookie(string cookieFlavor, double cookiePrice, double cookieDiameter,
            bool cookieGlutenFree, string[] cookieToppings)
        {
            // FIELD = PARAMETER;
            flavor = cookieFlavor;
            price = cookiePrice;
            diameter = cookieDiameter;
            glutenFree = cookieGlutenFree;
            toppings = cookieToppings;
        }
        */
    }
}
