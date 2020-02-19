using InterviewExercise.aut.lib;
using InterviewExercise.aut.pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewExercise.aut.facades
{
    public class AmazonSearchFcde
    {
        AmazonSearchPage searchPage = new AmazonSearchPage();

        public void SearchItem(string item)
        {
            searchPage.searchItem(item);
            searchPage.clickSearch();
        }
    }
}
