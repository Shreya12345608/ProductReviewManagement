using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    class Management
    {
        // Create a table with a schema that matches that of the query results
        public readonly DataTable dataTable = new DataTable();
        public void TopRecords(List<ProductReview> listProductReview)
        {
            // Query for Retrieve top 3 records from the list who’s rating is high using LINQ
            var recordedData = (from productReviews in listProductReview
                                orderby productReviews.Rating descending
                                select productReviews).Take(3);
            // If you need the results to be in a DataTable
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID:- " + list.ProductID + " " + "UserID:- " + list.UserID
                    + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.isLike);
                Console.WriteLine("-----------------------------------------------------------------");
            }
        }
        public void SelectedRecords(List<ProductReview> listProductReview)
        {
            //Retrieve all record from the list who’s rating are greater then 3 and productID is 1 or 4 or 9 using

            var recordedData = from productReviews in listProductReview
                               where (productReviews.ProductID == 1 || productReviews.ProductID == 4 || productReviews.ProductID == 9)
                               && productReviews.Rating > 3
                               select productReviews;
            Console.WriteLine("Rating greater than 3 with product id of 1,4,or 9: ");
            // If you need the results to be in a DataTable
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID:- " + list.ProductID + " " + "UserID:- " + list.UserID
                    + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.isLike);
                Console.WriteLine("-----------------------------------------------------------------");
            }
        }
        public void RetrieveCountOfRecords(List<ProductReview> listProductReview)
        {
            //method syntax
            var recordedData = listProductReview.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, Count = x.Count() });
            Console.WriteLine("Count of records by ProductID: ");
            foreach (var list in recordedData)
            {
                Console.WriteLine("ID:" + list.ProductID + "----->" + "Count: " + list.Count);
              
            }
        }
    }
}