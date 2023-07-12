using Moq.AutoMock;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNCAApiConsumerApplication.BestStories
{
    [TestFixture]
    public class GetHNBestStoriesQueryTests
    {

        private GetHNBestStoriesQuery _query;
        private AutoMocker _mocker;
        private List<HNStoryModel> _stories;

        private const int Id = 1;
        private const string Name = "Customer 1";

        public void SetUp()
        {
            _mocker = new AutoMocker();

            _stories = new List<HNStoryModel>()
            {
                //Id = Id,
               // Name = Name
            };

            /*_mocker.GetMock<IDatabaseService>()
                .Setup(p => p.Customers)
                .ReturnsDbSet(new List<Customer> { _stories });

            _query = _mocker.CreateInstance<GetCustomersListQuery>();*/

        }

        [Test]
        public void TestExecuteShouldReturnListOfHNBestStories()
        {
            var results = _query.Execute(1);

          // var result = results.Single();

            //Assert.That(result.Id, Is.EqualTo(Id));
            //Assert.That(result.Name, Is.EqualTo(Name));
        }
    }
}
