using Address_Book_MultiThreading;
namespace TestAddress_MultiThreading
{
    public class Tests
    {
        /*
        [SetUp]
        public void Setup()
        {
        }
        */

        [Test]
        public void GivenListOfPersons_AddIntoDB_TestTimeRequiredToAdd()
        {
            //Assert.Pass();
            List<Book_Definition_Model> model = new List<Book_Definition_Model>();
            model.Add(new Book_Definition_Model(personId: 1, firstName: "Nandhini", lastName: "Priya", address: "Salem", city: "Salem", state: "TamilNadu", zip: 687489, phone_no: "9867543672", email: "anil@gmail.com", name: "VIP", persontype: "Friend"));
            model.Add(new Book_Definition_Model(personId: 2, firstName: "Anil", lastName: "Kumar", address: "Central", city: "Chennai", state: "TamilNadu", zip: 769889, phone_no: "6433826486", email: "xee@gmail.com", name: "VIP", persontype: "Family"));
            model.Add(new Book_Definition_Model(personId: 3, firstName: "Amir", lastName: "Khan", address: "Egmore", city: "Chennai", state: "TamilNadu", zip: 948599, phone_no: "9867628854", email: "sfda@gmail.com", name: "VIP", persontype: "Sportsman"));
            model.Add(new Book_Definition_Model(personId: 4, firstName: "Sampath", lastName: "Kumar", address: "Erode", city: "Erode", state: "TamilNadu", zip: 687898, phone_no: "9133287672", email: "wgshg@gmail.com", name: "Guru", persontype: "Family"));
            model.Add(new Book_Definition_Model(personId: 5, firstName: "Anu", lastName: "Priya", address: "Tirupur", city: "Tirupur", state: "TamilNadu", zip: 677899, phone_no: "9864326572", email: "dsghg@gmail.com", name: "Guru", persontype: "Family"));
            Address_Book_System_Controller system = new Address_Book_System_Controller();
            DateTime start = DateTime.Now;
            system.addNewContact(model);
            DateTime end = DateTime.Now;
            Console.WriteLine("Time required to add all persons is: " + (end - start));

            DateTime startTime = DateTime.Now;
            system.addNewContactWithMultiThreading(model);
            DateTime dateTime = DateTime.Now;
            Console.WriteLine("Time Required to add all persons using multithreading is: " + (dateTime - startTime));
        }
    }
}