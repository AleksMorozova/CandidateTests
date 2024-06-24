using System.Linq;

namespace AssessmentLibrary.Assessment2;

public class Assessment2
{
    public static Dictionary<int, List<int>> PartitionList(IEnumerable<int> source, int segmentLength)
    {
        var result = new Dictionary<int, List<int>>();
        var index = 1;

        for (int i = 0; i < source.Count(); i += segmentLength)
        {
            if (segmentLength > source.Count() - i)
            {
                result.Add(index, source.Skip(i).Take(source.Count() - i).ToList());
                break;
            }

            result.Add(index, source.Skip(i).Take(segmentLength).ToList());
            index++;
        }

        return result;
        // Partition the source into smaller lists - each containing no more than segmentLength items.
        // Return a dictionary of these smaller lists indexed by segment number (starting at 1 not 0) of the source stream.
        // throw new NotImplementedException();
    }
}