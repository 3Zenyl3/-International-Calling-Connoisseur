public static class DialingCodes
{
    public static Dictionary<int, string> GetEmptyDictionary()
    {
        return new Dictionary<int, string>();
    }

    public static Dictionary<int, string> GetExistingDictionary()
    {
        return new Dictionary<int, string> {
            { 1, "United States of America" },
            { 55, "Brazil" },
            { 91, "India" }
        };
    }
    public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
    {
        return new Dictionary<int, string>
        {
            {countryCode, countryName},
        };
    }

    public static Dictionary<int, string> AddCountryToExistingDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        existingDictionary.Add(countryCode, countryName);
        return existingDictionary;
    }

    public static string GetCountryNameFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        if (existingDictionary.TryGetValue(countryCode, out string countryName))
            return countryName;
        else return string.Empty;
    }

    public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
    {
        if (existingDictionary.TryGetValue(countryCode, out string countryName))
        {
           return countryName != null;
        }
        else return false;
    }

    public static Dictionary<int, string> UpdateDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        if (existingDictionary.TryGetValue(countryCode, out string country))
        {
            country = countryName;
            existingDictionary.Remove(countryCode);
            existingDictionary.Add(countryCode, country);
            return existingDictionary;
        }
        else
        {
            return existingDictionary;
        }
    }

    public static Dictionary<int, string> RemoveCountryFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        if (existingDictionary.TryGetValue(countryCode, out string country))
        {
            existingDictionary.Remove(countryCode);
            return existingDictionary;
        }
        else
        {
            return existingDictionary;
        }
    }

    public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
    {
        string a = "";
        foreach(int c in existingDictionary.Keys)
        {
            if(existingDictionary.TryGetValue(c, out string countryName))
            {
               if (countryName.Length>a.Length)
                {
                    a = countryName;
                }
            }
        }
        return a;
    }
}
