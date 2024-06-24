using System.ComponentModel.DataAnnotations;

namespace AssessmentLibrary.Assessment1;

public class Assessment1
{
    public IEnumerable<string> ConvertBytes(IEnumerable<byte> input)
    {
        var res = new List<string>();
        foreach (var item in input)
        {
            res.Add(IntegerConverter.Convert(item));
        }

        return res;
        // Using provided IntegerConverter.Convert(int value)
        // return equivalent collection of string values for each given input.
        //throw new NotImplementedException();
    }
    public IEnumerable<string> FilterAndConvertIntegers(IEnumerable<int> input)
    {
        var res = new List<string>();
        foreach (var item in input)
        {
            string value = "";
            try {   value = IntegerConverter.Convert(item); 
            res.Add(value);}
            catch { }

        }

        return res;
        // Using provided IntegerConverter.Convert(int value)
        // return equivalent collection of string values for each given input.
        // Where input value cannot be converted, remove the offending value.
        //throw new NotImplementedException();
    }

    public Dictionary<string, int> CountOccurrences(IEnumerable<byte> input)
    {
        var res = new Dictionary<string, int>();

        var converted = new List<string>();
        foreach (var item in input)
        {
            converted.Add(IntegerConverter.Convert(item));
        }

        var g = converted.GroupBy(i => i);

        foreach (var grp in g)
        {
            res.Add(grp.Key, grp.Count());
        }
        return res;
        // Using provided IntegerConverter.Convert(int value)
        // return a summary of values and the occurrence count.
        //throw new NotImplementedException();
    }

    public Dictionary<string, int> ExtractMostCommonBytes(IEnumerable<byte> input)
    {
        var res = new Dictionary<string, int>();
        var converted = new List<string>();
        foreach (var item in input)
        {
            converted.Add(IntegerConverter.Convert(item));
        }

        var g = converted.GroupBy(i => i);

        foreach (var grp in g)
        {
            res.Add(grp.Key, grp.Count());
        }

        var sortedDict = res.OrderBy(entry => entry.Value)
                     .Take(10)
                     .ToDictionary(pair => pair.Key, pair => pair.Value);

        return sortedDict;
        // Using provided IntegerConverter.Convert(int value)
        // return top 10 most commonly occurring values and the occurrence count ideally in less than 2seconds.
        // throw new NotImplementedException();
    }
}