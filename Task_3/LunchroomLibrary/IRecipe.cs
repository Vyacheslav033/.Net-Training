using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchroomLibrary
{
    public interface IRecipe
    {

        Structure structure { get; set; }
        CookingSequence cookingSequence { get; set; }

        void Prepare();

    }
}
