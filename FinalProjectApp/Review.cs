using System;

namespace FinalProjectApp
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string ReviewText { get; set; }

        // Full-Arg Constructor
        public Review (string reviewText)
        {
            ReviewText = reviewText;
        }

        public override string ToString()
        {
            return "";
        }
    }
}
