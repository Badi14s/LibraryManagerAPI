using System;
using TechTalk.SpecFlow;
using RestSharp;
using System.Collections.Generic;
using System.Diagnostics;
using NUnit.Framework;
using RestSharp.Serialization.Json;
using static LibraryManagerAPITests.API.Objects;


namespace LibraryManagerAPITests.StepDefinitions
{

    [Binding]
    public class SharedSteps
    {
        //Setup server url.
        private static string baseUrl = "http://localhost:9000/api/books";

        //Setup RestClient.
        private static RestClient client;

        public SharedSteps()
        {
            client = new RestClient(baseUrl);
        }

        // Initialize bookDetails to store data.
        BookDetails _bookDetails = new BookDetails();

        // Initialize id for delete request for AfterMethod().
        private static string _deleteId;
    
        [Given(@"I add to my reading list the following book")]
        public void GivenIAddToMyReadingListABookWithIdAuthorAndTtile(Table table)
        {
            var request = new RestRequest(baseUrl, Method.POST);

            // Get data from specflow table and add parameters to request body.           
            foreach (var bookTableRow in table.Rows)
            {
                string id;
                string author;
                string title;
                string description;
                bookTableRow.TryGetValue("Id", out id);
                bookTableRow.TryGetValue("Author", out author);
                bookTableRow.TryGetValue("Title", out title);
                bookTableRow.TryGetValue("Description", out description);

                request.AddParameter("Id", id).AddParameter("Author", author).AddParameter("Title", title)
                    .AddParameter("Description", description);

                // Set deleteId for deleteing request for AfterMethod().
                _deleteId = id;
            }
            
            var response = client.Execute(request);
            String responseContnet = response.Content;

            // Parse request response to String and check for message that Id already exists.
            if (responseContnet.Contains("already exists!"))
            {
                Assert.Fail("Book with id " + _deleteId + " already exists!");
            }

            // Parse request response to String and check for message for exceeding characters.
            if (responseContnet.Contains("should not exceed"))
            {
                Assert.Fail(responseContnet);
            }
          
            // Get status code and check if POST request has successful code 201.
            int statusCode = (int)response.StatusCode;
            Assert.AreEqual(201, statusCode, "POST status code is not 201");
        }

        [When(@"I search for book with Id ""(.*)""")]
        public void WhenISearchForBookWithId(int id)
        {
            // Perfrom Get request.
            var uri = string.Format("{0}/{1}", baseUrl, id);
            var request = new RestRequest(uri, Method.GET);
            var response = client.Execute<List<BookDetails>>(request);

            // Check the number of objects in the response
            Assert.AreEqual(4, response.Data.Capacity, "Number of objects in reponse are: "+ response.Data.Capacity);

            //response.Data.Count
            // Get status code and check if GET request has successful code 200.
            int statusCode = (int) response.StatusCode;
            Assert.AreEqual(200, statusCode, "GET status code is not 200");

            // Set the object valuзнаes from the GET request response.
            _bookDetails = new JsonDeserializer().Deserialize<BookDetails>(response);
        }


        [Then(@"the result should should retun the following book")]
        public void ThenTheResultShouldShouldRetungABookWithIdAuthorAndTtile(Table table)
        {
            // Get data from specflow table and convert to object in order to compare single object values.
            var bookDetails = new BookDetails();
            foreach (var bookTableRow in table.Rows)
            {
                string id;
                string author;
                string title;
                string description;
                bookTableRow.TryGetValue("Id", out id);
                bookTableRow.TryGetValue("Author", out author);
                bookTableRow.TryGetValue("Title", out title);
                bookTableRow.TryGetValue("Description", out description);

                if (!string.IsNullOrEmpty(id))
                {
                    bookDetails.Id = int.Parse(id);
                } 
                bookDetails.Author = IsNullOrEmpty(author); ;
                bookDetails.Title = IsNullOrEmpty(title); ;
                bookDetails.Description = IsNullOrEmpty(description);
            }

            //Compare Json reponse with Specflow Table.
            Assert.AreEqual(bookDetails.Id, _bookDetails.Id, "Id does not match!");
            Assert.AreEqual(bookDetails.Author, _bookDetails.Author, "Author does not match");
            Assert.AreEqual(bookDetails.Description, _bookDetails.Description, "Description does not match");
            Assert.AreEqual(bookDetails.Title, _bookDetails.Title, "Title does not match");                        
        }

        //Convert empty string to NULL string      
        private static string IsNullOrEmpty(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return null;
            }
            return str;
        }


        // The following method cleans entries from each test.
        [AfterScenario]
        public static void AfterMethod()
        {
            {
                // Perfrom Delete request. 
                var uri = string.Format("{0}/{1}", baseUrl, _deleteId);                
                var request = new RestRequest(uri, Method.DELETE);
                var response = client.Execute(request);

                // Get status code and check if DELETE request has successful code 204.
                int statusCode = (int)response.StatusCode;
                Assert.AreEqual(204, statusCode, "DELETE status code is not 204");
            }
        }

        // The following starts service LibraryManager.
        [BeforeFeature]
        public static void StartServer()
        {
            Process.Start("..\\LibraryManagerAPI\\LibraryManagerAPITests\\Config\\LibraryManager.exe");
            
        }

        // The following stops service LibraryManager.
        [AfterFeature]
        public static void StopServer()
        {
            Process[] workers = Process.GetProcessesByName("LibraryManager");
            foreach (Process worker in workers)
            {
                worker.Kill();
                worker.WaitForExit();
                worker.Dispose();
            }         
        }
        
    }
}
