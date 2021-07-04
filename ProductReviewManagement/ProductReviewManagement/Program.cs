using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management Program.");
            // add elements of the custom classes using the collection-initializer syntax.
            // The following adds objects of the ProductReview class in the List<ProductReview>.
            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                //Add Custom Class Objects in List
                new ProductReview(){ProductID=1,UserID=1,Rating=2,Review="Good",isLike=true},
                new ProductReview(){ProductID=2,UserID=1,Rating=4,Review="Good",isLike=true},
                new ProductReview(){ProductID=3,UserID=1,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductID=4,UserID=1,Rating=6,Review="Good",isLike=false},
                new ProductReview(){ProductID=5,UserID=1,Rating=2,Review="nice",isLike=true},
                new ProductReview(){ProductID=6,UserID=1,Rating=1,Review="bas",isLike=true},
                new ProductReview(){ProductID=8,UserID=1,Rating=1,Review="Good",isLike=false},
                new ProductReview(){ProductID=8,UserID=1,Rating=9,Review="nice",isLike=true},
                new ProductReview(){ProductID=2,UserID=1,Rating=10,Review="nice",isLike=true},
                new ProductReview(){ProductID=10,UserID=1,Rating=8,Review="nice",isLike=true},
                new ProductReview(){ProductID=11,UserID=1,Rating=3,Review="nice",isLike=true},
                new ProductReview(){ProductID=12,UserID=1,Rating=2,Review="Good",isLike=true},
                new ProductReview(){ProductID=12,UserID=1,Rating=4,Review="Good",isLike=true},
                new ProductReview(){ProductID=13,UserID=1,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductID=14,UserID=1,Rating=6,Review="Good",isLike=false},
                new ProductReview(){ProductID=15,UserID=1,Rating=2,Review="nice",isLike=true},
                new ProductReview(){ProductID=15,UserID=1,Rating=1,Review="bad",isLike=true},
                new ProductReview(){ProductID=15,UserID=1,Rating=2,Review="bad",isLike=true},
                new ProductReview(){ProductID=15,UserID=1,Rating=1,Review="Good",isLike=false},
                new ProductReview(){ProductID=18,UserID=1,Rating=9,Review="nice",isLike=true},
                new ProductReview(){ProductID=19,UserID=1,Rating=10,Review="nice",isLike=true},
                new ProductReview(){ProductID=20,UserID=1,Rating=8,Review="nice",isLike=true},
                new ProductReview(){ProductID=21,UserID=1,Rating=3,Review="nice",isLike=true},
                new ProductReview(){ProductID=22,UserID=1,Rating=10,Review="nice",isLike=true},
                new ProductReview(){ProductID=22,UserID=1,Rating=8,Review="nice",isLike=true},
                new ProductReview(){ProductID=25,UserID=1,Rating=3,Review="nice",isLike=true}

            };
            // using foreach LINQ method
            // Query execution
            foreach (var list in productReviewList)
            {
                Console.WriteLine("ProductID:- " + list.ProductID + " " + "UserID:- " + list.UserID
                    + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.isLike);
                Console.WriteLine("-----------------------------------------------------------------");
            }
            Console.WriteLine("UC2- Retrieving Top 3 records based on rating: ");
            Management management = new Management();
            management.TopRecords(productReviewList);
            Console.WriteLine("\n");
            Console.WriteLine("UC3- Retrieving records with specific conditions: ");
            management.SelectedRecords(productReviewList);
            Console.WriteLine("UC4- Count: ");
            management.RetrieveCountOfRecords(productReviewList);
            Console.WriteLine("UC5- Retrieving review by Product ID:");
            management.RetrieveProductIDAndReview(productReviewList);
            Console.WriteLine("UC6- Skipping top 5 records:");
            management.SkipTopFiveRecords(productReviewList);
            Console.WriteLine("UC7- Retrieving review by Product ID:");
            management.SelectProductIDAndReviews(productReviewList);
            Console.WriteLine("UC7- Create DataTable .");
            DataTableOperations dataTableOperations = new DataTableOperations();
            dataTableOperations.CreateDataTable();
            Console.ReadLine();

        }
    }
}
