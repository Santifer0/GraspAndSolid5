using System;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter 
    {
        public void PrintRecipe(IRecipeContent recipeContent)
        {
            Console.WriteLine(recipeContent.GetTextToPrint());
        }
    }
}