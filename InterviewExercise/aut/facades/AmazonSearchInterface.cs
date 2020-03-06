using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewExercise.aut.facades
{
    interface AmazonSearchInterface
    {
        void SearchAndSelectItem(string item);

        void ValidatePriceAndAddToCart();

        void CreateAmazonAccount();
    }
}
