using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Models
{
    public partial class Ingredient
    {
        public double Price => (double)Cost / CostForCount;
    }
}
