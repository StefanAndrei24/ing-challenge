using Bank.Contracts.Queries;
using Moq;
using Xunit;

namespace Bank.Tests
{
    public class InterviewAlgoProblemTest
    {
        private Mock<IInterviewAlgoQuery> _interviewAlgoQuery;

        public InterviewAlgoProblemTest()
        {
            _interviewAlgoQuery = new Mock<IInterviewAlgoQuery>();
        }

        [Fact]
        public void GetUniqueElement_ReturnUnpairElement()
        {
            var integerArray = new int[] { 1, 2, 3, 4, 3, 2, 1 };

            var uniqueNumber = _interviewAlgoQuery.Object.GetUniqueElementFromPairNumbers(integerArray);

            Assert.Equal(4, uniqueNumber);
        }
    }
}
