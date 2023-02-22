using Bank.Contracts.Queries;

namespace Bank.CQS.Queries
{
    public class InterviewAlgoQuery : IInterviewAlgoQuery
    {
        public int GetUniqueElementFromPairNumbers(int[] integerArray)
        {
            var uniqueNumber = 0;

            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

            for (int i = 0; i < integerArray.Length; i++)
            {
                if (keyValuePairs.ContainsKey(integerArray[i]))
                {
                    keyValuePairs[integerArray[i]] = keyValuePairs[integerArray[i]] + 1;
                }
                else
                {
                    keyValuePairs.Add(integerArray[i], 1);
                }
            }

            var dictionaryKeys = keyValuePairs.Where(x => x.Value == 1).Select(x => x.Key);

            if (dictionaryKeys.Count() > 1)
            {
                uniqueNumber = -1;
            }
            else
            {
                uniqueNumber = dictionaryKeys.FirstOrDefault();
            }

            Console.WriteLine(uniqueNumber);
            Console.ReadLine();

            return 0;
        }
    }
}
